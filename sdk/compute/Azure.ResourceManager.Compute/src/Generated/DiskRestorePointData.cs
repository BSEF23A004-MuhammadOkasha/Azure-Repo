// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the DiskRestorePoint data model. </summary>
    public partial class DiskRestorePointData : Resource
    {
        /// <summary> Initializes a new instance of DiskRestorePointData. </summary>
        internal DiskRestorePointData()
        {
        }

        /// <summary> Initializes a new instance of DiskRestorePointData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="timeCreated"> The timestamp of restorePoint creation. </param>
        /// <param name="sourceResourceId"> arm id of source disk. </param>
        /// <param name="osType"> The Operating System type. </param>
        /// <param name="hyperVGeneration"> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </param>
        /// <param name="purchasePlan"> Purchase plan information for the the image from which the OS disk was created. </param>
        /// <param name="familyId"> id of the backing snapshot&apos;s MIS family. </param>
        /// <param name="sourceUniqueId"> unique incarnation id of the source disk. </param>
        /// <param name="encryption"> Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys. </param>
        /// <param name="supportsHibernation"> Indicates the OS on a disk supports hibernation. </param>
        internal DiskRestorePointData(ResourceIdentifier id, string name, ResourceType type, DateTimeOffset? timeCreated, string sourceResourceId, OperatingSystemTypes? osType, HyperVGeneration? hyperVGeneration, PurchasePlanAutoGenerated purchasePlan, string familyId, string sourceUniqueId, Encryption encryption, bool? supportsHibernation) : base(id, name, type)
        {
            TimeCreated = timeCreated;
            SourceResourceId = sourceResourceId;
            OsType = osType;
            HyperVGeneration = hyperVGeneration;
            PurchasePlan = purchasePlan;
            FamilyId = familyId;
            SourceUniqueId = sourceUniqueId;
            Encryption = encryption;
            SupportsHibernation = supportsHibernation;
        }

        /// <summary> The timestamp of restorePoint creation. </summary>
        public DateTimeOffset? TimeCreated { get; }
        /// <summary> arm id of source disk. </summary>
        public string SourceResourceId { get; }
        /// <summary> The Operating System type. </summary>
        public OperatingSystemTypes? OsType { get; }
        /// <summary> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </summary>
        public HyperVGeneration? HyperVGeneration { get; }
        /// <summary> Purchase plan information for the the image from which the OS disk was created. </summary>
        public PurchasePlanAutoGenerated PurchasePlan { get; }
        /// <summary> id of the backing snapshot&apos;s MIS family. </summary>
        public string FamilyId { get; }
        /// <summary> unique incarnation id of the source disk. </summary>
        public string SourceUniqueId { get; }
        /// <summary> Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys. </summary>
        public Encryption Encryption { get; }
        /// <summary> Indicates the OS on a disk supports hibernation. </summary>
        public bool? SupportsHibernation { get; }
    }
}
