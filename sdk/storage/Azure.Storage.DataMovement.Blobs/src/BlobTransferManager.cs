﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using Azure.Storage;
using Azure.Storage.DataMovement;
using Azure.Storage.DataMovement.Models;
using Azure.Storage.DataMovement.Blobs.Models;
using System.IO;
using Azure.Core.Pipeline;

namespace Azure.Storage.DataMovement.Blobs
{
    /// <summary>
    /// The <see cref="BlobTransferManager"/> allows you to manipulate
    /// Azure Storage Block Blobs by queueing up upload and download transfer
    /// items, manage those operations, track progress and pause and resume
    /// transfer processes.
    ///
    /// TODO: update description to include page blobs, append blobs, SMB Files
    /// and DataLake Files once added.
    /// </summary>
    public class BlobTransferManager : StorageTransferManager
    {
        /// <summary>
        /// Total Transfer Jobs
        ///
        /// Indexed by the job id
        /// </summary>
        private IDictionary<string, TransferJobInternal> _totalTransferJobs { get; set; }

        /// <summary>
        /// internal job transfer to scan for job sand schedule requests accordingly
        /// </summary>
        private BlobJobTransferScheduler _jobTransferScheduler { get; set; }

        /// <summary>
        /// Task Factory
        /// </summary>
        private TaskFactory _taskFactory { get; set; }

        /// <summary>
        /// Constructor for mocking
        /// </summary>
        protected internal BlobTransferManager()
        {
        }

        ///<summary>
        /// Initializes a new instance of the <see cref="StorageTransferManager"/>
        /// class.
        /// </summary>
        /// <param name="options">Directory path where transfer state is kept.</param>
        public BlobTransferManager(StorageTransferManagerOptions options)
            : base(options)
        {
            _jobTransferScheduler = new BlobJobTransferScheduler(options?.ConcurrencyForLocalFilesystemListing, options?.ConcurrencyForServiceListing);
            _taskFactory = new TaskFactory(_jobTransferScheduler);
        }

        /// <summary>
        /// Add Blob Upload Job to perform
        ///
        /// TODO: Better description and param comments.
        /// </summary>
        /// <param name="sourceLocalPath"></param>
        /// <param name="destinationClient"></param>
        /// <param name="uploadOptions"></param>
        /// <returns>A guid of the job id</returns>
        public string ScheduleUpload(
            string sourceLocalPath,
            BlobClient destinationClient,
            BlobUploadOptions uploadOptions = default)
        {
            //TODO: if check the local path exists and not a directory
            // or we can go and check at the start of the job, to prevent
            // having to check the existence of the path twice.
            string jobId = Guid.NewGuid().ToString(); // TODO; update the way we generate job ids, to also check if the job id already exists

            BlobUploadTransferJob transferJob = new BlobUploadTransferJob(jobId, sourceLocalPath, destinationClient, uploadOptions);
            _totalTransferJobs.Add(jobId, transferJob);
            Task uploadTask = _taskFactory.StartNew(
                action: transferJob.ProcessUploadTransfer(),
                cancellationToken: transferJob.CancellationTokenSource.Token,
                creationOptions: TaskCreationOptions.LongRunning, //TODO: look into if setting this to TaskCreationOptions.
                scheduler: _jobTransferScheduler);

            // TODO: remove stub
            return jobId;
        }

        /// <summary>
        /// Add Blob Download Job to perform
        ///
        /// TODO: Better description and param comments.
        /// </summary>
        /// <param name="sourceClient"></param>
        /// <param name="destinationLocalPath"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public string ScheduleDownload(
            BlobClient sourceClient,
            string destinationLocalPath,
            BlobDownloadToOptions options = default)
        {
            //TODO: if check the local path exists and not a directory
            // or we can go and check at the start of the job, to prevent
            // having to check the existence of the path twice.
            string jobId = Guid.NewGuid().ToString(); // TODO; update the way we generate job ids, to also check if the job id already exists
            BlobDownloadTransferJob transferJob = new BlobDownloadTransferJob(jobId, sourceClient, destinationLocalPath, options);
            Task downloadTask = _taskFactory.StartNew(
                action: transferJob.ProcessDownloadTransfer(),
                cancellationToken: transferJob.CancellationTokenSource.Token,
                creationOptions: TaskCreationOptions.LongRunning, //TODO: look into if setting this to TaskCreationOptions.None would be better if the transfer is small
                scheduler: _jobTransferScheduler);
            return jobId;
        }

