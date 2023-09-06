// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Document analysis parameters. </summary>
    internal partial class AnalyzeDocumentRequest
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AnalyzeDocumentRequest"/>. </summary>
        public AnalyzeDocumentRequest()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeDocumentRequest"/>. </summary>
        /// <param name="urlSource"> Document URL to analyze.  Either urlSource or base64Source must be specified. </param>
        /// <param name="base64Source"> Base64 encoding of the document to analyze.  Either urlSource or base64Source must be specified. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeDocumentRequest(Uri urlSource, byte[] base64Source, Dictionary<string, BinaryData> rawData)
        {
            UrlSource = urlSource;
            Base64Source = base64Source;
            _rawData = rawData;
        }

        /// <summary> Document URL to analyze.  Either urlSource or base64Source must be specified. </summary>
        public Uri UrlSource { get; set; }
        /// <summary> Base64 encoding of the document to analyze.  Either urlSource or base64Source must be specified. </summary>
        public byte[] Base64Source { get; set; }
    }
}
