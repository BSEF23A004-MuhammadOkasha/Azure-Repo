// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    /// <summary> A class representing the NetAppVolumeGroup data model. </summary>
    public partial class NetAppVolumeGroupData : ResourceData
    {
        /// <summary> Initializes a new instance of NetAppVolumeGroupData. </summary>
        public NetAppVolumeGroupData()
        {
            Volumes = new ChangeTrackingList<NetAppVolumeGroupData>();
        }

        /// <summary> Initializes a new instance of NetAppVolumeGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="provisioningState"> Azure lifecycle management. </param>
        /// <param name="groupMetaData"> Volume group details. </param>
        /// <param name="volumes"> List of volumes from group. </param>
        internal NetAppVolumeGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, string provisioningState, NetAppVolumeGroupMetadata groupMetaData, IList<NetAppVolumeGroupData> volumes) : base(id, name, resourceType, systemData)
        {
            Location = location;
            ProvisioningState = provisioningState;
            GroupMetaData = groupMetaData;
            Volumes = volumes;
        }

        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Azure lifecycle management. </summary>
        public string ProvisioningState { get; }
        /// <summary> Volume group details. </summary>
        public NetAppVolumeGroupMetadata GroupMetaData { get; set; }
        /// <summary> List of volumes from group. </summary>
        public IList<NetAppVolumeGroupData> Volumes { get; }
    }
}
