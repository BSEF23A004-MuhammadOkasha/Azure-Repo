// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The ApiManagementSkuRestrictionInfo. </summary>
    public partial class ApiManagementSkuRestrictionInfo
    {
        /// <summary> Initializes a new instance of ApiManagementSkuRestrictionInfo. </summary>
        internal ApiManagementSkuRestrictionInfo()
        {
            Locations = new Core.ChangeTrackingList<AzureLocation>();
            Zones = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ApiManagementSkuRestrictionInfo. </summary>
        /// <param name="locations"> Locations where the SKU is restricted. </param>
        /// <param name="zones"> List of availability zones where the SKU is restricted. </param>
        internal ApiManagementSkuRestrictionInfo(IReadOnlyList<AzureLocation> locations, IReadOnlyList<string> zones)
        {
            Locations = locations;
            Zones = zones;
        }

        /// <summary> Locations where the SKU is restricted. </summary>
        public IReadOnlyList<AzureLocation> Locations { get; }
        /// <summary> List of availability zones where the SKU is restricted. </summary>
        public IReadOnlyList<string> Zones { get; }
    }
}
