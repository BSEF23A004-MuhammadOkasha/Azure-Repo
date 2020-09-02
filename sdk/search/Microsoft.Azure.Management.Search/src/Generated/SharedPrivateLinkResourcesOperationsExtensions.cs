// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Search
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SharedPrivateLinkResourcesOperations.
    /// </summary>
    public static partial class SharedPrivateLinkResourcesOperationsExtensions
    {
            /// <summary>
            /// Initiates the creation or update of a shared private link resource managed
            /// by the Search service in the given resource group.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='sharedPrivateLinkResourceName'>
            /// The name of the shared private link resource managed by the Azure Cognitive
            /// Search service within the specified resource group.
            /// </param>
            /// <param name='sharedPrivateLinkResource'>
            /// The definition of the shared private link resource to create or update.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static SharedPrivateLinkResource CreateOrUpdate(this ISharedPrivateLinkResourcesOperations operations, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SharedPrivateLinkResource sharedPrivateLinkResource, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, searchServiceName, sharedPrivateLinkResourceName, sharedPrivateLinkResource, searchManagementRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Initiates the creation or update of a shared private link resource managed
            /// by the Search service in the given resource group.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='sharedPrivateLinkResourceName'>
            /// The name of the shared private link resource managed by the Azure Cognitive
            /// Search service within the specified resource group.
            /// </param>
            /// <param name='sharedPrivateLinkResource'>
            /// The definition of the shared private link resource to create or update.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedPrivateLinkResource> CreateOrUpdateAsync(this ISharedPrivateLinkResourcesOperations operations, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SharedPrivateLinkResource sharedPrivateLinkResource, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, searchServiceName, sharedPrivateLinkResourceName, sharedPrivateLinkResource, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the details of the shared private link resource managed by the Search
            /// service in the given resource group.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='sharedPrivateLinkResourceName'>
            /// The name of the shared private link resource managed by the Azure Cognitive
            /// Search service within the specified resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static SharedPrivateLinkResource Get(this ISharedPrivateLinkResourcesOperations operations, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return operations.GetAsync(resourceGroupName, searchServiceName, sharedPrivateLinkResourceName, searchManagementRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of the shared private link resource managed by the Search
            /// service in the given resource group.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='sharedPrivateLinkResourceName'>
            /// The name of the shared private link resource managed by the Azure Cognitive
            /// Search service within the specified resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedPrivateLinkResource> GetAsync(this ISharedPrivateLinkResourcesOperations operations, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, searchServiceName, sharedPrivateLinkResourceName, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Initiates the deletion of the shared private link resource from the Search
            /// service.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='sharedPrivateLinkResourceName'>
            /// The name of the shared private link resource managed by the Azure Cognitive
            /// Search service within the specified resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static void Delete(this ISharedPrivateLinkResourcesOperations operations, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                operations.DeleteAsync(resourceGroupName, searchServiceName, sharedPrivateLinkResourceName, searchManagementRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Initiates the deletion of the shared private link resource from the Search
            /// service.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='sharedPrivateLinkResourceName'>
            /// The name of the shared private link resource managed by the Azure Cognitive
            /// Search service within the specified resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISharedPrivateLinkResourcesOperations operations, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, searchServiceName, sharedPrivateLinkResourceName, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of all shared private link resources managed by the given
            /// service.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IPage<SharedPrivateLinkResource> ListByService(this ISharedPrivateLinkResourcesOperations operations, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return operations.ListByServiceAsync(resourceGroupName, searchServiceName, searchManagementRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of all shared private link resources managed by the given
            /// service.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SharedPrivateLinkResource>> ListByServiceAsync(this ISharedPrivateLinkResourcesOperations operations, string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, searchServiceName, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Initiates the creation or update of a shared private link resource managed
            /// by the Search service in the given resource group.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='sharedPrivateLinkResourceName'>
            /// The name of the shared private link resource managed by the Azure Cognitive
            /// Search service within the specified resource group.
            /// </param>
            /// <param name='sharedPrivateLinkResource'>
            /// The definition of the shared private link resource to create or update.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static SharedPrivateLinkResource BeginCreateOrUpdate(this ISharedPrivateLinkResourcesOperations operations, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SharedPrivateLinkResource sharedPrivateLinkResource, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, searchServiceName, sharedPrivateLinkResourceName, sharedPrivateLinkResource, searchManagementRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Initiates the creation or update of a shared private link resource managed
            /// by the Search service in the given resource group.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='sharedPrivateLinkResourceName'>
            /// The name of the shared private link resource managed by the Azure Cognitive
            /// Search service within the specified resource group.
            /// </param>
            /// <param name='sharedPrivateLinkResource'>
            /// The definition of the shared private link resource to create or update.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedPrivateLinkResource> BeginCreateOrUpdateAsync(this ISharedPrivateLinkResourcesOperations operations, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SharedPrivateLinkResource sharedPrivateLinkResource, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, searchServiceName, sharedPrivateLinkResourceName, sharedPrivateLinkResource, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Initiates the deletion of the shared private link resource from the Search
            /// service.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='sharedPrivateLinkResourceName'>
            /// The name of the shared private link resource managed by the Azure Cognitive
            /// Search service within the specified resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static void BeginDelete(this ISharedPrivateLinkResourcesOperations operations, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                operations.BeginDeleteAsync(resourceGroupName, searchServiceName, sharedPrivateLinkResourceName, searchManagementRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Initiates the deletion of the shared private link resource from the Search
            /// service.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the current subscription. You can
            /// obtain this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='searchServiceName'>
            /// The name of the Azure Cognitive Search service associated with the
            /// specified resource group.
            /// </param>
            /// <param name='sharedPrivateLinkResourceName'>
            /// The name of the shared private link resource managed by the Azure Cognitive
            /// Search service within the specified resource group.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ISharedPrivateLinkResourcesOperations operations, string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, searchServiceName, sharedPrivateLinkResourceName, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of all shared private link resources managed by the given
            /// service.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IPage<SharedPrivateLinkResource> ListByServiceNext(this ISharedPrivateLinkResourcesOperations operations, string nextPageLink, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions))
            {
                return operations.ListByServiceNextAsync(nextPageLink, searchManagementRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of all shared private link resources managed by the given
            /// service.
            /// <see href="https://aka.ms/search-manage" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='searchManagementRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SharedPrivateLinkResource>> ListByServiceNextAsync(this ISharedPrivateLinkResourcesOperations operations, string nextPageLink, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceNextWithHttpMessagesAsync(nextPageLink, searchManagementRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
