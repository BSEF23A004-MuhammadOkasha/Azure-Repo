// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The response from the List Snapshots operation. </summary>
    internal partial class AgentPoolSnapshotListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AgentPoolSnapshotListResult"/>. </summary>
        internal AgentPoolSnapshotListResult()
        {
            Value = new ChangeTrackingList<AgentPoolSnapshotData>();
        }

        /// <summary> Initializes a new instance of <see cref="AgentPoolSnapshotListResult"/>. </summary>
        /// <param name="value"> The list of snapshots. </param>
        /// <param name="nextLink"> The URL to get the next set of snapshot results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AgentPoolSnapshotListResult(IReadOnlyList<AgentPoolSnapshotData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of snapshots. </summary>
        public IReadOnlyList<AgentPoolSnapshotData> Value { get; }
        /// <summary> The URL to get the next set of snapshot results. </summary>
        public string NextLink { get; }
    }
}
