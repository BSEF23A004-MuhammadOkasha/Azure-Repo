// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> A List of logFiles. </summary>
    internal partial class PostgreSqlFlexibleServerLogFileListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerLogFileListResult"/>. </summary>
        internal PostgreSqlFlexibleServerLogFileListResult()
        {
            Value = new ChangeTrackingList<PostgreSqlFlexibleServerLogFile>();
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerLogFileListResult"/>. </summary>
        /// <param name="value"> The list of logFiles in a server. </param>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFlexibleServerLogFileListResult(IReadOnlyList<PostgreSqlFlexibleServerLogFile> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of logFiles in a server. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerLogFile> Value { get; }
        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
    }
}
