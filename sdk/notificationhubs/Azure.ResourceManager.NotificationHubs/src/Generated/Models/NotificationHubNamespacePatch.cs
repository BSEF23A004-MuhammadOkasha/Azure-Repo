// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Parameters supplied to the Patch Namespace operation. </summary>
    public partial class NotificationHubNamespacePatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NotificationHubNamespacePatch"/>. </summary>
        public NotificationHubNamespacePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubNamespacePatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationHubNamespacePatch(IDictionary<string, string> tags, NotificationHubSku sku, Dictionary<string, BinaryData> rawData)
        {
            Tags = tags;
            Sku = sku;
            _rawData = rawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The sku of the created namespace. </summary>
        public NotificationHubSku Sku { get; set; }
    }
}
