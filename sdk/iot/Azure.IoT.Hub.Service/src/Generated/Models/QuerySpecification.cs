// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The Json query request. </summary>
    public partial class QuerySpecification
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="QuerySpecification"/>. </summary>
        public QuerySpecification()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QuerySpecification"/>. </summary>
        /// <param name="query"> The query string. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QuerySpecification(string query, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Query = query;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The query string. </summary>
        public string Query { get; set; }
    }
}
