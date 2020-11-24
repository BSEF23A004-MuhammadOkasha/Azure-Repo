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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// SharedPrivateLinkResourcesOperations operations.
    /// </summary>
    public partial interface ISharedPrivateLinkResourcesOperations
    {
        /// <summary>
        /// Initiates the creation or update of a shared private link resource
        /// managed by the search service in the given resource group.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription. You
        /// can obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='searchServiceName'>
        /// The name of the Azure Cognitive Search service associated with the
        /// specified resource group.
        /// </param>
        /// <param name='sharedPrivateLinkResourceName'>
        /// The name of the shared private link resource managed by the Azure
        /// Cognitive Search service within the specified resource group.
        /// </param>
        /// <param name='sharedPrivateLinkResource'>
        /// The definition of the shared private link resource to create or
        /// update.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SharedPrivateLinkResource>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SharedPrivateLinkResource sharedPrivateLinkResource, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the details of the shared private link resource managed by the
        /// search service in the given resource group.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription. You
        /// can obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='searchServiceName'>
        /// The name of the Azure Cognitive Search service associated with the
        /// specified resource group.
        /// </param>
        /// <param name='sharedPrivateLinkResourceName'>
        /// The name of the shared private link resource managed by the Azure
        /// Cognitive Search service within the specified resource group.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SharedPrivateLinkResource>> GetWithHttpMessagesAsync(string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Initiates the deletion of the shared private link resource from the
        /// search service.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription. You
        /// can obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='searchServiceName'>
        /// The name of the Azure Cognitive Search service associated with the
        /// specified resource group.
        /// </param>
        /// <param name='sharedPrivateLinkResourceName'>
        /// The name of the shared private link resource managed by the Azure
        /// Cognitive Search service within the specified resource group.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of all shared private link resources managed by the
        /// given service.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription. You
        /// can obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='searchServiceName'>
        /// The name of the Azure Cognitive Search service associated with the
        /// specified resource group.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SharedPrivateLinkResource>>> ListByServiceWithHttpMessagesAsync(string resourceGroupName, string searchServiceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Initiates the creation or update of a shared private link resource
        /// managed by the search service in the given resource group.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription. You
        /// can obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='searchServiceName'>
        /// The name of the Azure Cognitive Search service associated with the
        /// specified resource group.
        /// </param>
        /// <param name='sharedPrivateLinkResourceName'>
        /// The name of the shared private link resource managed by the Azure
        /// Cognitive Search service within the specified resource group.
        /// </param>
        /// <param name='sharedPrivateLinkResource'>
        /// The definition of the shared private link resource to create or
        /// update.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SharedPrivateLinkResource>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SharedPrivateLinkResource sharedPrivateLinkResource, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Initiates the deletion of the shared private link resource from the
        /// search service.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription. You
        /// can obtain this value from the Azure Resource Manager API or the
        /// portal.
        /// </param>
        /// <param name='searchServiceName'>
        /// The name of the Azure Cognitive Search service associated with the
        /// specified resource group.
        /// </param>
        /// <param name='sharedPrivateLinkResourceName'>
        /// The name of the shared private link resource managed by the Azure
        /// Cognitive Search service within the specified resource group.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string searchServiceName, string sharedPrivateLinkResourceName, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of all shared private link resources managed by the
        /// given service.
        /// <see href="https://aka.ms/search-manage" />
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='searchManagementRequestOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SharedPrivateLinkResource>>> ListByServiceNextWithHttpMessagesAsync(string nextPageLink, SearchManagementRequestOptions searchManagementRequestOptions = default(SearchManagementRequestOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
