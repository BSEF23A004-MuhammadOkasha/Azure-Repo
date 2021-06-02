// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The SuppressConditionPatch. </summary>
    internal partial class SuppressConditionPatch
    {
        /// <summary> Initializes a new instance of SuppressConditionPatch. </summary>
        public SuppressConditionPatch()
        {
        }

        /// <summary> min point number, value range : [1, +∞). </summary>
        public int? MinNumber { get; set; }
        /// <summary> min point ratio, value range : (0, 100]. </summary>
        public double? MinRatio { get; set; }
    }
}
