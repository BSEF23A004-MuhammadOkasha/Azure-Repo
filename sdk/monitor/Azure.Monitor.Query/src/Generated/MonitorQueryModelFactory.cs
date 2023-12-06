// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class MonitorQueryModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.LogsTableColumn"/>. </summary>
        /// <param name="name"> The name of this column. </param>
        /// <param name="type"> The data type of this column. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <returns> A new <see cref="Models.LogsTableColumn"/> instance for mocking. </returns>
        public static LogsTableColumn LogsTableColumn(string name = null, LogsColumnType type = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return new LogsTableColumn(name, type);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MetricsBatchResult"/>. </summary>
        /// <param name="values"> The collection of metric data responses per resource, per metric. </param>
        /// <returns> A new <see cref="Models.MetricsBatchResult"/> instance for mocking. </returns>
        public static MetricsBatchResult MetricsBatchResult(IEnumerable<MetricsBatchResultValues> values = null)
        {
            values ??= new List<MetricsBatchResultValues>();

            return new MetricsBatchResult(values?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Models.MetricsBatchResultValues"/>. </summary>
        /// <param name="startTime"> The start time, in datetime format, for which the data was retrieved. </param>
        /// <param name="endTime"> The end time, in datetime format, for which the data was retrieved. </param>
        /// <param name="interval"> The interval (window size) for which the metric data was returned in. Follows the IS8601/RFC3339 duration format (e.g. 'P1D' for 1 day). This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </param>
        /// <param name="namespace"> The namespace of the metrics been queried. </param>
        /// <param name="resourceRegion"> The region of the resource been queried for metrics. </param>
        /// <param name="resourceId"> The resource that has been queried for metrics. </param>
        /// <param name="metrics"> The value of the collection. </param>
        /// <returns> A new <see cref="Models.MetricsBatchResultValues"/> instance for mocking. </returns>
        public static MetricsBatchResultValues MetricsBatchResultValues(DateTimeOffset startTime = default, DateTimeOffset endTime = default, TimeSpan? interval = null, string @namespace = null, AzureLocation resourceRegion = default, ResourceIdentifier resourceId = null, IEnumerable<MetricResult> metrics = null)
        {
            metrics ??= new List<MetricResult>();

            return new MetricsBatchResultValues(startTime, endTime, interval, @namespace, resourceRegion, resourceId, metrics?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Models.MetricAvailability"/>. </summary>
        /// <param name="granularity"> the time grain specifies the aggregation interval for the metric. Expressed as a duration 'PT1M', 'P1D', etc. </param>
        /// <param name="retention"> the retention period for the metric at the specified timegrain.  Expressed as a duration 'PT1M', 'P1D', etc. </param>
        /// <returns> A new <see cref="Models.MetricAvailability"/> instance for mocking. </returns>
        public static MetricAvailability MetricAvailability(TimeSpan? granularity = null, TimeSpan? retention = null)
        {
            return new MetricAvailability(granularity, retention);
        }
    }
}
