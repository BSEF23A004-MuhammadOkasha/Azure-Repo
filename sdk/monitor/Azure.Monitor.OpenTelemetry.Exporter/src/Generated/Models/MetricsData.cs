// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    /// <summary> An instance of the Metric item is a list of measurements (single data points) and/or aggregations. </summary>
    internal partial class MetricsData : MonitorDomain
    {
        /// <summary> Initializes a new instance of MetricsData. </summary>
        /// <param name="version"> Schema version. </param>
        /// <param name="metrics"> List of metrics. Only one metric in the list is currently supported by Application Insights storage. If multiple data points were sent only the first one will be used. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metrics"/> is null. </exception>
        public MetricsData(int version, IEnumerable<MetricDataPoint> metrics) : base(version)
        {
            Argument.AssertNotNull(metrics, nameof(metrics));

            Metrics = metrics.ToList();
            Properties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> List of metrics. Only one metric in the list is currently supported by Application Insights storage. If multiple data points were sent only the first one will be used. </summary>
        public IList<MetricDataPoint> Metrics { get; }
        /// <summary> Collection of custom properties. </summary>
        public IDictionary<string, string> Properties { get; }
    }
}
