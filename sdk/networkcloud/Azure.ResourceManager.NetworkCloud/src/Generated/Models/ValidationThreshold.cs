// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ValidationThreshold indicates allowed machine and node hardware and deployment failures. </summary>
    public partial class ValidationThreshold
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ValidationThreshold"/>. </summary>
        /// <param name="grouping"> Selection of how the type evaluation is applied to the cluster calculation. </param>
        /// <param name="thresholdType"> Selection of how the threshold should be evaluated. </param>
        /// <param name="value"> The numeric threshold value. </param>
        public ValidationThreshold(ValidationThresholdGrouping grouping, ValidationThresholdType thresholdType, long value)
        {
            Grouping = grouping;
            ThresholdType = thresholdType;
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="ValidationThreshold"/>. </summary>
        /// <param name="grouping"> Selection of how the type evaluation is applied to the cluster calculation. </param>
        /// <param name="thresholdType"> Selection of how the threshold should be evaluated. </param>
        /// <param name="value"> The numeric threshold value. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ValidationThreshold(ValidationThresholdGrouping grouping, ValidationThresholdType thresholdType, long value, Dictionary<string, BinaryData> rawData)
        {
            Grouping = grouping;
            ThresholdType = thresholdType;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ValidationThreshold"/> for deserialization. </summary>
        internal ValidationThreshold()
        {
        }

        /// <summary> Selection of how the type evaluation is applied to the cluster calculation. </summary>
        public ValidationThresholdGrouping Grouping { get; set; }
        /// <summary> Selection of how the threshold should be evaluated. </summary>
        public ValidationThresholdType ThresholdType { get; set; }
        /// <summary> The numeric threshold value. </summary>
        public long Value { get; set; }
    }
}
