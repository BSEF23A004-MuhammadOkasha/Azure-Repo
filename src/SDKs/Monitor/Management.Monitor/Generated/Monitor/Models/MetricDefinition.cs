// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Monitor;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Metric definition class specifies the metadata for a metric.
    /// </summary>
    public partial class MetricDefinition
    {
        /// <summary>
        /// Initializes a new instance of the MetricDefinition class.
        /// </summary>
        public MetricDefinition()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricDefinition class.
        /// </summary>
        /// <param name="isDimensionRequired">Flag to indicate whether the
        /// dimension is required.</param>
        /// <param name="resourceId">the resource identifier of the resource
        /// that emitted the metric.</param>
        /// <param name="name">the name and the display name of the metric,
        /// i.e. it is a localizable string.</param>
        /// <param name="unit">the unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'CountPerSecond', 'BytesPerSecond',
        /// 'Percent', 'MilliSeconds'</param>
        /// <param name="primaryAggregationType">the primary aggregation type
        /// value defining how to use the values for display. Possible values
        /// include: 'None', 'Average', 'Count', 'Minimum', 'Maximum',
        /// 'Total'</param>
        /// <param name="metricAvailabilities">the collection of what
        /// aggregation intervals are available to be queried.</param>
        /// <param name="id">the resource identifier of the metric
        /// definition.</param>
        /// <param name="dimensions">the name and the display name of the
        /// dimension, i.e. it is a localizable string.</param>
        public MetricDefinition(bool? isDimensionRequired = default(bool?), string resourceId = default(string), LocalizableString name = default(LocalizableString), Unit? unit = default(Unit?), AggregationType? primaryAggregationType = default(AggregationType?), IList<MetricAvailability> metricAvailabilities = default(IList<MetricAvailability>), string id = default(string), IList<LocalizableString> dimensions = default(IList<LocalizableString>))
        {
            IsDimensionRequired = isDimensionRequired;
            ResourceId = resourceId;
            Name = name;
            Unit = unit;
            PrimaryAggregationType = primaryAggregationType;
            MetricAvailabilities = metricAvailabilities;
            Id = id;
            Dimensions = dimensions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets flag to indicate whether the dimension is required.
        /// </summary>
        [JsonProperty(PropertyName = "isDimensionRequired")]
        public bool? IsDimensionRequired { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier of the resource that emitted
        /// the metric.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the name and the display name of the metric, i.e. it
        /// is a localizable string.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public LocalizableString Name { get; set; }

        /// <summary>
        /// Gets or sets the unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'CountPerSecond', 'BytesPerSecond',
        /// 'Percent', 'MilliSeconds'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public Unit? Unit { get; set; }

        /// <summary>
        /// Gets or sets the primary aggregation type value defining how to use
        /// the values for display. Possible values include: 'None', 'Average',
        /// 'Count', 'Minimum', 'Maximum', 'Total'
        /// </summary>
        [JsonProperty(PropertyName = "primaryAggregationType")]
        public AggregationType? PrimaryAggregationType { get; set; }

        /// <summary>
        /// Gets or sets the collection of what aggregation intervals are
        /// available to be queried.
        /// </summary>
        [JsonProperty(PropertyName = "metricAvailabilities")]
        public IList<MetricAvailability> MetricAvailabilities { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier of the metric definition.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name and the display name of the dimension, i.e.
        /// it is a localizable string.
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IList<LocalizableString> Dimensions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name != null)
            {
                Name.Validate();
            }
            if (Dimensions != null)
            {
                foreach (var element in Dimensions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
