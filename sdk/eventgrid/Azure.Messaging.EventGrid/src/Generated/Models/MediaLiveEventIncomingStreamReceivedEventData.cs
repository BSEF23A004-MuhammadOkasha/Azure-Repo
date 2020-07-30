// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Encoder connect event data. </summary>
    internal partial class MediaLiveEventIncomingStreamReceivedEventData
    {
        /// <summary> Initializes a new instance of MediaLiveEventIncomingStreamReceivedEventData. </summary>
        internal MediaLiveEventIncomingStreamReceivedEventData()
        {
        }

        /// <summary> Gets the ingest URL provided by the live event. </summary>
        public string IngestUrl { get; }
        /// <summary> Gets the type of the track (Audio / Video). </summary>
        public string TrackType { get; }
        /// <summary> Gets the track name. </summary>
        public string TrackName { get; }
        /// <summary> Gets the bitrate of the track. </summary>
        public long? Bitrate { get; }
        /// <summary> Gets the remote IP. </summary>
        public string EncoderIp { get; }
        /// <summary> Gets the remote port. </summary>
        public string EncoderPort { get; }
        /// <summary> Gets the first timestamp of the data chunk received. </summary>
        public string Timestamp { get; }
        /// <summary> Gets the duration of the first data chunk. </summary>
        public string Duration { get; }
        /// <summary> Gets the timescale in which timestamp is represented. </summary>
        public string Timescale { get; }
    }
}
