// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> A list of query texts. </summary>
    internal partial class MySqlQueryTextListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MySqlQueryTextListResult"/>. </summary>
        internal MySqlQueryTextListResult()
        {
            Value = new ChangeTrackingList<MySqlQueryTextData>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlQueryTextListResult"/>. </summary>
        /// <param name="value"> The list of query texts. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlQueryTextListResult(IReadOnlyList<MySqlQueryTextData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of query texts. </summary>
        public IReadOnlyList<MySqlQueryTextData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
