// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.FormRecognizer.Training;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Response to the get custom model operation. </summary>
    internal partial class Model
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

        /// <summary> Initializes a new instance of <see cref="Model"/>. </summary>
        /// <param name="modelInfo"> Basic custom model information. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelInfo"/> is null. </exception>
        internal Model(CustomFormModelInfo modelInfo)
        {
            Argument.AssertNotNull(modelInfo, nameof(modelInfo));

            ModelInfo = modelInfo;
            ComposedTrainResults = new ChangeTrackingList<TrainResult>();
        }

        /// <summary> Initializes a new instance of <see cref="Model"/>. </summary>
        /// <param name="modelInfo"> Basic custom model information. </param>
        /// <param name="keys"> Keys extracted by the custom model. </param>
        /// <param name="trainResult"> Training result for custom model. </param>
        /// <param name="composedTrainResults"> Training result for composed model. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Model(CustomFormModelInfo modelInfo, KeysResult keys, TrainResult trainResult, IReadOnlyList<TrainResult> composedTrainResults, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ModelInfo = modelInfo;
            Keys = keys;
            TrainResult = trainResult;
            ComposedTrainResults = composedTrainResults;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="Model"/> for deserialization. </summary>
        internal Model()
        {
        }

        /// <summary> Basic custom model information. </summary>
        public CustomFormModelInfo ModelInfo { get; }
        /// <summary> Keys extracted by the custom model. </summary>
        public KeysResult Keys { get; }
        /// <summary> Training result for custom model. </summary>
        public TrainResult TrainResult { get; }
        /// <summary> Training result for composed model. </summary>
        public IReadOnlyList<TrainResult> ComposedTrainResults { get; }
    }
}
