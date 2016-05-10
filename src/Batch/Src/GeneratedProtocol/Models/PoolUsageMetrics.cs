// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Usage metrics for a pool across an aggregation interval.
    /// </summary>
    public partial class PoolUsageMetrics
    {
        /// <summary>
        /// Initializes a new instance of the PoolUsageMetrics class.
        /// </summary>
        public PoolUsageMetrics() { }

        /// <summary>
        /// Initializes a new instance of the PoolUsageMetrics class.
        /// </summary>
        public PoolUsageMetrics(string poolId, DateTime startTime, DateTime endTime, string vmSize, double totalCoreHours, double dataIngressGiB, double dataEgressGiB)
        {
            PoolId = poolId;
            StartTime = startTime;
            EndTime = endTime;
            VmSize = vmSize;
            TotalCoreHours = totalCoreHours;
            DataIngressGiB = dataIngressGiB;
            DataEgressGiB = dataEgressGiB;
        }

        /// <summary>
        /// The id of the pool whose metrics are being aggregated.
        /// </summary>
        [JsonProperty(PropertyName = "poolId")]
        public string PoolId { get; set; }

        /// <summary>
        /// The start time of the aggregation interval.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The end time of the aggregation interval.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// The size of virtual machines in the pool. All VMs in a pool are
        /// the same size.
        /// </summary>
        [JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// The total core hours used in the pool during this aggregation
        /// interval.
        /// </summary>
        [JsonProperty(PropertyName = "totalCoreHours")]
        public double TotalCoreHours { get; set; }

        /// <summary>
        /// The cross data center network ingress in GiB to the pool during
        /// this interval.
        /// </summary>
        [JsonProperty(PropertyName = "dataIngressGiB")]
        public double DataIngressGiB { get; set; }

        /// <summary>
        /// The cross data center network egress in GiB from the pool during
        /// this interval.
        /// </summary>
        [JsonProperty(PropertyName = "dataEgressGiB")]
        public double DataEgressGiB { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (PoolId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PoolId");
            }
            if (VmSize == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VmSize");
            }
        }
    }
}
