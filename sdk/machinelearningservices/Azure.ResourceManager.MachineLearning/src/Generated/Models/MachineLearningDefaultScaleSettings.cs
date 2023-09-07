// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningDefaultScaleSettings. </summary>
    public partial class MachineLearningDefaultScaleSettings : MachineLearningOnlineScaleSettings
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningDefaultScaleSettings"/>. </summary>
        public MachineLearningDefaultScaleSettings()
        {
            ScaleType = ScaleType.Default;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningDefaultScaleSettings"/>. </summary>
        /// <param name="scaleType"> [Required] Type of deployment scaling algorithm. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningDefaultScaleSettings(ScaleType scaleType, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(scaleType, serializedAdditionalRawData)
        {
            ScaleType = scaleType;
        }
    }
}
