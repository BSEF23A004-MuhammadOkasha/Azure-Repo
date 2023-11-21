// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> A collection of related endpoints from the same service for which the agent requires outbound access. </summary>
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
            Endpoints = new ChangeTrackingList<EndpointDependency>();
        }

        /// <summary> Initializes a new instance of <see cref="OutboundEnvironmentEndpoint"/>. </summary>
        /// <param name="category"> The type of service that the agent connects to. </param>
        /// <param name="endpoints"> The endpoints for this service for which the agent requires outbound access. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OutboundEnvironmentEndpoint(string category, IReadOnlyList<EndpointDependency> endpoints, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Category = category;
            Endpoints = endpoints;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of service that the agent connects to. </summary>
        public string Category { get; }
        /// <summary> The endpoints for this service for which the agent requires outbound access. </summary>
        public IReadOnlyList<EndpointDependency> Endpoints { get; }
    }
}
