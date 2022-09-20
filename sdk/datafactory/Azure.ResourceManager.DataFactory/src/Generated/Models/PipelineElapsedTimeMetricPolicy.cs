// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Pipeline ElapsedTime Metric Policy. </summary>
    internal partial class PipelineElapsedTimeMetricPolicy
    {
        /// <summary> Initializes a new instance of PipelineElapsedTimeMetricPolicy. </summary>
        public PipelineElapsedTimeMetricPolicy()
        {
        }

        /// <summary> Initializes a new instance of PipelineElapsedTimeMetricPolicy. </summary>
        /// <param name="duration"> TimeSpan value, after which an Azure Monitoring Metric is fired. </param>
        internal PipelineElapsedTimeMetricPolicy(TimeSpan? duration)
        {
            Duration = duration;
        }

        /// <summary> TimeSpan value, after which an Azure Monitoring Metric is fired. </summary>
        public TimeSpan? Duration { get; set; }
    }
}
