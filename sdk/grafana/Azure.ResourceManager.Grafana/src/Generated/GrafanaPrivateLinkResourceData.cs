// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Grafana.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Grafana
{
    /// <summary>
    /// A class representing the GrafanaPrivateLinkResource data model.
    /// A private link resource
    /// </summary>
    public partial class GrafanaPrivateLinkResourceData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GrafanaPrivateLinkResourceData"/>. </summary>
        public GrafanaPrivateLinkResourceData()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="GrafanaPrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The private link resource Private link DNS zone name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GrafanaPrivateLinkResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, GrafanaProvisioningState? provisioningState, string groupId, IReadOnlyList<string> requiredMembers, IList<string> requiredZoneNames, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
            _rawData = rawData;
        }

        /// <summary> Provisioning state of the resource. </summary>
        public GrafanaProvisioningState? ProvisioningState { get; }
        /// <summary> The private link resource group id. </summary>
        public string GroupId { get; }
        /// <summary> The private link resource required member names. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> The private link resource Private link DNS zone name. </summary>
        public IList<string> RequiredZoneNames { get; }
    }
}
