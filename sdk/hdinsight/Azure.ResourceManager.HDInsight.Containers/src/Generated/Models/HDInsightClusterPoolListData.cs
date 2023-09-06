// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HDInsight.Containers;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The list cluster pools operation response. </summary>
    internal partial class HDInsightClusterPoolListData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterPoolListData"/>. </summary>
        internal HDInsightClusterPoolListData()
        {
            Value = new ChangeTrackingList<HDInsightClusterPoolData>();
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterPoolListData"/>. </summary>
        /// <param name="value"> The list of cluster pools. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightClusterPoolListData(IReadOnlyList<HDInsightClusterPoolData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of cluster pools. </summary>
        public IReadOnlyList<HDInsightClusterPoolData> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
