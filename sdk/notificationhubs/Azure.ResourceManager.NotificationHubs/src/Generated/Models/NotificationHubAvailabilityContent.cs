// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Parameters supplied to the Check Name Availability for Namespace and NotificationHubs. </summary>
    public partial class NotificationHubAvailabilityContent : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NotificationHubAvailabilityContent"/>. </summary>
        /// <param name="location"> The location. </param>
        public NotificationHubAvailabilityContent(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubAvailabilityContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        /// <param name="isAvailiable"> True if the name is available and can be used to create new Namespace/NotificationHub. Otherwise false. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationHubAvailabilityContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, NotificationHubSku sku, bool? isAvailiable, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            IsAvailiable = isAvailiable;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubAvailabilityContent"/> for deserialization. </summary>
        internal NotificationHubAvailabilityContent()
        {
        }

        /// <summary> The sku of the created namespace. </summary>
        public NotificationHubSku Sku { get; set; }
        /// <summary> True if the name is available and can be used to create new Namespace/NotificationHub. Otherwise false. </summary>
        public bool? IsAvailiable { get; set; }
    }
}
