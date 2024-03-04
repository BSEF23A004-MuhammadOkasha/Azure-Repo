// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Endpoints accessed for a common purpose that the App Service Environment requires outbound network access to. </summary>
    public partial class OutboundEnvironmentEndpoint
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OutboundEnvironmentEndpoint"/>. </summary>
        internal OutboundEnvironmentEndpoint()
        {
            Endpoints = new ChangeTrackingList<AppServiceEndpointDependency>();
        }

        /// <summary> Initializes a new instance of <see cref="OutboundEnvironmentEndpoint"/>. </summary>
        /// <param name="category"> The type of service accessed by the App Service Environment, e.g., Azure Storage, Azure SQL Database, and Azure Active Directory. </param>
        /// <param name="endpoints"> The endpoints that the App Service Environment reaches the service at. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OutboundEnvironmentEndpoint(string category, IReadOnlyList<AppServiceEndpointDependency> endpoints, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Category = category;
            Endpoints = endpoints;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of service accessed by the App Service Environment, e.g., Azure Storage, Azure SQL Database, and Azure Active Directory. </summary>
        public string Category { get; }
        /// <summary> The endpoints that the App Service Environment reaches the service at. </summary>
        public IReadOnlyList<AppServiceEndpointDependency> Endpoints { get; }
    }
}
