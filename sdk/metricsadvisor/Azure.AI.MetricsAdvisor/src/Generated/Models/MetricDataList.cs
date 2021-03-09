// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The MetricDataList. </summary>
    public partial class MetricDataList
    {
        /// <summary> Initializes a new instance of MetricDataList. </summary>
        internal MetricDataList()
        {
            Value = new ChangeTrackingList<MetricSeriesData>();
        }

        /// <summary> Initializes a new instance of MetricDataList. </summary>
        /// <param name="value"> . </param>
        internal MetricDataList(IReadOnlyList<MetricSeriesData> value)
        {
            Value = value;
        }

        public IReadOnlyList<MetricSeriesData> Value { get; }
    }
}
