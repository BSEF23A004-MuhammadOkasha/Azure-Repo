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
    /// <summary> Response for ListSubnets API service call. Retrieves all subnets that belong to a virtual network. </summary>
    internal partial class VirtualNetworkPeeringListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkPeeringListResult"/>. </summary>
        internal VirtualNetworkPeeringListResult()
        {
            Value = new ChangeTrackingList<VirtualNetworkPeeringData>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkPeeringListResult"/>. </summary>
        /// <param name="value"> The peerings in a virtual network. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualNetworkPeeringListResult(IReadOnlyList<VirtualNetworkPeeringData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The peerings in a virtual network. </summary>
        public IReadOnlyList<VirtualNetworkPeeringData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
