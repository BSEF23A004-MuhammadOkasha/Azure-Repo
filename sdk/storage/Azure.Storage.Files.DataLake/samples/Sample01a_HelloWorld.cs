﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Azure.Storage;
using Azure.Storage.Files.DataLake;
using Azure.Storage.Files.DataLake.Models;
using NUnit.Framework;

namespace Azure.Storage.Files.DataLake.Samples
{
    /// <summary>
    /// Basic Azure DataLake Storage samples.
    /// </summary>
    public class Sample01a_HelloWorld : SampleTest
    {
        /// <summary>
        /// Upload a file to a DataLake File.
        /// </summary>
        [Test]
        public void Append()
        {
            // Create three temporary Lorem Ipsum files on disk that we can upload
            int oneThirdPosition = SampleFileContent.Length / 3;
            string sampleFileContentPart1 = CreateTempFile(SampleFileContent.Substring(0, oneThirdPosition));
            string sampleFileContentPart2 = CreateTempFile(SampleFileContent.Substring(oneThirdPosition, oneThirdPosition + 1));
            string sampleFileContentPart3 = CreateTempFile(SampleFileContent.Substring((oneThirdPosition * 2 + 1), oneThirdPosition + 1));

            // Make StorageSharedKeyCredential to pass to the serviceClient
            string storageAccountName = StorageAccountName;
            string storageAccountKey = StorageAccountKey;
            Uri serviceUri = StorageAccountBlobUri;

            StorageSharedKeyCredential sharedKeyCredential = new StorageSharedKeyCredential(storageAccountName, storageAccountKey);

            // Get a reference to a FileSystemClient
            DataLakeServiceClient serviceClient = new DataLakeServiceClient(serviceUri, sharedKeyCredential);

            // Get a reference to a filesystem named "sample-filesystem-append" and then create it
            DataLakeFileSystemClient filesystem = serviceClient.GetFileSystemClient("sample-filesystem-append");
            filesystem.Create();
            try
            {
                // Get a reference to a file named "sample-file" in a filesystem named "sample-filesystem"
                DataLakeFileClient file = filesystem.GetFileClient(Randomize("sample-file"));

                // Open the file and upload its data
                file.Create();

                file.Append(File.OpenRead(sampleFileContentPart1), 0);
                file.Append(File.OpenRead(sampleFileContentPart2), oneThirdPosition);
                file.Append(File.OpenRead(sampleFileContentPart3), oneThirdPosition * 2 + 1);
                file.Flush(SampleFileContent.Length);

                // Verify we uploaded one file with some content
                Assert.AreEqual(1, filesystem.ListPaths().Count());
                PathProperties properties = file.GetProperties();
                Assert.AreEqual(SampleFileContent.Length, properties.ContentLength);

                // Cleanup
                file.Delete();
            }
            finally
            {
                // Clean up after the test when we're finished
                filesystem.Delete();
            }
        }

        /// <summary>
        /// Download a DataLake File to a file.
        /// </summary>
        [Test]
        public void Read()
        {
            // Create a temporary Lorem Ipsum file on disk that we can upload
            string originalPath = CreateTempFile(SampleFileContent);

            // Get a temporary path on disk where we can download the file
            string downloadPath = CreateTempPath();

            // Make StorageSharedKeyCredential to pass to the serviceClient
            string storageAccountName = StorageAccountName;
            string storageAccountKey = StorageAccountKey;
            Uri serviceUri = StorageAccountBlobUri;
            StorageSharedKeyCredential sharedKeyCredential = new StorageSharedKeyCredential(storageAccountName, storageAccountKey);

            // Create DataLakeServiceClient using StorageSharedKeyCredentials
            DataLakeServiceClient serviceClient = new DataLakeServiceClient(serviceUri, sharedKeyCredential);

            // Get a reference to a filesystem named "sample-filesystem-read" and then create it
            DataLakeFileSystemClient filesystem = serviceClient.GetFileSystemClient("sample-filesystem-read");
            filesystem.Create();
            try
            {
                // Get a reference to a file named "sample-file" in a filesystem named "sample-filesystem"
                DataLakeFileClient file = filesystem.GetFileClient(Randomize("sample-file"));

                // First upload something the DataLake file so we have something to download
                file.Create();
                file.Append(File.OpenRead(originalPath), 0);
                file.Flush(SampleFileContent.Length);

                // Download the DataLake file's contents and save it to a file
                Response<FileDownloadInfo> fileContents = file.Read();
                using (FileStream stream = File.OpenWrite(downloadPath))
                {
                    fileContents.Value.Content.CopyTo(stream);
                }

                // Verify the contents
                Assert.AreEqual(SampleFileContent, File.ReadAllText(downloadPath));

                file.Delete();
            }
            finally
            {
                // Clean up after the test when we're finished
                filesystem.Delete();
            }
        }

