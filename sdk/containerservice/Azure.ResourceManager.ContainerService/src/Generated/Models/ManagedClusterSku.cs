// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The SKU of a Managed Cluster. </summary>
    public partial class ManagedClusterSku
    {
        /// <summary> Initializes a new instance of ManagedClusterSku. </summary>
        public ManagedClusterSku()
        {
        }

        /// <summary> Initializes a new instance of ManagedClusterSku. </summary>
        /// <param name="name"> The name of a managed cluster SKU. </param>
        /// <param name="tier"> If not specified, the default is &apos;Free&apos;. See [uptime SLA](https://docs.microsoft.com/azure/aks/uptime-sla) for more details. </param>
        internal ManagedClusterSku(ManagedClusterSkuName? name, ManagedClusterSkuTier? tier)
        {
            Name = name;
            Tier = tier;
        }

        /// <summary> The name of a managed cluster SKU. </summary>
        public ManagedClusterSkuName? Name { get; set; }
        /// <summary> If not specified, the default is &apos;Free&apos;. See [uptime SLA](https://docs.microsoft.com/azure/aks/uptime-sla) for more details. </summary>
        public ManagedClusterSkuTier? Tier { get; set; }
    }
}
