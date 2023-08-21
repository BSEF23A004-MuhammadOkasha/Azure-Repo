// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> A word object consisting of a contiguous sequence of characters.  For non-space delimited languages, such as Chinese, Japanese, and Korean, each character is represented as its own word. </summary>
    public partial class DocumentWord
    {
        /// <summary> Initializes a new instance of DocumentWord. </summary>
        /// <param name="content"> Text content of the word. </param>
        /// <param name="span"> Location of the word in the reading order concatenated content. </param>
        /// <param name="confidence"> Confidence of correctly extracting the word. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        internal DocumentWord(string content, DocumentSpan span, float confidence)
        {
            Argument.AssertNotNull(content, nameof(content));

            Content = content;
            Polygon = new ChangeTrackingList<float>();
            Span = span;
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of DocumentWord. </summary>
        /// <param name="content"> Text content of the word. </param>
        /// <param name="polygon"> Bounding polygon of the word. </param>
        /// <param name="span"> Location of the word in the reading order concatenated content. </param>
        /// <param name="confidence"> Confidence of correctly extracting the word. </param>
        internal DocumentWord(string content, IReadOnlyList<float> polygon, DocumentSpan span, float confidence)
        {
            Content = content;
            Polygon = polygon;
            Span = span;
            Confidence = confidence;
        }

        /// <summary> Text content of the word. </summary>
        public string Content { get; }
        /// <summary> Location of the word in the reading order concatenated content. </summary>
        public DocumentSpan Span { get; }
        /// <summary> Confidence of correctly extracting the word. </summary>
        public float Confidence { get; }
    }
}
