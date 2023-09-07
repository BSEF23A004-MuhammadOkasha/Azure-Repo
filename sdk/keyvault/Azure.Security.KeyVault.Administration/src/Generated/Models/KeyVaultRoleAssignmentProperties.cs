// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.KeyVault.Administration
{
    /// <summary> Role assignment properties with scope. </summary>
    public partial class KeyVaultRoleAssignmentProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KeyVaultRoleAssignmentProperties"/>. </summary>
        internal KeyVaultRoleAssignmentProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultRoleAssignmentProperties"/>. </summary>
        /// <param name="scope"> The role scope. </param>
        /// <param name="roleDefinitionId"> The role definition ID. </param>
        /// <param name="principalId"> The principal ID. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultRoleAssignmentProperties(KeyVaultRoleScope? scope, string roleDefinitionId, string principalId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Scope = scope;
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The role scope. </summary>
        public KeyVaultRoleScope? Scope { get; }
        /// <summary> The role definition ID. </summary>
        public string RoleDefinitionId { get; }
        /// <summary> The principal ID. </summary>
        public string PrincipalId { get; }
    }
}
