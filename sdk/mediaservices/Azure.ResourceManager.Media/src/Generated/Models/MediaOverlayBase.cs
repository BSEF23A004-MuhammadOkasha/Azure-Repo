// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Base type for all overlays - image, audio or video.
    /// Please note <see cref="MediaOverlayBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AudioOverlay"/> and <see cref="VideoOverlay"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownOverlay))]
    public abstract partial class MediaOverlayBase
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MediaOverlayBase"/>. </summary>
        /// <param name="inputLabel"> The label of the job input which is to be used as an overlay. The Input must specify exactly one file. You can specify an image file in JPG, PNG, GIF or BMP format, or an audio file (such as a WAV, MP3, WMA or M4A file), or a video file. See https://aka.ms/mesformats for the complete list of supported audio and video file formats. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputLabel"/> is null. </exception>
        protected MediaOverlayBase(string inputLabel)
        {
            Argument.AssertNotNull(inputLabel, nameof(inputLabel));

            InputLabel = inputLabel;
        }

        /// <summary> Initializes a new instance of <see cref="MediaOverlayBase"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="inputLabel"> The label of the job input which is to be used as an overlay. The Input must specify exactly one file. You can specify an image file in JPG, PNG, GIF or BMP format, or an audio file (such as a WAV, MP3, WMA or M4A file), or a video file. See https://aka.ms/mesformats for the complete list of supported audio and video file formats. </param>
        /// <param name="start"> The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video. </param>
        /// <param name="end"> The end position, with reference to the input video, at which the overlay ends. The value should be in ISO 8601 format. For example, PT30S to end the overlay at 30 seconds into the input video. If not specified or the value is greater than the input video duration, the overlay will be applied until the end of the input video if the overlay media duration is greater than the input video duration, else the overlay will last as long as the overlay media duration. </param>
        /// <param name="fadeInDuration"> The duration over which the overlay fades in onto the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade in (same as PT0S). </param>
        /// <param name="fadeOutDuration"> The duration over which the overlay fades out of the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade out (same as PT0S). </param>
        /// <param name="audioGainLevel"> The gain level of audio in the overlay. The value should be in the range [0, 1.0]. The default is 1.0. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaOverlayBase(string odataType, string inputLabel, TimeSpan? start, TimeSpan? end, TimeSpan? fadeInDuration, TimeSpan? fadeOutDuration, double? audioGainLevel, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OdataType = odataType;
            InputLabel = inputLabel;
            Start = start;
            End = end;
            FadeInDuration = fadeInDuration;
            FadeOutDuration = fadeOutDuration;
            AudioGainLevel = audioGainLevel;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MediaOverlayBase"/> for deserialization. </summary>
        internal MediaOverlayBase()
        {
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
        /// <summary> The label of the job input which is to be used as an overlay. The Input must specify exactly one file. You can specify an image file in JPG, PNG, GIF or BMP format, or an audio file (such as a WAV, MP3, WMA or M4A file), or a video file. See https://aka.ms/mesformats for the complete list of supported audio and video file formats. </summary>
        public string InputLabel { get; set; }
        /// <summary> The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video. </summary>
        public TimeSpan? Start { get; set; }
        /// <summary> The end position, with reference to the input video, at which the overlay ends. The value should be in ISO 8601 format. For example, PT30S to end the overlay at 30 seconds into the input video. If not specified or the value is greater than the input video duration, the overlay will be applied until the end of the input video if the overlay media duration is greater than the input video duration, else the overlay will last as long as the overlay media duration. </summary>
        public TimeSpan? End { get; set; }
        /// <summary> The duration over which the overlay fades in onto the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade in (same as PT0S). </summary>
        public TimeSpan? FadeInDuration { get; set; }
        /// <summary> The duration over which the overlay fades out of the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade out (same as PT0S). </summary>
        public TimeSpan? FadeOutDuration { get; set; }
        /// <summary> The gain level of audio in the overlay. The value should be in the range [0, 1.0]. The default is 1.0. </summary>
        public double? AudioGainLevel { get; set; }
    }
}
