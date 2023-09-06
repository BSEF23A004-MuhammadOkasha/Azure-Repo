// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.DigitalTwins.Core
{
    /// <summary> The results of a query operation and an optional continuation token. </summary>
    internal partial class QueryResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="QueryResult"/>. </summary>
        /// <param name="value"> The query results. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal QueryResult(IEnumerable<object> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="QueryResult"/>. </summary>
        /// <param name="value"> The query results. </param>
        /// <param name="continuationToken"> A token which can be used to construct a new QuerySpecification to retrieve the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryResult(IReadOnlyList<object> value, string continuationToken, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            ContinuationToken = continuationToken;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="QueryResult"/> for deserialization. </summary>
        internal QueryResult()
        {
        }

        /// <summary> The query results. </summary>
        public IReadOnlyList<object> Value { get; }
        /// <summary> A token which can be used to construct a new QuerySpecification to retrieve the next set of results. </summary>
        public string ContinuationToken { get; }
    }
}
