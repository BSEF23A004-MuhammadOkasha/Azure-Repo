// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Information about metrics for the workspace. </summary>
    public partial class MonitorWorkspaceMetricProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MonitorWorkspaceMetricProperties"/>. </summary>
        internal MonitorWorkspaceMetricProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MonitorWorkspaceMetricProperties"/>. </summary>
        /// <param name="prometheusQueryEndpoint"> The Prometheus query endpoint for the workspace. </param>
        /// <param name="internalId"> An internal identifier for the metrics container. Only to be used by the system. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorWorkspaceMetricProperties(string prometheusQueryEndpoint, string internalId, Dictionary<string, BinaryData> rawData)
        {
            PrometheusQueryEndpoint = prometheusQueryEndpoint;
            InternalId = internalId;
            _rawData = rawData;
        }

        /// <summary> The Prometheus query endpoint for the workspace. </summary>
        public string PrometheusQueryEndpoint { get; }
        /// <summary> An internal identifier for the metrics container. Only to be used by the system. </summary>
        public string InternalId { get; }
    }
}
