// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The list attached database configurations operation response. </summary>
    internal partial class SynapseAttachedDatabaseConfigurationListResult
    {
        /// <summary> Initializes a new instance of SynapseAttachedDatabaseConfigurationListResult. </summary>
        internal SynapseAttachedDatabaseConfigurationListResult()
        {
            Value = new ChangeTrackingList<SynapseAttachedDatabaseConfigurationData>();
        }

        /// <summary> Initializes a new instance of SynapseAttachedDatabaseConfigurationListResult. </summary>
        /// <param name="value"> The list of attached database configurations. </param>
        internal SynapseAttachedDatabaseConfigurationListResult(IReadOnlyList<SynapseAttachedDatabaseConfigurationData> value)
        {
            Value = value;
        }

        /// <summary> The list of attached database configurations. </summary>
        public IReadOnlyList<SynapseAttachedDatabaseConfigurationData> Value { get; }
    }
}
