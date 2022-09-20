// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Sync Session status object. </summary>
    public partial class ServerEndpointSyncActivityStatus
    {
        /// <summary> Initializes a new instance of ServerEndpointSyncActivityStatus. </summary>
        internal ServerEndpointSyncActivityStatus()
        {
        }

        /// <summary> Initializes a new instance of ServerEndpointSyncActivityStatus. </summary>
        /// <param name="timestamp"> Timestamp when properties were updated. </param>
        /// <param name="perItemErrorCount"> Per item error count. </param>
        /// <param name="appliedItemCount"> Applied item count. </param>
        /// <param name="totalItemCount"> Total item count (if available). </param>
        /// <param name="appliedBytes"> Applied bytes. </param>
        /// <param name="totalBytes"> Total bytes (if available). </param>
        /// <param name="syncMode"> Sync mode. </param>
        /// <param name="sessionMinutesRemaining"> Session minutes remaining (if available). </param>
        internal ServerEndpointSyncActivityStatus(DateTimeOffset? timestamp, long? perItemErrorCount, long? appliedItemCount, long? totalItemCount, long? appliedBytes, long? totalBytes, ServerEndpointSyncMode? syncMode, int? sessionMinutesRemaining)
        {
            Timestamp = timestamp;
            PerItemErrorCount = perItemErrorCount;
            AppliedItemCount = appliedItemCount;
            TotalItemCount = totalItemCount;
            AppliedBytes = appliedBytes;
            TotalBytes = totalBytes;
            SyncMode = syncMode;
            SessionMinutesRemaining = sessionMinutesRemaining;
        }

        /// <summary> Timestamp when properties were updated. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> Per item error count. </summary>
        public long? PerItemErrorCount { get; }
        /// <summary> Applied item count. </summary>
        public long? AppliedItemCount { get; }
        /// <summary> Total item count (if available). </summary>
        public long? TotalItemCount { get; }
        /// <summary> Applied bytes. </summary>
        public long? AppliedBytes { get; }
        /// <summary> Total bytes (if available). </summary>
        public long? TotalBytes { get; }
        /// <summary> Sync mode. </summary>
        public ServerEndpointSyncMode? SyncMode { get; }
        /// <summary> Session minutes remaining (if available). </summary>
        public int? SessionMinutesRemaining { get; }
    }
}
