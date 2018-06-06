// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HybridRunbookWorkerGroupOperations.
    /// </summary>
    public static partial class HybridRunbookWorkerGroupOperationsExtensions
    {
            /// <summary>
            /// Delete a hybrid runbook worker group.
            /// <see href="http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// Automation account name.
            /// </param>
            /// <param name='hybridRunbookWorkerGroupName'>
            /// The hybrid runbook worker group name
            /// </param>
            public static void Delete(this IHybridRunbookWorkerGroupOperations operations, string resourceGroupName, string automationAccountName, string hybridRunbookWorkerGroupName)
            {
                operations.DeleteAsync(resourceGroupName, automationAccountName, hybridRunbookWorkerGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a hybrid runbook worker group.
            /// <see href="http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// Automation account name.
            /// </param>
            /// <param name='hybridRunbookWorkerGroupName'>
            /// The hybrid runbook worker group name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IHybridRunbookWorkerGroupOperations operations, string resourceGroupName, string automationAccountName, string hybridRunbookWorkerGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, automationAccountName, hybridRunbookWorkerGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve a hybrid runbook worker group.
            /// <see href="http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='hybridRunbookWorkerGroupName'>
            /// The hybrid runbook worker group name
            /// </param>
            public static HybridRunbookWorkerGroup Get(this IHybridRunbookWorkerGroupOperations operations, string resourceGroupName, string automationAccountName, string hybridRunbookWorkerGroupName)
            {
                return operations.GetAsync(resourceGroupName, automationAccountName, hybridRunbookWorkerGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a hybrid runbook worker group.
            /// <see href="http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='hybridRunbookWorkerGroupName'>
            /// The hybrid runbook worker group name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HybridRunbookWorkerGroup> GetAsync(this IHybridRunbookWorkerGroupOperations operations, string resourceGroupName, string automationAccountName, string hybridRunbookWorkerGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, automationAccountName, hybridRunbookWorkerGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a hybrid runbook worker group.
            /// <see href="http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='hybridRunbookWorkerGroupName'>
            /// The hybrid runbook worker group name
            /// </param>
            /// <param name='parameters'>
            /// The hybrid runbook worker group
            /// </param>
            public static HybridRunbookWorkerGroup Update(this IHybridRunbookWorkerGroupOperations operations, string resourceGroupName, string automationAccountName, string hybridRunbookWorkerGroupName, HybridRunbookWorkerGroupUpdateParameters parameters)
            {
                return operations.UpdateAsync(resourceGroupName, automationAccountName, hybridRunbookWorkerGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a hybrid runbook worker group.
            /// <see href="http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='hybridRunbookWorkerGroupName'>
            /// The hybrid runbook worker group name
            /// </param>
            /// <param name='parameters'>
            /// The hybrid runbook worker group
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HybridRunbookWorkerGroup> UpdateAsync(this IHybridRunbookWorkerGroupOperations operations, string resourceGroupName, string automationAccountName, string hybridRunbookWorkerGroupName, HybridRunbookWorkerGroupUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, automationAccountName, hybridRunbookWorkerGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of hybrid runbook worker groups.
            /// <see href="http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<HybridRunbookWorkerGroup> ListByAutomationAccount(this IHybridRunbookWorkerGroupOperations operations, string resourceGroupName, string automationAccountName, ODataQuery<HybridRunbookWorkerGroup> odataQuery = default(ODataQuery<HybridRunbookWorkerGroup>))
            {
                return operations.ListByAutomationAccountAsync(resourceGroupName, automationAccountName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of hybrid runbook worker groups.
            /// <see href="http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<HybridRunbookWorkerGroup>> ListByAutomationAccountAsync(this IHybridRunbookWorkerGroupOperations operations, string resourceGroupName, string automationAccountName, ODataQuery<HybridRunbookWorkerGroup> odataQuery = default(ODataQuery<HybridRunbookWorkerGroup>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAutomationAccountWithHttpMessagesAsync(resourceGroupName, automationAccountName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of hybrid runbook worker groups.
            /// <see href="http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<HybridRunbookWorkerGroup> ListByAutomationAccountNext(this IHybridRunbookWorkerGroupOperations operations, string nextPageLink)
            {
                return operations.ListByAutomationAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of hybrid runbook worker groups.
            /// <see href="http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations" />
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
            public static async Task<IPage<HybridRunbookWorkerGroup>> ListByAutomationAccountNextAsync(this IHybridRunbookWorkerGroupOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAutomationAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
