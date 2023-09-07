// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Json-serialized array of User subscription quota response. </summary>
    internal partial class IotHubUserSubscriptionQuotaListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IotHubUserSubscriptionQuotaListResult"/>. </summary>
        internal IotHubUserSubscriptionQuotaListResult()
        {
            Value = new ChangeTrackingList<IotHubUserSubscriptionQuota>();
        }

        /// <summary> Initializes a new instance of <see cref="IotHubUserSubscriptionQuotaListResult"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotHubUserSubscriptionQuotaListResult(IReadOnlyList<IotHubUserSubscriptionQuota> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<IotHubUserSubscriptionQuota> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
