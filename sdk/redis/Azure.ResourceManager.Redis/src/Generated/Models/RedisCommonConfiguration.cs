// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value etc. </summary>
    public partial class RedisCommonConfiguration
    {
        /// <summary> Initializes a new instance of RedisCommonConfiguration. </summary>
        public RedisCommonConfiguration()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of RedisCommonConfiguration. </summary>
        /// <param name="rdbBackupEnabled"> Specifies whether the rdb backup is enabled. </param>
        /// <param name="rdbBackupFrequency"> Specifies the frequency for creating rdb backup. </param>
        /// <param name="rdbBackupMaxSnapshotCount"> Specifies the maximum number of snapshots for rdb backup. </param>
        /// <param name="rdbStorageConnectionString"> The storage account connection string for storing rdb file. </param>
        /// <param name="aofBackupEnabled"> Specifies whether the aof backup is enabled. </param>
        /// <param name="aofStorageConnectionString0"> First storage account connection string. </param>
        /// <param name="aofStorageConnectionString1"> Second storage account connection string. </param>
        /// <param name="maxFragmentationMemoryReserved"> Value in megabytes reserved for fragmentation per shard. </param>
        /// <param name="maxMemoryPolicy"> The eviction strategy used when your data won&apos;t fit within its memory limit. </param>
        /// <param name="maxMemoryReserved"> Value in megabytes reserved for non-cache usage per shard e.g. failover. </param>
        /// <param name="maxMemoryDelta"> Value in megabytes reserved for non-cache usage per shard e.g. failover. </param>
        /// <param name="maxClients"> The max clients config. </param>
        /// <param name="preferredDataArchiveAuthMethod"> Preferred auth method to communicate to storage account used for data archive, specify SAS or ManagedIdentity, default value is SAS. </param>
        /// <param name="preferredDataPersistenceAuthMethod"> Preferred auth method to communicate to storage account used for data persistence, specify SAS or ManagedIdentity, default value is SAS. </param>
        /// <param name="zonalConfiguration"> Zonal Configuration. </param>
        /// <param name="authNotRequired"> Specifies whether the authentication is disabled. Setting this property is highly discouraged from security point of view. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal RedisCommonConfiguration(string rdbBackupEnabled, string rdbBackupFrequency, string rdbBackupMaxSnapshotCount, string rdbStorageConnectionString, string aofBackupEnabled, string aofStorageConnectionString0, string aofStorageConnectionString1, string maxFragmentationMemoryReserved, string maxMemoryPolicy, string maxMemoryReserved, string maxMemoryDelta, string maxClients, string preferredDataArchiveAuthMethod, string preferredDataPersistenceAuthMethod, string zonalConfiguration, string authNotRequired, IDictionary<string, BinaryData> additionalProperties)
        {
            RdbBackupEnabled = rdbBackupEnabled;
            RdbBackupFrequency = rdbBackupFrequency;
            RdbBackupMaxSnapshotCount = rdbBackupMaxSnapshotCount;
            RdbStorageConnectionString = rdbStorageConnectionString;
            AofBackupEnabled = aofBackupEnabled;
            AofStorageConnectionString0 = aofStorageConnectionString0;
            AofStorageConnectionString1 = aofStorageConnectionString1;
            MaxFragmentationMemoryReserved = maxFragmentationMemoryReserved;
            MaxMemoryPolicy = maxMemoryPolicy;
            MaxMemoryReserved = maxMemoryReserved;
            MaxMemoryDelta = maxMemoryDelta;
            MaxClients = maxClients;
            PreferredDataArchiveAuthMethod = preferredDataArchiveAuthMethod;
            PreferredDataPersistenceAuthMethod = preferredDataPersistenceAuthMethod;
            ZonalConfiguration = zonalConfiguration;
            AuthNotRequired = authNotRequired;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Specifies whether the rdb backup is enabled. </summary>
        public string RdbBackupEnabled { get; set; }
        /// <summary> Specifies the frequency for creating rdb backup. </summary>
        public string RdbBackupFrequency { get; set; }
        /// <summary> Specifies the maximum number of snapshots for rdb backup. </summary>
        public string RdbBackupMaxSnapshotCount { get; set; }
        /// <summary> The storage account connection string for storing rdb file. </summary>
        public string RdbStorageConnectionString { get; set; }
        /// <summary> Specifies whether the aof backup is enabled. </summary>
        public string AofBackupEnabled { get; set; }
        /// <summary> First storage account connection string. </summary>
        public string AofStorageConnectionString0 { get; set; }
        /// <summary> Second storage account connection string. </summary>
        public string AofStorageConnectionString1 { get; set; }
        /// <summary> Value in megabytes reserved for fragmentation per shard. </summary>
        public string MaxFragmentationMemoryReserved { get; set; }
        /// <summary> The eviction strategy used when your data won&apos;t fit within its memory limit. </summary>
        public string MaxMemoryPolicy { get; set; }
        /// <summary> Value in megabytes reserved for non-cache usage per shard e.g. failover. </summary>
        public string MaxMemoryReserved { get; set; }
        /// <summary> Value in megabytes reserved for non-cache usage per shard e.g. failover. </summary>
        public string MaxMemoryDelta { get; set; }
        /// <summary> The max clients config. </summary>
        public string MaxClients { get; }
        /// <summary> Preferred auth method to communicate to storage account used for data archive, specify SAS or ManagedIdentity, default value is SAS. </summary>
        public string PreferredDataArchiveAuthMethod { get; }
        /// <summary> Preferred auth method to communicate to storage account used for data persistence, specify SAS or ManagedIdentity, default value is SAS. </summary>
        public string PreferredDataPersistenceAuthMethod { get; }
        /// <summary> Zonal Configuration. </summary>
        public string ZonalConfiguration { get; }
        /// <summary> Specifies whether the authentication is disabled. Setting this property is highly discouraged from security point of view. </summary>
        public string AuthNotRequired { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
