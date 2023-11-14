// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The result data of a query. </summary>
    public partial class SubscriptionMonitorMetric
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SubscriptionMonitorMetric"/>. </summary>
        /// <param name="id"> the metric Id. </param>
        /// <param name="subscriptionScopeMetricType"> the resource type of the metric resource. </param>
        /// <param name="name"> the name and the display name of the metric, i.e. it is localizable string. </param>
        /// <param name="unit"> The unit of the metric. </param>
        /// <param name="timeseries"> the time series returned when a data query is performed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="subscriptionScopeMetricType"/>, <paramref name="name"/> or <paramref name="timeseries"/> is null. </exception>
        internal SubscriptionMonitorMetric(string id, string subscriptionScopeMetricType, MonitorLocalizableString name, MonitorMetricUnit unit, IEnumerable<MonitorTimeSeriesElement> timeseries)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(subscriptionScopeMetricType, nameof(subscriptionScopeMetricType));
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(timeseries, nameof(timeseries));

            Id = id;
            SubscriptionScopeMetricType = subscriptionScopeMetricType;
            Name = name;
            Unit = unit;
            Timeseries = timeseries.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionMonitorMetric"/>. </summary>
        /// <param name="id"> the metric Id. </param>
        /// <param name="subscriptionScopeMetricType"> the resource type of the metric resource. </param>
        /// <param name="name"> the name and the display name of the metric, i.e. it is localizable string. </param>
        /// <param name="displayDescription"> Detailed description of this metric. </param>
        /// <param name="errorCode"> 'Success' or the error details on query failures for this metric. </param>
        /// <param name="errorMessage"> Error message encountered querying this specific metric. </param>
        /// <param name="unit"> The unit of the metric. </param>
        /// <param name="timeseries"> the time series returned when a data query is performed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SubscriptionMonitorMetric(string id, string subscriptionScopeMetricType, MonitorLocalizableString name, string displayDescription, string errorCode, string errorMessage, MonitorMetricUnit unit, IReadOnlyList<MonitorTimeSeriesElement> timeseries, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            SubscriptionScopeMetricType = subscriptionScopeMetricType;
            Name = name;
            DisplayDescription = displayDescription;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            Unit = unit;
            Timeseries = timeseries;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionMonitorMetric"/> for deserialization. </summary>
        internal SubscriptionMonitorMetric()
        {
        }

        /// <summary> the metric Id. </summary>
        public string Id { get; }
        /// <summary> the resource type of the metric resource. </summary>
        public string SubscriptionScopeMetricType { get; }
        /// <summary> the name and the display name of the metric, i.e. it is localizable string. </summary>
        public MonitorLocalizableString Name { get; }
        /// <summary> Detailed description of this metric. </summary>
        public string DisplayDescription { get; }
        /// <summary> 'Success' or the error details on query failures for this metric. </summary>
        public string ErrorCode { get; }
        /// <summary> Error message encountered querying this specific metric. </summary>
        public string ErrorMessage { get; }
        /// <summary> The unit of the metric. </summary>
        public MonitorMetricUnit Unit { get; }
        /// <summary> the time series returned when a data query is performed. </summary>
        public IReadOnlyList<MonitorTimeSeriesElement> Timeseries { get; }
    }
}
