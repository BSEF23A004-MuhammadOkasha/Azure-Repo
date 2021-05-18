// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureDataLakeStorageGen2Parameter. </summary>
    internal partial class AzureDataLakeStorageGen2Parameter
    {
        /// <summary> Initializes a new instance of AzureDataLakeStorageGen2Parameter. </summary>
        /// <param name="accountName"> The account name of this Azure Data Lake. </param>
        /// <param name="fileSystemName"> The file system (container) name in this Azure Data Lake. </param>
        /// <param name="directoryTemplate"> The directory template under this file system. </param>
        /// <param name="fileTemplate"> The file template. </param>
        public AzureDataLakeStorageGen2Parameter(string accountName, string fileSystemName, string directoryTemplate, string fileTemplate)
        {
            AccountName = accountName;
            FileSystemName = fileSystemName;
            DirectoryTemplate = directoryTemplate;
            FileTemplate = fileTemplate;
        }

        /// <summary> Initializes a new instance of AzureDataLakeStorageGen2Parameter. </summary>
        /// <param name="accountName"> The account name of this Azure Data Lake. </param>
        /// <param name="accountKey"> The account key that can access this Azure Data Lake. </param>
        /// <param name="fileSystemName"> The file system (container) name in this Azure Data Lake. </param>
        /// <param name="directoryTemplate"> The directory template under this file system. </param>
        /// <param name="fileTemplate"> The file template. </param>
        internal AzureDataLakeStorageGen2Parameter(string accountName, string accountKey, string fileSystemName, string directoryTemplate, string fileTemplate)
        {
            AccountName = accountName;
            AccountKey = accountKey;
            FileSystemName = fileSystemName;
            DirectoryTemplate = directoryTemplate;
            FileTemplate = fileTemplate;
        }

        /// <summary> The account name of this Azure Data Lake. </summary>
        public string AccountName { get; set; }
        /// <summary> The account key that can access this Azure Data Lake. </summary>
        public string AccountKey { get; set; }
        /// <summary> The file system (container) name in this Azure Data Lake. </summary>
        public string FileSystemName { get; set; }
        /// <summary> The directory template under this file system. </summary>
        public string DirectoryTemplate { get; set; }
        /// <summary> The file template. </summary>
        public string FileTemplate { get; set; }
    }
}
