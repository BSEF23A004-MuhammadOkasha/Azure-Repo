// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of InstancePool and their operations over its parent. </summary>
    public partial class InstancePoolCollection : ArmCollection, IEnumerable<InstancePool>, IAsyncEnumerable<InstancePool>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly InstancePoolsRestOperations _instancePoolsRestClient;

        /// <summary> Initializes a new instance of the <see cref="InstancePoolCollection"/> class for mocking. </summary>
        protected InstancePoolCollection()
        {
        }

        /// <summary> Initializes a new instance of InstancePoolCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal InstancePoolCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _instancePoolsRestClient = new InstancePoolsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/instancePools/{instancePoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: InstancePools_CreateOrUpdate
        /// <summary> Creates or updates an instance pool. </summary>
        /// <param name="instancePoolName"> The name of the instance pool to be created or updated. </param>
        /// <param name="parameters"> The requested instance pool resource state. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instancePoolName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual InstancePoolCreateOrUpdateOperation CreateOrUpdate(string instancePoolName, InstancePoolData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (instancePoolName == null)
            {
                throw new ArgumentNullException(nameof(instancePoolName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("InstancePoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _instancePoolsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, instancePoolName, parameters, cancellationToken);
                var operation = new InstancePoolCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _instancePoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, instancePoolName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/instancePools/{instancePoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: InstancePools_CreateOrUpdate
        /// <summary> Creates or updates an instance pool. </summary>
        /// <param name="instancePoolName"> The name of the instance pool to be created or updated. </param>
        /// <param name="parameters"> The requested instance pool resource state. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instancePoolName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<InstancePoolCreateOrUpdateOperation> CreateOrUpdateAsync(string instancePoolName, InstancePoolData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (instancePoolName == null)
            {
                throw new ArgumentNullException(nameof(instancePoolName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("InstancePoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _instancePoolsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, instancePoolName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new InstancePoolCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _instancePoolsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, instancePoolName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/instancePools/{instancePoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: InstancePools_Get
        /// <summary> Gets an instance pool. </summary>
        /// <param name="instancePoolName"> The name of the instance pool to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instancePoolName"/> is null. </exception>
        public virtual Response<InstancePool> Get(string instancePoolName, CancellationToken cancellationToken = default)
        {
            if (instancePoolName == null)
            {
                throw new ArgumentNullException(nameof(instancePoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("InstancePoolCollection.Get");
            scope.Start();
            try
            {
                var response = _instancePoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, instancePoolName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InstancePool(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/instancePools/{instancePoolName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: InstancePools_Get
        /// <summary> Gets an instance pool. </summary>
        /// <param name="instancePoolName"> The name of the instance pool to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instancePoolName"/> is null. </exception>
        public async virtual Task<Response<InstancePool>> GetAsync(string instancePoolName, CancellationToken cancellationToken = default)
        {
            if (instancePoolName == null)
            {
                throw new ArgumentNullException(nameof(instancePoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("InstancePoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _instancePoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, instancePoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new InstancePool(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instancePoolName"> The name of the instance pool to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instancePoolName"/> is null. </exception>
        public virtual Response<InstancePool> GetIfExists(string instancePoolName, CancellationToken cancellationToken = default)
        {
            if (instancePoolName == null)
            {
                throw new ArgumentNullException(nameof(instancePoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("InstancePoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _instancePoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, instancePoolName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<InstancePool>(null, response.GetRawResponse())
                    : Response.FromValue(new InstancePool(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instancePoolName"> The name of the instance pool to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instancePoolName"/> is null. </exception>
        public async virtual Task<Response<InstancePool>> GetIfExistsAsync(string instancePoolName, CancellationToken cancellationToken = default)
        {
            if (instancePoolName == null)
            {
                throw new ArgumentNullException(nameof(instancePoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("InstancePoolCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _instancePoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, instancePoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<InstancePool>(null, response.GetRawResponse())
                    : Response.FromValue(new InstancePool(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instancePoolName"> The name of the instance pool to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instancePoolName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string instancePoolName, CancellationToken cancellationToken = default)
        {
            if (instancePoolName == null)
            {
                throw new ArgumentNullException(nameof(instancePoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("InstancePoolCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(instancePoolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instancePoolName"> The name of the instance pool to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instancePoolName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string instancePoolName, CancellationToken cancellationToken = default)
        {
            if (instancePoolName == null)
            {
                throw new ArgumentNullException(nameof(instancePoolName));
            }

            using var scope = _clientDiagnostics.CreateScope("InstancePoolCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(instancePoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/instancePools
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: InstancePools_ListByResourceGroup
        /// <summary> Gets a list of instance pools in the resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="InstancePool" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<InstancePool> GetAll(CancellationToken cancellationToken = default)
        {
            Page<InstancePool> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InstancePoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _instancePoolsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new InstancePool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<InstancePool> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InstancePoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _instancePoolsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new InstancePool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/instancePools
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: InstancePools_ListByResourceGroup
        /// <summary> Gets a list of instance pools in the resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="InstancePool" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<InstancePool> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<InstancePool>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InstancePoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _instancePoolsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new InstancePool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<InstancePool>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("InstancePoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _instancePoolsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new InstancePool(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="InstancePool" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InstancePoolCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(InstancePool.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="InstancePool" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("InstancePoolCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(InstancePool.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<InstancePool> IEnumerable<InstancePool>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<InstancePool> IAsyncEnumerable<InstancePool>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, InstancePool, InstancePoolData> Construct() { }
    }
}
