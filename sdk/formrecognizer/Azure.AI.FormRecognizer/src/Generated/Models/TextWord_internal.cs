// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> An object representing a word. </summary>
    internal partial class TextWord_internal
    {
        /// <summary> Initializes a new instance of TextWord_internal. </summary>
        /// <param name="text"> The text content of the word. </param>
        /// <param name="boundingBox"> Bounding box of an extracted word. </param>
        internal TextWord_internal(string text, IReadOnlyList<float> boundingBox)
        {
            Text = text;
            BoundingBox = boundingBox;
        }

        /// <summary> Initializes a new instance of TextWord_internal. </summary>
        /// <param name="text"> The text content of the word. </param>
        /// <param name="boundingBox"> Bounding box of an extracted word. </param>
        /// <param name="confidence"> Confidence value. </param>
        internal TextWord_internal(string text, IReadOnlyList<float> boundingBox, float? confidence)
        {
            Text = text;
            BoundingBox = boundingBox;
            Confidence = confidence;
        }

        /// <summary> The text content of the word. </summary>
        public string Text { get; }
        /// <summary> Bounding box of an extracted word. </summary>
        public IReadOnlyList<float> BoundingBox { get; } = new List<float>();
        /// <summary> Confidence value. </summary>
        public float? Confidence { get; }
    }
}
