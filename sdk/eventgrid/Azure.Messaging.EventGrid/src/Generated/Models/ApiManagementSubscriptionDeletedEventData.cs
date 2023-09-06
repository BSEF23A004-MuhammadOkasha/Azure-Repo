// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.ApiManagement.SubscriptionDeleted event. </summary>
    public partial class ApiManagementSubscriptionDeletedEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementSubscriptionDeletedEventData"/>. </summary>
        internal ApiManagementSubscriptionDeletedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementSubscriptionDeletedEventData"/>. </summary>
        /// <param name="resourceUri"> The fully qualified ID of the resource that the compliance state change is for, including the resource name and resource type. Uses the format, `/subscriptions/&lt;SubscriptionID&gt;/resourceGroups/&lt;ResourceGroup&gt;/Microsoft.ApiManagement/service/&lt;ServiceName&gt;/&lt;ResourceType&gt;/&lt;ResourceName&gt;`. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementSubscriptionDeletedEventData(string resourceUri, Dictionary<string, BinaryData> rawData)
        {
            ResourceUri = resourceUri;
            _rawData = rawData;
        }

        /// <summary> The fully qualified ID of the resource that the compliance state change is for, including the resource name and resource type. Uses the format, `/subscriptions/&lt;SubscriptionID&gt;/resourceGroups/&lt;ResourceGroup&gt;/Microsoft.ApiManagement/service/&lt;ServiceName&gt;/&lt;ResourceType&gt;/&lt;ResourceName&gt;`. </summary>
        public string ResourceUri { get; }
    }
}
