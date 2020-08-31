// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations.
    /// </summary>
    public static partial class ManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperationsExtensions
    {
            /// <summary>
            /// Gets a dropped database's short term retention policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='restorableDroppedDatabaseId'>
            /// </param>
            public static ManagedBackupShortTermRetentionPolicy Get(this IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations operations, string resourceGroupName, string managedInstanceName, string restorableDroppedDatabaseId)
            {
                return operations.GetAsync(resourceGroupName, managedInstanceName, restorableDroppedDatabaseId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a dropped database's short term retention policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='restorableDroppedDatabaseId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedBackupShortTermRetentionPolicy> GetAsync(this IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations operations, string resourceGroupName, string managedInstanceName, string restorableDroppedDatabaseId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, managedInstanceName, restorableDroppedDatabaseId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sets a database's long term retention policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='restorableDroppedDatabaseId'>
            /// </param>
            /// <param name='parameters'>
            /// The long term retention policy info.
            /// </param>
            public static ManagedBackupShortTermRetentionPolicy CreateOrUpdate(this IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations operations, string resourceGroupName, string managedInstanceName, string restorableDroppedDatabaseId, ManagedBackupShortTermRetentionPolicy parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, managedInstanceName, restorableDroppedDatabaseId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets a database's long term retention policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='restorableDroppedDatabaseId'>
            /// </param>
            /// <param name='parameters'>
            /// The long term retention policy info.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedBackupShortTermRetentionPolicy> CreateOrUpdateAsync(this IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations operations, string resourceGroupName, string managedInstanceName, string restorableDroppedDatabaseId, ManagedBackupShortTermRetentionPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, restorableDroppedDatabaseId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sets a database's long term retention policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='restorableDroppedDatabaseId'>
            /// </param>
            /// <param name='parameters'>
            /// The long term retention policy info.
            /// </param>
            public static ManagedBackupShortTermRetentionPolicy Update(this IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations operations, string resourceGroupName, string managedInstanceName, string restorableDroppedDatabaseId, ManagedBackupShortTermRetentionPolicy parameters)
            {
                return operations.UpdateAsync(resourceGroupName, managedInstanceName, restorableDroppedDatabaseId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets a database's long term retention policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='restorableDroppedDatabaseId'>
            /// </param>
            /// <param name='parameters'>
            /// The long term retention policy info.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedBackupShortTermRetentionPolicy> UpdateAsync(this IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations operations, string resourceGroupName, string managedInstanceName, string restorableDroppedDatabaseId, ManagedBackupShortTermRetentionPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, restorableDroppedDatabaseId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a dropped database's short term retention policy list.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='restorableDroppedDatabaseId'>
            /// </param>
            public static IPage<ManagedBackupShortTermRetentionPolicy> ListByRestorableDroppedDatabase(this IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations operations, string resourceGroupName, string managedInstanceName, string restorableDroppedDatabaseId)
            {
                return operations.ListByRestorableDroppedDatabaseAsync(resourceGroupName, managedInstanceName, restorableDroppedDatabaseId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a dropped database's short term retention policy list.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='restorableDroppedDatabaseId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedBackupShortTermRetentionPolicy>> ListByRestorableDroppedDatabaseAsync(this IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations operations, string resourceGroupName, string managedInstanceName, string restorableDroppedDatabaseId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByRestorableDroppedDatabaseWithHttpMessagesAsync(resourceGroupName, managedInstanceName, restorableDroppedDatabaseId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sets a database's long term retention policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='restorableDroppedDatabaseId'>
            /// </param>
            /// <param name='parameters'>
            /// The long term retention policy info.
            /// </param>
            public static ManagedBackupShortTermRetentionPolicy BeginCreateOrUpdate(this IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations operations, string resourceGroupName, string managedInstanceName, string restorableDroppedDatabaseId, ManagedBackupShortTermRetentionPolicy parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, managedInstanceName, restorableDroppedDatabaseId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets a database's long term retention policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='restorableDroppedDatabaseId'>
            /// </param>
            /// <param name='parameters'>
            /// The long term retention policy info.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedBackupShortTermRetentionPolicy> BeginCreateOrUpdateAsync(this IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations operations, string resourceGroupName, string managedInstanceName, string restorableDroppedDatabaseId, ManagedBackupShortTermRetentionPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, restorableDroppedDatabaseId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sets a database's long term retention policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='restorableDroppedDatabaseId'>
            /// </param>
            /// <param name='parameters'>
            /// The long term retention policy info.
            /// </param>
            public static ManagedBackupShortTermRetentionPolicy BeginUpdate(this IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations operations, string resourceGroupName, string managedInstanceName, string restorableDroppedDatabaseId, ManagedBackupShortTermRetentionPolicy parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, managedInstanceName, restorableDroppedDatabaseId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets a database's long term retention policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='restorableDroppedDatabaseId'>
            /// </param>
            /// <param name='parameters'>
            /// The long term retention policy info.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedBackupShortTermRetentionPolicy> BeginUpdateAsync(this IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations operations, string resourceGroupName, string managedInstanceName, string restorableDroppedDatabaseId, ManagedBackupShortTermRetentionPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, managedInstanceName, restorableDroppedDatabaseId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a dropped database's short term retention policy list.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ManagedBackupShortTermRetentionPolicy> ListByRestorableDroppedDatabaseNext(this IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListByRestorableDroppedDatabaseNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a dropped database's short term retention policy list.
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
            public static async Task<IPage<ManagedBackupShortTermRetentionPolicy>> ListByRestorableDroppedDatabaseNextAsync(this IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByRestorableDroppedDatabaseNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
