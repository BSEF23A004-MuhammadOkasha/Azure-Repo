// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> NetworkProfile - Profile of network configuration. </summary>
    public partial class NetworkProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkProfile"/>. </summary>
        public NetworkProfile()
        {
            PodCidrs = new ChangeTrackingList<string>();
            ServiceCidrs = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkProfile"/>. </summary>
        /// <param name="loadBalancerProfile"> LoadBalancerProfile - Profile of the cluster load balancer. </param>
        /// <param name="loadBalancerSku"> LoadBalancerSku - The load balancer sku for the provisioned cluster. Possible values: 'unstacked-haproxy', 'stacked-kube-vip', 'stacked-metallb', 'unmanaged'. The default is 'unmanaged'. </param>
        /// <param name="dnsServiceIP"> DNSServiceIP - An IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address range specified in serviceCidr. </param>
        /// <param name="networkPolicy"> NetworkPolicy - Network policy used for building Kubernetes network. Possible values include: 'calico', 'flannel'. Default is 'calico'. </param>
        /// <param name="podCidr"> PodCidr - A CIDR notation IP range from which to assign pod IPs when kubenet is used. </param>
        /// <param name="podCidrs"> The CIDR notation IP ranges from which to assign pod IPs. One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. </param>
        /// <param name="serviceCidr"> ServiceCidr - A CIDR notation IP range from which to assign service cluster IPs. It must not overlap with any Subnet IP ranges. </param>
        /// <param name="serviceCidrs"> The CIDR notation IP ranges from which to assign service cluster IPs. One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. They must not overlap with any Subnet IP ranges. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkProfile(LoadBalancerProfile loadBalancerProfile, LoadBalancerSku? loadBalancerSku, string dnsServiceIP, NetworkPolicy? networkPolicy, string podCidr, IList<string> podCidrs, string serviceCidr, IList<string> serviceCidrs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LoadBalancerProfile = loadBalancerProfile;
            LoadBalancerSku = loadBalancerSku;
            DnsServiceIP = dnsServiceIP;
            NetworkPolicy = networkPolicy;
            PodCidr = podCidr;
            PodCidrs = podCidrs;
            ServiceCidr = serviceCidr;
            ServiceCidrs = serviceCidrs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> LoadBalancerProfile - Profile of the cluster load balancer. </summary>
        public LoadBalancerProfile LoadBalancerProfile { get; set; }
        /// <summary> LoadBalancerSku - The load balancer sku for the provisioned cluster. Possible values: 'unstacked-haproxy', 'stacked-kube-vip', 'stacked-metallb', 'unmanaged'. The default is 'unmanaged'. </summary>
        public LoadBalancerSku? LoadBalancerSku { get; set; }
        /// <summary> DNSServiceIP - An IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address range specified in serviceCidr. </summary>
        public string DnsServiceIP { get; set; }
        /// <summary> NetworkPolicy - Network policy used for building Kubernetes network. Possible values include: 'calico', 'flannel'. Default is 'calico'. </summary>
        public NetworkPolicy? NetworkPolicy { get; set; }
        /// <summary> PodCidr - A CIDR notation IP range from which to assign pod IPs when kubenet is used. </summary>
        public string PodCidr { get; set; }
        /// <summary> The CIDR notation IP ranges from which to assign pod IPs. One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. </summary>
        public IList<string> PodCidrs { get; }
        /// <summary> ServiceCidr - A CIDR notation IP range from which to assign service cluster IPs. It must not overlap with any Subnet IP ranges. </summary>
        public string ServiceCidr { get; set; }
        /// <summary> The CIDR notation IP ranges from which to assign service cluster IPs. One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. They must not overlap with any Subnet IP ranges. </summary>
        public IList<string> ServiceCidrs { get; }
    }
}
