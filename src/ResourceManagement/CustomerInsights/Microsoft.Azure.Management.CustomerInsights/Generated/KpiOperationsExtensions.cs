// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for KpiOperations.
    /// </summary>
    public static partial class KpiOperationsExtensions
    {
            /// <summary>
            /// Creates a KPI or updates an existing KPI in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='kpiName'>
            /// The name of the KPI.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update KPI operation.
            /// </param>
            public static KpiResourceFormat CreateOrUpdate(this IKpiOperations operations, string resourceGroupName, string hubName, string kpiName, KpiResourceFormat parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, hubName, kpiName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a KPI or updates an existing KPI in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='kpiName'>
            /// The name of the KPI.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update KPI operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<KpiResourceFormat> CreateOrUpdateAsync(this IKpiOperations operations, string resourceGroupName, string hubName, string kpiName, KpiResourceFormat parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, hubName, kpiName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a KPI in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='kpiName'>
            /// The name of the KPI.
            /// </param>
            public static KpiResourceFormat Get(this IKpiOperations operations, string resourceGroupName, string hubName, string kpiName)
            {
                return operations.GetAsync(resourceGroupName, hubName, kpiName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a KPI in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='kpiName'>
            /// The name of the KPI.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<KpiResourceFormat> GetAsync(this IKpiOperations operations, string resourceGroupName, string hubName, string kpiName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, hubName, kpiName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a KPI in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='kpiName'>
            /// The name of the KPI.
            /// </param>
            public static void Delete(this IKpiOperations operations, string resourceGroupName, string hubName, string kpiName)
            {
                operations.DeleteAsync(resourceGroupName, hubName, kpiName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a KPI in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='kpiName'>
            /// The name of the KPI.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IKpiOperations operations, string resourceGroupName, string hubName, string kpiName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, hubName, kpiName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Reprocesses the Kpi values of the specified KPI.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='kpiName'>
            /// The name of the KPI.
            /// </param>
            public static void Reprocess(this IKpiOperations operations, string resourceGroupName, string hubName, string kpiName)
            {
                operations.ReprocessAsync(resourceGroupName, hubName, kpiName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Reprocesses the Kpi values of the specified KPI.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='kpiName'>
            /// The name of the KPI.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ReprocessAsync(this IKpiOperations operations, string resourceGroupName, string hubName, string kpiName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ReprocessWithHttpMessagesAsync(resourceGroupName, hubName, kpiName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets all the KPIs in the specified hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            public static IPage<KpiResourceFormat> ListByHub(this IKpiOperations operations, string resourceGroupName, string hubName)
            {
                return operations.ListByHubAsync(resourceGroupName, hubName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the KPIs in the specified hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<KpiResourceFormat>> ListByHubAsync(this IKpiOperations operations, string resourceGroupName, string hubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHubWithHttpMessagesAsync(resourceGroupName, hubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a KPI or updates an existing KPI in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='kpiName'>
            /// The name of the KPI.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update KPI operation.
            /// </param>
            public static KpiResourceFormat BeginCreateOrUpdate(this IKpiOperations operations, string resourceGroupName, string hubName, string kpiName, KpiResourceFormat parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, hubName, kpiName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a KPI or updates an existing KPI in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='kpiName'>
            /// The name of the KPI.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update KPI operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<KpiResourceFormat> BeginCreateOrUpdateAsync(this IKpiOperations operations, string resourceGroupName, string hubName, string kpiName, KpiResourceFormat parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, hubName, kpiName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a KPI in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='kpiName'>
            /// The name of the KPI.
            /// </param>
            public static void BeginDelete(this IKpiOperations operations, string resourceGroupName, string hubName, string kpiName)
            {
                operations.BeginDeleteAsync(resourceGroupName, hubName, kpiName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a KPI in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='kpiName'>
            /// The name of the KPI.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IKpiOperations operations, string resourceGroupName, string hubName, string kpiName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, hubName, kpiName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets all the KPIs in the specified hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<KpiResourceFormat> ListByHubNext(this IKpiOperations operations, string nextPageLink)
            {
                return operations.ListByHubNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the KPIs in the specified hub.
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
            public static async Task<IPage<KpiResourceFormat>> ListByHubNextAsync(this IKpiOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHubNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

