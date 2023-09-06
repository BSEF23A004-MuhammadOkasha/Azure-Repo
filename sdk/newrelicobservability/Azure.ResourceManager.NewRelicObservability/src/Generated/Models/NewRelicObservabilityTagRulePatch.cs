// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> The type used for update operations of the TagRule. </summary>
    public partial class NewRelicObservabilityTagRulePatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityTagRulePatch"/>. </summary>
        public NewRelicObservabilityTagRulePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityTagRulePatch"/>. </summary>
        /// <param name="logRules"> Set of rules for sending logs for the Monitor resource. </param>
        /// <param name="metricRules"> Set of rules for sending metrics for the Monitor resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicObservabilityTagRulePatch(NewRelicObservabilityLogRules logRules, NewRelicObservabilityMetricRules metricRules, Dictionary<string, BinaryData> rawData)
        {
            LogRules = logRules;
            MetricRules = metricRules;
            _rawData = rawData;
        }

        /// <summary> Set of rules for sending logs for the Monitor resource. </summary>
        public NewRelicObservabilityLogRules LogRules { get; set; }
        /// <summary> Set of rules for sending metrics for the Monitor resource. </summary>
        public NewRelicObservabilityMetricRules MetricRules { get; set; }
    }
}
