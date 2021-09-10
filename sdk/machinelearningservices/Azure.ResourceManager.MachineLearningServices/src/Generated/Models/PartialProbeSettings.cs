// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Deployment container liveness/readiness probe configuration. </summary>
    public partial class PartialProbeSettings
    {
        /// <summary> Initializes a new instance of PartialProbeSettings. </summary>
        public PartialProbeSettings()
        {
        }

        /// <summary> The number of failures to allow before returning an unhealthy status. </summary>
        public int? FailureThreshold { get; set; }
        /// <summary> The delay before the first probe in ISO 8601 format. </summary>
        public TimeSpan? InitialDelay { get; set; }
        /// <summary> The length of time between probes in ISO 8601 format. </summary>
        public TimeSpan? Period { get; set; }
        /// <summary> The number of successful probes before returning a healthy status. </summary>
        public int? SuccessThreshold { get; set; }
        /// <summary> The probe timeout in ISO 8601 format. </summary>
        public TimeSpan? Timeout { get; set; }
    }
}
