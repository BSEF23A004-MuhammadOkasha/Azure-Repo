// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The SubscriptionLifecycleNotificationSpecifications. </summary>
    public partial class SubscriptionLifecycleNotificationSpecifications
    {
        /// <summary> Initializes a new instance of SubscriptionLifecycleNotificationSpecifications. </summary>
        public SubscriptionLifecycleNotificationSpecifications()
        {
            SubscriptionStateOverrideActions = new ChangeTrackingList<SubscriptionStateOverrideAction>();
        }

        /// <summary> Initializes a new instance of SubscriptionLifecycleNotificationSpecifications. </summary>
        /// <param name="subscriptionStateOverrideActions"></param>
        /// <param name="softDeleteTtl"></param>
        internal SubscriptionLifecycleNotificationSpecifications(IList<SubscriptionStateOverrideAction> subscriptionStateOverrideActions, TimeSpan? softDeleteTtl)
        {
            SubscriptionStateOverrideActions = subscriptionStateOverrideActions;
            SoftDeleteTtl = softDeleteTtl;
        }

        /// <summary> Gets the subscription state override actions. </summary>
        public IList<SubscriptionStateOverrideAction> SubscriptionStateOverrideActions { get; }
        /// <summary> Gets or sets the soft delete ttl. </summary>
        public TimeSpan? SoftDeleteTtl { get; set; }
    }
}
