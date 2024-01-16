// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Result of the request to list networkManagerEffectiveConnectivityConfiguration. It contains a list of groups and a skiptoken to get the next set of results. </summary>
    internal partial class NetworkManagerEffectiveConnectivityConfigurationListResult
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

        /// <summary> Initializes a new instance of <see cref="NetworkManagerEffectiveConnectivityConfigurationListResult"/>. </summary>
        internal NetworkManagerEffectiveConnectivityConfigurationListResult()
        {
            Value = new ChangeTrackingList<EffectiveConnectivityConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkManagerEffectiveConnectivityConfigurationListResult"/>. </summary>
        /// <param name="value"> Gets a page of NetworkManagerEffectiveConnectivityConfiguration. </param>
        /// <param name="skipToken"> When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkManagerEffectiveConnectivityConfigurationListResult(IReadOnlyList<EffectiveConnectivityConfiguration> value, string skipToken, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            SkipToken = skipToken;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets a page of NetworkManagerEffectiveConnectivityConfiguration. </summary>
        public IReadOnlyList<EffectiveConnectivityConfiguration> Value { get; }
        /// <summary> When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data. </summary>
        public string SkipToken { get; }
    }
}
