// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownDistributionConfiguration. </summary>
    internal partial class UnknownDistributionConfiguration : MachineLearningDistributionConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="UnknownDistributionConfiguration"/>. </summary>
        /// <param name="distributionType"> [Required] Specifies the type of distribution framework. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownDistributionConfiguration(DistributionType distributionType, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(distributionType, serializedAdditionalRawData)
        {
            DistributionType = distributionType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownDistributionConfiguration"/> for deserialization. </summary>
        internal UnknownDistributionConfiguration()
        {
        }
    }
}
