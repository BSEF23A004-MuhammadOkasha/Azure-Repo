// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.OperationalInsights;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The related metadata items for the function. </summary>
    public partial class LogAnalyticsQueryRelatedMetadata
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

        /// <summary> Initializes a new instance of <see cref="LogAnalyticsQueryRelatedMetadata"/>. </summary>
        public LogAnalyticsQueryRelatedMetadata()
        {
            Categories = new ChangeTrackingList<string>();
            ResourceTypes = new ChangeTrackingList<string>();
            Solutions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="LogAnalyticsQueryRelatedMetadata"/>. </summary>
        /// <param name="categories"> The related categories for the function. </param>
        /// <param name="resourceTypes"> The related resource types for the function. </param>
        /// <param name="solutions"> The related Log Analytics solutions for the function. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LogAnalyticsQueryRelatedMetadata(IList<string> categories, IList<string> resourceTypes, IList<string> solutions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Categories = categories;
            ResourceTypes = resourceTypes;
            Solutions = solutions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The related categories for the function. </summary>
        [WirePath("categories")]
        public IList<string> Categories { get; }
        /// <summary> The related resource types for the function. </summary>
        [WirePath("resourceTypes")]
        public IList<string> ResourceTypes { get; }
        /// <summary> The related Log Analytics solutions for the function. </summary>
        [WirePath("solutions")]
        public IList<string> Solutions { get; }
    }
}
