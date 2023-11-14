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
    /// <summary> Response for ListExpressRouteCircuit API service call. </summary>
    internal partial class ExpressRouteCircuitListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitListResult"/>. </summary>
        internal ExpressRouteCircuitListResult()
        {
            Value = new ChangeTrackingList<ExpressRouteCircuitData>();
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteCircuitListResult"/>. </summary>
        /// <param name="value"> A list of ExpressRouteCircuits in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpressRouteCircuitListResult(IReadOnlyList<ExpressRouteCircuitData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A list of ExpressRouteCircuits in a resource group. </summary>
        public IReadOnlyList<ExpressRouteCircuitData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
