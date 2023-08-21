// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The list Kusto pools operation response. </summary>
    internal partial class KustoPoolListResult
    {
        /// <summary> Initializes a new instance of KustoPoolListResult. </summary>
        internal KustoPoolListResult()
        {
            Value = new ChangeTrackingList<SynapseKustoPoolData>();
        }

        /// <summary> Initializes a new instance of KustoPoolListResult. </summary>
        /// <param name="value"> The list of Kusto pools. </param>
        internal KustoPoolListResult(IReadOnlyList<SynapseKustoPoolData> value)
        {
            Value = value;
        }

        /// <summary> The list of Kusto pools. </summary>
        public IReadOnlyList<SynapseKustoPoolData> Value { get; }
    }
}
