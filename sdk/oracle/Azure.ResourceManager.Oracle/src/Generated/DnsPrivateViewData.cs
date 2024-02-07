// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Oracle.Models;

namespace Azure.ResourceManager.Oracle
{
    /// <summary>
    /// A class representing the DnsPrivateView data model.
    /// DnsPrivateView resource definition
    /// </summary>
    public partial class DnsPrivateViewData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="DnsPrivateViewData"/>. </summary>
        public DnsPrivateViewData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DnsPrivateViewData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="ocid"> The OCID of the view. </param>
        /// <param name="displayName"> The display name of the view resource. </param>
        /// <param name="isProtected"> A Boolean flag indicating whether or not parts of the resource are unable to be explicitly managed. </param>
        /// <param name="provisioningState"> Views lifecycleState. </param>
        /// <param name="self"> The canonical absolute URL of the resource. </param>
        /// <param name="timeCreated"> views timeCreated. </param>
        /// <param name="timeUpdated"> views timeCreated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DnsPrivateViewData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string ocid, string displayName, bool? isProtected, DnsPrivateViewsProvisioningState? provisioningState, string self, DateTimeOffset? timeCreated, DateTimeOffset? timeUpdated, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Ocid = ocid;
            DisplayName = displayName;
            IsProtected = isProtected;
            ProvisioningState = provisioningState;
            Self = self;
            TimeCreated = timeCreated;
            TimeUpdated = timeUpdated;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The OCID of the view. </summary>
        public string Ocid { get; }
        /// <summary> The display name of the view resource. </summary>
        public string DisplayName { get; }
        /// <summary> A Boolean flag indicating whether or not parts of the resource are unable to be explicitly managed. </summary>
        public bool? IsProtected { get; }
        /// <summary> Views lifecycleState. </summary>
        public DnsPrivateViewsProvisioningState? ProvisioningState { get; }
        /// <summary> The canonical absolute URL of the resource. </summary>
        public string Self { get; }
        /// <summary> views timeCreated. </summary>
        public DateTimeOffset? TimeCreated { get; }
        /// <summary> views timeCreated. </summary>
        public DateTimeOffset? TimeUpdated { get; }
    }
}
