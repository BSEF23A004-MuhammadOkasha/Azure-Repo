// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The instance view of a disk restore point. </summary>
    public partial class DiskRestorePointReplicationStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DiskRestorePointReplicationStatus"/>. </summary>
        internal DiskRestorePointReplicationStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DiskRestorePointReplicationStatus"/>. </summary>
        /// <param name="status"> The resource status information. </param>
        /// <param name="completionPercent"> Replication completion percentage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskRestorePointReplicationStatus(InstanceViewStatus status, int? completionPercent, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            CompletionPercent = completionPercent;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource status information. </summary>
        public InstanceViewStatus Status { get; }
        /// <summary> Replication completion percentage. </summary>
        public int? CompletionPercent { get; }
    }
}
