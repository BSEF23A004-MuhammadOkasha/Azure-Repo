// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> Image reference information. </summary>
    public partial class DevCenterImageReference
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

        /// <summary> Initializes a new instance of <see cref="DevCenterImageReference"/>. </summary>
        public DevCenterImageReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterImageReference"/>. </summary>
        /// <param name="id"> Image ID, or Image version ID. When Image ID is provided, its latest version will be used. </param>
        /// <param name="exactVersion"> The actual version of the image after use. When id references a gallery image latest version, this will indicate the actual version in use. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevCenterImageReference(ResourceIdentifier id, string exactVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ExactVersion = exactVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Image ID, or Image version ID. When Image ID is provided, its latest version will be used. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> The actual version of the image after use. When id references a gallery image latest version, this will indicate the actual version in use. </summary>
        public string ExactVersion { get; }
    }
}
