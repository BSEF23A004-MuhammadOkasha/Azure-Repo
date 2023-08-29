// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDBForPostgreSql;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Models
{
    /// <summary> A list of firewall rules. </summary>
    internal partial class CosmosDBForPostgreSqlFirewallRuleListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSqlFirewallRuleListResult"/>. </summary>
        internal CosmosDBForPostgreSqlFirewallRuleListResult()
        {
            Value = new ChangeTrackingList<CosmosDBForPostgreSqlFirewallRuleData>();
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSqlFirewallRuleListResult"/>. </summary>
        /// <param name="value"> The list of firewall rules in a cluster. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBForPostgreSqlFirewallRuleListResult(IReadOnlyList<CosmosDBForPostgreSqlFirewallRuleData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The list of firewall rules in a cluster. </summary>
        public IReadOnlyList<CosmosDBForPostgreSqlFirewallRuleData> Value { get; }
    }
}
