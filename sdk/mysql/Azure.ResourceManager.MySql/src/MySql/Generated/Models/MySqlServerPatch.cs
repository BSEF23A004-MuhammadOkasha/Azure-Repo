// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> Parameters allowed to update for a server. </summary>
    public partial class MySqlServerPatch
    {
        /// <summary> Initializes a new instance of MySqlServerPatch. </summary>
        public MySqlServerPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The Azure Active Directory identity of the server. </summary>
        public ResourceIdentity Identity { get; set; }
        /// <summary> The SKU (pricing tier) of the server. </summary>
        public MySqlSku Sku { get; set; }
        /// <summary> Application-specific metadata in the form of key-value pairs. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Storage profile of a server. </summary>
        public MySqlStorageProfile StorageProfile { get; set; }
        /// <summary> The password of the administrator login. </summary>
        public string AdministratorLoginPassword { get; set; }
        /// <summary> The version of a server. </summary>
        public MySqlServerVersion? Version { get; set; }
        /// <summary> Enable ssl enforcement or not when connect to server. </summary>
        public MySqlSslEnforcementEnum? SslEnforcement { get; set; }
        /// <summary> Enforce a minimal Tls version for the server. </summary>
        public MySqlMinimalTlsVersionEnum? MinimalTlsVersion { get; set; }
        /// <summary> Whether or not public network access is allowed for this server. Value is optional but if passed in, must be &apos;Enabled&apos; or &apos;Disabled&apos;. </summary>
        public MySqlPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }
        /// <summary> The replication role of the server. </summary>
        public string ReplicationRole { get; set; }
    }
}
