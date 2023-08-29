// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    /// <summary> Rtmp stream to be used as an output. </summary>
    public partial class RtmpOutput : MediaOutput
    {
        /// <summary> Initializes a new instance of <see cref="RtmpOutput"/>. </summary>
        /// <param name="streamKey"> Stream key of the stream. </param>
        /// <param name="resolution"> The dimensions of the scene or objects in the scene. </param>
        /// <param name="streamUrl"> The url of the stream. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="streamKey"/>, <paramref name="resolution"/> or <paramref name="streamUrl"/> is null. </exception>
        public RtmpOutput(string streamKey, LayoutResolution resolution, string streamUrl)
        {
            Argument.AssertNotNull(streamKey, nameof(streamKey));
            Argument.AssertNotNull(resolution, nameof(resolution));
            Argument.AssertNotNull(streamUrl, nameof(streamUrl));

            StreamKey = streamKey;
            Resolution = resolution;
            StreamUrl = streamUrl;
            Kind = MediaOutputType.Rtmp;
        }

        /// <summary> Initializes a new instance of <see cref="RtmpOutput"/>. </summary>
        /// <param name="kind"> Kind of media output. </param>
        /// <param name="streamKey"> Stream key of the stream. </param>
        /// <param name="resolution"> The dimensions of the scene or objects in the scene. </param>
        /// <param name="streamUrl"> The url of the stream. </param>
        /// <param name="mode"> Rtmp mode. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RtmpOutput(MediaOutputType kind, string streamKey, LayoutResolution resolution, string streamUrl, RtmpMode? mode, Dictionary<string, BinaryData> rawData) : base(kind, rawData)
        {
            StreamKey = streamKey;
            Resolution = resolution;
            StreamUrl = streamUrl;
            Mode = mode;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="RtmpOutput"/> for deserialization. </summary>
        internal RtmpOutput()
        {
        }

        /// <summary> Stream key of the stream. </summary>
        public string StreamKey { get; set; }
        /// <summary> The dimensions of the scene or objects in the scene. </summary>
        public LayoutResolution Resolution { get; set; }
        /// <summary> The url of the stream. </summary>
        public string StreamUrl { get; set; }
        /// <summary> Rtmp mode. </summary>
        public RtmpMode? Mode { get; set; }
    }
}
