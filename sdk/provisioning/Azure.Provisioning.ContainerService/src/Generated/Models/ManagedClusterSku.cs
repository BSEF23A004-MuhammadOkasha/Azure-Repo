// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// The SKU of a Managed Cluster.
/// </summary>
public partial class ManagedClusterSku : ProvisionableConstruct
{
    /// <summary>
    /// The name of a managed cluster SKU.
    /// </summary>
    public BicepValue<ManagedClusterSkuName> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<ManagedClusterSkuName> _name;

    /// <summary>
    /// If not specified, the default is &apos;Free&apos;. See [AKS Pricing
    /// Tier](https://learn.microsoft.com/azure/aks/free-standard-pricing-tiers)
    /// for more details.
    /// </summary>
    public BicepValue<ManagedClusterSkuTier> Tier { get => _tier; set => _tier.Assign(value); }
    private readonly BicepValue<ManagedClusterSkuTier> _tier;

    /// <summary>
    /// Creates a new ManagedClusterSku.
    /// </summary>
    public ManagedClusterSku()
    {
        _name = BicepValue<ManagedClusterSkuName>.DefineProperty(this, "Name", ["name"]);
        _tier = BicepValue<ManagedClusterSkuTier>.DefineProperty(this, "Tier", ["tier"]);
    }
}
