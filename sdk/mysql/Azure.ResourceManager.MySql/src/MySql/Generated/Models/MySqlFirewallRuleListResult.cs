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
    /// <summary> A list of firewall rules. </summary>
    internal partial class MySqlFirewallRuleListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MySqlFirewallRuleListResult"/>. </summary>
        internal MySqlFirewallRuleListResult()
        {
            Value = new ChangeTrackingList<MySqlFirewallRuleData>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFirewallRuleListResult"/>. </summary>
        /// <param name="value"> The list of firewall rules in a server. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlFirewallRuleListResult(IReadOnlyList<MySqlFirewallRuleData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of firewall rules in a server. </summary>
        public IReadOnlyList<MySqlFirewallRuleData> Value { get; }
    }
}