        /// <summary>
        /// Add Upload Blob Directory Job to perform
        ///
        /// TODO: Better description and param comments.
        /// </summary>
        /// <param name="sourceLocalPath"></param>
        /// <param name="destinationClient"></param>
        /// <param name="overwrite"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// TODO: remove suppression
        public string ScheduleUploadDirectory(
            string sourceLocalPath,
            BlobVirtualDirectoryClient destinationClient,
            bool overwrite = false,
            BlobDirectoryUploadOptions options = default)
        {
            //TODO: if check the local path exists and not a directory
            // or we can go and check at the start of the job, to prevent
            // having to check the existence of the path twice.
            string jobId = Guid.NewGuid().ToString(); // TODO; update the way we generate job ids, to also check if the job id already exists
            BlobUploadDirectoryTransferJob transferJob = new BlobUploadDirectoryTransferJob(jobId, sourceLocalPath, overwrite, destinationClient, options);
            _totalTransferJobs.Add(jobId, transferJob);

            // Queue task to scan the local directory for paths to upload
            // As each local path is found, it is added to the queue as well.
            Task uploadDirectoryTask = _taskFactory.StartNew(
                action: () => {
                    transferJob.Logger.LogAsync(
                        logLevel: DataMovementLogLevel.Information,
                        message: $"Begin enumerating files within source directory: {transferJob.SourceLocalPath}",
                        false).EnsureCompleted();
                    PathScannerFactory scannerFactory = new PathScannerFactory(transferJob.SourceLocalPath);
                    PathScanner scanner = scannerFactory.BuildPathScanner();
                    IEnumerable<FileSystemInfo> pathList = scanner.Scan();
                    transferJob.Logger.LogAsync(
                        logLevel: DataMovementLogLevel.Information,
                        message: $"Completed enumerating files within source directory: {transferJob.SourceLocalPath}\n",
                        false).EnsureCompleted();

                    List<Task> fileUploadTasks = new List<Task>();
                    foreach (FileSystemInfo path in pathList)
                    {
                        if (path.GetType() == typeof(FileInfo))
                        {
                            Task singleUploadTask = _taskFactory.StartNew(
                                transferJob.ProcessSingleUploadTransfer(path.FullName),
                                cancellationToken: transferJob.CancellationTokenSource.Token,
                                creationOptions: TaskCreationOptions.LongRunning,
                                scheduler: _jobTransferScheduler);
                            fileUploadTasks.Add(singleUploadTask);
                        }
                    }
                    transferJob.Logger.LogAsync(
                        logLevel: DataMovementLogLevel.Information,
                        message: $"Created all upload tasks for the source directory: {transferJob.SourceLocalPath} to upload to the destination directory: {transferJob.DestinationDirectoryBlobClient.Uri.AbsoluteUri}",
                        false).EnsureCompleted();

                    // Wait for all the remaining blobs to finish upload before logging that the transfer has finished.
                    Task.WhenAll(fileUploadTasks).Wait();

                    transferJob.Logger.LogAsync(
                        logLevel: DataMovementLogLevel.Information,
                        message: $"Completed all upload tasks for the source directory: {transferJob.SourceLocalPath} and uploaded to the destination directory: {transferJob.DestinationDirectoryBlobClient.Uri.AbsoluteUri}",
                        false).EnsureCompleted();
                },
                cancellationToken: transferJob.CancellationTokenSource.Token,
                creationOptions: TaskCreationOptions.LongRunning, //TODO: look into if setting this to TaskCreationOptions.None would be better if the transfer is small
                scheduler: _jobTransferScheduler);
            return jobId;
        }

