// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PostgreSql.FlexibleServers;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> A list of long term retention backup operations for server. </summary>
    internal partial class PostgreSqlLtrServerBackupOperationList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlLtrServerBackupOperationList"/>. </summary>
        internal PostgreSqlLtrServerBackupOperationList()
        {
            Value = new ChangeTrackingList<PostgreSqlLtrServerBackupOperationData>();
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlLtrServerBackupOperationList"/>. </summary>
        /// <param name="value"> The list of long term retention server backup operations. </param>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlLtrServerBackupOperationList(IReadOnlyList<PostgreSqlLtrServerBackupOperationData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of long term retention server backup operations. </summary>
        public IReadOnlyList<PostgreSqlLtrServerBackupOperationData> Value { get; }
        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
    }
}
