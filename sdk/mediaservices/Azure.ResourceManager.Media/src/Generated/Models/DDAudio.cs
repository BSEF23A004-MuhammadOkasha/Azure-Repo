// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes Dolby Digital Audio Codec (AC3) audio encoding settings. The current implementation for Dolby Digital Audio support are: Audio channel numbers at 1((mono), 2(stereo), 6(5.1side); Audio sampling frequency rates at: 32K/44.1K/48K Hz; Audio bitrate values as AC3 specification supports: 32000, 40000, 48000, 56000, 64000, 80000, 96000, 112000, 128000, 160000, 192000, 224000, 256000, 320000, 384000, 448000, 512000, 576000, 640000 bps. </summary>
    public partial class DDAudio : MediaAudioBase
    {
        /// <summary> Initializes a new instance of <see cref="DDAudio"/>. </summary>
        public DDAudio()
        {
            OdataType = "#Microsoft.Media.DDAudio";
        }

        /// <summary> Initializes a new instance of <see cref="DDAudio"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="label"> An optional label for the codec. The label can be used to control muxing behavior. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="channels"> The number of channels in the audio. </param>
        /// <param name="samplingRate"> The sampling rate to use for encoding in hertz. </param>
        /// <param name="bitrate"> The bitrate, in bits per second, of the output encoded audio. </param>
        internal DDAudio(string odataType, string label, IDictionary<string, BinaryData> serializedAdditionalRawData, int? channels, int? samplingRate, int? bitrate) : base(odataType, label, serializedAdditionalRawData, channels, samplingRate, bitrate)
        {
            OdataType = odataType ?? "#Microsoft.Media.DDAudio";
        }
    }
}
