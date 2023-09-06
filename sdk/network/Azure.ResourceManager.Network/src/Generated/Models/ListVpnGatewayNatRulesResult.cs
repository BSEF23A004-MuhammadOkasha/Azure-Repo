// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Result of the request to list all nat rules to a virtual wan vpn gateway. It contains a list of Nat rules and a URL nextLink to get the next set of results. </summary>
    internal partial class ListVpnGatewayNatRulesResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ListVpnGatewayNatRulesResult"/>. </summary>
        internal ListVpnGatewayNatRulesResult()
        {
            Value = new ChangeTrackingList<VpnGatewayNatRuleData>();
        }

        /// <summary> Initializes a new instance of <see cref="ListVpnGatewayNatRulesResult"/>. </summary>
        /// <param name="value"> List of Nat Rules. </param>
        /// <param name="nextLink"> URL to get the next set of operation list results if there are any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ListVpnGatewayNatRulesResult(IReadOnlyList<VpnGatewayNatRuleData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of Nat Rules. </summary>
        public IReadOnlyList<VpnGatewayNatRuleData> Value { get; }
        /// <summary> URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}
