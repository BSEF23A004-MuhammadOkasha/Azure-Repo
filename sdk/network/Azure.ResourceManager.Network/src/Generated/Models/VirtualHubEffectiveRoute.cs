// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The effective route configured on the virtual hub or specified resource. </summary>
    public partial class VirtualHubEffectiveRoute
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualHubEffectiveRoute"/>. </summary>
        internal VirtualHubEffectiveRoute()
        {
            AddressPrefixes = new ChangeTrackingList<string>();
            NextHops = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualHubEffectiveRoute"/>. </summary>
        /// <param name="addressPrefixes"> The list of address prefixes. </param>
        /// <param name="nextHops"> The list of next hops. </param>
        /// <param name="nextHopType"> The type of the next hop. </param>
        /// <param name="asPath"> The ASPath of this route. </param>
        /// <param name="routeOrigin"> The origin of this route. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualHubEffectiveRoute(IReadOnlyList<string> addressPrefixes, IReadOnlyList<string> nextHops, string nextHopType, string asPath, string routeOrigin, Dictionary<string, BinaryData> rawData)
        {
            AddressPrefixes = addressPrefixes;
            NextHops = nextHops;
            NextHopType = nextHopType;
            AsPath = asPath;
            RouteOrigin = routeOrigin;
            _rawData = rawData;
        }

        /// <summary> The list of address prefixes. </summary>
        public IReadOnlyList<string> AddressPrefixes { get; }
        /// <summary> The list of next hops. </summary>
        public IReadOnlyList<string> NextHops { get; }
        /// <summary> The type of the next hop. </summary>
        public string NextHopType { get; }
        /// <summary> The ASPath of this route. </summary>
        public string AsPath { get; }
        /// <summary> The origin of this route. </summary>
        public string RouteOrigin { get; }
    }
}
