// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Usage details for subnet. </summary>
    public partial class VirtualNetworkUsage
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkUsage"/>. </summary>
        internal VirtualNetworkUsage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkUsage"/>. </summary>
        /// <param name="currentValue"> Indicates number of IPs used from the Subnet. </param>
        /// <param name="id"> Subnet identifier. </param>
        /// <param name="limit"> Indicates the size of the subnet. </param>
        /// <param name="name"> The name containing common and localized value for usage. </param>
        /// <param name="unit"> Usage units. Returns 'Count'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualNetworkUsage(double? currentValue, ResourceIdentifier id, double? limit, VirtualNetworkUsageName name, string unit, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CurrentValue = currentValue;
            Id = id;
            Limit = limit;
            Name = name;
            Unit = unit;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates number of IPs used from the Subnet. </summary>
        public double? CurrentValue { get; }
        /// <summary> Subnet identifier. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Indicates the size of the subnet. </summary>
        public double? Limit { get; }
        /// <summary> The name containing common and localized value for usage. </summary>
        public VirtualNetworkUsageName Name { get; }
        /// <summary> Usage units. Returns 'Count'. </summary>
        public string Unit { get; }
    }
}
