// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> PyTorch distribution configuration. </summary>
    public partial class PyTorchDistributionConfiguration : MachineLearningDistributionConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="PyTorchDistributionConfiguration"/>. </summary>
        public PyTorchDistributionConfiguration()
        {
            DistributionType = DistributionType.PyTorch;
        }

        /// <summary> Initializes a new instance of <see cref="PyTorchDistributionConfiguration"/>. </summary>
        /// <param name="distributionType"> [Required] Specifies the type of distribution framework. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="processCountPerInstance"> Number of processes per node. </param>
        internal PyTorchDistributionConfiguration(DistributionType distributionType, IDictionary<string, BinaryData> serializedAdditionalRawData, int? processCountPerInstance) : base(distributionType, serializedAdditionalRawData)
        {
            ProcessCountPerInstance = processCountPerInstance;
            DistributionType = distributionType;
        }

        /// <summary> Number of processes per node. </summary>
        public int? ProcessCountPerInstance { get; set; }
    }
}
