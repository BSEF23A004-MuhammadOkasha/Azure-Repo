// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the Route data model. </summary>
    public partial class RouteData : NetworkWritableResourceData
    {
        /// <summary> Initializes a new instance of RouteData. </summary>
        public RouteData()
        {
        }

        /// <summary> Initializes a new instance of RouteData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="eTag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="addressPrefix"> The destination CIDR to which the route applies. </param>
        /// <param name="nextHopType"> The type of Azure hop the packet should be sent to. </param>
        /// <param name="nextHopIPAddress"> The IP address packets should be forwarded to. Next hop values are only allowed in routes where the next hop type is VirtualAppliance. </param>
        /// <param name="provisioningState"> The provisioning state of the route resource. </param>
        /// <param name="hasBgpOverride"> A value indicating whether this route overrides overlapping BGP routes regardless of LPM. </param>
        internal RouteData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? eTag, string addressPrefix, RouteNextHopType? nextHopType, string nextHopIPAddress, NetworkProvisioningState? provisioningState, bool? hasBgpOverride) : base(id, name, resourceType)
        {
            ETag = eTag;
            AddressPrefix = addressPrefix;
            NextHopType = nextHopType;
            NextHopIPAddress = nextHopIPAddress;
            ProvisioningState = provisioningState;
            HasBgpOverride = hasBgpOverride;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The destination CIDR to which the route applies. </summary>
        public string AddressPrefix { get; set; }
        /// <summary> The type of Azure hop the packet should be sent to. </summary>
        public RouteNextHopType? NextHopType { get; set; }
        /// <summary> The IP address packets should be forwarded to. Next hop values are only allowed in routes where the next hop type is VirtualAppliance. </summary>
        public string NextHopIPAddress { get; set; }
        /// <summary> The provisioning state of the route resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> A value indicating whether this route overrides overlapping BGP routes regardless of LPM. </summary>
        public bool? HasBgpOverride { get; set; }
    }
}
