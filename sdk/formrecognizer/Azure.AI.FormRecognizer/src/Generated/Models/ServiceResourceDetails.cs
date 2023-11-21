// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> General information regarding the current resource. </summary>
    internal partial class ServiceResourceDetails
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

        /// <summary> Initializes a new instance of <see cref="ServiceResourceDetails"/>. </summary>
        /// <param name="customDocumentModels"> Details regarding custom document models. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customDocumentModels"/> is null. </exception>
        internal ServiceResourceDetails(CustomDocumentModelsDetails customDocumentModels)
        {
            Argument.AssertNotNull(customDocumentModels, nameof(customDocumentModels));

            CustomDocumentModels = customDocumentModels;
        }

        /// <summary> Initializes a new instance of <see cref="ServiceResourceDetails"/>. </summary>
        /// <param name="customDocumentModels"> Details regarding custom document models. </param>
        /// <param name="customNeuralDocumentModelBuilds"> Quota used, limit, and next reset date/time. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceResourceDetails(CustomDocumentModelsDetails customDocumentModels, ResourceQuotaDetails customNeuralDocumentModelBuilds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CustomDocumentModels = customDocumentModels;
            CustomNeuralDocumentModelBuilds = customNeuralDocumentModelBuilds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ServiceResourceDetails"/> for deserialization. </summary>
        internal ServiceResourceDetails()
        {
        }

        /// <summary> Details regarding custom document models. </summary>
        public CustomDocumentModelsDetails CustomDocumentModels { get; }
        /// <summary> Quota used, limit, and next reset date/time. </summary>
        public ResourceQuotaDetails CustomNeuralDocumentModelBuilds { get; }
    }
}
