// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Volume group resource. </summary>
    public partial class NetAppVolumeGroupResult : ResourceData
    {
        /// <summary> Initializes a new instance of NetAppVolumeGroupResult. </summary>
        internal NetAppVolumeGroupResult()
        {
        }

        /// <summary> Initializes a new instance of NetAppVolumeGroupResult. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="provisioningState"> Azure lifecycle management. </param>
        /// <param name="groupMetaData"> Volume group details. </param>
        internal NetAppVolumeGroupResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, string provisioningState, NetAppVolumeGroupMetadata groupMetaData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            ProvisioningState = provisioningState;
            GroupMetaData = groupMetaData;
        }

        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Azure lifecycle management. </summary>
        public string ProvisioningState { get; }
        /// <summary> Volume group details. </summary>
        public NetAppVolumeGroupMetadata GroupMetaData { get; }
    }
}
