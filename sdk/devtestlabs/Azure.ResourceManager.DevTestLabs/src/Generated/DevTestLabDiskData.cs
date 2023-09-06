// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing the DevTestLabDisk data model.
    /// A Disk.
    /// </summary>
    public partial class DevTestLabDiskData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DevTestLabDiskData"/>. </summary>
        /// <param name="location"> The location. </param>
        public DevTestLabDiskData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabDiskData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="diskType"> The storage type for the disk (i.e. Standard, Premium). </param>
        /// <param name="diskSizeGiB"> The size of the disk in Gibibytes. </param>
        /// <param name="leasedByLabVmId"> The resource ID of the VM to which this disk is leased. </param>
        /// <param name="diskBlobName"> When backed by a blob, the name of the VHD blob without extension. </param>
        /// <param name="diskUri"> When backed by a blob, the URI of underlying blob. </param>
        /// <param name="storageAccountId"> When backed by a blob, the storage account where the blob is. </param>
        /// <param name="createdOn"> The creation date of the disk. </param>
        /// <param name="hostCaching"> The host caching policy of the disk (i.e. None, ReadOnly, ReadWrite). </param>
        /// <param name="managedDiskId"> When backed by managed disk, this is the ID of the compute disk resource. </param>
        /// <param name="provisioningState"> The provisioning status of the resource. </param>
        /// <param name="uniqueIdentifier"> The unique immutable identifier of a resource (Guid). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabDiskData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, DevTestLabStorageType? diskType, int? diskSizeGiB, ResourceIdentifier leasedByLabVmId, string diskBlobName, Uri diskUri, string storageAccountId, DateTimeOffset? createdOn, string hostCaching, ResourceIdentifier managedDiskId, string provisioningState, Guid? uniqueIdentifier, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            DiskType = diskType;
            DiskSizeGiB = diskSizeGiB;
            LeasedByLabVmId = leasedByLabVmId;
            DiskBlobName = diskBlobName;
            DiskUri = diskUri;
            StorageAccountId = storageAccountId;
            CreatedOn = createdOn;
            HostCaching = hostCaching;
            ManagedDiskId = managedDiskId;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabDiskData"/> for deserialization. </summary>
        internal DevTestLabDiskData()
        {
        }

        /// <summary> The storage type for the disk (i.e. Standard, Premium). </summary>
        public DevTestLabStorageType? DiskType { get; set; }
        /// <summary> The size of the disk in Gibibytes. </summary>
        public int? DiskSizeGiB { get; set; }
        /// <summary> The resource ID of the VM to which this disk is leased. </summary>
        public ResourceIdentifier LeasedByLabVmId { get; set; }
        /// <summary> When backed by a blob, the name of the VHD blob without extension. </summary>
        public string DiskBlobName { get; set; }
        /// <summary> When backed by a blob, the URI of underlying blob. </summary>
        public Uri DiskUri { get; set; }
        /// <summary> When backed by a blob, the storage account where the blob is. </summary>
        public string StorageAccountId { get; set; }
        /// <summary> The creation date of the disk. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The host caching policy of the disk (i.e. None, ReadOnly, ReadWrite). </summary>
        public string HostCaching { get; set; }
        /// <summary> When backed by managed disk, this is the ID of the compute disk resource. </summary>
        public ResourceIdentifier ManagedDiskId { get; set; }
        /// <summary> The provisioning status of the resource. </summary>
        public string ProvisioningState { get; }
        /// <summary> The unique immutable identifier of a resource (Guid). </summary>
        public Guid? UniqueIdentifier { get; }
    }
}
