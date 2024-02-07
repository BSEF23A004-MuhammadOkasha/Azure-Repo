// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Oracle.Models
{
    /// <summary> PrivateIpAddress resource properties. </summary>
    public partial class PrivateIPAddressProperties
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

        /// <summary> Initializes a new instance of <see cref="PrivateIPAddressProperties"/>. </summary>
        /// <param name="displayName"> PrivateIpAddresses displayName. </param>
        /// <param name="hostnameLabel"> PrivateIpAddresses hostnameLabel. </param>
        /// <param name="ocid"> PrivateIpAddresses Id. </param>
        /// <param name="ipAddress"> PrivateIpAddresses ipAddress. </param>
        /// <param name="subnetId"> PrivateIpAddresses subnetId. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="displayName"/>, <paramref name="hostnameLabel"/>, <paramref name="ocid"/>, <paramref name="ipAddress"/> or <paramref name="subnetId"/> is null. </exception>
        internal PrivateIPAddressProperties(string displayName, string hostnameLabel, string ocid, string ipAddress, string subnetId)
        {
            Argument.AssertNotNull(displayName, nameof(displayName));
            Argument.AssertNotNull(hostnameLabel, nameof(hostnameLabel));
            Argument.AssertNotNull(ocid, nameof(ocid));
            Argument.AssertNotNull(ipAddress, nameof(ipAddress));
            Argument.AssertNotNull(subnetId, nameof(subnetId));

            DisplayName = displayName;
            HostnameLabel = hostnameLabel;
            Ocid = ocid;
            IPAddress = ipAddress;
            SubnetId = subnetId;
        }

        /// <summary> Initializes a new instance of <see cref="PrivateIPAddressProperties"/>. </summary>
        /// <param name="displayName"> PrivateIpAddresses displayName. </param>
        /// <param name="hostnameLabel"> PrivateIpAddresses hostnameLabel. </param>
        /// <param name="ocid"> PrivateIpAddresses Id. </param>
        /// <param name="ipAddress"> PrivateIpAddresses ipAddress. </param>
        /// <param name="subnetId"> PrivateIpAddresses subnetId. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateIPAddressProperties(string displayName, string hostnameLabel, string ocid, string ipAddress, string subnetId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisplayName = displayName;
            HostnameLabel = hostnameLabel;
            Ocid = ocid;
            IPAddress = ipAddress;
            SubnetId = subnetId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PrivateIPAddressProperties"/> for deserialization. </summary>
        internal PrivateIPAddressProperties()
        {
        }

        /// <summary> PrivateIpAddresses displayName. </summary>
        public string DisplayName { get; }
        /// <summary> PrivateIpAddresses hostnameLabel. </summary>
        public string HostnameLabel { get; }
        /// <summary> PrivateIpAddresses Id. </summary>
        public string Ocid { get; }
        /// <summary> PrivateIpAddresses ipAddress. </summary>
        public string IPAddress { get; }
        /// <summary> PrivateIpAddresses subnetId. </summary>
        public string SubnetId { get; }
    }
}
