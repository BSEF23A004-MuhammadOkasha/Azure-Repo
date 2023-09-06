// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The parameters specifying the connection resource whose inbound routes are being requested. </summary>
    public partial class VirtualHubInboundRoutesContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualHubInboundRoutesContent"/>. </summary>
        public VirtualHubInboundRoutesContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualHubInboundRoutesContent"/>. </summary>
        /// <param name="resourceUri"> The connection resource whose inbound routes are being requested. </param>
        /// <param name="connectionType"> The type of the specified connection resource like ExpressRouteConnection, HubVirtualNetworkConnection, VpnConnection and P2SConnection. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualHubInboundRoutesContent(Uri resourceUri, string connectionType, Dictionary<string, BinaryData> rawData)
        {
            ResourceUri = resourceUri;
            ConnectionType = connectionType;
            _rawData = rawData;
        }

        /// <summary> The connection resource whose inbound routes are being requested. </summary>
        public Uri ResourceUri { get; set; }
        /// <summary> The type of the specified connection resource like ExpressRouteConnection, HubVirtualNetworkConnection, VpnConnection and P2SConnection. </summary>
        public string ConnectionType { get; set; }
    }
}
