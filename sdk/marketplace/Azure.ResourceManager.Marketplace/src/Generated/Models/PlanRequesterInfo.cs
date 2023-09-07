// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> user request details. </summary>
    public partial class PlanRequesterInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PlanRequesterInfo"/>. </summary>
        internal PlanRequesterInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PlanRequesterInfo"/>. </summary>
        /// <param name="user"> Gets user id. </param>
        /// <param name="date"> Gets request date. </param>
        /// <param name="justification"> Gets justification. </param>
        /// <param name="subscriptionId"> Gets the subscription id that the user is requesting to add the plan to. </param>
        /// <param name="subscriptionName"> Gets the subscription name that the user is requesting to add the plan to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PlanRequesterInfo(string user, string date, string justification, string subscriptionId, string subscriptionName, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            User = user;
            Date = date;
            Justification = justification;
            SubscriptionId = subscriptionId;
            SubscriptionName = subscriptionName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets user id. </summary>
        public string User { get; }
        /// <summary> Gets request date. </summary>
        public string Date { get; }
        /// <summary> Gets justification. </summary>
        public string Justification { get; }
        /// <summary> Gets the subscription id that the user is requesting to add the plan to. </summary>
        public string SubscriptionId { get; }
        /// <summary> Gets the subscription name that the user is requesting to add the plan to. </summary>
        public string SubscriptionName { get; }
    }
}
