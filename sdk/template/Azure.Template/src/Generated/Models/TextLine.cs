// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace Azure.Template.Models
{
    /// <summary> An object representing an extracted text line. </summary>
    public partial class TextLine
    {
        /// <summary> The text content of the line. </summary>
        public string Text { get; set; }
        /// <summary> Quadrangle bounding box, with coordinates specified relative to the top-left of the original image. The eight numbers represent the four points, clockwise from the top-left corner relative to the text orientation. For image, the (x, y) coordinates are measured in pixels. For PDF, the (x, y) coordinates are measured in inches. </summary>
        public ICollection<float> BoundingBox { get; set; } = new List<float>();
        /// <summary> Language code. </summary>
        public Language? Language { get; set; }
        /// <summary> List of words in the text line. </summary>
        public ICollection<TextWord> Words { get; set; } = new System.Collections.Generic.List<Azure.Template.Models.TextWord>();
    }
}