        /// <summary>
        /// Add Download Blob Directory Job to perform
        ///
        /// TODO: Better description and param comments.
        /// </summary>
        /// <param name="sourceClient"></param>
        /// <param name="destinationLocalPath"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// TODO: remove suppression
        public string ScheduleDownloadDirectory(
            BlobVirtualDirectoryClient sourceClient,
            string destinationLocalPath,
            BlobDirectoryDownloadOptions options = default)
        {
            //TODO: if check the local path exists and not a directory
            // or we can go and check at the start of the job, to prevent
            // having to check the existence of the path twice.
            string jobId = Guid.NewGuid().ToString(); // TODO; update the way we generate job ids, to also check if the job id already exists
            BlobDownloadDirectoryTransferJob transferJob = new BlobDownloadDirectoryTransferJob(jobId, sourceClient, destinationLocalPath, options);
            _totalTransferJobs.Add(jobId, transferJob);
            // Queue task to scan the remote directory for paths to download
            // As each blob is found, it is added to the queue as well.
            Task uploadDirectoryTask = _taskFactory.StartNew(
                action: () => {
                    transferJob.Logger.LogAsync(
                        logLevel: DataMovementLogLevel.Information,
                        message: $"Begin enumerating files within source directory: {transferJob.SourceDirectoryBlobClient.DirectoryPath}",
                        false).EnsureCompleted();
                    Pageable<BlobItem> blobs = transferJob.SourceDirectoryBlobClient.GetBlobs();

                    transferJob.Logger.LogAsync(
                        logLevel: DataMovementLogLevel.Information,
                        message: $"Completed enumerating files within source directory: {transferJob.SourceDirectoryBlobClient.DirectoryPath}\n",
                        false).EnsureCompleted();

                    List<Task> fileUploadTasks = new List<Task>();
                    foreach (BlobItem blob in blobs)
                    {
                        Task singleDownloadTask = _taskFactory.StartNew(
                            transferJob.ProcessSingleDownloadTransfer(blob.Name),
                            cancellationToken: transferJob.CancellationTokenSource.Token,
                            creationOptions: TaskCreationOptions.LongRunning,
                            scheduler: _jobTransferScheduler);
                        fileUploadTasks.Add(singleDownloadTask);
                    }
                    transferJob.Logger.LogAsync(
                        logLevel: DataMovementLogLevel.Information,
                        message: $"Created all upload tasks for the source directory: {transferJob.SourceDirectoryBlobClient.DirectoryPath} to upload to the destination directory: {transferJob.DestinationLocalPath}",
                        false).EnsureCompleted();

                    // Wait for all the remaining blobs to finish upload before logging that the transfer has finished.
                    Task.WhenAll(fileUploadTasks).Wait();

                    transferJob.Logger.LogAsync(
                        logLevel: DataMovementLogLevel.Information,
                        message: $"Completed all upload tasks for the source directory: {transferJob.SourceDirectoryBlobClient.DirectoryPath} and uploaded to the destination directory: {transferJob.DestinationLocalPath}",
                        false).EnsureCompleted();
                },
                cancellationToken: transferJob.CancellationTokenSource.Token,
                creationOptions: TaskCreationOptions.LongRunning, //TODO: look into if setting this to TaskCreationOptions.None would be better if the transfer is small
                scheduler: _jobTransferScheduler);

            return jobId;
        }

        /// <summary>
        /// Add Blob Copy Job to perform
        ///
        /// TODO: Better description and param comments.
        /// </summary>
        /// <param name="sourceUri"></param>
        /// <param name="destinationClient"></param>
        /// <param name="copyMethod">Copy Method</param>
        /// <param name="copyOptions"></param>
        /// <returns>A guid of the job id</returns>
        public string ScheduleCopy(
            Uri sourceUri,
            BlobClient destinationClient,
            BlobServiceCopyMethod copyMethod,
            BlobCopyFromUriOptions copyOptions = default)
        {
            //TODO: if check the local path exists and not a directory
            // or we can go and check at the start of the job, to prevent
            // having to check the existence of the path twice.
            string jobId = Guid.NewGuid().ToString(); // TODO; update the way we generate job ids, to also check if the job id already exists

            BlobServiceCopyTransferJob transferJob = new BlobServiceCopyTransferJob(
                jobId,
                sourceUri,
                destinationClient,
                copyMethod,
                copyOptions);
            _totalTransferJobs.Add(jobId, transferJob);
            Task downloadTask = _taskFactory.StartNew(
                action: transferJob.ProcessCopyTransfer(),
                cancellationToken: transferJob.CancellationTokenSource.Token,
                creationOptions: TaskCreationOptions.LongRunning, //TODO: look into if setting this to TaskCreationOptions.None would be better if the transfer is small
                scheduler: _jobTransferScheduler);

            // TODO: remove stub
            return jobId;
        }

