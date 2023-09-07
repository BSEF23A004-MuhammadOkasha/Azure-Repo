// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The Kusto SKU description of given resource type. </summary>
    public partial class KustoSkuDescription
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KustoSkuDescription"/>. </summary>
        internal KustoSkuDescription()
        {
            Locations = new ChangeTrackingList<AzureLocation>();
            LocationInfo = new ChangeTrackingList<KustoSkuLocationInfoItem>();
            Restrictions = new ChangeTrackingList<BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="KustoSkuDescription"/>. </summary>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="name"> The name of the SKU. </param>
        /// <param name="tier"> The tier of the SKU. </param>
        /// <param name="locations"> The set of locations that the SKU is available. </param>
        /// <param name="locationInfo"> Locations and zones. </param>
        /// <param name="restrictions"> The restrictions because of which SKU cannot be used. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoSkuDescription(string resourceType, string name, string tier, IReadOnlyList<AzureLocation> locations, IReadOnlyList<KustoSkuLocationInfoItem> locationInfo, IReadOnlyList<BinaryData> restrictions, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceType = resourceType;
            Name = name;
            Tier = tier;
            Locations = locations;
            LocationInfo = locationInfo;
            Restrictions = restrictions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource type. </summary>
        public string ResourceType { get; }
        /// <summary> The name of the SKU. </summary>
        public string Name { get; }
        /// <summary> The tier of the SKU. </summary>
        public string Tier { get; }
        /// <summary> The set of locations that the SKU is available. </summary>
        public IReadOnlyList<AzureLocation> Locations { get; }
        /// <summary> Locations and zones. </summary>
        public IReadOnlyList<KustoSkuLocationInfoItem> LocationInfo { get; }
        /// <summary>
        /// The restrictions because of which SKU cannot be used
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IReadOnlyList<BinaryData> Restrictions { get; }
    }
}
