// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing the DenyAssignment data model.
    /// Deny Assignment
    /// </summary>
    public partial class DenyAssignmentData : ResourceData
    {
        /// <summary> Initializes a new instance of DenyAssignmentData. </summary>
        internal DenyAssignmentData()
        {
            Permissions = new Core.ChangeTrackingList<DenyAssignmentPermission>();
            Principals = new Core.ChangeTrackingList<RoleManagementPrincipal>();
            ExcludePrincipals = new Core.ChangeTrackingList<RoleManagementPrincipal>();
        }

        /// <summary> Initializes a new instance of DenyAssignmentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="denyAssignmentName"> The display name of the deny assignment. </param>
        /// <param name="description"> The description of the deny assignment. </param>
        /// <param name="permissions"> An array of permissions that are denied by the deny assignment. </param>
        /// <param name="scope"> The deny assignment scope. </param>
        /// <param name="isAppliedToChildScopes"> Determines if the deny assignment applies to child scopes. Default value is false. </param>
        /// <param name="principals"> Array of principals to which the deny assignment applies. </param>
        /// <param name="excludePrincipals"> Array of principals to which the deny assignment does not apply. </param>
        /// <param name="isSystemProtected"> Specifies whether this deny assignment was created by Azure and cannot be edited or deleted. </param>
        internal DenyAssignmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string denyAssignmentName, string description, IReadOnlyList<DenyAssignmentPermission> permissions, string scope, bool? isAppliedToChildScopes, IReadOnlyList<RoleManagementPrincipal> principals, IReadOnlyList<RoleManagementPrincipal> excludePrincipals, bool? isSystemProtected) : base(id, name, resourceType, systemData)
        {
            DenyAssignmentName = denyAssignmentName;
            Description = description;
            Permissions = permissions;
            Scope = scope;
            IsAppliedToChildScopes = isAppliedToChildScopes;
            Principals = principals;
            ExcludePrincipals = excludePrincipals;
            IsSystemProtected = isSystemProtected;
        }

        /// <summary> The display name of the deny assignment. </summary>
        public string DenyAssignmentName { get; }
        /// <summary> The description of the deny assignment. </summary>
        public string Description { get; }
        /// <summary> An array of permissions that are denied by the deny assignment. </summary>
        public IReadOnlyList<DenyAssignmentPermission> Permissions { get; }
        /// <summary> The deny assignment scope. </summary>
        public string Scope { get; }
        /// <summary> Determines if the deny assignment applies to child scopes. Default value is false. </summary>
        public bool? IsAppliedToChildScopes { get; }
        /// <summary> Array of principals to which the deny assignment applies. </summary>
        public IReadOnlyList<RoleManagementPrincipal> Principals { get; }
        /// <summary> Array of principals to which the deny assignment does not apply. </summary>
        public IReadOnlyList<RoleManagementPrincipal> ExcludePrincipals { get; }
        /// <summary> Specifies whether this deny assignment was created by Azure and cannot be edited or deleted. </summary>
        public bool? IsSystemProtected { get; }
    }
}
