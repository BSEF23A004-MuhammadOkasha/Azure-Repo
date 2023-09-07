// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes all the properties for encoding a video with the H.265 codec. </summary>
    public partial class H265Video : MediaVideoBase
    {
        /// <summary> Initializes a new instance of <see cref="H265Video"/>. </summary>
        public H265Video()
        {
            Layers = new ChangeTrackingList<H265Layer>();
            OdataType = "#Microsoft.Media.H265Video";
        }

        /// <summary> Initializes a new instance of <see cref="H265Video"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="label"> An optional label for the codec. The label can be used to control muxing behavior. </param>
        /// <param name="keyFrameInterval"> The distance between two key frames. The value should be non-zero in the range [0.5, 20] seconds, specified in ISO 8601 format. The default is 2 seconds(PT2S). Note that this setting is ignored if VideoSyncMode.Passthrough is set, where the KeyFrameInterval value will follow the input source setting. </param>
        /// <param name="stretchMode"> The resizing mode - how the input video will be resized to fit the desired output resolution(s). Default is AutoSize. </param>
        /// <param name="syncMode"> The Video Sync Mode. </param>
        /// <param name="useSceneChangeDetection"> Specifies whether or not the encoder should insert key frames at scene changes. If not specified, the default is false. This flag should be set to true only when the encoder is being configured to produce a single output video. </param>
        /// <param name="complexity"> Tells the encoder how to choose its encoding settings.  Quality will provide for a higher compression ratio but at a higher cost and longer compute time.  Speed will produce a relatively larger file but is faster and more economical. The default value is Balanced. </param>
        /// <param name="layers"> The collection of output H.265 layers to be produced by the encoder. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal H265Video(string odataType, string label, TimeSpan? keyFrameInterval, InputVideoStretchMode? stretchMode, VideoSyncMode? syncMode, bool? useSceneChangeDetection, H265Complexity? complexity, IList<H265Layer> layers, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(odataType, label, keyFrameInterval, stretchMode, syncMode, serializedAdditionalRawData)
        {
            UseSceneChangeDetection = useSceneChangeDetection;
            Complexity = complexity;
            Layers = layers;
            OdataType = odataType ?? "#Microsoft.Media.H265Video";
        }

        /// <summary> Specifies whether or not the encoder should insert key frames at scene changes. If not specified, the default is false. This flag should be set to true only when the encoder is being configured to produce a single output video. </summary>
        public bool? UseSceneChangeDetection { get; set; }
        /// <summary> Tells the encoder how to choose its encoding settings.  Quality will provide for a higher compression ratio but at a higher cost and longer compute time.  Speed will produce a relatively larger file but is faster and more economical. The default value is Balanced. </summary>
        public H265Complexity? Complexity { get; set; }
        /// <summary> The collection of output H.265 layers to be produced by the encoder. </summary>
        public IList<H265Layer> Layers { get; }
    }
}
