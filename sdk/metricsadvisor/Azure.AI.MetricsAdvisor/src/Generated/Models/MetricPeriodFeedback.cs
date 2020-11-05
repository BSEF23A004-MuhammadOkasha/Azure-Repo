// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.MetricsAdvisor;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The PeriodFeedback. </summary>
    public partial class MetricPeriodFeedback : MetricFeedback
    {

        /// <summary> Initializes a new instance of MetricPeriodFeedback. </summary>
        /// <param name="type"> feedback type. </param>
        /// <param name="id"> feedback unique id. </param>
        /// <param name="createdTime"> feedback created time. </param>
        /// <param name="userPrincipal"> user who gives this feedback. </param>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="dimensionFilter"> . </param>
        /// <param name="valueInternal"> . </param>
        internal MetricPeriodFeedback(FeedbackType type, string id, DateTimeOffset? createdTime, string userPrincipal, string metricId, FeedbackDimensionFilter dimensionFilter, PeriodFeedbackValue valueInternal) : base(type, id, createdTime, userPrincipal, metricId, dimensionFilter)
        {
            ValueInternal = valueInternal;
            Type = type;
        }
    }
}
