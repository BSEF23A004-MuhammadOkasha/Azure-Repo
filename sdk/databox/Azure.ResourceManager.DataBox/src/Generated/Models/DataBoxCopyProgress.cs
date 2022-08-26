// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Copy progress. </summary>
    public partial class DataBoxCopyProgress
    {
        /// <summary> Initializes a new instance of DataBoxCopyProgress. </summary>
        internal DataBoxCopyProgress()
        {
        }

        /// <summary> Initializes a new instance of DataBoxCopyProgress. </summary>
        /// <param name="storageAccountName"> Name of the storage account. This will be empty for data account types other than storage account. </param>
        /// <param name="transferType"> Transfer type of data. </param>
        /// <param name="dataAccountType"> Data Account Type. </param>
        /// <param name="accountId"> Id of the account where the data needs to be uploaded. </param>
        /// <param name="bytesProcessed"> To indicate bytes transferred. </param>
        /// <param name="totalBytesToProcess"> Total amount of data to be processed by the job. </param>
        /// <param name="filesProcessed"> Number of files processed. </param>
        /// <param name="totalFilesToProcess"> Total files to process. </param>
        /// <param name="invalidFilesProcessed"> Number of files not adhering to azure naming conventions which were processed by automatic renaming. </param>
        /// <param name="invalidFileBytesUploaded"> Total amount of data not adhering to azure naming conventions which were processed by automatic renaming. </param>
        /// <param name="renamedContainerCount"> Number of folders not adhering to azure naming conventions which were processed by automatic renaming. </param>
        /// <param name="filesErroredOut"> Number of files which could not be copied. </param>
        /// <param name="directoriesErroredOut"> To indicate directories errored out in the job. </param>
        /// <param name="invalidDirectoriesProcessed"> To indicate directories renamed. </param>
        /// <param name="isEnumerationInProgress">
        /// To indicate if enumeration of data is in progress. 
        /// Until this is true, the TotalBytesToProcess may not be valid.
        /// </param>
        internal DataBoxCopyProgress(string storageAccountName, DataBoxJobTransferType? transferType, DataAccountType? dataAccountType, ResourceIdentifier accountId, long? bytesProcessed, long? totalBytesToProcess, long? filesProcessed, long? totalFilesToProcess, long? invalidFilesProcessed, long? invalidFileBytesUploaded, long? renamedContainerCount, long? filesErroredOut, long? directoriesErroredOut, long? invalidDirectoriesProcessed, bool? isEnumerationInProgress)
        {
            StorageAccountName = storageAccountName;
            TransferType = transferType;
            DataAccountType = dataAccountType;
            AccountId = accountId;
            BytesProcessed = bytesProcessed;
            TotalBytesToProcess = totalBytesToProcess;
            FilesProcessed = filesProcessed;
            TotalFilesToProcess = totalFilesToProcess;
            InvalidFilesProcessed = invalidFilesProcessed;
            InvalidFileBytesUploaded = invalidFileBytesUploaded;
            RenamedContainerCount = renamedContainerCount;
            FilesErroredOut = filesErroredOut;
            DirectoriesErroredOut = directoriesErroredOut;
            InvalidDirectoriesProcessed = invalidDirectoriesProcessed;
            IsEnumerationInProgress = isEnumerationInProgress;
        }

        /// <summary> Name of the storage account. This will be empty for data account types other than storage account. </summary>
        public string StorageAccountName { get; }
        /// <summary> Transfer type of data. </summary>
        public DataBoxJobTransferType? TransferType { get; }
        /// <summary> Data Account Type. </summary>
        public DataAccountType? DataAccountType { get; }
        /// <summary> Id of the account where the data needs to be uploaded. </summary>
        public ResourceIdentifier AccountId { get; }
        /// <summary> To indicate bytes transferred. </summary>
        public long? BytesProcessed { get; }
        /// <summary> Total amount of data to be processed by the job. </summary>
        public long? TotalBytesToProcess { get; }
        /// <summary> Number of files processed. </summary>
        public long? FilesProcessed { get; }
        /// <summary> Total files to process. </summary>
        public long? TotalFilesToProcess { get; }
        /// <summary> Number of files not adhering to azure naming conventions which were processed by automatic renaming. </summary>
        public long? InvalidFilesProcessed { get; }
        /// <summary> Total amount of data not adhering to azure naming conventions which were processed by automatic renaming. </summary>
        public long? InvalidFileBytesUploaded { get; }
        /// <summary> Number of folders not adhering to azure naming conventions which were processed by automatic renaming. </summary>
        public long? RenamedContainerCount { get; }
        /// <summary> Number of files which could not be copied. </summary>
        public long? FilesErroredOut { get; }
        /// <summary> To indicate directories errored out in the job. </summary>
        public long? DirectoriesErroredOut { get; }
        /// <summary> To indicate directories renamed. </summary>
        public long? InvalidDirectoriesProcessed { get; }
        /// <summary>
        /// To indicate if enumeration of data is in progress. 
        /// Until this is true, the TotalBytesToProcess may not be valid.
        /// </summary>
        public bool? IsEnumerationInProgress { get; }
    }
}
