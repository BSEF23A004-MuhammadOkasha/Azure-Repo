// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of connection states snapshots. </summary>
    public partial class ConnectionMonitorQueryResult
    {
        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorQueryResult"/>. </summary>
        internal ConnectionMonitorQueryResult()
        {
            States = new ChangeTrackingList<ConnectionStateSnapshot>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorQueryResult"/>. </summary>
        /// <param name="sourceStatus"> Status of connection monitor source. </param>
        /// <param name="states"> Information about connection states. </param>
        internal ConnectionMonitorQueryResult(ConnectionMonitorSourceStatus? sourceStatus, IReadOnlyList<ConnectionStateSnapshot> states)
        {
            SourceStatus = sourceStatus;
            States = states;
        }

        /// <summary> Status of connection monitor source. </summary>
        public ConnectionMonitorSourceStatus? SourceStatus { get; }
        /// <summary> Information about connection states. </summary>
        public IReadOnlyList<ConnectionStateSnapshot> States { get; }
    }
}
