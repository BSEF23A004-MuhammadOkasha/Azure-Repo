// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes the properties of a rectangular window applied to the input media before processing it. </summary>
    public partial class RectangularWindow
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RectangularWindow"/>. </summary>
        public RectangularWindow()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RectangularWindow"/>. </summary>
        /// <param name="left"> The number of pixels from the left-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%). </param>
        /// <param name="top"> The number of pixels from the top-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%). </param>
        /// <param name="width"> The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%). </param>
        /// <param name="height"> The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RectangularWindow(string left, string top, string width, string height, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The number of pixels from the left-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%). </summary>
        public string Left { get; set; }
        /// <summary> The number of pixels from the top-margin. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%). </summary>
        public string Top { get; set; }
        /// <summary> The width of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%). </summary>
        public string Width { get; set; }
        /// <summary> The height of the rectangular region in pixels. This can be absolute pixel value (e.g 100), or relative to the size of the video (For example, 50%). </summary>
        public string Height { get; set; }
    }
}
