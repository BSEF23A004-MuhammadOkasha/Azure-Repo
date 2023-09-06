// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PrivateDns;

namespace Azure.ResourceManager.PrivateDns.Models
{
    /// <summary> The response to a record set list operation. </summary>
    internal partial class PrivateDnsRecordListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateDnsRecordListResult"/>. </summary>
        internal PrivateDnsRecordListResult()
        {
            Value = new ChangeTrackingList<PrivateDnsRecordData>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateDnsRecordListResult"/>. </summary>
        /// <param name="value"> Information about the record sets in the response. </param>
        /// <param name="nextLink"> The continuation token for the next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateDnsRecordListResult(IReadOnlyList<PrivateDnsRecordData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Information about the record sets in the response. </summary>
        public IReadOnlyList<PrivateDnsRecordData> Value { get; }
        /// <summary> The continuation token for the next page of results. </summary>
        public string NextLink { get; }
    }
}
