// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The response to a list partition metrics request. </summary>
    public partial class PartitionMetricListResult
    {
        /// <summary> Initializes a new instance of PartitionMetricListResult. </summary>
        internal PartitionMetricListResult()
        {
            Value = new ChangeTrackingList<PartitionMetric>();
        }

        /// <summary> Initializes a new instance of PartitionMetricListResult. </summary>
        /// <param name="value"> The list of partition-level metrics for the account. </param>
        internal PartitionMetricListResult(IReadOnlyList<PartitionMetric> value)
        {
            Value = value;
        }

        /// <summary> The list of partition-level metrics for the account. </summary>
        public IReadOnlyList<PartitionMetric> Value { get; }
    }
}
