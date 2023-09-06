// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListAzureFirewallFqdnTags API service call. </summary>
    internal partial class AzureFirewallFqdnTagListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AzureFirewallFqdnTagListResult"/>. </summary>
        internal AzureFirewallFqdnTagListResult()
        {
            Value = new ChangeTrackingList<AzureFirewallFqdnTag>();
        }

        /// <summary> Initializes a new instance of <see cref="AzureFirewallFqdnTagListResult"/>. </summary>
        /// <param name="value"> List of Azure Firewall FQDN Tags in a resource group. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureFirewallFqdnTagListResult(IReadOnlyList<AzureFirewallFqdnTag> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of Azure Firewall FQDN Tags in a resource group. </summary>
        public IReadOnlyList<AzureFirewallFqdnTag> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
