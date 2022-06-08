// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;

namespace Azure.Security.KeyVault.Administration
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class KeyVaultAdministrationModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Administration.KeyVaultRoleDefinition"/>. </summary>
        /// <param name="id"> The role definition ID. </param>
        /// <param name="name"> The role definition name. </param>
        /// <param name="type"> The role definition type. </param>
        /// <param name="roleName"> The role name. </param>
        /// <param name="description"> The role definition description. </param>
        /// <param name="roleType"> The role type. </param>
        /// <param name="permissions"> Role definition permissions. </param>
        /// <param name="assignableScopes"> Role definition assignable scopes. </param>
        /// <returns> A new <see cref="Administration.KeyVaultRoleDefinition"/> instance for mocking. </returns>
        public static KeyVaultRoleDefinition KeyVaultRoleDefinition(string id = null, string name = null, KeyVaultRoleDefinitionType? type = null, string roleName = null, string description = null, KeyVaultRoleType? roleType = null, IEnumerable<KeyVaultPermission> permissions = null, IEnumerable<KeyVaultRoleScope> assignableScopes = null)
        {
            permissions ??= new List<KeyVaultPermission>();
            assignableScopes ??= new List<KeyVaultRoleScope>();

            return new KeyVaultRoleDefinition(id, name, type, roleName, description, roleType, permissions?.ToList(), assignableScopes?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Administration.KeyVaultRoleAssignment"/>. </summary>
        /// <param name="id"> The role assignment ID. </param>
        /// <param name="name"> The role assignment name. </param>
        /// <param name="type"> The role assignment type. </param>
        /// <param name="properties"> Role assignment properties. </param>
        /// <returns> A new <see cref="Administration.KeyVaultRoleAssignment"/> instance for mocking. </returns>
        public static KeyVaultRoleAssignment KeyVaultRoleAssignment(string id = null, string name = null, string type = null, KeyVaultRoleAssignmentProperties properties = null)
        {
            return new KeyVaultRoleAssignment(id, name, type, properties);
        }

        /// <summary> Initializes a new instance of <see cref="Administration.KeyVaultRoleAssignmentProperties"/>. </summary>
        /// <param name="scope"> The role scope. </param>
        /// <param name="roleDefinitionId"> The role definition ID. </param>
        /// <param name="principalId"> The principal ID. </param>
        /// <returns> A new <see cref="Administration.KeyVaultRoleAssignmentProperties"/> instance for mocking. </returns>
        public static KeyVaultRoleAssignmentProperties KeyVaultRoleAssignmentProperties(KeyVaultRoleScope? scope = null, string roleDefinitionId = null, string principalId = null)
        {
            return new KeyVaultRoleAssignmentProperties(scope, roleDefinitionId, principalId);
        }
    }
}
