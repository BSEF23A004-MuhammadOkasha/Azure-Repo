// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    /// <summary> Gets or sets the provider specific properties. </summary>
    public partial class ProviderSpecificProperties
    {
        /// <summary> Initializes a new instance of ProviderSpecificProperties. </summary>
        public ProviderSpecificProperties()
        {
        }

        /// <summary> Initializes a new instance of ProviderSpecificProperties. </summary>
        /// <param name="providerType"> The provider type. For example, the value can be SapHana. </param>
        internal ProviderSpecificProperties(string providerType)
        {
            ProviderType = providerType;
        }

        /// <summary> The provider type. For example, the value can be SapHana. </summary>
        internal string ProviderType { get; set; }
    }
}
