// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> Parameters allowed to update for a server. </summary>
    public partial class PostgreSqlServerPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerPatch"/>. </summary>
        public PostgreSqlServerPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerPatch"/>. </summary>
        /// <param name="identity"> The Azure Active Directory identity of the server. Current supported identity types: SystemAssigned. </param>
        /// <param name="sku"> The SKU (pricing tier) of the server. </param>
        /// <param name="tags"> Application-specific metadata in the form of key-value pairs. </param>
        /// <param name="storageProfile"> Storage profile of a server. </param>
        /// <param name="administratorLoginPassword"> The password of the administrator login. </param>
        /// <param name="version"> The version of a server. </param>
        /// <param name="sslEnforcement"> Enable ssl enforcement or not when connect to server. </param>
        /// <param name="minimalTlsVersion"> Enforce a minimal Tls version for the server. </param>
        /// <param name="publicNetworkAccess"> Whether or not public network access is allowed for this server. Value is optional but if passed in, must be 'Enabled' or 'Disabled'. </param>
        /// <param name="replicationRole"> The replication role of the server. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlServerPatch(ManagedServiceIdentity identity, PostgreSqlSku sku, IDictionary<string, string> tags, PostgreSqlStorageProfile storageProfile, string administratorLoginPassword, PostgreSqlServerVersion? version, PostgreSqlSslEnforcementEnum? sslEnforcement, PostgreSqlMinimalTlsVersionEnum? minimalTlsVersion, PostgreSqlPublicNetworkAccessEnum? publicNetworkAccess, string replicationRole, Dictionary<string, BinaryData> rawData)
        {
            Identity = identity;
            Sku = sku;
            Tags = tags;
            StorageProfile = storageProfile;
            AdministratorLoginPassword = administratorLoginPassword;
            Version = version;
            SslEnforcement = sslEnforcement;
            MinimalTlsVersion = minimalTlsVersion;
            PublicNetworkAccess = publicNetworkAccess;
            ReplicationRole = replicationRole;
            _rawData = rawData;
        }

        /// <summary> The Azure Active Directory identity of the server. Current supported identity types: SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The SKU (pricing tier) of the server. </summary>
        public PostgreSqlSku Sku { get; set; }
        /// <summary> Application-specific metadata in the form of key-value pairs. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Storage profile of a server. </summary>
        public PostgreSqlStorageProfile StorageProfile { get; set; }
        /// <summary> The password of the administrator login. </summary>
        public string AdministratorLoginPassword { get; set; }
        /// <summary> The version of a server. </summary>
        public PostgreSqlServerVersion? Version { get; set; }
        /// <summary> Enable ssl enforcement or not when connect to server. </summary>
        public PostgreSqlSslEnforcementEnum? SslEnforcement { get; set; }
        /// <summary> Enforce a minimal Tls version for the server. </summary>
        public PostgreSqlMinimalTlsVersionEnum? MinimalTlsVersion { get; set; }
        /// <summary> Whether or not public network access is allowed for this server. Value is optional but if passed in, must be 'Enabled' or 'Disabled'. </summary>
        public PostgreSqlPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }
        /// <summary> The replication role of the server. </summary>
        public string ReplicationRole { get; set; }
    }
}
