// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing the IntegrationAccountMap data model.
    /// The integration account map.
    /// </summary>
    public partial class IntegrationAccountMapData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountMapData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="mapType"> The map type. </param>
        public IntegrationAccountMapData(AzureLocation location, IntegrationAccountMapType mapType) : base(location)
        {
            MapType = mapType;
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountMapData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="mapType"> The map type. </param>
        /// <param name="parametersSchema"> The parameters schema of integration account map. </param>
        /// <param name="createdOn"> The created time. </param>
        /// <param name="changedOn"> The changed time. </param>
        /// <param name="content"> The content. </param>
        /// <param name="contentType"> The content type. </param>
        /// <param name="contentLink"> The content link. </param>
        /// <param name="metadata"> The metadata. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationAccountMapData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IntegrationAccountMapType mapType, IntegrationAccountMapPropertiesParametersSchema parametersSchema, DateTimeOffset? createdOn, DateTimeOffset? changedOn, BinaryData content, ContentType? contentType, LogicContentLink contentLink, BinaryData metadata, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            MapType = mapType;
            ParametersSchema = parametersSchema;
            CreatedOn = createdOn;
            ChangedOn = changedOn;
            Content = content;
            ContentType = contentType;
            ContentLink = contentLink;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountMapData"/> for deserialization. </summary>
        internal IntegrationAccountMapData()
        {
        }

        /// <summary> The map type. </summary>
        public IntegrationAccountMapType MapType { get; set; }
        /// <summary> The parameters schema of integration account map. </summary>
        internal IntegrationAccountMapPropertiesParametersSchema ParametersSchema { get; set; }
        /// <summary> The reference name. </summary>
        public string ParametersSchemaRef
        {
            get => ParametersSchema is null ? default : ParametersSchema.Ref;
            set
            {
                if (ParametersSchema is null)
                    ParametersSchema = new IntegrationAccountMapPropertiesParametersSchema();
                ParametersSchema.Ref = value;
            }
        }

        /// <summary> The created time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The changed time. </summary>
        public DateTimeOffset? ChangedOn { get; }
        /// <summary>
        /// The content.
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
        public BinaryData Content { get; set; }
        /// <summary> The content type. </summary>
        public ContentType? ContentType { get; set; }
        /// <summary> The content link. </summary>
        public LogicContentLink ContentLink { get; }
        /// <summary>
        /// The metadata.
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
        public BinaryData Metadata { get; set; }
    }
}
