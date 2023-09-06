// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The load-based autoscale request parameters. </summary>
    public partial class HDInsightAutoScaleCapacity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightAutoScaleCapacity"/>. </summary>
        public HDInsightAutoScaleCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightAutoScaleCapacity"/>. </summary>
        /// <param name="minInstanceCount"> The minimum instance count of the cluster. </param>
        /// <param name="maxInstanceCount"> The maximum instance count of the cluster. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightAutoScaleCapacity(int? minInstanceCount, int? maxInstanceCount, Dictionary<string, BinaryData> rawData)
        {
            MinInstanceCount = minInstanceCount;
            MaxInstanceCount = maxInstanceCount;
            _rawData = rawData;
        }

        /// <summary> The minimum instance count of the cluster. </summary>
        public int? MinInstanceCount { get; set; }
        /// <summary> The maximum instance count of the cluster. </summary>
        public int? MaxInstanceCount { get; set; }
    }
}
