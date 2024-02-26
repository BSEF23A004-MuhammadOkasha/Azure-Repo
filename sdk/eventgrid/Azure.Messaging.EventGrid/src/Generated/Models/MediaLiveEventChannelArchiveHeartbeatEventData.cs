// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Channel Archive heartbeat event data. Schema of the data property of an EventGridEvent for a Microsoft.Media.LiveEventChannelArchiveHeartbeat event. </summary>
    public partial class MediaLiveEventChannelArchiveHeartbeatEventData
    {
        /// <summary> Initializes a new instance of <see cref="MediaLiveEventChannelArchiveHeartbeatEventData"/>. </summary>
        /// <param name="channelLatencyMsInternal"> Gets the channel latency in ms. </param>
        /// <param name="latencyResultCode"> Gets the latency result code. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="channelLatencyMsInternal"/> or <paramref name="latencyResultCode"/> is null. </exception>
        internal MediaLiveEventChannelArchiveHeartbeatEventData(string channelLatencyMsInternal, string latencyResultCode)
        {
            if (channelLatencyMsInternal == null)
            {
                throw new ArgumentNullException(nameof(channelLatencyMsInternal));
            }
            if (latencyResultCode == null)
            {
                throw new ArgumentNullException(nameof(latencyResultCode));
            }

            ChannelLatencyMsInternal = channelLatencyMsInternal;
            LatencyResultCode = latencyResultCode;
        }
        /// <summary> Gets the latency result code. </summary>
        public string LatencyResultCode { get; }
    }
}
