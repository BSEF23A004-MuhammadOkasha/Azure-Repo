// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Capture storage details for capture description. </summary>
    public partial class EventHubDestination
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EventHubDestination"/>. </summary>
        public EventHubDestination()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventHubDestination"/>. </summary>
        /// <param name="name"> Name for capture destination. </param>
        /// <param name="storageAccountResourceId"> Resource id of the storage account to be used to create the blobs. </param>
        /// <param name="blobContainer"> Blob container Name. </param>
        /// <param name="archiveNameFormat"> Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order. </param>
        /// <param name="dataLakeSubscriptionId"> Subscription Id of Azure Data Lake Store. </param>
        /// <param name="dataLakeAccountName"> The Azure Data Lake Store name for the captured events. </param>
        /// <param name="dataLakeFolderPath"> The destination folder path for the captured events. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubDestination(string name, ResourceIdentifier storageAccountResourceId, string blobContainer, string archiveNameFormat, Guid? dataLakeSubscriptionId, string dataLakeAccountName, string dataLakeFolderPath, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            StorageAccountResourceId = storageAccountResourceId;
            BlobContainer = blobContainer;
            ArchiveNameFormat = archiveNameFormat;
            DataLakeSubscriptionId = dataLakeSubscriptionId;
            DataLakeAccountName = dataLakeAccountName;
            DataLakeFolderPath = dataLakeFolderPath;
            _rawData = rawData;
        }

        /// <summary> Name for capture destination. </summary>
        public string Name { get; set; }
        /// <summary> Resource id of the storage account to be used to create the blobs. </summary>
        public ResourceIdentifier StorageAccountResourceId { get; set; }
        /// <summary> Blob container Name. </summary>
        public string BlobContainer { get; set; }
        /// <summary> Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order. </summary>
        public string ArchiveNameFormat { get; set; }
        /// <summary> Subscription Id of Azure Data Lake Store. </summary>
        public Guid? DataLakeSubscriptionId { get; set; }
        /// <summary> The Azure Data Lake Store name for the captured events. </summary>
        public string DataLakeAccountName { get; set; }
        /// <summary> The destination folder path for the captured events. </summary>
        public string DataLakeFolderPath { get; set; }
    }
}
