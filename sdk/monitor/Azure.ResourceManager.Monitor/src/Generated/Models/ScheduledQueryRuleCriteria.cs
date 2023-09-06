// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The rule criteria that defines the conditions of the scheduled query rule. </summary>
    internal partial class ScheduledQueryRuleCriteria
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ScheduledQueryRuleCriteria"/>. </summary>
        public ScheduledQueryRuleCriteria()
        {
            AllOf = new ChangeTrackingList<ScheduledQueryRuleCondition>();
        }

        /// <summary> Initializes a new instance of <see cref="ScheduledQueryRuleCriteria"/>. </summary>
        /// <param name="allOf"> A list of conditions to evaluate against the specified scopes. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ScheduledQueryRuleCriteria(IList<ScheduledQueryRuleCondition> allOf, Dictionary<string, BinaryData> rawData)
        {
            AllOf = allOf;
            _rawData = rawData;
        }

        /// <summary> A list of conditions to evaluate against the specified scopes. </summary>
        public IList<ScheduledQueryRuleCondition> AllOf { get; }
    }
}
