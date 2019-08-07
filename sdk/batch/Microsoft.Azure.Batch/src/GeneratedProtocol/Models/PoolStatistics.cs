// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains utilization and resource usage statistics for the lifetime of
    /// a Pool.
    /// </summary>
    public partial class PoolStatistics
    {
        /// <summary>
        /// Initializes a new instance of the PoolStatistics class.
        /// </summary>
        public PoolStatistics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PoolStatistics class.
        /// </summary>
        /// <param name="url">The URL for the statistics.</param>
        /// <param name="startTime">The start time of the time range covered by
        /// the statistics.</param>
        /// <param name="lastUpdateTime">The time at which the statistics were
        /// last updated. All statistics are limited to the range between
        /// startTime and lastUpdateTime.</param>
        /// <param name="usageStats">Statistics related to Pool usage, such as
        /// the amount of core-time used.</param>
        /// <param name="resourceStats">Statistics related to resource
        /// consumption by Compute Nodes in the Pool.</param>
        public PoolStatistics(string url, System.DateTime startTime, System.DateTime lastUpdateTime, UsageStatistics usageStats = default(UsageStatistics), ResourceStatistics resourceStats = default(ResourceStatistics))
        {
            Url = url;
            StartTime = startTime;
            LastUpdateTime = lastUpdateTime;
            UsageStats = usageStats;
            ResourceStats = resourceStats;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL for the statistics.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the start time of the time range covered by the
        /// statistics.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the statistics were last updated.
        /// All statistics are limited to the range between startTime and
        /// lastUpdateTime.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateTime")]
        public System.DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// Gets or sets statistics related to Pool usage, such as the amount
        /// of core-time used.
        /// </summary>
        [JsonProperty(PropertyName = "usageStats")]
        public UsageStatistics UsageStats { get; set; }

        /// <summary>
        /// Gets or sets statistics related to resource consumption by Compute
        /// Nodes in the Pool.
        /// </summary>
        [JsonProperty(PropertyName = "resourceStats")]
        public ResourceStatistics ResourceStats { get; set; }

    }
}