        /// <summary>
        /// Download our sample image.
        /// </summary>
        [Test]
        public void ReadImage()
        {
            // Get a temporary path on disk where we can download the file
            string downloadPath = CreateTempPath();

            // Download the public file at https://aka.ms/bloburl.
            Response<FileDownloadInfo> fileDownload = new DataLakeFileClient(new Uri("https://aka.ms/bloburl")).Read();
            using (FileStream stream = File.OpenWrite(downloadPath))
            {
                fileDownload.Value.Content.CopyTo(stream);
            }
        }

        /// <summary>
        /// List all the DataLake directories in a filesystem.
        /// </summary>
        [Test]
        public void List()
        {
            // Make StorageSharedKeyCredential to pass to the serviceClient
            string storageAccountName = StorageAccountName;
            string storageAccountKey = StorageAccountKey;
            Uri serviceUri = StorageAccountBlobUri;
            StorageSharedKeyCredential sharedKeyCredential = new StorageSharedKeyCredential(storageAccountName, storageAccountKey);

            // Create DataLakeServiceClient using StorageSharedKeyCredentials
            DataLakeServiceClient serviceClient = new DataLakeServiceClient(serviceUri, sharedKeyCredential);

            // Get a reference to a filesystem named "sample-filesystem-list" and then create it
            DataLakeFileSystemClient filesystem = serviceClient.GetFileSystemClient("sample-filesystem-list");
            filesystem.Create();
            try
            {
                // Upload a couple of directories so we have something to list
                filesystem.CreateDirectory("sample-directory1");
                filesystem.CreateDirectory("sample-directory2");
                filesystem.CreateDirectory("sample-directory3");

                // List all the directories
                List<string> names = new List<string>();
                Pageable<PathItem> response = filesystem.ListPaths();
                List<PathItem> paths = response.ToList();
                foreach (PathItem pathItem in paths)
                {
                    names.Add(pathItem.Name);
                }
                Assert.AreEqual(3, paths.Count);
                Assert.Contains("sample-directory1", names);
                Assert.Contains("sample-directory2", names);
                Assert.Contains("sample-directory3", names);
            }
            finally
            {
                // Clean up after the test when we're finished
                filesystem.Delete();
            }
        }

