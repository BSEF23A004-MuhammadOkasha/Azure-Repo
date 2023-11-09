// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Information regarding Subscription Quota Item. </summary>
    public partial class NetAppSubscriptionQuotaItem : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetAppSubscriptionQuotaItem"/>. </summary>
        public NetAppSubscriptionQuotaItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetAppSubscriptionQuotaItem"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="current"> The current quota value. </param>
        /// <param name="default"> The default quota value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppSubscriptionQuotaItem(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? current, int? @default, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Current = current;
            Default = @default;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The current quota value. </summary>
        public int? Current { get; }
        /// <summary> The default quota value. </summary>
        public int? Default { get; }
    }
}
