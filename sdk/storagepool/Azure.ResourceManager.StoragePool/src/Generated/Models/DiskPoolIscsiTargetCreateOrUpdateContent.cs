// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Payload for iSCSI Target create or update requests. </summary>
    public partial class DiskPoolIscsiTargetCreateOrUpdateContent : ResourceData
    {
        /// <summary> Initializes a new instance of DiskPoolIscsiTargetCreateOrUpdateContent. </summary>
        /// <param name="aclMode"> Mode for Target connectivity. </param>
        public DiskPoolIscsiTargetCreateOrUpdateContent(DiskPoolIscsiTargetAclMode aclMode)
        {
            ManagedByExtended = new Core.ChangeTrackingList<string>();
            AclMode = aclMode;
            StaticAcls = new Core.ChangeTrackingList<DiskPoolIscsiTargetPortalGroupAcl>();
            Luns = new Core.ChangeTrackingList<ManagedDiskIscsiLun>();
        }

        /// <summary> Initializes a new instance of DiskPoolIscsiTargetCreateOrUpdateContent. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="managedBy"> Azure resource id. Indicates if this resource is managed by another Azure resource. </param>
        /// <param name="managedByExtended"> List of Azure resource ids that manage this resource. </param>
        /// <param name="aclMode"> Mode for Target connectivity. </param>
        /// <param name="targetIqn"> iSCSI Target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server". </param>
        /// <param name="staticAcls"> Access Control List (ACL) for an iSCSI Target; defines LUN masking policy. </param>
        /// <param name="luns"> List of LUNs to be exposed through iSCSI Target. </param>
        internal DiskPoolIscsiTargetCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string managedBy, IList<string> managedByExtended, DiskPoolIscsiTargetAclMode aclMode, string targetIqn, IList<DiskPoolIscsiTargetPortalGroupAcl> staticAcls, IList<ManagedDiskIscsiLun> luns) : base(id, name, resourceType, systemData)
        {
            ManagedBy = managedBy;
            ManagedByExtended = managedByExtended;
            AclMode = aclMode;
            TargetIqn = targetIqn;
            StaticAcls = staticAcls;
            Luns = luns;
        }

        /// <summary> Azure resource id. Indicates if this resource is managed by another Azure resource. </summary>
        public string ManagedBy { get; set; }
        /// <summary> List of Azure resource ids that manage this resource. </summary>
        public IList<string> ManagedByExtended { get; }
        /// <summary> Mode for Target connectivity. </summary>
        public DiskPoolIscsiTargetAclMode AclMode { get; set; }
        /// <summary> iSCSI Target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server". </summary>
        public string TargetIqn { get; set; }
        /// <summary> Access Control List (ACL) for an iSCSI Target; defines LUN masking policy. </summary>
        public IList<DiskPoolIscsiTargetPortalGroupAcl> StaticAcls { get; }
        /// <summary> List of LUNs to be exposed through iSCSI Target. </summary>
        public IList<ManagedDiskIscsiLun> Luns { get; }
    }
}
