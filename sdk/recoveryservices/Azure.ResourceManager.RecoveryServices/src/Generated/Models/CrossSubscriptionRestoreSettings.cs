// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Settings for Cross Subscription Restore Settings. </summary>
    internal partial class CrossSubscriptionRestoreSettings
    {
        /// <summary> Initializes a new instance of CrossSubscriptionRestoreSettings. </summary>
        public CrossSubscriptionRestoreSettings()
        {
        }

        /// <summary> Initializes a new instance of CrossSubscriptionRestoreSettings. </summary>
        /// <param name="crossSubscriptionRestoreState"></param>
        internal CrossSubscriptionRestoreSettings(CrossSubscriptionRestoreState? crossSubscriptionRestoreState)
        {
            CrossSubscriptionRestoreState = crossSubscriptionRestoreState;
        }

        /// <summary> Gets or sets the cross subscription restore state. </summary>
        public CrossSubscriptionRestoreState? CrossSubscriptionRestoreState { get; set; }
    }
}
