// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Azure Blob Storage content. </summary>
    public partial class BlobContentSource
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BlobContentSource"/>. </summary>
        /// <param name="containerUri"> Azure Blob Storage container URL. </param>
        /// <param name="prefix"> Blob name prefix. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobContentSource(Uri containerUri, string prefix, Dictionary<string, BinaryData> rawData)
        {
            ContainerUri = containerUri;
            Prefix = prefix;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="BlobContentSource"/> for deserialization. </summary>
        internal BlobContentSource()
        {
        }
        /// <summary> Blob name prefix. </summary>
        public string Prefix { get; set; }
    }
}