        /// <summary>
        /// Add Blob Copy Job to perform
        ///
        /// TODO: Better description and param comments.
        /// </summary>
        /// <param name="sourceUri">
        /// The Source directory Uri to copy blobs from.
        /// The source must allow permissions to list in the container.
        /// TODO: add minimum SAS permissions requirements (e.g. permissions for both contaner and blob level, rl permissions)</param>
        /// <param name="destinationClient"></param>
        /// <param name="copyMethod">Copy Method</param>
        /// <param name="copyOptions"></param>
        /// <returns>A guid of the job id</returns>
        public string ScheduleCopyDirectory(
            Uri sourceUri,
            BlobVirtualDirectoryClient destinationClient,
            BlobServiceCopyMethod copyMethod,
            BlobDirectoryCopyFromUriOptions copyOptions = default)
        {
            //TODO: if check the local path exists and not a directory
            // or we can go and check at the start of the job, to prevent
            // having to check the existence of the path twice.
            string jobId = Guid.NewGuid().ToString(); // TODO; update the way we generate job ids, to also check if the job id already exists
            BlobServiceCopyDirectoryTransferJob transferJob = new BlobServiceCopyDirectoryTransferJob(jobId, sourceUri, destinationClient, copyMethod, copyOptions);
            _totalTransferJobs.Add(jobId, transferJob);
            // Queue task to scan the remote directory for paths to download
            // As each blob is found, it is added to the queue as well.
            Task copyDirectoryTask = _taskFactory.StartNew(
                action: () => {
                    BlobVirtualDirectoryClient sourceVirtualDirectoryClient = new BlobVirtualDirectoryClient(transferJob.SourceDirectoryUri);
                    transferJob.Logger.LogAsync(
                        logLevel: DataMovementLogLevel.Information,
                        message: $"Begin enumerating files within source directory: {transferJob.SourceDirectoryUri.AbsoluteUri}",
                        false).EnsureCompleted();
                    Pageable<BlobItem> blobs = sourceVirtualDirectoryClient.GetBlobs();

                    transferJob.Logger.LogAsync(
                        logLevel: DataMovementLogLevel.Information,
                        message: $"Completed enumerating files within source directory: {transferJob.SourceDirectoryUri.AbsoluteUri}\n",
                        false).EnsureCompleted();

                    List<Task> fileUploadTasks = new List<Task>();
                    foreach (BlobItem blob in blobs)
                    {
                        Task singleDownloadTask = _taskFactory.StartNew(
                            transferJob.ProcessSingleCopyTransfer(blob.Name),
                            cancellationToken: transferJob.CancellationTokenSource.Token,
                            creationOptions: TaskCreationOptions.LongRunning,
                            scheduler: _jobTransferScheduler);
                        fileUploadTasks.Add(singleDownloadTask);
                    }
                    transferJob.Logger.LogAsync(
                        logLevel: DataMovementLogLevel.Information,
                        message: $"Created all upload tasks for the source directory: {transferJob.SourceDirectoryUri.AbsoluteUri} to upload to the destination directory: {transferJob.DestinationDirectoryClient.Uri.AbsoluteUri}",
                        false).EnsureCompleted();

                    // Wait for all the remaining blobs to finish upload before logging that the transfer has finished.
                    Task.WhenAll(fileUploadTasks).Wait();

                    transferJob.Logger.LogAsync(
                        logLevel: DataMovementLogLevel.Information,
                        message: $"Completed all upload tasks for the source directory: {transferJob.SourceDirectoryUri.AbsoluteUri} and uploaded to the destination directory: {transferJob.DestinationDirectoryClient.Uri.AbsoluteUri}",
                        false).EnsureCompleted();
                },
                cancellationToken: transferJob.CancellationTokenSource.Token,
                creationOptions: TaskCreationOptions.LongRunning, //TODO: look into if setting this to TaskCreationOptions.None would be better if the transfer is small
                scheduler: _jobTransferScheduler);
            return jobId;
        }

        /*
        /// <summary>
        /// For those who have existing transfers that were paused
        /// but now want to resume it can do so by passing the file path
        /// to the plan file.
        ///
        /// The file will be read to see where the transfer left off
        /// and continue from there.
        ///
        /// This Job will have the same job id as contained in the job file.
        /// </summary>
        /// <param name="planFilePath"></param>
        /// <returns></returns>
        public string ScheduleJobFromPlanFile(string planFilePath)
        {
            //TODO: stub
            string jobId = Guid.NewGuid().ToString(); // TODO; update the way we generate job ids, to also check if the job id already exists
            return jobId;
        }
        */

        /// <summary>
        /// Returns storage job information if provided jobId.
        /// </summary>
        /// <param name="jobId"></param>
        /// <returns></returns>
        public override StorageTransferJobDetails GetJob(string jobId)
        {
            //TODO: stub
            return default;
        }

        /// <summary>
        /// Returns storage job information if provided jobId.
        /// </summary>
        /// <param name="jobId"></param>
        public async Task PauseJob(string jobId)
        {
            if (!_totalTransferJobs.ContainsKey(jobId))
            {
                TransferJobInternal job = _totalTransferJobs[jobId];
                if (job.CancellationTokenSource.IsCancellationRequested)
                {
                    throw Errors.JobCancelledOrPaused(jobId);
                }
                else
                {
                    await job.PauseTransferJob().ConfigureAwait(false);
                }
            }
            else
            {
                throw Errors.InvalidJobId(nameof(PauseJob), jobId);
            }
        }
    }
}