        /// <summary>
        /// Traverse the DataLake Files and DataLake Directories in a DataLake filesystem.
        /// </summary>
        [Test]
        public void Traverse()
        {
            // Create a temporary Lorem Ipsum file on disk that we can upload
            string originalPath = CreateTempFile(SampleFileContent);

            // Make StorageSharedKeyCredential to pass to the serviceClient
            string storageAccountName = StorageAccountName;
            string storageAccountKey = StorageAccountKey;
            Uri serviceUri = StorageAccountBlobUri;
            StorageSharedKeyCredential sharedKeyCredential = new StorageSharedKeyCredential(storageAccountName, storageAccountKey);

            // Create DataLakeServiceClient using StorageSharedKeyCredentials
            DataLakeServiceClient serviceClient = new DataLakeServiceClient(serviceUri, sharedKeyCredential);

            // Get a reference to a filesystem named "sample-filesystem-traverse" and then create it
            DataLakeFileSystemClient filesystem = serviceClient.GetFileSystemClient("sample-filesystem-traverse");

            filesystem.Create();
            try
            {
                // Create a bunch of directories and files within the directories
                DataLakeDirectoryClient first = filesystem.CreateDirectory("first");
                first.CreateSubDirectory("a");
                first.CreateSubDirectory("b");
                DataLakeDirectoryClient second = filesystem.CreateDirectory("second");
                second.CreateSubDirectory("c");
                second.CreateSubDirectory("d");
                filesystem.CreateDirectory("third");
                DataLakeDirectoryClient fourth = filesystem.CreateDirectory("fourth");
                DataLakeDirectoryClient deepest = fourth.CreateSubDirectory("e");

                // Upload a DataLake file named "file"
                DataLakeFileClient file = deepest.GetFileClient("file");
                file.Create();
                using (FileStream stream = File.OpenRead(originalPath))
                {
                    file.Append(stream, 0);
                }

                // Keep track of all the names we encounter
                List<string> names = new List<string>();
                Pageable<PathItem> response = filesystem.ListPaths(recursive: true);
                List<PathItem> paths = response.ToList();
                foreach (PathItem pathItem in paths)
                {
                    names.Add(pathItem.Name);
                }

                // Verify we've seen everything
                Assert.AreEqual(10, paths.Count);
                Assert.Contains("first", names);
                Assert.Contains("second", names);
                Assert.Contains("third", names);
                Assert.Contains("fourth", names);
                Assert.Contains("first/a", names);
                Assert.Contains("first/b", names);
                Assert.Contains("second/c", names);
                Assert.Contains("second/d", names);
                Assert.Contains("fourth/e", names);
                Assert.Contains("fourth/e/file", names);
            }
            finally
            {
                // Clean up after the test when we're finished
                filesystem.Delete();
            }
        }

        /// <summary>
        /// Trigger a recoverable error.
        /// </summary>
        [Test]
        public void Errors()
        {
            // Make StorageSharedKeyCredential to pass to the serviceClient
            string storageAccountName = StorageAccountName;
            string storageAccountKey = StorageAccountKey;
            Uri serviceUri = StorageAccountBlobUri;
            StorageSharedKeyCredential sharedKeyCredential = new StorageSharedKeyCredential(storageAccountName, storageAccountKey);

            // Create DataLakeServiceClient using StorageSharedKeyCredentials
            DataLakeServiceClient serviceClient = new DataLakeServiceClient(serviceUri, sharedKeyCredential);

            // Get a reference to a filesystem named "sample-filesystem-errors" and then create it
            DataLakeFileSystemClient filesystem = serviceClient.GetFileSystemClient("sample-filesystem-errors");
            filesystem.Create();
            try
            {
                // Try to create the filesystem again
                filesystem.Create();
            }
            catch (RequestFailedException ex)
                when (ex.ErrorCode == Constants.Blob.Container.AlreadyExists)
            {
                // Ignore any errors if the filesystem already exists
            }
            catch (RequestFailedException ex)
            {
                Assert.Fail($"Unexpected error: {ex}");
            }

            // Clean up after the test when we're finished
            filesystem.Delete();
        }


        /// <summary>
        /// Set permissions in the access control list and gets access control list on a DataLake File
        /// </summary>
        [Test]
        public void SetPermissionsAsync()
        {
            // Make StorageSharedKeyCredential to pass to the serviceClient
            string storageAccountName = NamespaceStorageAccountName;
            string storageAccountKey = NamespaceStorageAccountKey;
            Uri serviceUri = StorageAccountNamespaceUri;
            StorageSharedKeyCredential sharedKeyCredential = new StorageSharedKeyCredential(storageAccountName, storageAccountKey);

            // Create DataLakeServiceClient using StorageSharedKeyCredentials
            DataLakeServiceClient serviceClient = new DataLakeServiceClient(serviceUri, sharedKeyCredential);

            // Get a reference to a filesystem named "sample-filesystem-acl" and then create it
            DataLakeFileSystemClient filesystem = serviceClient.GetFileSystemClient("sample-filesystem-per");
            filesystem.Create();
            try
            {
                // Create a DataLake file so we can set the Access Controls on the files
                DataLakeFileClient fileClient = filesystem.GetFileClient("sample-file");
                fileClient.Create();

                // Make Access Control List and Set Access Control List
                fileClient.SetPermissions(permissions: "0777");

                // Get Access Control List
                PathAccessControl accessControlreturn = fileClient.GetAccessControl();

                //Check Access Control permissions
                Assert.AreEqual("rwxrwxrwx", accessControlreturn.Permissions);
            }
            finally
            {
                // Clean up after the test when we're finished
                filesystem.Delete();
            }
        }

