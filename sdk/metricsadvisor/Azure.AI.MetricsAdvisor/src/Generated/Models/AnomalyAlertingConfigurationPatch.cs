// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AnomalyAlertingConfigurationPatch. </summary>
    internal partial class AnomalyAlertingConfigurationPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AnomalyAlertingConfigurationPatch"/>. </summary>
        public AnomalyAlertingConfigurationPatch()
        {
            SplitAlertByDimensions = new ChangeTrackingList<string>();
            HookIds = new ChangeTrackingList<Guid>();
            MetricAlertingConfigurations = new ChangeTrackingList<MetricAlertConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyAlertingConfigurationPatch"/>. </summary>
        /// <param name="name"> Anomaly alerting configuration name. </param>
        /// <param name="description"> anomaly alerting configuration description. </param>
        /// <param name="crossMetricsOperator"> cross metrics operator. </param>
        /// <param name="splitAlertByDimensions"> dimensions used to split alert. </param>
        /// <param name="hookIds"> hook unique ids. </param>
        /// <param name="metricAlertingConfigurations"> Anomaly alerting configurations. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AnomalyAlertingConfigurationPatch(string name, string description, MetricAlertConfigurationsOperator? crossMetricsOperator, IList<string> splitAlertByDimensions, IList<Guid> hookIds, IList<MetricAlertConfiguration> metricAlertingConfigurations, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Description = description;
            CrossMetricsOperator = crossMetricsOperator;
            SplitAlertByDimensions = splitAlertByDimensions;
            HookIds = hookIds;
            MetricAlertingConfigurations = metricAlertingConfigurations;
            _rawData = rawData;
        }

        /// <summary> Anomaly alerting configuration name. </summary>
        public string Name { get; set; }
        /// <summary> anomaly alerting configuration description. </summary>
        public string Description { get; set; }
        /// <summary> cross metrics operator. </summary>
        public MetricAlertConfigurationsOperator? CrossMetricsOperator { get; set; }
    }
}
