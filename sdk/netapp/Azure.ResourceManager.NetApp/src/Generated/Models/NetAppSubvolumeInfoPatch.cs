// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary>
    /// Subvolume Patch Request properties
    /// Serialized Name: SubvolumePatchRequest
    /// </summary>
    public partial class NetAppSubvolumeInfoPatch
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

        /// <summary> Initializes a new instance of <see cref="NetAppSubvolumeInfoPatch"/>. </summary>
        public NetAppSubvolumeInfoPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetAppSubvolumeInfoPatch"/>. </summary>
        /// <param name="size">
        /// Truncate subvolume to the provided size in bytes
        /// Serialized Name: SubvolumePatchRequest.properties.size
        /// </param>
        /// <param name="path">
        /// path to the subvolume
        /// Serialized Name: SubvolumePatchRequest.properties.path
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppSubvolumeInfoPatch(long? size, string path, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Size = size;
            Path = path;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Truncate subvolume to the provided size in bytes
        /// Serialized Name: SubvolumePatchRequest.properties.size
        /// </summary>
        public long? Size { get; set; }
        /// <summary>
        /// path to the subvolume
        /// Serialized Name: SubvolumePatchRequest.properties.path
        /// </summary>
        public string Path { get; set; }
    }
}
