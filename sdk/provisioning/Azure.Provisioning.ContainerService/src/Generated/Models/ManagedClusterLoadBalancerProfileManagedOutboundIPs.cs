// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Desired managed outbound IPs for the cluster load balancer.
/// </summary>
public partial class ManagedClusterLoadBalancerProfileManagedOutboundIPs : ProvisioningConstruct
{
    /// <summary>
    /// The desired number of IPv4 outbound IPs created/managed by Azure for
    /// the cluster load balancer. Allowed values must be in the range of 1 to
    /// 100 (inclusive). The default value is 1.
    /// </summary>
    public BicepValue<int> Count { get => _count; set => _count.Assign(value); }
    private readonly BicepValue<int> _count;

    /// <summary>
    /// The desired number of IPv6 outbound IPs created/managed by Azure for
    /// the cluster load balancer. Allowed values must be in the range of 1 to
    /// 100 (inclusive). The default value is 0 for single-stack and 1 for
    /// dual-stack.
    /// </summary>
    public BicepValue<int> CountIPv6 { get => _countIPv6; set => _countIPv6.Assign(value); }
    private readonly BicepValue<int> _countIPv6;

    /// <summary>
    /// Creates a new ManagedClusterLoadBalancerProfileManagedOutboundIPs.
    /// </summary>
    public ManagedClusterLoadBalancerProfileManagedOutboundIPs()
    {
        _count = BicepValue<int>.DefineProperty(this, "Count", ["count"]);
        _countIPv6 = BicepValue<int>.DefineProperty(this, "CountIPv6", ["countIPv6"]);
    }
}
