// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> Private link service connection details. </summary>
    public partial class PrivateLinkServiceConnection
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

        /// <summary> Initializes a new instance of <see cref="PrivateLinkServiceConnection"/>. </summary>
        public PrivateLinkServiceConnection()
        {
            GroupIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateLinkServiceConnection"/>. </summary>
        /// <param name="name"> Private link service connection name. </param>
        /// <param name="groupIds"> List of group IDs. </param>
        /// <param name="requestMessage"> Request message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateLinkServiceConnection(string name, IList<string> groupIds, string requestMessage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            GroupIds = groupIds;
            RequestMessage = requestMessage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Private link service connection name. </summary>
        public string Name { get; set; }
        /// <summary> List of group IDs. </summary>
        public IList<string> GroupIds { get; }
        /// <summary> Request message. </summary>
        public string RequestMessage { get; set; }
    }
}
