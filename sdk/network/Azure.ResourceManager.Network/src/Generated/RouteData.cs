// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the Route data model. </summary>
    public partial class RouteData : SubResource
    {
        /// <summary> Initializes a new instance of RouteData. </summary>
        public RouteData()
        {
        }

        /// <summary> Initializes a new instance of RouteData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="addressPrefix"> The destination CIDR to which the route applies. </param>
        /// <param name="nextHopType"> The type of Azure hop the packet should be sent to. </param>
        /// <param name="nextHopIPAddress"> The IP address packets should be forwarded to. Next hop values are only allowed in routes where the next hop type is VirtualAppliance. </param>
        /// <param name="provisioningState"> The provisioning state of the route resource. </param>
        /// <param name="hasBgpOverride"> A value indicating whether this route overrides overlapping BGP routes regardless of LPM. </param>
        internal RouteData(string id, string name, string etag, string resourceType, string addressPrefix, RouteNextHopType? nextHopType, string nextHopIPAddress, ProvisioningState? provisioningState, bool? hasBgpOverride) : base(id)
        {
            Name = name;
            Etag = etag;
            ResourceType = resourceType;
            AddressPrefix = addressPrefix;
            NextHopType = nextHopType;
            NextHopIPAddress = nextHopIPAddress;
            ProvisioningState = provisioningState;
            HasBgpOverride = hasBgpOverride;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The type of the resource. </summary>
        public string ResourceType { get; set; }
        /// <summary> The destination CIDR to which the route applies. </summary>
        public string AddressPrefix { get; set; }
        /// <summary> The type of Azure hop the packet should be sent to. </summary>
        public RouteNextHopType? NextHopType { get; set; }
        /// <summary> The IP address packets should be forwarded to. Next hop values are only allowed in routes where the next hop type is VirtualAppliance. </summary>
        public string NextHopIPAddress { get; set; }
        /// <summary> The provisioning state of the route resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> A value indicating whether this route overrides overlapping BGP routes regardless of LPM. </summary>
        public bool? HasBgpOverride { get; set; }
    }
}
