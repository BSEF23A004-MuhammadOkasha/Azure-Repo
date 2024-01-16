// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Information protection policy. </summary>
    public partial class InformationProtectionPolicy : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="InformationProtectionPolicy"/>. </summary>
        public InformationProtectionPolicy()
        {
            Labels = new ChangeTrackingDictionary<string, SensitivityLabel>();
            InformationTypes = new ChangeTrackingDictionary<string, SecurityInformationTypeInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="InformationProtectionPolicy"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="lastModifiedUtc"> Describes the last UTC time the policy was modified. </param>
        /// <param name="version"> Describes the version of the policy. </param>
        /// <param name="labels"> Dictionary of sensitivity labels. </param>
        /// <param name="informationTypes"> The sensitivity information types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InformationProtectionPolicy(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? lastModifiedUtc, string version, IDictionary<string, SensitivityLabel> labels, IDictionary<string, SecurityInformationTypeInfo> informationTypes, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            LastModifiedUtc = lastModifiedUtc;
            Version = version;
            Labels = labels;
            InformationTypes = informationTypes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Describes the last UTC time the policy was modified. </summary>
        public DateTimeOffset? LastModifiedUtc { get; }
        /// <summary> Describes the version of the policy. </summary>
        public string Version { get; }
        /// <summary> Dictionary of sensitivity labels. </summary>
        public IDictionary<string, SensitivityLabel> Labels { get; }
        /// <summary> The sensitivity information types. </summary>
        public IDictionary<string, SecurityInformationTypeInfo> InformationTypes { get; }
    }
}
