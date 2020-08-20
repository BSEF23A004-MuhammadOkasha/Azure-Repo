// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.Compute.Models
{
    /// <summary> Snapshot resource. </summary>
    public partial class Snapshot : Resource
    {
        /// <summary> Initializes a new instance of Snapshot. </summary>
        /// <param name="location"> Resource location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public Snapshot(string location) : base(location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
        }

        /// <summary> Initializes a new instance of Snapshot. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="managedBy"> Unused. Always Null. </param>
        /// <param name="sku"> The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. </param>
        /// <param name="timeCreated"> The time when the disk was created. </param>
        /// <param name="osType"> The Operating System type. </param>
        /// <param name="hyperVGeneration"> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </param>
        /// <param name="creationData"> Disk source information. CreationData information cannot be changed after the disk has been created. </param>
        /// <param name="diskSizeGB"> If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk&apos;s size. </param>
        /// <param name="diskSizeBytes"> The size of the disk in bytes. This field is read only. </param>
        /// <param name="uniqueId"> Unique Guid identifying the resource. </param>
        /// <param name="encryptionSettingsCollection"> Encryption settings collection used be Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot. </param>
        /// <param name="provisioningState"> The disk provisioning state. </param>
        /// <param name="incremental"> Whether a snapshot is incremental. Incremental snapshots on the same disk occupy less space than full snapshots and can be diffed. </param>
        /// <param name="encryption"> Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys. </param>
        internal Snapshot(string id, string name, string type, string location, IDictionary<string, string> tags, string managedBy, SnapshotSku sku, DateTimeOffset? timeCreated, OperatingSystemTypes? osType, HyperVGeneration? hyperVGeneration, CreationData creationData, int? diskSizeGB, long? diskSizeBytes, string uniqueId, EncryptionSettingsCollection encryptionSettingsCollection, string provisioningState, bool? incremental, Encryption encryption) : base(id, name, type, location, tags)
        {
            ManagedBy = managedBy;
            Sku = sku;
            TimeCreated = timeCreated;
            OsType = osType;
            HyperVGeneration = hyperVGeneration;
            CreationData = creationData;
            DiskSizeGB = diskSizeGB;
            DiskSizeBytes = diskSizeBytes;
            UniqueId = uniqueId;
            EncryptionSettingsCollection = encryptionSettingsCollection;
            ProvisioningState = provisioningState;
            Incremental = incremental;
            Encryption = encryption;
        }

        /// <summary> Unused. Always Null. </summary>
        public string ManagedBy { get; }
        /// <summary> The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. </summary>
        public SnapshotSku Sku { get; set; }
        /// <summary> The time when the disk was created. </summary>
        public DateTimeOffset? TimeCreated { get; }
        /// <summary> The Operating System type. </summary>
        public OperatingSystemTypes? OsType { get; set; }
        /// <summary> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </summary>
        public HyperVGeneration? HyperVGeneration { get; set; }
        /// <summary> Disk source information. CreationData information cannot be changed after the disk has been created. </summary>
        public CreationData CreationData { get; set; }
        /// <summary> If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk&apos;s size. </summary>
        public int? DiskSizeGB { get; set; }
        /// <summary> The size of the disk in bytes. This field is read only. </summary>
        public long? DiskSizeBytes { get; }
        /// <summary> Unique Guid identifying the resource. </summary>
        public string UniqueId { get; }
        /// <summary> Encryption settings collection used be Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot. </summary>
        public EncryptionSettingsCollection EncryptionSettingsCollection { get; set; }
        /// <summary> The disk provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> Whether a snapshot is incremental. Incremental snapshots on the same disk occupy less space than full snapshots and can be diffed. </summary>
        public bool? Incremental { get; set; }
        /// <summary> Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys. </summary>
        public Encryption Encryption { get; set; }
    }
}
