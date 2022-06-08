// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    /// <summary> A class representing the ArcSetting data model. </summary>
    public partial class ArcSettingData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ArcSettingData"/>. </summary>
        public ArcSettingData()
        {
            PerNodeDetails = new ChangeTrackingList<PerNodeState>();
        }

        /// <summary> Initializes a new instance of <see cref="ArcSettingData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the ArcSetting proxy resource. </param>
        /// <param name="arcInstanceResourceGroup"> The resource group that hosts the Arc agents, ie. Hybrid Compute Machine resources. </param>
        /// <param name="arcApplicationClientId"> App id of arc AAD identity. </param>
        /// <param name="arcApplicationTenantId"> Tenant id of arc AAD identity. </param>
        /// <param name="arcServicePrincipalObjectId"> Object id of arc AAD service principal. </param>
        /// <param name="arcApplicationObjectId"> Object id of arc AAD identity. </param>
        /// <param name="aggregateState"> Aggregate state of Arc agent across the nodes in this HCI cluster. </param>
        /// <param name="perNodeDetails"> State of Arc agent in each of the nodes. </param>
        /// <param name="connectivityProperties"> contains connectivity related configuration for ARC resources. </param>
        internal ArcSettingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ProvisioningState? provisioningState, string arcInstanceResourceGroup, Guid? arcApplicationClientId, Guid? arcApplicationTenantId, Guid? arcServicePrincipalObjectId, Guid? arcApplicationObjectId, ArcSettingAggregateState? aggregateState, IReadOnlyList<PerNodeState> perNodeDetails, BinaryData connectivityProperties) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            ArcInstanceResourceGroup = arcInstanceResourceGroup;
            ArcApplicationClientId = arcApplicationClientId;
            ArcApplicationTenantId = arcApplicationTenantId;
            ArcServicePrincipalObjectId = arcServicePrincipalObjectId;
            ArcApplicationObjectId = arcApplicationObjectId;
            AggregateState = aggregateState;
            PerNodeDetails = perNodeDetails;
            ConnectivityProperties = connectivityProperties;
        }

        /// <summary> Provisioning state of the ArcSetting proxy resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The resource group that hosts the Arc agents, ie. Hybrid Compute Machine resources. </summary>
        public string ArcInstanceResourceGroup { get; set; }
        /// <summary> App id of arc AAD identity. </summary>
        public Guid? ArcApplicationClientId { get; set; }
        /// <summary> Tenant id of arc AAD identity. </summary>
        public Guid? ArcApplicationTenantId { get; set; }
        /// <summary> Object id of arc AAD service principal. </summary>
        public Guid? ArcServicePrincipalObjectId { get; set; }
        /// <summary> Object id of arc AAD identity. </summary>
        public Guid? ArcApplicationObjectId { get; set; }
        /// <summary> Aggregate state of Arc agent across the nodes in this HCI cluster. </summary>
        public ArcSettingAggregateState? AggregateState { get; }
        /// <summary> State of Arc agent in each of the nodes. </summary>
        public IReadOnlyList<PerNodeState> PerNodeDetails { get; }
        /// <summary> contains connectivity related configuration for ARC resources. </summary>
        public BinaryData ConnectivityProperties { get; set; }
    }
}
