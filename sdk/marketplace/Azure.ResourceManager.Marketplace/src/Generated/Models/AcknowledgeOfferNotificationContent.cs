// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Notification update request payload. </summary>
    public partial class AcknowledgeOfferNotificationContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AcknowledgeOfferNotificationContent"/>. </summary>
        public AcknowledgeOfferNotificationContent()
        {
            AddPlans = new ChangeTrackingList<string>();
            RemovePlans = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AcknowledgeOfferNotificationContent"/>. </summary>
        /// <param name="isAcknowledgeActionFlagEnabled"> Gets or sets a value indicating whether acknowledge action flag is enabled. </param>
        /// <param name="isDismissActionFlagEnabled"> Gets or sets a value indicating whether dismiss action flag is enabled. </param>
        /// <param name="isRemoveOfferActionFlagEnabled"> Gets or sets a value indicating whether remove offer action flag is enabled. </param>
        /// <param name="addPlans"> Gets or sets added plans. </param>
        /// <param name="removePlans"> Gets or sets remove plans. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AcknowledgeOfferNotificationContent(bool? isAcknowledgeActionFlagEnabled, bool? isDismissActionFlagEnabled, bool? isRemoveOfferActionFlagEnabled, IList<string> addPlans, IList<string> removePlans, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsAcknowledgeActionFlagEnabled = isAcknowledgeActionFlagEnabled;
            IsDismissActionFlagEnabled = isDismissActionFlagEnabled;
            IsRemoveOfferActionFlagEnabled = isRemoveOfferActionFlagEnabled;
            AddPlans = addPlans;
            RemovePlans = removePlans;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets a value indicating whether acknowledge action flag is enabled. </summary>
        public bool? IsAcknowledgeActionFlagEnabled { get; set; }
        /// <summary> Gets or sets a value indicating whether dismiss action flag is enabled. </summary>
        public bool? IsDismissActionFlagEnabled { get; set; }
        /// <summary> Gets or sets a value indicating whether remove offer action flag is enabled. </summary>
        public bool? IsRemoveOfferActionFlagEnabled { get; set; }
        /// <summary> Gets or sets added plans. </summary>
        public IList<string> AddPlans { get; }
        /// <summary> Gets or sets remove plans. </summary>
        public IList<string> RemovePlans { get; }
    }
}
