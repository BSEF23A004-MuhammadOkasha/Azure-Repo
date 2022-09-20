// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes how data from an input is serialized or how data is serialized when written to an output in Parquet format. </summary>
    public partial class ParquetFormatSerialization : StreamAnalyticsDataSerialization
    {
        /// <summary> Initializes a new instance of ParquetFormatSerialization. </summary>
        public ParquetFormatSerialization()
        {
            EventSerializationType = EventSerializationType.Parquet;
        }

        /// <summary> Initializes a new instance of ParquetFormatSerialization. </summary>
        /// <param name="eventSerializationType"> Indicates the type of serialization that the input or output uses. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="properties"> The properties that are associated with the Parquet serialization type. Required on PUT (CreateOrReplace) requests. </param>
        internal ParquetFormatSerialization(EventSerializationType eventSerializationType, BinaryData properties) : base(eventSerializationType)
        {
            Properties = properties;
            EventSerializationType = eventSerializationType;
        }

        /// <summary>
        /// The properties that are associated with the Parquet serialization type. Required on PUT (CreateOrReplace) requests.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Properties { get; set; }
    }
}
