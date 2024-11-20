// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sku.Models
{
    /// <summary> Describes an available Compute SKU Restriction Information. </summary>
    public partial class SkuResourceSkuRestrictionInfo
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

        /// <summary> Initializes a new instance of <see cref="SkuResourceSkuRestrictionInfo"/>. </summary>
        internal SkuResourceSkuRestrictionInfo()
        {
            Locations = new ChangeTrackingList<AzureLocation>();
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SkuResourceSkuRestrictionInfo"/>. </summary>
        /// <param name="locations"> Locations where the SKU is restricted. </param>
        /// <param name="zones"> List of availability zones where the SKU is restricted. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SkuResourceSkuRestrictionInfo(IReadOnlyList<AzureLocation> locations, IReadOnlyList<string> zones, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Locations = locations;
            Zones = zones;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Locations where the SKU is restricted. </summary>
        public IReadOnlyList<AzureLocation> Locations { get; }
        /// <summary> List of availability zones where the SKU is restricted. </summary>
        public IReadOnlyList<string> Zones { get; }
    }
}
