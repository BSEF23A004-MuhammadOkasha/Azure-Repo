// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> The mapping content. </summary>
    public partial class HealthcareApisIotMappingProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HealthcareApisIotMappingProperties"/>. </summary>
        public HealthcareApisIotMappingProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareApisIotMappingProperties"/>. </summary>
        /// <param name="content"> The mapping. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthcareApisIotMappingProperties(BinaryData content, Dictionary<string, BinaryData> rawData)
        {
            Content = content;
            _rawData = rawData;
        }

        /// <summary>
        /// The mapping.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Content { get; set; }
    }
}
