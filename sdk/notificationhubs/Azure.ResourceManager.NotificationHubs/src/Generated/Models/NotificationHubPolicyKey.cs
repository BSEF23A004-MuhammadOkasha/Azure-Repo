// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Namespace/NotificationHub Regenerate Keys. </summary>
    public partial class NotificationHubPolicyKey
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NotificationHubPolicyKey"/>. </summary>
        public NotificationHubPolicyKey()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubPolicyKey"/>. </summary>
        /// <param name="policyKey"> Name of the key that has to be regenerated for the Namespace/Notification Hub Authorization Rule. The value can be Primary Key/Secondary Key. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationHubPolicyKey(string policyKey, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PolicyKey = policyKey;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the key that has to be regenerated for the Namespace/Notification Hub Authorization Rule. The value can be Primary Key/Secondary Key. </summary>
        public string PolicyKey { get; set; }
    }
}
