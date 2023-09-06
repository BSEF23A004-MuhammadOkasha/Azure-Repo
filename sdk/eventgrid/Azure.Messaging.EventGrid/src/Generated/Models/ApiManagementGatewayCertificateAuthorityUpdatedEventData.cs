// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.ApiManagement.GatewayCertificateAuthorityUpdated event. </summary>
    public partial class ApiManagementGatewayCertificateAuthorityUpdatedEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementGatewayCertificateAuthorityUpdatedEventData"/>. </summary>
        internal ApiManagementGatewayCertificateAuthorityUpdatedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementGatewayCertificateAuthorityUpdatedEventData"/>. </summary>
        /// <param name="resourceUri"> The fully qualified ID of the resource that the compliance state change is for, including the resource name and resource type. Uses the format, `/subscriptions/&lt;SubscriptionID&gt;/resourceGroups/&lt;ResourceGroup&gt;/Microsoft.ApiManagement/service/&lt;ServiceName&gt;/gateways/&lt;GatewayName&gt;/certificateAuthorities/&lt;ResourceName&gt;`. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementGatewayCertificateAuthorityUpdatedEventData(string resourceUri, Dictionary<string, BinaryData> rawData)
        {
            ResourceUri = resourceUri;
            _rawData = rawData;
        }

        /// <summary> The fully qualified ID of the resource that the compliance state change is for, including the resource name and resource type. Uses the format, `/subscriptions/&lt;SubscriptionID&gt;/resourceGroups/&lt;ResourceGroup&gt;/Microsoft.ApiManagement/service/&lt;ServiceName&gt;/gateways/&lt;GatewayName&gt;/certificateAuthorities/&lt;ResourceName&gt;`. </summary>
        public string ResourceUri { get; }
    }
}
