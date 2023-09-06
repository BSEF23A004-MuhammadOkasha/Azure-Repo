// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Contiguous region of the concatenated content property, specified as an offset and length. </summary>
    public readonly partial struct DocumentSpan
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private readonly Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DocumentSpan"/>. </summary>
        /// <param name="index"> Zero-based index of the content represented by the span. </param>
        /// <param name="length"> Number of characters in the content represented by the span. </param>
        internal DocumentSpan(int index, int length)
        {
            Index = index;
            Length = length;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentSpan"/>. </summary>
        /// <param name="index"> Zero-based index of the content represented by the span. </param>
        /// <param name="length"> Number of characters in the content represented by the span. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentSpan(int index, int length, Dictionary<string, BinaryData> rawData)
        {
            Index = index;
            Length = length;
            _rawData = rawData;
        }
    }
}
