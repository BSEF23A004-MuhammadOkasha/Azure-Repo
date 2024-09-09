// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A paginated list of ModelContainer entities. </summary>
    internal partial class ModelContainerResourceArmPaginatedResult
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

        /// <summary> Initializes a new instance of <see cref="ModelContainerResourceArmPaginatedResult"/>. </summary>
        internal ModelContainerResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<MachineLearningModelContainerData>();
        }

        /// <summary> Initializes a new instance of <see cref="ModelContainerResourceArmPaginatedResult"/>. </summary>
        /// <param name="value"> An array of objects of type ModelContainer. </param>
        /// <param name="nextLink"> The link to the next page of ModelContainer objects. If null, there are no additional pages. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ModelContainerResourceArmPaginatedResult(IReadOnlyList<MachineLearningModelContainerData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> An array of objects of type ModelContainer. </summary>
        public IReadOnlyList<MachineLearningModelContainerData> Value { get; }
        /// <summary> The link to the next page of ModelContainer objects. If null, there are no additional pages. </summary>
        public string NextLink { get; }
    }
}
