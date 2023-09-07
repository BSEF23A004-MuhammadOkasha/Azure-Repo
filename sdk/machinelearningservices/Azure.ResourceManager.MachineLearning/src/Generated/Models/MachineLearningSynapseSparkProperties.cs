// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningSynapseSparkProperties. </summary>
    public partial class MachineLearningSynapseSparkProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningSynapseSparkProperties"/>. </summary>
        public MachineLearningSynapseSparkProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningSynapseSparkProperties"/>. </summary>
        /// <param name="autoScaleProperties"> Auto scale properties. </param>
        /// <param name="autoPauseProperties"> Auto pause properties. </param>
        /// <param name="sparkVersion"> Spark version. </param>
        /// <param name="nodeCount"> The number of compute nodes currently assigned to the compute. </param>
        /// <param name="nodeSize"> Node size. </param>
        /// <param name="nodeSizeFamily"> Node size family. </param>
        /// <param name="subscriptionId"> Azure subscription identifier. </param>
        /// <param name="resourceGroup"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="poolName"> Pool name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningSynapseSparkProperties(MachineLearningAutoScaleProperties autoScaleProperties, MachineLearningAutoPauseProperties autoPauseProperties, string sparkVersion, int? nodeCount, string nodeSize, string nodeSizeFamily, string subscriptionId, string resourceGroup, string workspaceName, string poolName, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AutoScaleProperties = autoScaleProperties;
            AutoPauseProperties = autoPauseProperties;
            SparkVersion = sparkVersion;
            NodeCount = nodeCount;
            NodeSize = nodeSize;
            NodeSizeFamily = nodeSizeFamily;
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
            WorkspaceName = workspaceName;
            PoolName = poolName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Auto scale properties. </summary>
        public MachineLearningAutoScaleProperties AutoScaleProperties { get; set; }
        /// <summary> Auto pause properties. </summary>
        public MachineLearningAutoPauseProperties AutoPauseProperties { get; set; }
        /// <summary> Spark version. </summary>
        public string SparkVersion { get; set; }
        /// <summary> The number of compute nodes currently assigned to the compute. </summary>
        public int? NodeCount { get; set; }
        /// <summary> Node size. </summary>
        public string NodeSize { get; set; }
        /// <summary> Node size family. </summary>
        public string NodeSizeFamily { get; set; }
        /// <summary> Azure subscription identifier. </summary>
        public string SubscriptionId { get; set; }
        /// <summary> Name of the resource group in which workspace is located. </summary>
        public string ResourceGroup { get; set; }
        /// <summary> Name of Azure Machine Learning workspace. </summary>
        public string WorkspaceName { get; set; }
        /// <summary> Pool name. </summary>
        public string PoolName { get; set; }
    }
}
