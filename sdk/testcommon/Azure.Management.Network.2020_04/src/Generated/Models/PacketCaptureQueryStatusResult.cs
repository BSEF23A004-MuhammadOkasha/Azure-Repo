// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Status of packet capture session. </summary>
    public partial class PacketCaptureQueryStatusResult
    {
        /// <summary> Initializes a new instance of PacketCaptureQueryStatusResult. </summary>
        internal PacketCaptureQueryStatusResult()
        {
        }

        /// <summary> Initializes a new instance of PacketCaptureQueryStatusResult. </summary>
        /// <param name="name"> The name of the packet capture resource. </param>
        /// <param name="id"> The ID of the packet capture resource. </param>
        /// <param name="captureStartTime"> The start time of the packet capture session. </param>
        /// <param name="packetCaptureStatus"> The status of the packet capture session. </param>
        /// <param name="stopReason"> The reason the current packet capture session was stopped. </param>
        /// <param name="packetCaptureError"> List of errors of packet capture session. </param>
        internal PacketCaptureQueryStatusResult(string name, string id, DateTimeOffset? captureStartTime, PcStatus? packetCaptureStatus, string stopReason, IReadOnlyList<PcError> packetCaptureError)
        {
            Name = name;
            Id = id;
            CaptureStartTime = captureStartTime;
            PacketCaptureStatus = packetCaptureStatus;
            StopReason = stopReason;
            PacketCaptureError = packetCaptureError;
        }

        /// <summary> The name of the packet capture resource. </summary>
        public string Name { get; }
        /// <summary> The ID of the packet capture resource. </summary>
        public string Id { get; }
        /// <summary> The start time of the packet capture session. </summary>
        public DateTimeOffset? CaptureStartTime { get; }
        /// <summary> The status of the packet capture session. </summary>
        public PcStatus? PacketCaptureStatus { get; }
        /// <summary> The reason the current packet capture session was stopped. </summary>
        public string StopReason { get; }
        /// <summary> List of errors of packet capture session. </summary>
        public IReadOnlyList<PcError> PacketCaptureError { get; }
    }
}
