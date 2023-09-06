// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The identity information with the event subscription. </summary>
    public partial class EventSubscriptionIdentity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EventSubscriptionIdentity"/>. </summary>
        public EventSubscriptionIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventSubscriptionIdentity"/>. </summary>
        /// <param name="identityType"> The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user-assigned identities. The type 'None' will remove any identity. </param>
        /// <param name="userAssignedIdentity"> The user identity associated with the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EventSubscriptionIdentity(EventSubscriptionIdentityType? identityType, string userAssignedIdentity, Dictionary<string, BinaryData> rawData)
        {
            IdentityType = identityType;
            UserAssignedIdentity = userAssignedIdentity;
            _rawData = rawData;
        }

        /// <summary> The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user-assigned identities. The type 'None' will remove any identity. </summary>
        public EventSubscriptionIdentityType? IdentityType { get; set; }
        /// <summary> The user identity associated with the resource. </summary>
        public string UserAssignedIdentity { get; set; }
    }
}