        /// <summary>
        /// Set and gets access control list on a DataLake File
        /// </summary>
        [Test]
        public void SetGetAclsAsync()
        {
            // Make StorageSharedKeyCredential to pass to the serviceClient
            string storageAccountName = NamespaceStorageAccountName;
            string storageAccountKey = NamespaceStorageAccountKey;
            Uri serviceUri = StorageAccountNamespaceUri;
            StorageSharedKeyCredential sharedKeyCredential = new StorageSharedKeyCredential(storageAccountName, storageAccountKey);

            // Create DataLakeServiceClient using StorageSharedKeyCredentials
            DataLakeServiceClient serviceClient = new DataLakeServiceClient(serviceUri, sharedKeyCredential);

            // Get a reference to a filesystem named "sample-filesystem-acl" and then create it
            DataLakeFileSystemClient filesystem = serviceClient.GetFileSystemClient("sample-filesystem-acl");
            filesystem.Create();
            try
            {
                // Create a DataLake file so we can set the Access Controls on the files
                DataLakeFileClient fileClient = filesystem.GetFileClient("sample-file");
                fileClient.Create();

                // Make Access Control List and Set Access Control List
                fileClient.SetAccessControl("user::rwx,group::r--,mask::rwx,other::---");

                // Get Access Control List
                PathAccessControl accessControlreturn = fileClient.GetAccessControl();

                //Check accessControl permissions
                Assert.AreEqual("user::rwx,group::r--,mask::rwx,other::---", accessControlreturn.Acl);
            }
            finally
            {
                // Clean up after the test when we're finished
                // Clean up after the test when we're finished
                filesystem.Delete();
            }
        }

        /// <summary>
        /// Rename a DataLake file and a DatLake directories in a DataLake Filesystem.
        /// </summary>
        [Test]
        public void Rename()
        {
            // Make StorageSharedKeyCredential to pass to the serviceClient
            string storageAccountName = StorageAccountName;
            string storageAccountKey = StorageAccountKey;
            Uri serviceUri = StorageAccountBlobUri;
            StorageSharedKeyCredential sharedKeyCredential = new StorageSharedKeyCredential(storageAccountName, storageAccountKey);

            // Create DataLakeServiceClient using StorageSharedKeyCredentials
            DataLakeServiceClient serviceClient = new DataLakeServiceClient(serviceUri, sharedKeyCredential);

            // Get a reference to a filesystem named "sample-filesystem-rename" and then create it
            DataLakeFileSystemClient filesystem = serviceClient.GetFileSystemClient("sample-filesystem-rename");
            filesystem.Create();
            try
            {
                // Create a DataLake Directory to rename it later
                DataLakeDirectoryClient directoryClient = filesystem.GetDirectoryClient("sample-directory");
                directoryClient.Create();

                // Rename the sample directory
                directoryClient.Rename("sample-directory2");

                // Delete the sample directory using the new path/name
                filesystem.DeleteDirectory("sample-directory2");

                // Create a DataLake file.
                DataLakeFileClient fileClient = filesystem.GetFileClient("sample-file");
                fileClient.Create();

                // Rename the sample file
                fileClient.Rename("sample-file2");

                // Delete the sample directory using the new path/name
                filesystem.DeleteFile("sample-file2");
            }
            finally
            {
                // Clean up after the test when we're finished
                // Clean up after the test when we're finished
                filesystem.Delete();
            }
        }
    }
}
