// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningDeploymentResourceConfiguration. </summary>
    public partial class MachineLearningDeploymentResourceConfiguration : MachineLearningResourceConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningDeploymentResourceConfiguration"/>. </summary>
        public MachineLearningDeploymentResourceConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningDeploymentResourceConfiguration"/>. </summary>
        /// <param name="instanceCount"> Optional number of instances or nodes used by the compute target. </param>
        /// <param name="instanceType"> Optional type of VM used as supported by the compute target. </param>
        /// <param name="properties"> Additional properties bag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningDeploymentResourceConfiguration(int? instanceCount, string instanceType, IDictionary<string, BinaryData> properties, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceCount, instanceType, properties, serializedAdditionalRawData)
        {
        }
    }
}
