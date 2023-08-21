// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The AutomationRulesList. </summary>
    internal partial class AutomationRulesList
    {
        /// <summary> Initializes a new instance of AutomationRulesList. </summary>
        internal AutomationRulesList()
        {
            Value = new ChangeTrackingList<SecurityInsightsAutomationRuleData>();
        }

        /// <summary> Initializes a new instance of AutomationRulesList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal AutomationRulesList(IReadOnlyList<SecurityInsightsAutomationRuleData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<SecurityInsightsAutomationRuleData> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
