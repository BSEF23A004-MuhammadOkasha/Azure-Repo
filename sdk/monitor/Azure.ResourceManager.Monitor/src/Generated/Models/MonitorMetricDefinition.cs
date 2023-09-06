// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Metric definition class specifies the metadata for a metric. </summary>
    public partial class MonitorMetricDefinition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MonitorMetricDefinition"/>. </summary>
        internal MonitorMetricDefinition()
        {
            SupportedAggregationTypes = new ChangeTrackingList<MonitorAggregationType>();
            MetricAvailabilities = new ChangeTrackingList<MonitorMetricAvailability>();
            Dimensions = new ChangeTrackingList<MonitorLocalizableString>();
        }

        /// <summary> Initializes a new instance of <see cref="MonitorMetricDefinition"/>. </summary>
        /// <param name="isDimensionRequired"> Flag to indicate whether the dimension is required. </param>
        /// <param name="resourceId"> the resource identifier of the resource that emitted the metric. </param>
        /// <param name="namespace"> the namespace the metric belongs to. </param>
        /// <param name="name"> the name and the display name of the metric, i.e. it is a localizable string. </param>
        /// <param name="displayDescription"> Detailed description of this metric. </param>
        /// <param name="category"> Custom category name for this metric. </param>
        /// <param name="metricClass"> The class of the metric. </param>
        /// <param name="unit"> The unit of the metric. </param>
        /// <param name="primaryAggregationType"> the primary aggregation type value defining how to use the values for display. </param>
        /// <param name="supportedAggregationTypes"> the collection of what aggregation types are supported. </param>
        /// <param name="metricAvailabilities"> the collection of what aggregation intervals are available to be queried. </param>
        /// <param name="id"> the resource identifier of the metric definition. </param>
        /// <param name="dimensions"> the name and the display name of the dimension, i.e. it is a localizable string. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorMetricDefinition(bool? isDimensionRequired, string resourceId, string @namespace, MonitorLocalizableString name, string displayDescription, string category, MonitorMetricClass? metricClass, MonitorMetricUnit? unit, MonitorAggregationType? primaryAggregationType, IReadOnlyList<MonitorAggregationType> supportedAggregationTypes, IReadOnlyList<MonitorMetricAvailability> metricAvailabilities, string id, IReadOnlyList<MonitorLocalizableString> dimensions, Dictionary<string, BinaryData> rawData)
        {
            IsDimensionRequired = isDimensionRequired;
            ResourceId = resourceId;
            Namespace = @namespace;
            Name = name;
            DisplayDescription = displayDescription;
            Category = category;
            MetricClass = metricClass;
            Unit = unit;
            PrimaryAggregationType = primaryAggregationType;
            SupportedAggregationTypes = supportedAggregationTypes;
            MetricAvailabilities = metricAvailabilities;
            Id = id;
            Dimensions = dimensions;
            _rawData = rawData;
        }

        /// <summary> Flag to indicate whether the dimension is required. </summary>
        public bool? IsDimensionRequired { get; }
        /// <summary> the resource identifier of the resource that emitted the metric. </summary>
        public string ResourceId { get; }
        /// <summary> the namespace the metric belongs to. </summary>
        public string Namespace { get; }
        /// <summary> the name and the display name of the metric, i.e. it is a localizable string. </summary>
        public MonitorLocalizableString Name { get; }
        /// <summary> Detailed description of this metric. </summary>
        public string DisplayDescription { get; }
        /// <summary> Custom category name for this metric. </summary>
        public string Category { get; }
        /// <summary> The class of the metric. </summary>
        public MonitorMetricClass? MetricClass { get; }
        /// <summary> The unit of the metric. </summary>
        public MonitorMetricUnit? Unit { get; }
        /// <summary> the primary aggregation type value defining how to use the values for display. </summary>
        public MonitorAggregationType? PrimaryAggregationType { get; }
        /// <summary> the collection of what aggregation types are supported. </summary>
        public IReadOnlyList<MonitorAggregationType> SupportedAggregationTypes { get; }
        /// <summary> the collection of what aggregation intervals are available to be queried. </summary>
        public IReadOnlyList<MonitorMetricAvailability> MetricAvailabilities { get; }
        /// <summary> the resource identifier of the metric definition. </summary>
        public string Id { get; }
        /// <summary> the name and the display name of the dimension, i.e. it is a localizable string. </summary>
        public IReadOnlyList<MonitorLocalizableString> Dimensions { get; }
    }
}
