// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DnsResolver.Models
{
    /// <summary> The response to an enumeration operation on Virtual Network DNS Forwarding Ruleset. </summary>
    internal partial class VirtualNetworkDnsForwardingRulesetListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkDnsForwardingRulesetListResult"/>. </summary>
        internal VirtualNetworkDnsForwardingRulesetListResult()
        {
            Value = new ChangeTrackingList<VirtualNetworkDnsForwardingRuleset>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkDnsForwardingRulesetListResult"/>. </summary>
        /// <param name="value"> Enumeration of the Virtual Network DNS Forwarding Ruleset. </param>
        /// <param name="nextLink"> The continuation token for the next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualNetworkDnsForwardingRulesetListResult(IReadOnlyList<VirtualNetworkDnsForwardingRuleset> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Enumeration of the Virtual Network DNS Forwarding Ruleset. </summary>
        public IReadOnlyList<VirtualNetworkDnsForwardingRuleset> Value { get; }
        /// <summary> The continuation token for the next page of results. </summary>
        public string NextLink { get; }
    }
}
