// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> A List of logFiles. </summary>
    internal partial class MySqlFlexibleServerLogFileListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerLogFileListResult"/>. </summary>
        internal MySqlFlexibleServerLogFileListResult()
        {
            Value = new ChangeTrackingList<MySqlFlexibleServerLogFile>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerLogFileListResult"/>. </summary>
        /// <param name="value"> The list of logFiles in a server. </param>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlFlexibleServerLogFileListResult(IReadOnlyList<MySqlFlexibleServerLogFile> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of logFiles in a server. </summary>
        public IReadOnlyList<MySqlFlexibleServerLogFile> Value { get; }
        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
    }
}
