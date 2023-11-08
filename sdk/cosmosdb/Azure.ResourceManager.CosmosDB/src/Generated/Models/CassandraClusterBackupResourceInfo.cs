// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> A restorable backup of a Cassandra cluster. </summary>
    public partial class CassandraClusterBackupResourceInfo
    {
        /// <summary> Initializes a new instance of CassandraClusterBackupResourceInfo. </summary>
        internal CassandraClusterBackupResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of CassandraClusterBackupResourceInfo. </summary>
        /// <param name="backupId"> The unique identifier of backup. </param>
        /// <param name="backupState"> The current state of the backup. </param>
        /// <param name="backupStartTimestamp"> The time at which the backup process begins. </param>
        /// <param name="backupStopTimestamp"> The time at which the backup process ends. </param>
        /// <param name="backupExpiryTimestamp"> The time at which the backup will expire. </param>
        internal CassandraClusterBackupResourceInfo(string backupId, CassandraClusterBackupState? backupState, DateTimeOffset? backupStartTimestamp, DateTimeOffset? backupStopTimestamp, DateTimeOffset? backupExpiryTimestamp)
        {
            BackupId = backupId;
            BackupState = backupState;
            BackupStartTimestamp = backupStartTimestamp;
            BackupStopTimestamp = backupStopTimestamp;
            BackupExpiryTimestamp = backupExpiryTimestamp;
        }

        /// <summary> The unique identifier of backup. </summary>
        public string BackupId { get; }
        /// <summary> The current state of the backup. </summary>
        public CassandraClusterBackupState? BackupState { get; }
        /// <summary> The time at which the backup process begins. </summary>
        public DateTimeOffset? BackupStartTimestamp { get; }
        /// <summary> The time at which the backup process ends. </summary>
        public DateTimeOffset? BackupStopTimestamp { get; }
        /// <summary> The time at which the backup will expire. </summary>
        public DateTimeOffset? BackupExpiryTimestamp { get; }
    }
}
