// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Waf Metrics Response. </summary>
    public partial class WafMetricsResponse
    {
        /// <summary> Initializes a new instance of WafMetricsResponse. </summary>
        internal WafMetricsResponse()
        {
            Series = new ChangeTrackingList<WafMetricsResponseSeriesItem>();
        }

        /// <summary> Initializes a new instance of WafMetricsResponse. </summary>
        /// <param name="dateTimeBegin"></param>
        /// <param name="dateTimeEnd"></param>
        /// <param name="granularity"></param>
        /// <param name="series"></param>
        internal WafMetricsResponse(DateTimeOffset? dateTimeBegin, DateTimeOffset? dateTimeEnd, WafMetricsResponseGranularity? granularity, IReadOnlyList<WafMetricsResponseSeriesItem> series)
        {
            DateTimeBegin = dateTimeBegin;
            DateTimeEnd = dateTimeEnd;
            Granularity = granularity;
            Series = series;
        }

        public DateTimeOffset? DateTimeBegin { get; }
        public DateTimeOffset? DateTimeEnd { get; }
        public WafMetricsResponseGranularity? Granularity { get; }
        public IReadOnlyList<WafMetricsResponseSeriesItem> Series { get; }
    }
}
