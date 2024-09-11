// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The InsightQueryItemPropertiesTableQueryQueriesDefinitionsItem. </summary>
    public partial class InsightQueryItemPropertiesTableQueryQueriesDefinitionsItem
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

        /// <summary> Initializes a new instance of <see cref="InsightQueryItemPropertiesTableQueryQueriesDefinitionsItem"/>. </summary>
        internal InsightQueryItemPropertiesTableQueryQueriesDefinitionsItem()
        {
            LinkColumnsDefinitions = new ChangeTrackingList<InsightQueryItemPropertiesTableQueryQueriesDefinitionsPropertiesItemsItem>();
        }

        /// <summary> Initializes a new instance of <see cref="InsightQueryItemPropertiesTableQueryQueriesDefinitionsItem"/>. </summary>
        /// <param name="filter"> Insight column header. </param>
        /// <param name="summarize"> Insight column header. </param>
        /// <param name="project"> Insight column header. </param>
        /// <param name="linkColumnsDefinitions"> Insight column header. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InsightQueryItemPropertiesTableQueryQueriesDefinitionsItem(string filter, string summarize, string project, IReadOnlyList<InsightQueryItemPropertiesTableQueryQueriesDefinitionsPropertiesItemsItem> linkColumnsDefinitions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Filter = filter;
            Summarize = summarize;
            Project = project;
            LinkColumnsDefinitions = linkColumnsDefinitions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Insight column header. </summary>
        [WirePath("filter")]
        public string Filter { get; }
        /// <summary> Insight column header. </summary>
        [WirePath("summarize")]
        public string Summarize { get; }
        /// <summary> Insight column header. </summary>
        [WirePath("project")]
        public string Project { get; }
        /// <summary> Insight column header. </summary>
        [WirePath("linkColumnsDefinitions")]
        public IReadOnlyList<InsightQueryItemPropertiesTableQueryQueriesDefinitionsPropertiesItemsItem> LinkColumnsDefinitions { get; }
    }
}
