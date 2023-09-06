// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Contains IPv6 peering config. </summary>
    public partial class IPv6ExpressRouteCircuitPeeringConfig
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IPv6ExpressRouteCircuitPeeringConfig"/>. </summary>
        public IPv6ExpressRouteCircuitPeeringConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IPv6ExpressRouteCircuitPeeringConfig"/>. </summary>
        /// <param name="primaryPeerAddressPrefix"> The primary address prefix. </param>
        /// <param name="secondaryPeerAddressPrefix"> The secondary address prefix. </param>
        /// <param name="microsoftPeeringConfig"> The Microsoft peering configuration. </param>
        /// <param name="routeFilter"> The reference to the RouteFilter resource. </param>
        /// <param name="state"> The state of peering. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IPv6ExpressRouteCircuitPeeringConfig(string primaryPeerAddressPrefix, string secondaryPeerAddressPrefix, ExpressRouteCircuitPeeringConfig microsoftPeeringConfig, WritableSubResource routeFilter, ExpressRouteCircuitPeeringState? state, Dictionary<string, BinaryData> rawData)
        {
            PrimaryPeerAddressPrefix = primaryPeerAddressPrefix;
            SecondaryPeerAddressPrefix = secondaryPeerAddressPrefix;
            MicrosoftPeeringConfig = microsoftPeeringConfig;
            RouteFilter = routeFilter;
            State = state;
            _rawData = rawData;
        }

        /// <summary> The primary address prefix. </summary>
        public string PrimaryPeerAddressPrefix { get; set; }
        /// <summary> The secondary address prefix. </summary>
        public string SecondaryPeerAddressPrefix { get; set; }
        /// <summary> The Microsoft peering configuration. </summary>
        public ExpressRouteCircuitPeeringConfig MicrosoftPeeringConfig { get; set; }
        /// <summary> The reference to the RouteFilter resource. </summary>
        internal WritableSubResource RouteFilter { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier RouteFilterId
        {
            get => RouteFilter is null ? default : RouteFilter.Id;
            set
            {
                if (RouteFilter is null)
                    RouteFilter = new WritableSubResource();
                RouteFilter.Id = value;
            }
        }

        /// <summary> The state of peering. </summary>
        public ExpressRouteCircuitPeeringState? State { get; set; }
    }
}
