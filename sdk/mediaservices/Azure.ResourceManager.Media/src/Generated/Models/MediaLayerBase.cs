// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The encoder can be configured to produce video and/or images (thumbnails) at different resolutions, by specifying a layer for each desired resolution. A layer represents the properties for the video or image at a resolution. </summary>
    public partial class MediaLayerBase
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MediaLayerBase"/>. </summary>
        public MediaLayerBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaLayerBase"/>. </summary>
        /// <param name="width"> The width of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in width as the input. </param>
        /// <param name="height"> The height of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in height as the input. </param>
        /// <param name="label"> The alphanumeric label for this layer, which can be used in multiplexing different video and audio layers, or in naming the output file. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaLayerBase(string width, string height, string label, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Width = width;
            Height = height;
            Label = label;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The width of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in width as the input. </summary>
        public string Width { get; set; }
        /// <summary> The height of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in height as the input. </summary>
        public string Height { get; set; }
        /// <summary> The alphanumeric label for this layer, which can be used in multiplexing different video and audio layers, or in naming the output file. </summary>
        public string Label { get; set; }
    }
}
