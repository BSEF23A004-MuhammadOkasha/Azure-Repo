// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Sku, to be associated with a SiteNetworkService. </summary>
    public partial class HybridNetworkSku
    {
        /// <summary> Initializes a new instance of HybridNetworkSku. </summary>
        /// <param name="name"> Name of this Sku. </param>
        public HybridNetworkSku(HybridNetworkSkuName name)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of HybridNetworkSku. </summary>
        /// <param name="name"> Name of this Sku. </param>
        /// <param name="tier"> The SKU tier based on the SKU name. </param>
        internal HybridNetworkSku(HybridNetworkSkuName name, HybridNetworkSkuTier? tier)
        {
            Name = name;
            Tier = tier;
        }

        /// <summary> Name of this Sku. </summary>
        public HybridNetworkSkuName Name { get; set; }
        /// <summary> The SKU tier based on the SKU name. </summary>
        public HybridNetworkSkuTier? Tier { get; }
    }
}
