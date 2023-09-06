// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> A web application firewall rule group. </summary>
    public partial class ApplicationGatewayFirewallRuleGroup
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayFirewallRuleGroup"/>. </summary>
        /// <param name="ruleGroupName"> The name of the web application firewall rule group. </param>
        /// <param name="rules"> The rules of the web application firewall rule group. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleGroupName"/> or <paramref name="rules"/> is null. </exception>
        public ApplicationGatewayFirewallRuleGroup(string ruleGroupName, IEnumerable<ApplicationGatewayFirewallRule> rules)
        {
            Argument.AssertNotNull(ruleGroupName, nameof(ruleGroupName));
            Argument.AssertNotNull(rules, nameof(rules));

            RuleGroupName = ruleGroupName;
            Rules = rules.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayFirewallRuleGroup"/>. </summary>
        /// <param name="ruleGroupName"> The name of the web application firewall rule group. </param>
        /// <param name="description"> The description of the web application firewall rule group. </param>
        /// <param name="rules"> The rules of the web application firewall rule group. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayFirewallRuleGroup(string ruleGroupName, string description, IList<ApplicationGatewayFirewallRule> rules, Dictionary<string, BinaryData> rawData)
        {
            RuleGroupName = ruleGroupName;
            Description = description;
            Rules = rules;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayFirewallRuleGroup"/> for deserialization. </summary>
        internal ApplicationGatewayFirewallRuleGroup()
        {
        }

        /// <summary> The name of the web application firewall rule group. </summary>
        public string RuleGroupName { get; set; }
        /// <summary> The description of the web application firewall rule group. </summary>
        public string Description { get; set; }
        /// <summary> The rules of the web application firewall rule group. </summary>
        public IList<ApplicationGatewayFirewallRule> Rules { get; }
    }
}
