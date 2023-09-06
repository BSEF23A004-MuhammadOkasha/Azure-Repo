// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Resources.ResourceActionCancel event. This is raised when a resource action operation is canceled. </summary>
    public partial class ResourceActionCancelEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceActionCancelEventData"/>. </summary>
        internal ResourceActionCancelEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceActionCancelEventData"/>. </summary>
        /// <param name="tenantId"> The tenant ID of the resource. </param>
        /// <param name="subscriptionId"> The subscription ID of the resource. </param>
        /// <param name="resourceGroup"> The resource group of the resource. </param>
        /// <param name="resourceProvider"> The resource provider performing the operation. </param>
        /// <param name="resourceUri"> The URI of the resource in the operation. </param>
        /// <param name="operationName"> The operation that was performed. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="authorizationJson"> The requested authorization for the operation. </param>
        /// <param name="claimsJson"> The properties of the claims. </param>
        /// <param name="correlationId"> An operation ID used for troubleshooting. </param>
        /// <param name="httpRequestJson"> The details of the operation. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceActionCancelEventData(string tenantId, string subscriptionId, string resourceGroup, string resourceProvider, string resourceUri, string operationName, string status, JsonElement authorizationJson, JsonElement claimsJson, string correlationId, JsonElement httpRequestJson, Dictionary<string, BinaryData> rawData)
        {
            TenantId = tenantId;
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
            ResourceProvider = resourceProvider;
            ResourceUri = resourceUri;
            OperationName = operationName;
            Status = status;
            AuthorizationJson = authorizationJson;
            ClaimsJson = claimsJson;
            CorrelationId = correlationId;
            HttpRequestJson = httpRequestJson;
            _rawData = rawData;
        }

        /// <summary> The tenant ID of the resource. </summary>
        public string TenantId { get; }
        /// <summary> The subscription ID of the resource. </summary>
        public string SubscriptionId { get; }
        /// <summary> The resource group of the resource. </summary>
        public string ResourceGroup { get; }
        /// <summary> The resource provider performing the operation. </summary>
        public string ResourceProvider { get; }
        /// <summary> The URI of the resource in the operation. </summary>
        public string ResourceUri { get; }
        /// <summary> The operation that was performed. </summary>
        public string OperationName { get; }
        /// <summary> The status of the operation. </summary>
        public string Status { get; }
        /// <summary> An operation ID used for troubleshooting. </summary>
        public string CorrelationId { get; }
    }
}
