// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VirtualHub route table. </summary>
    internal partial class VirtualHubRouteTable
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualHubRouteTable"/>. </summary>
        public VirtualHubRouteTable()
        {
            Routes = new ChangeTrackingList<VirtualHubRoute>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualHubRouteTable"/>. </summary>
        /// <param name="routes"> List of all routes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualHubRouteTable(IList<VirtualHubRoute> routes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Routes = routes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of all routes. </summary>
        public IList<VirtualHubRoute> Routes { get; }
    }
}
