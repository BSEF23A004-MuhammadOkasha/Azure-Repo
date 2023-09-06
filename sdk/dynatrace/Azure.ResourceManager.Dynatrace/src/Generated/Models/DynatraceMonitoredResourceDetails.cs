// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Details of resource being monitored by Dynatrace monitor resource. </summary>
    public partial class DynatraceMonitoredResourceDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DynatraceMonitoredResourceDetails"/>. </summary>
        internal DynatraceMonitoredResourceDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DynatraceMonitoredResourceDetails"/>. </summary>
        /// <param name="id"> The ARM id of the resource. </param>
        /// <param name="sendingMetricsStatus"> Flag indicating if resource is sending metrics to Dynatrace. </param>
        /// <param name="reasonForMetricsStatus"> Reason for why the resource is sending metrics (or why it is not sending). </param>
        /// <param name="sendingLogsStatus"> Flag indicating if resource is sending logs to Dynatrace. </param>
        /// <param name="reasonForLogsStatus"> Reason for why the resource is sending logs (or why it is not sending). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DynatraceMonitoredResourceDetails(ResourceIdentifier id, MetricsSendingStatus? sendingMetricsStatus, string reasonForMetricsStatus, LogsSendingStatus? sendingLogsStatus, string reasonForLogsStatus, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            SendingMetricsStatus = sendingMetricsStatus;
            ReasonForMetricsStatus = reasonForMetricsStatus;
            SendingLogsStatus = sendingLogsStatus;
            ReasonForLogsStatus = reasonForLogsStatus;
            _rawData = rawData;
        }

        /// <summary> The ARM id of the resource. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Flag indicating if resource is sending metrics to Dynatrace. </summary>
        public MetricsSendingStatus? SendingMetricsStatus { get; }
        /// <summary> Reason for why the resource is sending metrics (or why it is not sending). </summary>
        public string ReasonForMetricsStatus { get; }
        /// <summary> Flag indicating if resource is sending logs to Dynatrace. </summary>
        public LogsSendingStatus? SendingLogsStatus { get; }
        /// <summary> Reason for why the resource is sending logs (or why it is not sending). </summary>
        public string ReasonForLogsStatus { get; }
    }
}
