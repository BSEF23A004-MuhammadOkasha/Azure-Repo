// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Value of resource metric.
    /// </summary>
    public partial class ResourceMetricValue
    {
        /// <summary>
        /// Initializes a new instance of the ResourceMetricValue class.
        /// </summary>
        public ResourceMetricValue() { }

        /// <summary>
        /// Initializes a new instance of the ResourceMetricValue class.
        /// </summary>
        /// <param name="timestamp">Value timestamp.</param>
        /// <param name="average">Value average.</param>
        /// <param name="minimum">Value minimum.</param>
        /// <param name="maximum">Value maximum.</param>
        /// <param name="total">Value total.</param>
        /// <param name="count">Value count.</param>
        /// <param name="properties">Properties.</param>
        public ResourceMetricValue(string timestamp = default(string), double? average = default(double?), double? minimum = default(double?), double? maximum = default(double?), double? total = default(double?), double? count = default(double?), System.Collections.Generic.IList<ResourceMetricProperty> properties = default(System.Collections.Generic.IList<ResourceMetricProperty>))
        {
            Timestamp = timestamp;
            Average = average;
            Minimum = minimum;
            Maximum = maximum;
            Total = total;
            Count = count;
            Properties = properties;
        }

        /// <summary>
        /// Gets value timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "timestamp")]
        public string Timestamp { get; private set; }

        /// <summary>
        /// Gets value average.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "average")]
        public double? Average { get; private set; }

        /// <summary>
        /// Gets value minimum.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "minimum")]
        public double? Minimum { get; private set; }

        /// <summary>
        /// Gets value maximum.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maximum")]
        public double? Maximum { get; private set; }

        /// <summary>
        /// Gets value total.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "total")]
        public double? Total { get; private set; }

        /// <summary>
        /// Gets value count.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "count")]
        public double? Count { get; private set; }

        /// <summary>
        /// Gets properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.IList<ResourceMetricProperty> Properties { get; private set; }

    }
}
