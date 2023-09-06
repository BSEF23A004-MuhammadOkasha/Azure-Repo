// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The comparison rule. </summary>
    public partial class HDInsightComparisonRule
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightComparisonRule"/>. </summary>
        /// <param name="operator"> The comparison operator. </param>
        /// <param name="threshold"> Threshold setting. </param>
        public HDInsightComparisonRule(HDInsightComparisonOperator @operator, float threshold)
        {
            Operator = @operator;
            Threshold = threshold;
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightComparisonRule"/>. </summary>
        /// <param name="operator"> The comparison operator. </param>
        /// <param name="threshold"> Threshold setting. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightComparisonRule(HDInsightComparisonOperator @operator, float threshold, Dictionary<string, BinaryData> rawData)
        {
            Operator = @operator;
            Threshold = threshold;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightComparisonRule"/> for deserialization. </summary>
        internal HDInsightComparisonRule()
        {
        }

        /// <summary> The comparison operator. </summary>
        public HDInsightComparisonOperator Operator { get; set; }
        /// <summary> Threshold setting. </summary>
        public float Threshold { get; set; }
    }
}
