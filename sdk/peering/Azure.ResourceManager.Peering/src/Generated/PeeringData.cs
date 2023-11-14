// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    /// <summary>
    /// A class representing the Peering data model.
    /// Peering is a logical representation of a set of connections to the Microsoft Cloud Edge at a location.
    /// </summary>
    public partial class PeeringData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PeeringData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU that defines the tier and kind of the peering. </param>
        /// <param name="kind"> The kind of the peering. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public PeeringData(AzureLocation location, PeeringSku sku, PeeringKind kind) : base(location)
        {
            Argument.AssertNotNull(sku, nameof(sku));

            Sku = sku;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="PeeringData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU that defines the tier and kind of the peering. </param>
        /// <param name="kind"> The kind of the peering. </param>
        /// <param name="direct"> The properties that define a direct peering. </param>
        /// <param name="exchange"> The properties that define an exchange peering. </param>
        /// <param name="peeringLocation"> The location of the peering. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PeeringData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, PeeringSku sku, PeeringKind kind, DirectPeeringProperties direct, ExchangePeeringProperties exchange, string peeringLocation, PeeringProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Kind = kind;
            Direct = direct;
            Exchange = exchange;
            PeeringLocation = peeringLocation;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PeeringData"/> for deserialization. </summary>
        internal PeeringData()
        {
        }

        /// <summary> The SKU that defines the tier and kind of the peering. </summary>
        public PeeringSku Sku { get; set; }
        /// <summary> The kind of the peering. </summary>
        public PeeringKind Kind { get; set; }
        /// <summary> The properties that define a direct peering. </summary>
        public DirectPeeringProperties Direct { get; set; }
        /// <summary> The properties that define an exchange peering. </summary>
        public ExchangePeeringProperties Exchange { get; set; }
        /// <summary> The location of the peering. </summary>
        public string PeeringLocation { get; set; }
        /// <summary> The provisioning state of the resource. </summary>
        public PeeringProvisioningState? ProvisioningState { get; }
    }
}
