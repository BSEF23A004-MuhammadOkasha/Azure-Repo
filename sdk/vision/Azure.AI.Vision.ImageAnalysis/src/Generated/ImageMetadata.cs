// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Vision.ImageAnalysis
{
    /// <summary> Metadata associated with the analyzed image. </summary>
    public partial class ImageMetadata
    {
        /// <summary> Initializes a new instance of <see cref="ImageMetadata"/>. </summary>
        /// <param name="height"> The height of the image in pixels. </param>
        /// <param name="width"> The width of the image in pixels. </param>
        internal ImageMetadata(int height, int width)
        {
            Height = height;
            Width = width;
        }

        /// <summary> The height of the image in pixels. </summary>
        public int Height { get; }
        /// <summary> The width of the image in pixels. </summary>
        public int Width { get; }
    }
}
