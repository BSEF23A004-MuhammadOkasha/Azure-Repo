// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> ThreatIntel Whitelist for Firewall Policy. </summary>
    public partial class FirewallPolicyThreatIntelWhitelist
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyThreatIntelWhitelist"/>. </summary>
        public FirewallPolicyThreatIntelWhitelist()
        {
            IPAddresses = new ChangeTrackingList<string>();
            Fqdns = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="FirewallPolicyThreatIntelWhitelist"/>. </summary>
        /// <param name="ipAddresses"> List of IP addresses for the ThreatIntel Whitelist. </param>
        /// <param name="fqdns"> List of FQDNs for the ThreatIntel Whitelist. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FirewallPolicyThreatIntelWhitelist(IList<string> ipAddresses, IList<string> fqdns, Dictionary<string, BinaryData> rawData)
        {
            IPAddresses = ipAddresses;
            Fqdns = fqdns;
            _rawData = rawData;
        }

        /// <summary> List of IP addresses for the ThreatIntel Whitelist. </summary>
        public IList<string> IPAddresses { get; }
        /// <summary> List of FQDNs for the ThreatIntel Whitelist. </summary>
        public IList<string> Fqdns { get; }
    }
}
