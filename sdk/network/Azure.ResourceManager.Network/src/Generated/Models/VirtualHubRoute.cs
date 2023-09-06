// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VirtualHub route. </summary>
    public partial class VirtualHubRoute
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualHubRoute"/>. </summary>
        public VirtualHubRoute()
        {
            AddressPrefixes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualHubRoute"/>. </summary>
        /// <param name="addressPrefixes"> List of all addressPrefixes. </param>
        /// <param name="nextHopIPAddress"> NextHop ip address. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualHubRoute(IList<string> addressPrefixes, string nextHopIPAddress, Dictionary<string, BinaryData> rawData)
        {
            AddressPrefixes = addressPrefixes;
            NextHopIPAddress = nextHopIPAddress;
            _rawData = rawData;
        }

        /// <summary> List of all addressPrefixes. </summary>
        public IList<string> AddressPrefixes { get; }
        /// <summary> NextHop ip address. </summary>
        public string NextHopIPAddress { get; set; }
    }
}
