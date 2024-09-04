// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> Information about the VM. </summary>
    public partial class GuestConfigurationVmInfo
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

        /// <summary> Initializes a new instance of <see cref="GuestConfigurationVmInfo"/>. </summary>
        public GuestConfigurationVmInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GuestConfigurationVmInfo"/>. </summary>
        /// <param name="id"> Azure resource Id of the VM. </param>
        /// <param name="uuid"> UUID(Universally Unique Identifier) of the VM. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GuestConfigurationVmInfo(ResourceIdentifier id, Guid? uuid, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Uuid = uuid;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Azure resource Id of the VM. </summary>
        [WirePath("id")]
        public ResourceIdentifier Id { get; }
        /// <summary> UUID(Universally Unique Identifier) of the VM. </summary>
        [WirePath("uuid")]
        public Guid? Uuid { get; }
    }
}
