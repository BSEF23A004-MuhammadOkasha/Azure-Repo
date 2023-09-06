// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Details of resource being monitored by NewRelic monitor resource. </summary>
    public partial class NewRelicResourceMonitorResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NewRelicResourceMonitorResult"/>. </summary>
        internal NewRelicResourceMonitorResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicResourceMonitorResult"/>. </summary>
        /// <param name="id"> The ARM id of the resource. </param>
        /// <param name="sendingMetrics"> Flag indicating if resource is sending metrics to NewRelic. </param>
        /// <param name="reasonForMetricsStatus"> Reason for why the resource is sending metrics (or why it is not sending). </param>
        /// <param name="sendingLogs"> Flag indicating if resource is sending logs to NewRelic. </param>
        /// <param name="reasonForLogsStatus"> Reason for why the resource is sending logs (or why it is not sending). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicResourceMonitorResult(ResourceIdentifier id, NewRelicObservabilitySendingMetricsStatus? sendingMetrics, string reasonForMetricsStatus, NewRelicObservabilitySendingLogsStatus? sendingLogs, string reasonForLogsStatus, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            SendingMetrics = sendingMetrics;
            ReasonForMetricsStatus = reasonForMetricsStatus;
            SendingLogs = sendingLogs;
            ReasonForLogsStatus = reasonForLogsStatus;
            _rawData = rawData;
        }

        /// <summary> The ARM id of the resource. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Flag indicating if resource is sending metrics to NewRelic. </summary>
        public NewRelicObservabilitySendingMetricsStatus? SendingMetrics { get; }
        /// <summary> Reason for why the resource is sending metrics (or why it is not sending). </summary>
        public string ReasonForMetricsStatus { get; }
        /// <summary> Flag indicating if resource is sending logs to NewRelic. </summary>
        public NewRelicObservabilitySendingLogsStatus? SendingLogs { get; }
        /// <summary> Reason for why the resource is sending logs (or why it is not sending). </summary>
        public string ReasonForLogsStatus { get; }
    }
}
