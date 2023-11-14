// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListConnections API service call retrieves all global reach connections that belongs to a Private Peering for an ExpressRouteCircuit. </summary>
    internal partial class ExpressRouteCircuitConnectionListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitConnectionListResult"/>. </summary>
        internal ExpressRouteCircuitConnectionListResult()
        {
            Value = new ChangeTrackingList<ExpressRouteCircuitConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitConnectionListResult"/>. </summary>
        /// <param name="value"> The global reach connection associated with Private Peering in an ExpressRoute Circuit. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpressRouteCircuitConnectionListResult(IReadOnlyList<ExpressRouteCircuitConnectionData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The global reach connection associated with Private Peering in an ExpressRoute Circuit. </summary>
        public IReadOnlyList<ExpressRouteCircuitConnectionData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
