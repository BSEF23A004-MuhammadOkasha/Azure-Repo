// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Represents a server to be updated. </summary>
    public partial class PostgreSqlFlexibleServerPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerPatch"/>. </summary>
        public PostgreSqlFlexibleServerPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerPatch"/>. </summary>
        /// <param name="sku"> The SKU (pricing tier) of the server. </param>
        /// <param name="identity"> Describes the identity of the application. </param>
        /// <param name="tags"> Application-specific metadata in the form of key-value pairs. </param>
        /// <param name="location"> The location the resource resides in. </param>
        /// <param name="administratorLoginPassword"> The password of the administrator login. </param>
        /// <param name="version"> PostgreSQL Server version. </param>
        /// <param name="storage"> Storage properties of a server. </param>
        /// <param name="backup"> Backup properties of a server. </param>
        /// <param name="highAvailability"> High availability properties of a server. </param>
        /// <param name="maintenanceWindow"> Maintenance window properties of a server. </param>
        /// <param name="authConfig"> AuthConfig properties of a server. </param>
        /// <param name="dataEncryption"> Data encryption properties of a server. </param>
        /// <param name="createMode"> The mode to update a new PostgreSQL server. </param>
        /// <param name="replicationRole"> Replication role of the server. </param>
        /// <param name="network"> Network properties of a server. These are required to be passed only in case if server is a private access server. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFlexibleServerPatch(PostgreSqlFlexibleServerSku sku, PostgreSqlFlexibleServerUserAssignedIdentity identity, IDictionary<string, string> tags, AzureLocation? location, string administratorLoginPassword, PostgreSqlFlexibleServerVersion? version, PostgreSqlFlexibleServerStorage storage, PostgreSqlFlexibleServerBackupProperties backup, PostgreSqlFlexibleServerHighAvailability highAvailability, PostgreSqlFlexibleServerMaintenanceWindow maintenanceWindow, PostgreSqlFlexibleServerAuthConfig authConfig, PostgreSqlFlexibleServerDataEncryption dataEncryption, PostgreSqlFlexibleServerCreateModeForUpdate? createMode, PostgreSqlFlexibleServerReplicationRole? replicationRole, PostgreSqlFlexibleServerNetwork network, Dictionary<string, BinaryData> rawData)
        {
            Sku = sku;
            Identity = identity;
            Tags = tags;
            Location = location;
            AdministratorLoginPassword = administratorLoginPassword;
            Version = version;
            Storage = storage;
            Backup = backup;
            HighAvailability = highAvailability;
            MaintenanceWindow = maintenanceWindow;
            AuthConfig = authConfig;
            DataEncryption = dataEncryption;
            CreateMode = createMode;
            ReplicationRole = replicationRole;
            Network = network;
            _rawData = rawData;
        }

        /// <summary> The SKU (pricing tier) of the server. </summary>
        public PostgreSqlFlexibleServerSku Sku { get; set; }
        /// <summary> Describes the identity of the application. </summary>
        public PostgreSqlFlexibleServerUserAssignedIdentity Identity { get; set; }
        /// <summary> Application-specific metadata in the form of key-value pairs. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The location the resource resides in. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The password of the administrator login. </summary>
        public string AdministratorLoginPassword { get; set; }
        /// <summary> PostgreSQL Server version. </summary>
        public PostgreSqlFlexibleServerVersion? Version { get; set; }
        /// <summary> Storage properties of a server. </summary>
        public PostgreSqlFlexibleServerStorage Storage { get; set; }
        /// <summary> Backup properties of a server. </summary>
        public PostgreSqlFlexibleServerBackupProperties Backup { get; set; }
        /// <summary> High availability properties of a server. </summary>
        public PostgreSqlFlexibleServerHighAvailability HighAvailability { get; set; }
        /// <summary> Maintenance window properties of a server. </summary>
        public PostgreSqlFlexibleServerMaintenanceWindow MaintenanceWindow { get; set; }
        /// <summary> AuthConfig properties of a server. </summary>
        public PostgreSqlFlexibleServerAuthConfig AuthConfig { get; set; }
        /// <summary> Data encryption properties of a server. </summary>
        public PostgreSqlFlexibleServerDataEncryption DataEncryption { get; set; }
        /// <summary> The mode to update a new PostgreSQL server. </summary>
        public PostgreSqlFlexibleServerCreateModeForUpdate? CreateMode { get; set; }
        /// <summary> Replication role of the server. </summary>
        public PostgreSqlFlexibleServerReplicationRole? ReplicationRole { get; set; }
        /// <summary> Network properties of a server. These are required to be passed only in case if server is a private access server. </summary>
        public PostgreSqlFlexibleServerNetwork Network { get; set; }
    }
}
