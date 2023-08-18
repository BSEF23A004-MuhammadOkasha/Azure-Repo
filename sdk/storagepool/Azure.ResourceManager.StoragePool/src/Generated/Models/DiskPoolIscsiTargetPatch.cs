// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Payload for iSCSI Target update requests. </summary>
    public partial class DiskPoolIscsiTargetPatch : ResourceData
    {
        /// <summary> Initializes a new instance of DiskPoolIscsiTargetPatch. </summary>
        public DiskPoolIscsiTargetPatch()
        {
            ManagedByExtended = new Core.ChangeTrackingList<string>();
            StaticAcls = new Core.ChangeTrackingList<DiskPoolIscsiTargetPortalGroupAcl>();
            Luns = new Core.ChangeTrackingList<ManagedDiskIscsiLun>();
        }

        /// <summary> Initializes a new instance of DiskPoolIscsiTargetPatch. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="managedBy"> Azure resource id. Indicates if this resource is managed by another Azure resource. </param>
        /// <param name="managedByExtended"> List of Azure resource ids that manage this resource. </param>
        /// <param name="staticAcls"> Access Control List (ACL) for an iSCSI Target; defines LUN masking policy. </param>
        /// <param name="luns"> List of LUNs to be exposed through iSCSI Target. </param>
        internal DiskPoolIscsiTargetPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string managedBy, IList<string> managedByExtended, IList<DiskPoolIscsiTargetPortalGroupAcl> staticAcls, IList<ManagedDiskIscsiLun> luns) : base(id, name, resourceType, systemData)
        {
            ManagedBy = managedBy;
            ManagedByExtended = managedByExtended;
            StaticAcls = staticAcls;
            Luns = luns;
        }

        /// <summary> Azure resource id. Indicates if this resource is managed by another Azure resource. </summary>
        public string ManagedBy { get; set; }
        /// <summary> List of Azure resource ids that manage this resource. </summary>
        public IList<string> ManagedByExtended { get; }
        /// <summary> Access Control List (ACL) for an iSCSI Target; defines LUN masking policy. </summary>
        public IList<DiskPoolIscsiTargetPortalGroupAcl> StaticAcls { get; }
        /// <summary> List of LUNs to be exposed through iSCSI Target. </summary>
        public IList<ManagedDiskIscsiLun> Luns { get; }
    }
}
