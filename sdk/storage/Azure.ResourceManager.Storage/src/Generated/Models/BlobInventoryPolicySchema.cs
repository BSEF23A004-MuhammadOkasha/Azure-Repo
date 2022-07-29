// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The storage account blob inventory policy rules. </summary>
    public partial class BlobInventoryPolicySchema
    {
        /// <summary> Initializes a new instance of BlobInventoryPolicySchema. </summary>
        /// <param name="isEnabled"> Policy is enabled if set to true. </param>
        /// <param name="ruleType"> The valid value is Inventory. </param>
        /// <param name="rules"> The storage account blob inventory policy rules. The rule is applied when it is enabled. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rules"/> is null. </exception>
        public BlobInventoryPolicySchema(bool isEnabled, BlobInventoryRuleType ruleType, IEnumerable<BlobInventoryPolicyRule> rules)
        {
            if (rules == null)
            {
                throw new ArgumentNullException(nameof(rules));
            }

            IsEnabled = isEnabled;
            RuleType = ruleType;
            Rules = rules.ToList();
        }

        /// <summary> Initializes a new instance of BlobInventoryPolicySchema. </summary>
        /// <param name="isEnabled"> Policy is enabled if set to true. </param>
        /// <param name="destination"> Deprecated Property from API version 2021-04-01 onwards, the required destination container name must be specified at the rule level &apos;policy.rule.destination&apos;. </param>
        /// <param name="ruleType"> The valid value is Inventory. </param>
        /// <param name="rules"> The storage account blob inventory policy rules. The rule is applied when it is enabled. </param>
        internal BlobInventoryPolicySchema(bool isEnabled, string destination, BlobInventoryRuleType ruleType, IList<BlobInventoryPolicyRule> rules)
        {
            IsEnabled = isEnabled;
            Destination = destination;
            RuleType = ruleType;
            Rules = rules;
        }

        /// <summary> Policy is enabled if set to true. </summary>
        public bool IsEnabled { get; set; }
        /// <summary> Deprecated Property from API version 2021-04-01 onwards, the required destination container name must be specified at the rule level &apos;policy.rule.destination&apos;. </summary>
        public string Destination { get; }
        /// <summary> The valid value is Inventory. </summary>
        public BlobInventoryRuleType RuleType { get; set; }
        /// <summary> The storage account blob inventory policy rules. The rule is applied when it is enabled. </summary>
        public IList<BlobInventoryPolicyRule> Rules { get; }
    }
}
