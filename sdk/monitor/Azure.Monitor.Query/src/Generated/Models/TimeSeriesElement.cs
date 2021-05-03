// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> A time series result type. The discriminator value is always TimeSeries in this case. </summary>
    public partial class TimeSeriesElement
    {
        /// <summary> Initializes a new instance of TimeSeriesElement. </summary>
        internal TimeSeriesElement()
        {
            Metadatavalues = new ChangeTrackingList<MetadataValue>();
            Data = new ChangeTrackingList<MetricValue>();
        }

        /// <summary> Initializes a new instance of TimeSeriesElement. </summary>
        /// <param name="metadatavalues"> the metadata values returned if $filter was specified in the call. </param>
        /// <param name="data"> An array of data points representing the metric values.  This is only returned if a result type of data is specified. </param>
        internal TimeSeriesElement(IReadOnlyList<MetadataValue> metadatavalues, IReadOnlyList<MetricValue> data)
        {
            Metadatavalues = metadatavalues;
            Data = data;
        }
        /// <summary> An array of data points representing the metric values.  This is only returned if a result type of data is specified. </summary>
        public IReadOnlyList<MetricValue> Data { get; }
    }
}
