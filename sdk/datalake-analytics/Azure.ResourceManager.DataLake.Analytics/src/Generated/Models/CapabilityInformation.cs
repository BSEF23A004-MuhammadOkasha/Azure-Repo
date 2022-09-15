// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataLake.Analytics.Models
{
    /// <summary> Subscription-level properties and limits for Data Lake Analytics. </summary>
    public partial class CapabilityInformation
    {
        /// <summary> Initializes a new instance of CapabilityInformation. </summary>
        internal CapabilityInformation()
        {
        }

        /// <summary> Initializes a new instance of CapabilityInformation. </summary>
        /// <param name="subscriptionId"> The subscription credentials that uniquely identifies the subscription. </param>
        /// <param name="state"> The subscription state. </param>
        /// <param name="maxAccountCount"> The maximum supported number of accounts under this subscription. </param>
        /// <param name="accountCount"> The current number of accounts under this subscription. </param>
        /// <param name="migrationState"> The Boolean value of true or false to indicate the maintenance state. </param>
        internal CapabilityInformation(Guid? subscriptionId, SubscriptionState? state, int? maxAccountCount, int? accountCount, bool? migrationState)
        {
            SubscriptionId = subscriptionId;
            State = state;
            MaxAccountCount = maxAccountCount;
            AccountCount = accountCount;
            MigrationState = migrationState;
        }

        /// <summary> The subscription credentials that uniquely identifies the subscription. </summary>
        public Guid? SubscriptionId { get; }
        /// <summary> The subscription state. </summary>
        public SubscriptionState? State { get; }
        /// <summary> The maximum supported number of accounts under this subscription. </summary>
        public int? MaxAccountCount { get; }
        /// <summary> The current number of accounts under this subscription. </summary>
        public int? AccountCount { get; }
        /// <summary> The Boolean value of true or false to indicate the maintenance state. </summary>
        public bool? MigrationState { get; }
    }
}
