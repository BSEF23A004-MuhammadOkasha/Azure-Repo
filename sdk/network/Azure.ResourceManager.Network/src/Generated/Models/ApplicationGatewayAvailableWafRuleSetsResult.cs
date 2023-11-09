// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ApplicationGatewayAvailableWafRuleSets API service call. </summary>
    internal partial class ApplicationGatewayAvailableWafRuleSetsResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayAvailableWafRuleSetsResult"/>. </summary>
        internal ApplicationGatewayAvailableWafRuleSetsResult()
        {
            Value = new ChangeTrackingList<ApplicationGatewayFirewallRuleSet>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayAvailableWafRuleSetsResult"/>. </summary>
        /// <param name="value"> The list of application gateway rule sets. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayAvailableWafRuleSetsResult(IReadOnlyList<ApplicationGatewayFirewallRuleSet> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of application gateway rule sets. </summary>
        public IReadOnlyList<ApplicationGatewayFirewallRuleSet> Value { get; }
    }
}
