// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The workspace managed identity. </summary>
    public partial class ManagedIdentity
    {
        /// <summary> Initializes a new instance of ManagedIdentity. </summary>
        public ManagedIdentity()
        {
        }

        /// <summary> Initializes a new instance of ManagedIdentity. </summary>
        /// <param name="principalId"> The principal ID of the workspace managed identity. </param>
        /// <param name="tenantId"> The tenant ID of the workspace managed identity. </param>
        /// <param name="type"> The type of managed identity for the workspace. </param>
        internal ManagedIdentity(string principalId, Guid? tenantId, ResourceIdentityType? type)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
        }

        /// <summary> The principal ID of the workspace managed identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The tenant ID of the workspace managed identity. </summary>
        public Guid? TenantId { get; }
        /// <summary> The type of managed identity for the workspace. </summary>
        public ResourceIdentityType? Type { get; set; }
    }
}
