// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownPredictionDriftMetricThresholdBase. </summary>
    internal partial class UnknownPredictionDriftMetricThresholdBase : PredictionDriftMetricThresholdBase
    {
        /// <summary> Initializes a new instance of <see cref="UnknownPredictionDriftMetricThresholdBase"/>. </summary>
        /// <param name="dataType"> [Required] Specifies the data type of the metric threshold. </param>
        /// <param name="threshold"> The threshold value. If null, a default value will be set depending on the selected metric. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownPredictionDriftMetricThresholdBase(MonitoringFeatureDataType dataType, MonitoringThreshold threshold, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(dataType, threshold, serializedAdditionalRawData)
        {
            DataType = dataType;
        }
    }
}
