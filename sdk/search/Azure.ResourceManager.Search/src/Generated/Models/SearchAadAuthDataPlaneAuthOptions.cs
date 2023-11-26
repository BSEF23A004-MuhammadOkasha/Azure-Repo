// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Defines the options for how the data plane API of a Search service authenticates requests. This cannot be set if 'disableLocalAuth' is set to true. </summary>
    public partial class SearchAadAuthDataPlaneAuthOptions
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

        /// <summary> Initializes a new instance of <see cref="SearchAadAuthDataPlaneAuthOptions"/>. </summary>
        public SearchAadAuthDataPlaneAuthOptions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SearchAadAuthDataPlaneAuthOptions"/>. </summary>
        /// <param name="apiKeyOnly"> Indicates that only the API key needs to be used for authentication. </param>
        /// <param name="aadOrApiKey"> Indicates that either the API key or an access token from Azure Active Directory can be used for authentication. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchAadAuthDataPlaneAuthOptions(BinaryData apiKeyOnly, DataPlaneAadOrApiKeyAuthOption aadOrApiKey, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ApiKeyOnly = apiKeyOnly;
            AadOrApiKey = aadOrApiKey;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Indicates that only the API key needs to be used for authentication.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData ApiKeyOnly { get; set; }
        /// <summary> Indicates that either the API key or an access token from Azure Active Directory can be used for authentication. </summary>
        internal DataPlaneAadOrApiKeyAuthOption AadOrApiKey { get; set; }
        /// <summary> Describes what response the data plane API of a Search service would send for requests that failed authentication. </summary>
        public SearchAadAuthFailureMode? AadAuthFailureMode
        {
            get => AadOrApiKey is null ? default : AadOrApiKey.AadAuthFailureMode;
            set
            {
                if (AadOrApiKey is null)
                    AadOrApiKey = new DataPlaneAadOrApiKeyAuthOption();
                AadOrApiKey.AadAuthFailureMode = value;
            }
        }
    }
}
