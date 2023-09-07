// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.IotHub.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotHub
{
    /// <summary>
    /// A class representing the IotHubDescription data model.
    /// The description of the IoT hub.
    /// </summary>
    public partial class IotHubDescriptionData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotHubDescriptionData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> IotHub SKU info. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public IotHubDescriptionData(AzureLocation location, IotHubSkuInfo sku) : base(location)
        {
            Argument.AssertNotNull(sku, nameof(sku));

            Sku = sku;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubDescriptionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention. </param>
        /// <param name="properties"> IotHub properties. </param>
        /// <param name="sku"> IotHub SKU info. </param>
        /// <param name="identity"> The managed identities for the IotHub. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubDescriptionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, IotHubProperties properties, IotHubSkuInfo sku, ManagedServiceIdentity identity, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            Properties = properties;
            Sku = sku;
            Identity = identity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubDescriptionData"/> for deserialization. </summary>
        internal IotHubDescriptionData()
        {
        }

        /// <summary> The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention. </summary>
        public ETag? ETag { get; set; }
        /// <summary> IotHub properties. </summary>
        public IotHubProperties Properties { get; set; }
        /// <summary> IotHub SKU info. </summary>
        public IotHubSkuInfo Sku { get; set; }
        /// <summary> The managed identities for the IotHub. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
