// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The response for the operation to get regional usages for a subscription. </summary>
    internal partial class UsagesListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UsagesListResult"/>. </summary>
        internal UsagesListResult()
        {
            Value = new ChangeTrackingList<HDInsightUsage>();
        }

        /// <summary> Initializes a new instance of <see cref="UsagesListResult"/>. </summary>
        /// <param name="value"> The list of usages. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UsagesListResult(IReadOnlyList<HDInsightUsage> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The list of usages. </summary>
        public IReadOnlyList<HDInsightUsage> Value { get; }
    }
}
