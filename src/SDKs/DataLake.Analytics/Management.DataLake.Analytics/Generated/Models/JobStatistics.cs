// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Analytics;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Data Lake Analytics job execution statistics.
    /// </summary>
    public partial class JobStatistics
    {
        /// <summary>
        /// Initializes a new instance of the JobStatistics class.
        /// </summary>
        public JobStatistics()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobStatistics class.
        /// </summary>
        /// <param name="lastUpdateTimeUtc">the last update time for the
        /// statistics.</param>
        /// <param name="finalizingTimeUtc">the job finalizing start
        /// time.</param>
        /// <param name="stages">the list of stages for the job.</param>
        public JobStatistics(System.DateTimeOffset? lastUpdateTimeUtc = default(System.DateTimeOffset?), System.DateTimeOffset? finalizingTimeUtc = default(System.DateTimeOffset?), IList<JobStatisticsVertexStage> stages = default(IList<JobStatisticsVertexStage>))
        {
            LastUpdateTimeUtc = lastUpdateTimeUtc;
            FinalizingTimeUtc = finalizingTimeUtc;
            Stages = stages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the last update time for the statistics.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateTimeUtc")]
        public System.DateTimeOffset? LastUpdateTimeUtc { get; private set; }

        /// <summary>
        /// Gets the job finalizing start time.
        /// </summary>
        [JsonProperty(PropertyName = "finalizingTimeUtc")]
        public System.DateTimeOffset? FinalizingTimeUtc { get; private set; }

        /// <summary>
        /// Gets the list of stages for the job.
        /// </summary>
        [JsonProperty(PropertyName = "stages")]
        public IList<JobStatisticsVertexStage> Stages { get; private set; }

    }
}
