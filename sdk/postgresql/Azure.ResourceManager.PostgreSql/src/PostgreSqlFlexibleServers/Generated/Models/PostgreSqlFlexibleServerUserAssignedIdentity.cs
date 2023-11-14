// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Information describing the identities associated with this application. </summary>
    public partial class PostgreSqlFlexibleServerUserAssignedIdentity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerUserAssignedIdentity"/>. </summary>
        /// <param name="identityType"> the types of identities associated with this resource; currently restricted to 'None and UserAssigned'. </param>
        public PostgreSqlFlexibleServerUserAssignedIdentity(PostgreSqlFlexibleServerIdentityType identityType)
        {
            UserAssignedIdentities = new ChangeTrackingDictionary<string, UserAssignedIdentity>();
            IdentityType = identityType;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerUserAssignedIdentity"/>. </summary>
        /// <param name="userAssignedIdentities"> represents user assigned identities map. </param>
        /// <param name="identityType"> the types of identities associated with this resource; currently restricted to 'None and UserAssigned'. </param>
        /// <param name="tenantId"> Tenant id of the server. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFlexibleServerUserAssignedIdentity(IDictionary<string, UserAssignedIdentity> userAssignedIdentities, PostgreSqlFlexibleServerIdentityType identityType, Guid? tenantId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UserAssignedIdentities = userAssignedIdentities;
            IdentityType = identityType;
            TenantId = tenantId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerUserAssignedIdentity"/> for deserialization. </summary>
        internal PostgreSqlFlexibleServerUserAssignedIdentity()
        {
        }

        /// <summary> represents user assigned identities map. </summary>
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; }
        /// <summary> the types of identities associated with this resource; currently restricted to 'None and UserAssigned'. </summary>
        public PostgreSqlFlexibleServerIdentityType IdentityType { get; set; }
        /// <summary> Tenant id of the server. </summary>
        public Guid? TenantId { get; }
    }
}
