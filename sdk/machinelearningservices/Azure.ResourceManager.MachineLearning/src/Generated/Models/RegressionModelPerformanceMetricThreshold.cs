// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The RegressionModelPerformanceMetricThreshold. </summary>
    public partial class RegressionModelPerformanceMetricThreshold : ModelPerformanceMetricThresholdBase
    {
        /// <summary> Initializes a new instance of RegressionModelPerformanceMetricThreshold. </summary>
        /// <param name="metric"> [Required] The regression model performance metric to calculate. </param>
        public RegressionModelPerformanceMetricThreshold(RegressionModelPerformanceMetric metric)
        {
            Metric = metric;
            ModelType = MonitoringModelType.Regression;
        }

        /// <summary> Initializes a new instance of RegressionModelPerformanceMetricThreshold. </summary>
        /// <param name="modelType"> [Required] Specifies the data type of the metric threshold. </param>
        /// <param name="threshold"> The threshold value. If null, a default value will be set depending on the selected metric. </param>
        /// <param name="metric"> [Required] The regression model performance metric to calculate. </param>
        internal RegressionModelPerformanceMetricThreshold(MonitoringModelType modelType, MonitoringThreshold threshold, RegressionModelPerformanceMetric metric) : base(modelType, threshold)
        {
            Metric = metric;
            ModelType = modelType;
        }

        /// <summary> [Required] The regression model performance metric to calculate. </summary>
        public RegressionModelPerformanceMetric Metric { get; set; }
    }
}
