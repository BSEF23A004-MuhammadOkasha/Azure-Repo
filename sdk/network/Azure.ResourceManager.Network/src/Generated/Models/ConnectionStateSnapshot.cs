// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Connection state snapshot. </summary>
    public partial class ConnectionStateSnapshot
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConnectionStateSnapshot"/>. </summary>
        internal ConnectionStateSnapshot()
        {
            Hops = new ChangeTrackingList<ConnectivityHopInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionStateSnapshot"/>. </summary>
        /// <param name="networkConnectionState"> The connection state. </param>
        /// <param name="startOn"> The start time of the connection snapshot. </param>
        /// <param name="endOn"> The end time of the connection snapshot. </param>
        /// <param name="evaluationState"> Connectivity analysis evaluation state. </param>
        /// <param name="avgLatencyInMs"> Average latency in ms. </param>
        /// <param name="minLatencyInMs"> Minimum latency in ms. </param>
        /// <param name="maxLatencyInMs"> Maximum latency in ms. </param>
        /// <param name="probesSent"> The number of sent probes. </param>
        /// <param name="probesFailed"> The number of failed probes. </param>
        /// <param name="hops"> List of hops between the source and the destination. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectionStateSnapshot(NetworkConnectionState? networkConnectionState, DateTimeOffset? startOn, DateTimeOffset? endOn, EvaluationState? evaluationState, long? avgLatencyInMs, long? minLatencyInMs, long? maxLatencyInMs, long? probesSent, long? probesFailed, IReadOnlyList<ConnectivityHopInfo> hops, Dictionary<string, BinaryData> rawData)
        {
            NetworkConnectionState = networkConnectionState;
            StartOn = startOn;
            EndOn = endOn;
            EvaluationState = evaluationState;
            AvgLatencyInMs = avgLatencyInMs;
            MinLatencyInMs = minLatencyInMs;
            MaxLatencyInMs = maxLatencyInMs;
            ProbesSent = probesSent;
            ProbesFailed = probesFailed;
            Hops = hops;
            _rawData = rawData;
        }

        /// <summary> The connection state. </summary>
        public NetworkConnectionState? NetworkConnectionState { get; }
        /// <summary> The start time of the connection snapshot. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The end time of the connection snapshot. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Connectivity analysis evaluation state. </summary>
        public EvaluationState? EvaluationState { get; }
        /// <summary> Average latency in ms. </summary>
        public long? AvgLatencyInMs { get; }
        /// <summary> Minimum latency in ms. </summary>
        public long? MinLatencyInMs { get; }
        /// <summary> Maximum latency in ms. </summary>
        public long? MaxLatencyInMs { get; }
        /// <summary> The number of sent probes. </summary>
        public long? ProbesSent { get; }
        /// <summary> The number of failed probes. </summary>
        public long? ProbesFailed { get; }
        /// <summary> List of hops between the source and the destination. </summary>
        public IReadOnlyList<ConnectivityHopInfo> Hops { get; }
    }
}
