// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> ElasticSAN SKU and its properties. </summary>
    public partial class ElasticSanSkuInformation
    {
        /// <summary> Initializes a new instance of ElasticSanSkuInformation. </summary>
        /// <param name="name"> Sku Name. </param>
        internal ElasticSanSkuInformation(ElasticSanSkuName name)
        {
            Name = name;
            Locations = new ChangeTrackingList<string>();
            LocationInfo = new ChangeTrackingList<ElasticSanSkuLocationInfo>();
            Capabilities = new ChangeTrackingList<ElasticSanSkuCapability>();
        }

        /// <summary> Initializes a new instance of ElasticSanSkuInformation. </summary>
        /// <param name="name"> Sku Name. </param>
        /// <param name="tier"> Sku Tier. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="locations"> The set of locations that the SKU is available. This will be supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). </param>
        /// <param name="locationInfo"> Availability of the SKU for the location/zone. </param>
        /// <param name="capabilities"> The capability information in the specified SKU. </param>
        internal ElasticSanSkuInformation(ElasticSanSkuName name, ElasticSanSkuTier? tier, string resourceType, IReadOnlyList<string> locations, IReadOnlyList<ElasticSanSkuLocationInfo> locationInfo, IReadOnlyList<ElasticSanSkuCapability> capabilities)
        {
            Name = name;
            Tier = tier;
            ResourceType = resourceType;
            Locations = locations;
            LocationInfo = locationInfo;
            Capabilities = capabilities;
        }

        /// <summary> Sku Name. </summary>
        public ElasticSanSkuName Name { get; }
        /// <summary> Sku Tier. </summary>
        public ElasticSanSkuTier? Tier { get; }
        /// <summary> The type of the resource. </summary>
        public string ResourceType { get; }
        /// <summary> The set of locations that the SKU is available. This will be supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). </summary>
        public IReadOnlyList<string> Locations { get; }
        /// <summary> Availability of the SKU for the location/zone. </summary>
        public IReadOnlyList<ElasticSanSkuLocationInfo> LocationInfo { get; }
        /// <summary> The capability information in the specified SKU. </summary>
        public IReadOnlyList<ElasticSanSkuCapability> Capabilities { get; }
    }
}
