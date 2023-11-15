// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownOnlineScaleSettings. </summary>
    internal partial class UnknownOnlineScaleSettings : MachineLearningOnlineScaleSettings
    {
        /// <summary> Initializes a new instance of <see cref="UnknownOnlineScaleSettings"/>. </summary>
        /// <param name="scaleType"> [Required] Type of deployment scaling algorithm. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownOnlineScaleSettings(ScaleType scaleType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(scaleType, serializedAdditionalRawData)
        {
            ScaleType = scaleType;
        }
    }
}
