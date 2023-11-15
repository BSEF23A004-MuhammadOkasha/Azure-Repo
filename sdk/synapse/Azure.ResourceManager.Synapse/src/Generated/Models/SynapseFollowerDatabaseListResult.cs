// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The list Kusto database principals operation response. </summary>
    internal partial class SynapseFollowerDatabaseListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SynapseFollowerDatabaseListResult"/>. </summary>
        internal SynapseFollowerDatabaseListResult()
        {
            Value = new ChangeTrackingList<SynapseFollowerDatabaseDefinition>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseFollowerDatabaseListResult"/>. </summary>
        /// <param name="value"> The list of follower database result. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseFollowerDatabaseListResult(IReadOnlyList<SynapseFollowerDatabaseDefinition> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of follower database result. </summary>
        public IReadOnlyList<SynapseFollowerDatabaseDefinition> Value { get; }
    }
}
