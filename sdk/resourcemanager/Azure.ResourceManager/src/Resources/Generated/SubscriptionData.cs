// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the Subscription data model. </summary>
    public partial class SubscriptionData
    {
        /// <summary> Initializes a new instance of SubscriptionData. </summary>
        internal SubscriptionData()
        {
            ManagedByTenants = new ChangeTrackingList<ManagedByTenant>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of SubscriptionData. </summary>
        /// <param name="id"> The fully qualified ID for the subscription. For example, /subscriptions/00000000-0000-0000-0000-000000000000. </param>
        /// <param name="subscriptionId"> The subscription ID. </param>
        /// <param name="displayName"> The subscription display name. </param>
        /// <param name="tenantId"> The subscription tenant ID. </param>
        /// <param name="state"> The subscription state. Possible values are Enabled, Warned, PastDue, Disabled, and Deleted. </param>
        /// <param name="subscriptionPolicies"> The subscription policies. </param>
        /// <param name="authorizationSource"> The authorization source of the request. Valid values are one or more combinations of Legacy, RoleBased, Bypassed, Direct and Management. For example, &apos;Legacy, RoleBased&apos;. </param>
        /// <param name="managedByTenants"> An array containing the tenants managing the subscription. </param>
        /// <param name="tags"> The tags attached to the subscription. </param>
        internal SubscriptionData(string id, string subscriptionId, string displayName, string tenantId, SubscriptionState? state, SubscriptionPolicies subscriptionPolicies, string authorizationSource, IReadOnlyList<ManagedByTenant> managedByTenants, IReadOnlyDictionary<string, string> tags)
        {
            Id = id;
            SubscriptionId = subscriptionId;
            DisplayName = displayName;
            TenantId = tenantId;
            State = state;
            SubscriptionPolicies = subscriptionPolicies;
            AuthorizationSource = authorizationSource;
            ManagedByTenants = managedByTenants;
            Tags = tags;
        }

        /// <summary> The fully qualified ID for the subscription. For example, /subscriptions/00000000-0000-0000-0000-000000000000. </summary>
        public string Id { get; }
        /// <summary> The subscription ID. </summary>
        public string SubscriptionId { get; }
        /// <summary> The subscription display name. </summary>
        public string DisplayName { get; }
        /// <summary> The subscription tenant ID. </summary>
        public string TenantId { get; }
        /// <summary> The subscription state. Possible values are Enabled, Warned, PastDue, Disabled, and Deleted. </summary>
        public SubscriptionState? State { get; }
        /// <summary> The subscription policies. </summary>
        public SubscriptionPolicies SubscriptionPolicies { get; }
        /// <summary> The authorization source of the request. Valid values are one or more combinations of Legacy, RoleBased, Bypassed, Direct and Management. For example, &apos;Legacy, RoleBased&apos;. </summary>
        public string AuthorizationSource { get; }
        /// <summary> An array containing the tenants managing the subscription. </summary>
        public IReadOnlyList<ManagedByTenant> ManagedByTenants { get; }
        /// <summary> The tags attached to the subscription. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
