// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> List of Subscription Quota Items. </summary>
    internal partial class SubscriptionQuotaItemList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SubscriptionQuotaItemList"/>. </summary>
        internal SubscriptionQuotaItemList()
        {
            Value = new ChangeTrackingList<NetAppSubscriptionQuotaItem>();
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionQuotaItemList"/>. </summary>
        /// <param name="value"> A list of SubscriptionQuotaItems. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SubscriptionQuotaItemList(IReadOnlyList<NetAppSubscriptionQuotaItem> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A list of SubscriptionQuotaItems. </summary>
        public IReadOnlyList<NetAppSubscriptionQuotaItem> Value { get; }
    }
}
