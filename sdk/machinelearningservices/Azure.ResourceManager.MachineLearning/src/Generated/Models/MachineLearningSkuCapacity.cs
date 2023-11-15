// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> SKU capacity information. </summary>
    public partial class MachineLearningSkuCapacity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningSkuCapacity"/>. </summary>
        internal MachineLearningSkuCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningSkuCapacity"/>. </summary>
        /// <param name="default"> Gets or sets the default capacity. </param>
        /// <param name="maximum"> Gets or sets the maximum. </param>
        /// <param name="minimum"> Gets or sets the minimum. </param>
        /// <param name="scaleType"> Gets or sets the type of the scale. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningSkuCapacity(int? @default, int? maximum, int? minimum, MachineLearningSkuScaleType? scaleType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Default = @default;
            Maximum = maximum;
            Minimum = minimum;
            ScaleType = scaleType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the default capacity. </summary>
        public int? Default { get; }
        /// <summary> Gets or sets the maximum. </summary>
        public int? Maximum { get; }
        /// <summary> Gets or sets the minimum. </summary>
        public int? Minimum { get; }
        /// <summary> Gets or sets the type of the scale. </summary>
        public MachineLearningSkuScaleType? ScaleType { get; }
    }
}
