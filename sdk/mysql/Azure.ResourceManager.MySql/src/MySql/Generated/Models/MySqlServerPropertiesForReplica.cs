// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> The properties to create a new replica. </summary>
    public partial class MySqlServerPropertiesForReplica : MySqlServerPropertiesForCreate
    {
        /// <summary> Initializes a new instance of <see cref="MySqlServerPropertiesForReplica"/>. </summary>
        /// <param name="sourceServerId"> The master server id to create replica from. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceServerId"/> is null. </exception>
        public MySqlServerPropertiesForReplica(ResourceIdentifier sourceServerId)
        {
            Argument.AssertNotNull(sourceServerId, nameof(sourceServerId));

            SourceServerId = sourceServerId;
            CreateMode = MySqlCreateMode.Replica;
        }

        /// <summary> Initializes a new instance of <see cref="MySqlServerPropertiesForReplica"/>. </summary>
        /// <param name="version"> Server version. </param>
        /// <param name="sslEnforcement"> Enable ssl enforcement or not when connect to server. </param>
        /// <param name="minimalTlsVersion"> Enforce a minimal Tls version for the server. </param>
        /// <param name="infrastructureEncryption"> Status showing whether the server enabled infrastructure encryption. </param>
        /// <param name="publicNetworkAccess"> Whether or not public network access is allowed for this server. Value is optional but if passed in, must be 'Enabled' or 'Disabled'. </param>
        /// <param name="storageProfile"> Storage profile of a server. </param>
        /// <param name="createMode"> The mode to create a new server. </param>
        /// <param name="sourceServerId"> The master server id to create replica from. </param>
        internal MySqlServerPropertiesForReplica(MySqlServerVersion? version, MySqlSslEnforcementEnum? sslEnforcement, MySqlMinimalTlsVersionEnum? minimalTlsVersion, MySqlInfrastructureEncryption? infrastructureEncryption, MySqlPublicNetworkAccessEnum? publicNetworkAccess, MySqlStorageProfile storageProfile, MySqlCreateMode createMode, ResourceIdentifier sourceServerId) : base(version, sslEnforcement, minimalTlsVersion, infrastructureEncryption, publicNetworkAccess, storageProfile, createMode)
        {
            SourceServerId = sourceServerId;
            CreateMode = createMode;
        }

        /// <summary> The master server id to create replica from. </summary>
        public ResourceIdentifier SourceServerId { get; }
    }
}
