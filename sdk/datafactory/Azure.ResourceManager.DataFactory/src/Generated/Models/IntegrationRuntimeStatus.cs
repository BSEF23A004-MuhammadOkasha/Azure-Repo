// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// Integration runtime status.
    /// Please note <see cref="IntegrationRuntimeStatus"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ManagedIntegrationRuntimeStatus"/> and <see cref="SelfHostedIntegrationRuntimeStatus"/>.
    /// </summary>
    public partial class IntegrationRuntimeStatus
    {
        /// <summary> Initializes a new instance of IntegrationRuntimeStatus. </summary>
        internal IntegrationRuntimeStatus()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of IntegrationRuntimeStatus. </summary>
        /// <param name="runtimeType"> Type of integration runtime. </param>
        /// <param name="dataFactoryName"> The data factory name which the integration runtime belong to. </param>
        /// <param name="state"> The state of integration runtime. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal IntegrationRuntimeStatus(IntegrationRuntimeType runtimeType, string dataFactoryName, IntegrationRuntimeState? state, IReadOnlyDictionary<string, BinaryData> additionalProperties)
        {
            RuntimeType = runtimeType;
            DataFactoryName = dataFactoryName;
            State = state;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Type of integration runtime. </summary>
        internal IntegrationRuntimeType RuntimeType { get; set; }
        /// <summary> The data factory name which the integration runtime belong to. </summary>
        public string DataFactoryName { get; }
        /// <summary> The state of integration runtime. </summary>
        public IntegrationRuntimeState? State { get; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IReadOnlyDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
