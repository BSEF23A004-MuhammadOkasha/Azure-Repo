// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Pipeline that needs to be triggered with the given parameters. </summary>
    public partial class TriggerPipelineReference
    {
        /// <summary> Initializes a new instance of TriggerPipelineReference. </summary>
        public TriggerPipelineReference()
        {
            Parameters = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of TriggerPipelineReference. </summary>
        /// <param name="pipelineReference"> Pipeline reference. </param>
        /// <param name="parameters"> Pipeline parameters. </param>
        internal TriggerPipelineReference(DataFactoryPipelineReference pipelineReference, IDictionary<string, BinaryData> parameters)
        {
            PipelineReference = pipelineReference;
            Parameters = parameters;
        }

        /// <summary> Pipeline reference. </summary>
        public DataFactoryPipelineReference PipelineReference { get; set; }
        /// <summary>
        /// Pipeline parameters.
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
        public IDictionary<string, BinaryData> Parameters { get; }
    }
}
