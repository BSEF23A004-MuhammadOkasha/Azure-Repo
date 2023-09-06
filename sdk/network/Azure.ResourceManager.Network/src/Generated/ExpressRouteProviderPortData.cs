// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the ExpressRouteProviderPort data model.
    /// ExpressRouteProviderPort resource.
    /// </summary>
    public partial class ExpressRouteProviderPortData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExpressRouteProviderPortData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ExpressRouteProviderPortData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteProviderPortData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="portPairDescriptor"> The name of the port pair. </param>
        /// <param name="primaryAzurePort"> The name of the primary port. </param>
        /// <param name="secondaryAzurePort"> The name of the secondary port. </param>
        /// <param name="peeringLocation"> The peering location of the port pair. </param>
        /// <param name="overprovisionFactor"> Overprovisioning factor for the port pair. </param>
        /// <param name="portBandwidthInMbps"> Bandwidth of the port in Mbps. </param>
        /// <param name="usedBandwidthInMbps"> Used Bandwidth of the port in Mbps. </param>
        /// <param name="remainingBandwidthInMbps"> Remaining Bandwidth of the port in Mbps. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpressRouteProviderPortData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, string portPairDescriptor, string primaryAzurePort, string secondaryAzurePort, string peeringLocation, int? overprovisionFactor, int? portBandwidthInMbps, int? usedBandwidthInMbps, int? remainingBandwidthInMbps, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            PortPairDescriptor = portPairDescriptor;
            PrimaryAzurePort = primaryAzurePort;
            SecondaryAzurePort = secondaryAzurePort;
            PeeringLocation = peeringLocation;
            OverprovisionFactor = overprovisionFactor;
            PortBandwidthInMbps = portBandwidthInMbps;
            UsedBandwidthInMbps = usedBandwidthInMbps;
            RemainingBandwidthInMbps = remainingBandwidthInMbps;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteProviderPortData"/> for deserialization. </summary>
        internal ExpressRouteProviderPortData()
        {
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The name of the port pair. </summary>
        public string PortPairDescriptor { get; }
        /// <summary> The name of the primary port. </summary>
        public string PrimaryAzurePort { get; }
        /// <summary> The name of the secondary port. </summary>
        public string SecondaryAzurePort { get; }
        /// <summary> The peering location of the port pair. </summary>
        public string PeeringLocation { get; set; }
        /// <summary> Overprovisioning factor for the port pair. </summary>
        public int? OverprovisionFactor { get; set; }
        /// <summary> Bandwidth of the port in Mbps. </summary>
        public int? PortBandwidthInMbps { get; set; }
        /// <summary> Used Bandwidth of the port in Mbps. </summary>
        public int? UsedBandwidthInMbps { get; set; }
        /// <summary> Remaining Bandwidth of the port in Mbps. </summary>
        public int? RemainingBandwidthInMbps { get; set; }
    }
}
