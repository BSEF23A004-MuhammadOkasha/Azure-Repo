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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The result data of a query.
    /// </summary>
    public partial class Metric
    {
        /// <summary>
        /// Initializes a new instance of the Metric class.
        /// </summary>
        public Metric()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Metric class.
        /// </summary>
        /// <param name="id">the metric Id.</param>
        /// <param name="type">the resource type of the metric
        /// resource.</param>
        /// <param name="name">the name and the display name of the metric,
        /// i.e. it is localizable string.</param>
        /// <param name="unit">the unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'CountPerSecond', 'BytesPerSecond',
        /// 'Percent', 'MilliSeconds'</param>
        /// <param name="timeseries">the time series returned when a data query
        /// is performed.</param>
        public Metric(string id, string type, LocalizableString name, Unit unit, IList<TimeSeriesElement> timeseries)
        {
            Id = id;
            Type = type;
            Name = name;
            Unit = unit;
            Timeseries = timeseries;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the metric Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the resource type of the metric resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name and the display name of the metric, i.e. it
        /// is localizable string.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public LocalizableString Name { get; set; }

        /// <summary>
        /// Gets or sets the unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'CountPerSecond', 'BytesPerSecond',
        /// 'Percent', 'MilliSeconds'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public Unit Unit { get; set; }

        /// <summary>
        /// Gets or sets the time series returned when a data query is
        /// performed.
        /// </summary>
        [JsonProperty(PropertyName = "timeseries")]
        public IList<TimeSeriesElement> Timeseries { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Timeseries == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Timeseries");
            }
            if (Name != null)
            {
                Name.Validate();
            }
        }
    }
}
