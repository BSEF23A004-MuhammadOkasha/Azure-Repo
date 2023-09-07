// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Defines an Aml Instance DataDisk. </summary>
    public partial class MachineLearningComputeInstanceDataDisk
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningComputeInstanceDataDisk"/>. </summary>
        internal MachineLearningComputeInstanceDataDisk()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningComputeInstanceDataDisk"/>. </summary>
        /// <param name="caching"> Caching type of Data Disk. </param>
        /// <param name="diskSizeGB"> The initial disk size in gigabytes. </param>
        /// <param name="lun"> The lun is used to uniquely identify each data disk. If attaching multiple disks, each should have a distinct lun. </param>
        /// <param name="storageAccountType"> type of this storage account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningComputeInstanceDataDisk(MachineLearningCachingType? caching, int? diskSizeGB, int? lun, MachineLearningStorageAccountType? storageAccountType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Caching = caching;
            DiskSizeGB = diskSizeGB;
            Lun = lun;
            StorageAccountType = storageAccountType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Caching type of Data Disk. </summary>
        public MachineLearningCachingType? Caching { get; }
        /// <summary> The initial disk size in gigabytes. </summary>
        public int? DiskSizeGB { get; }
        /// <summary> The lun is used to uniquely identify each data disk. If attaching multiple disks, each should have a distinct lun. </summary>
        public int? Lun { get; }
        /// <summary> type of this storage account. </summary>
        public MachineLearningStorageAccountType? StorageAccountType { get; }
    }
}
