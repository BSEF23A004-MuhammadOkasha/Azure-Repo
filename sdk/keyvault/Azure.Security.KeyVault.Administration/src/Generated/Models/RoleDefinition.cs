// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration.Models
{
    /// <summary> Role definition. </summary>
    public partial class RoleDefinition
    {
        /// <summary> Initializes a new instance of RoleDefinition. </summary>
        internal RoleDefinition()
        {
            Permissions = new ChangeTrackingList<KeyVaultPermission>();
            AssignableScopes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of RoleDefinition. </summary>
        /// <param name="id"> The role definition ID. </param>
        /// <param name="name"> The role definition name. </param>
        /// <param name="type"> The role definition type. </param>
        /// <param name="roleName"> The role name. </param>
        /// <param name="description"> The role definition description. </param>
        /// <param name="roleType"> The role type. </param>
        /// <param name="permissions"> Role definition permissions. </param>
        /// <param name="assignableScopes"> Role definition assignable scopes. </param>
        internal RoleDefinition(string id, string name, string type, string roleName, string description, string roleType, IReadOnlyList<KeyVaultPermission> permissions, IReadOnlyList<string> assignableScopes)
        {
            Id = id;
            Name = name;
            Type = type;
            RoleName = roleName;
            Description = description;
            RoleType = roleType;
            Permissions = permissions;
            AssignableScopes = assignableScopes;
        }

        /// <summary> The role definition ID. </summary>
        public string Id { get; }
        /// <summary> The role definition name. </summary>
        public string Name { get; }
        /// <summary> The role definition type. </summary>
        public string Type { get; }
        /// <summary> The role name. </summary>
        public string RoleName { get; }
        /// <summary> The role definition description. </summary>
        public string Description { get; }
        /// <summary> The role type. </summary>
        public string RoleType { get; }
        /// <summary> Role definition permissions. </summary>
        public IReadOnlyList<KeyVaultPermission> Permissions { get; }
        /// <summary> Role definition assignable scopes. </summary>
        public IReadOnlyList<string> AssignableScopes { get; }
    }
}
