// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create and update an Azure Cosmos DB SQL Role Definition. </summary>
    public partial class SqlRoleDefinitionCreateUpdateParameters
    {
        /// <summary> Initializes a new instance of SqlRoleDefinitionCreateUpdateParameters. </summary>
        public SqlRoleDefinitionCreateUpdateParameters()
        {
            AssignableScopes = new ChangeTrackingList<string>();
            Permissions = new ChangeTrackingList<Permission>();
        }

        /// <summary> A user-friendly name for the Role Definition. Must be unique for the database account. </summary>
        public string RoleName { get; set; }
        /// <summary> Indicates whether the Role Definition was built-in or user created. </summary>
        public RoleDefinitionType? Type { get; set; }
        /// <summary> A set of fully qualified Scopes at or below which Role Assignments may be created using this Role Definition. This will allow application of this Role Definition on the entire database account or any underlying Database / Collection. Must have at least one element. Scopes higher than Database account are not enforceable as assignable Scopes. Note that resources referenced in assignable Scopes need not exist. </summary>
        public IList<string> AssignableScopes { get; }
        /// <summary> The set of operations allowed through this Role Definition. </summary>
        public IList<Permission> Permissions { get; }
    }
}
