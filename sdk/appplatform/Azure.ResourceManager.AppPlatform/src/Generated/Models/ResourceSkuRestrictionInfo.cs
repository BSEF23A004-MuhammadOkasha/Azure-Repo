// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Information about the restriction where the SKU cannot be used. </summary>
    public partial class ResourceSkuRestrictionInfo
    {
        /// <summary> Initializes a new instance of <see cref="ResourceSkuRestrictionInfo"/>. </summary>
        internal ResourceSkuRestrictionInfo()
        {
            Locations = new ChangeTrackingList<AzureLocation>();
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceSkuRestrictionInfo"/>. </summary>
        /// <param name="locations"> Gets locations where the SKU is restricted. </param>
        /// <param name="zones"> Gets list of availability zones where the SKU is restricted. </param>
        internal ResourceSkuRestrictionInfo(IReadOnlyList<AzureLocation> locations, IReadOnlyList<string> zones)
        {
            Locations = locations;
            Zones = zones;
        }

        /// <summary> Gets locations where the SKU is restricted. </summary>
        public IReadOnlyList<AzureLocation> Locations { get; }
        /// <summary> Gets list of availability zones where the SKU is restricted. </summary>
        public IReadOnlyList<string> Zones { get; }
    }
}
