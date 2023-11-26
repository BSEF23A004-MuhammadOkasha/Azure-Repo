// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    /// <summary> The UnknownVectorSearchAlgorithmConfiguration. </summary>
    internal partial class UnknownVectorSearchAlgorithmConfiguration : VectorSearchAlgorithmConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="UnknownVectorSearchAlgorithmConfiguration"/>. </summary>
        /// <param name="name"> The name to associate with this particular configuration. </param>
        /// <param name="kind"> The name of the kind of algorithm being configured for use with vector search. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownVectorSearchAlgorithmConfiguration(string name, VectorSearchAlgorithmKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(name, kind, serializedAdditionalRawData)
        {
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownVectorSearchAlgorithmConfiguration"/> for deserialization. </summary>
        internal UnknownVectorSearchAlgorithmConfiguration()
        {
        }
    }
}
