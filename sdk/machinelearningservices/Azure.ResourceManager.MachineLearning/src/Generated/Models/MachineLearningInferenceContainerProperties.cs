// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningInferenceContainerProperties. </summary>
    public partial class MachineLearningInferenceContainerProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningInferenceContainerProperties"/>. </summary>
        public MachineLearningInferenceContainerProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningInferenceContainerProperties"/>. </summary>
        /// <param name="livenessRoute"> The route to check the liveness of the inference server container. </param>
        /// <param name="readinessRoute"> The route to check the readiness of the inference server container. </param>
        /// <param name="scoringRoute"> The port to send the scoring requests to, within the inference server container. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningInferenceContainerProperties(MachineLearningInferenceContainerRoute livenessRoute, MachineLearningInferenceContainerRoute readinessRoute, MachineLearningInferenceContainerRoute scoringRoute, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LivenessRoute = livenessRoute;
            ReadinessRoute = readinessRoute;
            ScoringRoute = scoringRoute;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The route to check the liveness of the inference server container. </summary>
        public MachineLearningInferenceContainerRoute LivenessRoute { get; set; }
        /// <summary> The route to check the readiness of the inference server container. </summary>
        public MachineLearningInferenceContainerRoute ReadinessRoute { get; set; }
        /// <summary> The port to send the scoring requests to, within the inference server container. </summary>
        public MachineLearningInferenceContainerRoute ScoringRoute { get; set; }
    }
}
