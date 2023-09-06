// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The BatchQueryResponse. </summary>
    internal partial class BatchQueryResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BatchQueryResponse"/>. </summary>
        internal BatchQueryResponse()
        {
            Headers = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchQueryResponse"/>. </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="body"> Contains the tables, columns &amp; rows resulting from a query. </param>
        /// <param name="headers"> Dictionary of &lt;string&gt;. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchQueryResponse(string id, int? status, LogsBatchQueryResult body, IReadOnlyDictionary<string, string> headers, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Status = status;
            Body = body;
            Headers = headers;
            _rawData = rawData;
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary> Gets the status. </summary>
        public int? Status { get; }
        /// <summary> Contains the tables, columns &amp; rows resulting from a query. </summary>
        public LogsBatchQueryResult Body { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IReadOnlyDictionary<string, string> Headers { get; }
    }
}
