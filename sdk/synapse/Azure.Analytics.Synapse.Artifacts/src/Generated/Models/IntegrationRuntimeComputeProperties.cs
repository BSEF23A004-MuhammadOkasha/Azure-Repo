// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The compute resource properties for managed integration runtime. </summary>
    public partial class IntegrationRuntimeComputeProperties
    {
        /// <summary> Initializes a new instance of IntegrationRuntimeComputeProperties. </summary>
        public IntegrationRuntimeComputeProperties()
        {
            AdditionalProperties = new Core.ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of IntegrationRuntimeComputeProperties. </summary>
        /// <param name="location"> The location for managed integration runtime. The supported regions could be found on https://docs.microsoft.com/en-us/azure/data-factory/data-factory-data-movement-activities. </param>
        /// <param name="nodeSize"> The node size requirement to managed integration runtime. </param>
        /// <param name="numberOfNodes"> The required number of nodes for managed integration runtime. </param>
        /// <param name="maxParallelExecutionsPerNode"> Maximum parallel executions count per node for managed integration runtime. </param>
        /// <param name="dataFlowProperties"> Data flow properties for managed integration runtime. </param>
        /// <param name="vNetProperties"> VNet properties for managed integration runtime. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal IntegrationRuntimeComputeProperties(string location, string nodeSize, int? numberOfNodes, int? maxParallelExecutionsPerNode, IntegrationRuntimeDataFlowProperties dataFlowProperties, IntegrationRuntimeVNetProperties vNetProperties, IDictionary<string, object> additionalProperties)
        {
            Location = location;
            NodeSize = nodeSize;
            NumberOfNodes = numberOfNodes;
            MaxParallelExecutionsPerNode = maxParallelExecutionsPerNode;
            DataFlowProperties = dataFlowProperties;
            VNetProperties = vNetProperties;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The location for managed integration runtime. The supported regions could be found on https://docs.microsoft.com/en-us/azure/data-factory/data-factory-data-movement-activities. </summary>
        public string Location { get; set; }
        /// <summary> The node size requirement to managed integration runtime. </summary>
        public string NodeSize { get; set; }
        /// <summary> The required number of nodes for managed integration runtime. </summary>
        public int? NumberOfNodes { get; set; }
        /// <summary> Maximum parallel executions count per node for managed integration runtime. </summary>
        public int? MaxParallelExecutionsPerNode { get; set; }
        /// <summary> Data flow properties for managed integration runtime. </summary>
        public IntegrationRuntimeDataFlowProperties DataFlowProperties { get; set; }
        /// <summary> VNet properties for managed integration runtime. </summary>
        public IntegrationRuntimeVNetProperties VNetProperties { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
