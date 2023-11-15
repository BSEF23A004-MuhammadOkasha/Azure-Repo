// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The SuppressConditionPatch. </summary>
    internal partial class SuppressConditionPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SuppressConditionPatch"/>. </summary>
        public SuppressConditionPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SuppressConditionPatch"/>. </summary>
        /// <param name="minNumber"> min point number, value range : [1, +∞). </param>
        /// <param name="minRatio"> min point ratio, value range : (0, 100]. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SuppressConditionPatch(int? minNumber, double? minRatio, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MinNumber = minNumber;
            MinRatio = minRatio;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> min point number, value range : [1, +∞). </summary>
        public int? MinNumber { get; set; }
        /// <summary> min point ratio, value range : (0, 100]. </summary>
        public double? MinRatio { get; set; }
    }
}
