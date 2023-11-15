// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Image scaling mode. </summary>
    public partial class ImageScale
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ImageScale"/>. </summary>
        public ImageScale()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ImageScale"/>. </summary>
        /// <param name="mode"> Describes the image scaling mode to be applied. Default mode is 'pad'. </param>
        /// <param name="width"> The desired output image width. </param>
        /// <param name="height"> The desired output image height. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImageScale(ImageScaleMode? mode, string width, string height, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Mode = mode;
            Width = width;
            Height = height;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Describes the image scaling mode to be applied. Default mode is 'pad'. </summary>
        public ImageScaleMode? Mode { get; set; }
        /// <summary> The desired output image width. </summary>
        public string Width { get; set; }
        /// <summary> The desired output image height. </summary>
        public string Height { get; set; }
    }
}
