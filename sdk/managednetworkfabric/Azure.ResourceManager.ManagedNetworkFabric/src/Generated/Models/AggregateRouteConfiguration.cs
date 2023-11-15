// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of IPv4 and IPv6 aggregate routes. </summary>
    public partial class AggregateRouteConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AggregateRouteConfiguration"/>. </summary>
        public AggregateRouteConfiguration()
        {
            IPv4Routes = new ChangeTrackingList<AggregateRoute>();
            IPv6Routes = new ChangeTrackingList<AggregateRoute>();
        }

        /// <summary> Initializes a new instance of <see cref="AggregateRouteConfiguration"/>. </summary>
        /// <param name="ipv4Routes"> List of IPv4 Route prefixes. </param>
        /// <param name="ipv6Routes"> List of Ipv6Routes prefixes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AggregateRouteConfiguration(IList<AggregateRoute> ipv4Routes, IList<AggregateRoute> ipv6Routes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IPv4Routes = ipv4Routes;
            IPv6Routes = ipv6Routes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of IPv4 Route prefixes. </summary>
        public IList<AggregateRoute> IPv4Routes { get; }
        /// <summary> List of Ipv6Routes prefixes. </summary>
        public IList<AggregateRoute> IPv6Routes { get; }
    }
}
