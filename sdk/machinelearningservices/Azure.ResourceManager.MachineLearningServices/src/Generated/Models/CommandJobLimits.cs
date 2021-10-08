// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Command Job limit class. </summary>
    public partial class CommandJobLimits : JobLimits
    {
        /// <summary> Initializes a new instance of CommandJobLimits. </summary>
        public CommandJobLimits()
        {
            JobLimitsType = JobLimitsType.Command;
        }

        /// <summary> Initializes a new instance of CommandJobLimits. </summary>
        /// <param name="jobLimitsType"> Joblimit type. </param>
        /// <param name="timeout"> The max run duration in ISO 8601 format, after which the job will be cancelled. Only supports duration with precision as low as Seconds. </param>
        internal CommandJobLimits(JobLimitsType jobLimitsType, TimeSpan? timeout) : base(jobLimitsType, timeout)
        {
            JobLimitsType = jobLimitsType;
        }
    }
}
