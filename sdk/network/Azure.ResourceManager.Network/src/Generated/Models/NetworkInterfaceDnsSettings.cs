// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> DNS settings of a network interface. </summary>
    public partial class NetworkInterfaceDnsSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkInterfaceDnsSettings"/>. </summary>
        public NetworkInterfaceDnsSettings()
        {
            DnsServers = new ChangeTrackingList<string>();
            AppliedDnsServers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkInterfaceDnsSettings"/>. </summary>
        /// <param name="dnsServers"> List of DNS servers IP addresses. Use 'AzureProvidedDNS' to switch to azure provided DNS resolution. 'AzureProvidedDNS' value cannot be combined with other IPs, it must be the only value in dnsServers collection. </param>
        /// <param name="appliedDnsServers"> If the VM that uses this NIC is part of an Availability Set, then this list will have the union of all DNS servers from all NICs that are part of the Availability Set. This property is what is configured on each of those VMs. </param>
        /// <param name="internalDnsNameLabel"> Relative DNS name for this NIC used for internal communications between VMs in the same virtual network. </param>
        /// <param name="internalFqdn"> Fully qualified DNS name supporting internal communications between VMs in the same virtual network. </param>
        /// <param name="internalDomainNameSuffix"> Even if internalDnsNameLabel is not specified, a DNS entry is created for the primary NIC of the VM. This DNS name can be constructed by concatenating the VM name with the value of internalDomainNameSuffix. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkInterfaceDnsSettings(IList<string> dnsServers, IReadOnlyList<string> appliedDnsServers, string internalDnsNameLabel, string internalFqdn, string internalDomainNameSuffix, Dictionary<string, BinaryData> rawData)
        {
            DnsServers = dnsServers;
            AppliedDnsServers = appliedDnsServers;
            InternalDnsNameLabel = internalDnsNameLabel;
            InternalFqdn = internalFqdn;
            InternalDomainNameSuffix = internalDomainNameSuffix;
            _rawData = rawData;
        }

        /// <summary> List of DNS servers IP addresses. Use 'AzureProvidedDNS' to switch to azure provided DNS resolution. 'AzureProvidedDNS' value cannot be combined with other IPs, it must be the only value in dnsServers collection. </summary>
        public IList<string> DnsServers { get; }
        /// <summary> If the VM that uses this NIC is part of an Availability Set, then this list will have the union of all DNS servers from all NICs that are part of the Availability Set. This property is what is configured on each of those VMs. </summary>
        public IReadOnlyList<string> AppliedDnsServers { get; }
        /// <summary> Relative DNS name for this NIC used for internal communications between VMs in the same virtual network. </summary>
        public string InternalDnsNameLabel { get; set; }
        /// <summary> Fully qualified DNS name supporting internal communications between VMs in the same virtual network. </summary>
        public string InternalFqdn { get; }
        /// <summary> Even if internalDnsNameLabel is not specified, a DNS entry is created for the primary NIC of the VM. This DNS name can be constructed by concatenating the VM name with the value of internalDomainNameSuffix. </summary>
        public string InternalDomainNameSuffix { get; }
    }
}
