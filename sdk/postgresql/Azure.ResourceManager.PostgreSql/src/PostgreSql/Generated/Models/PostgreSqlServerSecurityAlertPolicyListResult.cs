// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> A list of the server's security alert policies. </summary>
    internal partial class PostgreSqlServerSecurityAlertPolicyListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerSecurityAlertPolicyListResult"/>. </summary>
        internal PostgreSqlServerSecurityAlertPolicyListResult()
        {
            Value = new ChangeTrackingList<PostgreSqlServerSecurityAlertPolicyData>();
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerSecurityAlertPolicyListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlServerSecurityAlertPolicyListResult(IReadOnlyList<PostgreSqlServerSecurityAlertPolicyData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<PostgreSqlServerSecurityAlertPolicyData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
