// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Data flow properties for managed integration runtime. </summary>
    public partial class IntegrationRuntimeDataFlowProperties
    {
        /// <summary> Initializes a new instance of IntegrationRuntimeDataFlowProperties. </summary>
        public IntegrationRuntimeDataFlowProperties()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of IntegrationRuntimeDataFlowProperties. </summary>
        /// <param name="computeType"> Compute type of the cluster which will execute data flow job. </param>
        /// <param name="coreCount"> Core count of the cluster which will execute data flow job. Supported values are: 8, 16, 32, 48, 80, 144 and 272. </param>
        /// <param name="timeToLiveInMinutes"> Time to live (in minutes) setting of the cluster which will execute data flow job. </param>
        /// <param name="cleanup"> Cluster will not be recycled and it will be used in next data flow activity run until TTL (time to live) is reached if this is set as false. Default is true. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal IntegrationRuntimeDataFlowProperties(DataFlowComputeType? computeType, int? coreCount, int? timeToLiveInMinutes, bool? cleanup, IDictionary<string, BinaryData> additionalProperties)
        {
            ComputeType = computeType;
            CoreCount = coreCount;
            TimeToLiveInMinutes = timeToLiveInMinutes;
            Cleanup = cleanup;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Compute type of the cluster which will execute data flow job. </summary>
        public DataFlowComputeType? ComputeType { get; set; }
        /// <summary> Core count of the cluster which will execute data flow job. Supported values are: 8, 16, 32, 48, 80, 144 and 272. </summary>
        public int? CoreCount { get; set; }
        /// <summary> Time to live (in minutes) setting of the cluster which will execute data flow job. </summary>
        public int? TimeToLiveInMinutes { get; set; }
        /// <summary> Cluster will not be recycled and it will be used in next data flow activity run until TTL (time to live) is reached if this is set as false. Default is true. </summary>
        public bool? Cleanup { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
