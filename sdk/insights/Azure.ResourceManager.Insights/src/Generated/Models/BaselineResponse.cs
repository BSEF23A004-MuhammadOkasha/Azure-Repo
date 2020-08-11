// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> The response to a baseline query. </summary>
    public partial class BaselineResponse
    {
        /// <summary> Initializes a new instance of BaselineResponse. </summary>
        internal BaselineResponse()
        {
            Timestamps = new ChangeTrackingList<DateTimeOffset>();
            Baseline = new ChangeTrackingList<Baseline>();
            Metadata = new ChangeTrackingList<BaselineMetadataValue>();
        }

        /// <summary> Initializes a new instance of BaselineResponse. </summary>
        /// <param name="id"> the metric baseline Id. </param>
        /// <param name="type"> the resource type of the baseline resource. </param>
        /// <param name="name"> the name and the display name of the metric, i.e. it is localizable string. </param>
        /// <param name="timespan"> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by &apos;/&apos;.  This may be adjusted in the future and returned back from what was originally requested. </param>
        /// <param name="interval"> The interval (window size) for which the metric data was returned in.  This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </param>
        /// <param name="aggregation"> The aggregation type of the metric. </param>
        /// <param name="timestamps"> the array of timestamps of the baselines. </param>
        /// <param name="baseline"> the baseline values for each sensitivity. </param>
        /// <param name="metadata"> the baseline metadata values. </param>
        internal BaselineResponse(string id, string type, LocalizableString name, string timespan, TimeSpan? interval, string aggregation, IReadOnlyList<DateTimeOffset> timestamps, IReadOnlyList<Baseline> baseline, IReadOnlyList<BaselineMetadataValue> metadata)
        {
            Id = id;
            Type = type;
            Name = name;
            Timespan = timespan;
            Interval = interval;
            Aggregation = aggregation;
            Timestamps = timestamps;
            Baseline = baseline;
            Metadata = metadata;
        }

        /// <summary> the metric baseline Id. </summary>
        public string Id { get; }
        /// <summary> the resource type of the baseline resource. </summary>
        public string Type { get; }
        /// <summary> the name and the display name of the metric, i.e. it is localizable string. </summary>
        public LocalizableString Name { get; }
        /// <summary> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by &apos;/&apos;.  This may be adjusted in the future and returned back from what was originally requested. </summary>
        public string Timespan { get; }
        /// <summary> The interval (window size) for which the metric data was returned in.  This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </summary>
        public TimeSpan? Interval { get; }
        /// <summary> The aggregation type of the metric. </summary>
        public string Aggregation { get; }
        /// <summary> the array of timestamps of the baselines. </summary>
        public IReadOnlyList<DateTimeOffset> Timestamps { get; }
        /// <summary> the baseline values for each sensitivity. </summary>
        public IReadOnlyList<Baseline> Baseline { get; }
        /// <summary> the baseline metadata values. </summary>
        public IReadOnlyList<BaselineMetadataValue> Metadata { get; }
    }
}
