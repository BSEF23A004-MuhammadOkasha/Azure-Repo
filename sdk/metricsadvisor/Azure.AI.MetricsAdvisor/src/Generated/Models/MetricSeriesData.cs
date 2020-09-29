// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The MetricDataItem. </summary>
    public partial class MetricSeriesData
    {
        /// <summary> Initializes a new instance of MetricSeriesData. </summary>
        internal MetricSeriesData()
        {
            Timestamps = new ChangeTrackingList<DateTimeOffset>();
            Values = new ChangeTrackingList<double>();
        }

        /// <summary> Initializes a new instance of MetricSeriesData. </summary>
        /// <param name="definition"> . </param>
        /// <param name="timestamps"> timestamps of the data related to this time series. </param>
        /// <param name="values"> values of the data related to this time series. </param>
        internal MetricSeriesData(MetricSeriesDefinition definition, IReadOnlyList<DateTimeOffset> timestamps, IReadOnlyList<double> values)
        {
            Definition = definition;
            Timestamps = timestamps;
            Values = values;
        }
    }
}
