// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Authorization
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RoleManagementPolicyAssignmentsOperations.
    /// </summary>
    public static partial class RoleManagementPolicyAssignmentsOperationsExtensions
    {
            /// <summary>
            /// Get the specified role management policy assignment for a resource scope
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role management policy.
            /// </param>
            /// <param name='roleManagementPolicyAssignmentName'>
            /// The name of format {guid_guid} the role management policy assignment to
            /// get.
            /// </param>
            public static RoleManagementPolicyAssignment Get(this IRoleManagementPolicyAssignmentsOperations operations, string scope, string roleManagementPolicyAssignmentName)
            {
                return operations.GetAsync(scope, roleManagementPolicyAssignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the specified role management policy assignment for a resource scope
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role management policy.
            /// </param>
            /// <param name='roleManagementPolicyAssignmentName'>
            /// The name of format {guid_guid} the role management policy assignment to
            /// get.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleManagementPolicyAssignment> GetAsync(this IRoleManagementPolicyAssignmentsOperations operations, string scope, string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, roleManagementPolicyAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a role management policy assignment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role management policy assignment to upsert.
            /// </param>
            /// <param name='roleManagementPolicyAssignmentName'>
            /// The name of format {guid_guid} the role management policy assignment to
            /// upsert.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the role management policy assignment.
            /// </param>
            public static RoleManagementPolicyAssignment Create(this IRoleManagementPolicyAssignmentsOperations operations, string scope, string roleManagementPolicyAssignmentName, RoleManagementPolicyAssignment parameters)
            {
                return operations.CreateAsync(scope, roleManagementPolicyAssignmentName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a role management policy assignment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role management policy assignment to upsert.
            /// </param>
            /// <param name='roleManagementPolicyAssignmentName'>
            /// The name of format {guid_guid} the role management policy assignment to
            /// upsert.
            /// </param>
            /// <param name='parameters'>
            /// Parameters for the role management policy assignment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleManagementPolicyAssignment> CreateAsync(this IRoleManagementPolicyAssignmentsOperations operations, string scope, string roleManagementPolicyAssignmentName, RoleManagementPolicyAssignment parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(scope, roleManagementPolicyAssignmentName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a role management policy assignment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role management policy assignment to delete.
            /// </param>
            /// <param name='roleManagementPolicyAssignmentName'>
            /// The name of format {guid_guid} the role management policy assignment to
            /// delete.
            /// </param>
            public static void Delete(this IRoleManagementPolicyAssignmentsOperations operations, string scope, string roleManagementPolicyAssignmentName)
            {
                operations.DeleteAsync(scope, roleManagementPolicyAssignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a role management policy assignment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role management policy assignment to delete.
            /// </param>
            /// <param name='roleManagementPolicyAssignmentName'>
            /// The name of format {guid_guid} the role management policy assignment to
            /// delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IRoleManagementPolicyAssignmentsOperations operations, string scope, string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(scope, roleManagementPolicyAssignmentName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets role management assignment policies for a resource scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role management policy.
            /// </param>
            public static IPage<RoleManagementPolicyAssignment> ListForScope(this IRoleManagementPolicyAssignmentsOperations operations, string scope)
            {
                return operations.ListForScopeAsync(scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets role management assignment policies for a resource scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role management policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RoleManagementPolicyAssignment>> ListForScopeAsync(this IRoleManagementPolicyAssignmentsOperations operations, string scope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForScopeWithHttpMessagesAsync(scope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets role management assignment policies for a resource scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RoleManagementPolicyAssignment> ListForScopeNext(this IRoleManagementPolicyAssignmentsOperations operations, string nextPageLink)
            {
                return operations.ListForScopeNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets role management assignment policies for a resource scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RoleManagementPolicyAssignment>> ListForScopeNextAsync(this IRoleManagementPolicyAssignmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForScopeNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
