// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Represents a Slo Usage Metric.
    /// </summary>
    public partial class SloUsageMetricInner : Microsoft.Azure.Management.Resource.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the SloUsageMetricInner class.
        /// </summary>
        public SloUsageMetricInner() { }

        /// <summary>
        /// Initializes a new instance of the SloUsageMetricInner class.
        /// </summary>
        /// <param name="serviceLevelObjective">The serviceLevelObjective for
        /// SLO usage metric. Possible values include: 'Basic', 'S0', 'S1',
        /// 'S2', 'S3', 'P1', 'P2', 'P3'</param>
        /// <param name="serviceLevelObjectiveId">The serviceLevelObjectiveId
        /// for SLO usage metric.</param>
        /// <param name="inRangeTimeRatio">Gets or sets inRangeTimeRatio for
        /// SLO usage metric.</param>
        public SloUsageMetricInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string serviceLevelObjective = default(string), System.Guid? serviceLevelObjectiveId = default(System.Guid?), double? inRangeTimeRatio = default(double?))
            : base(location, id, name, type, tags)
        {
            ServiceLevelObjective = serviceLevelObjective;
            ServiceLevelObjectiveId = serviceLevelObjectiveId;
            InRangeTimeRatio = inRangeTimeRatio;
        }

        /// <summary>
        /// Gets or sets the serviceLevelObjective for SLO usage metric.
        /// Possible values include: 'Basic', 'S0', 'S1', 'S2', 'S3', 'P1',
        /// 'P2', 'P3'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "serviceLevelObjective")]
        public string ServiceLevelObjective { get; set; }

        /// <summary>
        /// Gets or sets the serviceLevelObjectiveId for SLO usage metric.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "serviceLevelObjectiveId")]
        public System.Guid? ServiceLevelObjectiveId { get; set; }

        /// <summary>
        /// Gets or sets inRangeTimeRatio for SLO usage metric.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "inRangeTimeRatio")]
        public double? InRangeTimeRatio { get; set; }

    }
}
