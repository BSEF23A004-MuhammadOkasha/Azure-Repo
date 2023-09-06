// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Describes the TCP configuration. </summary>
    public partial class ConnectionMonitorTcpConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorTcpConfiguration"/>. </summary>
        public ConnectionMonitorTcpConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorTcpConfiguration"/>. </summary>
        /// <param name="port"> The port to connect to. </param>
        /// <param name="disableTraceRoute"> Value indicating whether path evaluation with trace route should be disabled. </param>
        /// <param name="destinationPortBehavior"> Destination port behavior. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectionMonitorTcpConfiguration(int? port, bool? disableTraceRoute, DestinationPortBehavior? destinationPortBehavior, Dictionary<string, BinaryData> rawData)
        {
            Port = port;
            DisableTraceRoute = disableTraceRoute;
            DestinationPortBehavior = destinationPortBehavior;
            _rawData = rawData;
        }

        /// <summary> The port to connect to. </summary>
        public int? Port { get; set; }
        /// <summary> Value indicating whether path evaluation with trace route should be disabled. </summary>
        public bool? DisableTraceRoute { get; set; }
        /// <summary> Destination port behavior. </summary>
        public DestinationPortBehavior? DestinationPortBehavior { get; set; }
    }
}
