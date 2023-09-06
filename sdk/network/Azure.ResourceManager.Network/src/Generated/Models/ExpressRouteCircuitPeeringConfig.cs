// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Specifies the peering configuration. </summary>
    public partial class ExpressRouteCircuitPeeringConfig
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitPeeringConfig"/>. </summary>
        public ExpressRouteCircuitPeeringConfig()
        {
            AdvertisedPublicPrefixes = new ChangeTrackingList<string>();
            AdvertisedCommunities = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitPeeringConfig"/>. </summary>
        /// <param name="advertisedPublicPrefixes"> The reference to AdvertisedPublicPrefixes. </param>
        /// <param name="advertisedCommunities"> The communities of bgp peering. Specified for microsoft peering. </param>
        /// <param name="advertisedPublicPrefixesState"> The advertised public prefix state of the Peering resource. </param>
        /// <param name="legacyMode"> The legacy mode of the peering. </param>
        /// <param name="customerASN"> The CustomerASN of the peering. </param>
        /// <param name="routingRegistryName"> The RoutingRegistryName of the configuration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpressRouteCircuitPeeringConfig(IList<string> advertisedPublicPrefixes, IList<string> advertisedCommunities, ExpressRouteCircuitPeeringAdvertisedPublicPrefixState? advertisedPublicPrefixesState, int? legacyMode, int? customerASN, string routingRegistryName, Dictionary<string, BinaryData> rawData)
        {
            AdvertisedPublicPrefixes = advertisedPublicPrefixes;
            AdvertisedCommunities = advertisedCommunities;
            AdvertisedPublicPrefixesState = advertisedPublicPrefixesState;
            LegacyMode = legacyMode;
            CustomerASN = customerASN;
            RoutingRegistryName = routingRegistryName;
            _rawData = rawData;
        }

        /// <summary> The reference to AdvertisedPublicPrefixes. </summary>
        public IList<string> AdvertisedPublicPrefixes { get; }
        /// <summary> The communities of bgp peering. Specified for microsoft peering. </summary>
        public IList<string> AdvertisedCommunities { get; }
        /// <summary> The advertised public prefix state of the Peering resource. </summary>
        public ExpressRouteCircuitPeeringAdvertisedPublicPrefixState? AdvertisedPublicPrefixesState { get; }
        /// <summary> The legacy mode of the peering. </summary>
        public int? LegacyMode { get; set; }
        /// <summary> The CustomerASN of the peering. </summary>
        public int? CustomerASN { get; set; }
        /// <summary> The RoutingRegistryName of the configuration. </summary>
        public string RoutingRegistryName { get; set; }
    }
}
