// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The artifact properties definition. </summary>
    public partial class ArtifactProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ArtifactProperties"/>. </summary>
        public ArtifactProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ArtifactProperties"/>. </summary>
        /// <param name="createdOn"> The artifact creation time. </param>
        /// <param name="changedOn"> The artifact changed time. </param>
        /// <param name="metadata"> Anything. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArtifactProperties(DateTimeOffset? createdOn, DateTimeOffset? changedOn, BinaryData metadata, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CreatedOn = createdOn;
            ChangedOn = changedOn;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The artifact creation time. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> The artifact changed time. </summary>
        public DateTimeOffset? ChangedOn { get; set; }
        /// <summary>
        /// Anything
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
        public BinaryData Metadata { get; set; }
    }
}
