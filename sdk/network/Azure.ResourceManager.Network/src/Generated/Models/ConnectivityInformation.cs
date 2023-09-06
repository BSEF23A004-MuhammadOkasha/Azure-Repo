// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Information on the connectivity status. </summary>
    public partial class ConnectivityInformation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConnectivityInformation"/>. </summary>
        internal ConnectivityInformation()
        {
            Hops = new ChangeTrackingList<ConnectivityHopInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityInformation"/>. </summary>
        /// <param name="hops"> List of hops between the source and the destination. </param>
        /// <param name="networkConnectionStatus"> The connection status. </param>
        /// <param name="avgLatencyInMs"> Average latency in milliseconds. </param>
        /// <param name="minLatencyInMs"> Minimum latency in milliseconds. </param>
        /// <param name="maxLatencyInMs"> Maximum latency in milliseconds. </param>
        /// <param name="probesSent"> Total number of probes sent. </param>
        /// <param name="probesFailed"> Number of failed probes. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectivityInformation(IReadOnlyList<ConnectivityHopInfo> hops, NetworkConnectionStatus? networkConnectionStatus, int? avgLatencyInMs, int? minLatencyInMs, int? maxLatencyInMs, int? probesSent, int? probesFailed, Dictionary<string, BinaryData> rawData)
        {
            Hops = hops;
            NetworkConnectionStatus = networkConnectionStatus;
            AvgLatencyInMs = avgLatencyInMs;
            MinLatencyInMs = minLatencyInMs;
            MaxLatencyInMs = maxLatencyInMs;
            ProbesSent = probesSent;
            ProbesFailed = probesFailed;
            _rawData = rawData;
        }

        /// <summary> List of hops between the source and the destination. </summary>
        public IReadOnlyList<ConnectivityHopInfo> Hops { get; }
        /// <summary> The connection status. </summary>
        public NetworkConnectionStatus? NetworkConnectionStatus { get; }
        /// <summary> Average latency in milliseconds. </summary>
        public int? AvgLatencyInMs { get; }
        /// <summary> Minimum latency in milliseconds. </summary>
        public int? MinLatencyInMs { get; }
        /// <summary> Maximum latency in milliseconds. </summary>
        public int? MaxLatencyInMs { get; }
        /// <summary> Total number of probes sent. </summary>
        public int? ProbesSent { get; }
        /// <summary> Number of failed probes. </summary>
        public int? ProbesFailed { get; }
    }
}
