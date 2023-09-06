// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The DetectionAnomalyResultQuery. </summary>
    internal partial class DetectionAnomalyResultQuery
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DetectionAnomalyResultQuery"/>. </summary>
        /// <param name="startTime"> start time. </param>
        /// <param name="endTime"> end time. </param>
        public DetectionAnomalyResultQuery(DateTimeOffset startTime, DateTimeOffset endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        /// <summary> Initializes a new instance of <see cref="DetectionAnomalyResultQuery"/>. </summary>
        /// <param name="startTime"> start time. </param>
        /// <param name="endTime"> end time. </param>
        /// <param name="filter"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DetectionAnomalyResultQuery(DateTimeOffset startTime, DateTimeOffset endTime, DetectionAnomalyFilterCondition filter, Dictionary<string, BinaryData> rawData)
        {
            StartTime = startTime;
            EndTime = endTime;
            Filter = filter;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DetectionAnomalyResultQuery"/> for deserialization. </summary>
        internal DetectionAnomalyResultQuery()
        {
        }

        /// <summary> start time. </summary>
        public DateTimeOffset StartTime { get; }
        /// <summary> end time. </summary>
        public DateTimeOffset EndTime { get; }
        /// <summary> Gets or sets the filter. </summary>
        public DetectionAnomalyFilterCondition Filter { get; set; }
    }
}
