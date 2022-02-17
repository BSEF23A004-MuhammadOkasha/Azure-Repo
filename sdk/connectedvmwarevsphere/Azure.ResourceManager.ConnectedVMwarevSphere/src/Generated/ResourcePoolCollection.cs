// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing collection of ResourcePool and their operations over its parent. </summary>
    public partial class ResourcePoolCollection : ArmCollection, IEnumerable<ResourcePool>, IAsyncEnumerable<ResourcePool>
    {
        private readonly ClientDiagnostics _resourcePoolClientDiagnostics;
        private readonly ResourcePoolsRestOperations _resourcePoolRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourcePoolCollection"/> class for mocking. </summary>
        protected ResourcePoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourcePoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ResourcePoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourcePoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", ResourcePool.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourcePool.ResourceType, out string resourcePoolApiVersion);
            _resourcePoolRestClient = new ResourcePoolsRestOperations(_resourcePoolClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, resourcePoolApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create Or Update resourcePool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}
        /// Operation Id: ResourcePools_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public async virtual Task<ArmOperation<ResourcePool>> CreateOrUpdateAsync(bool waitForCompletion, string resourcePoolName, ResourcePoolData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _resourcePoolRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, body, cancellationToken).ConfigureAwait(false);
                var operation = new ConnectedVMwarevSphereArmOperation<ResourcePool>(new ResourcePoolOperationSource(Client), _resourcePoolClientDiagnostics, Pipeline, _resourcePoolRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, body).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary>
        /// Create Or Update resourcePool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}
        /// Operation Id: ResourcePools_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="body"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual ArmOperation<ResourcePool> CreateOrUpdate(bool waitForCompletion, string resourcePoolName, ResourcePoolData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _resourcePoolRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, body, cancellationToken);
                var operation = new ConnectedVMwarevSphereArmOperation<ResourcePool>(new ResourcePoolOperationSource(Client), _resourcePoolClientDiagnostics, Pipeline, _resourcePoolRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, body).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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

        /// <summary>
        /// Implements resourcePool GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}
        /// Operation Id: ResourcePools_Get
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public async virtual Task<Response<ResourcePool>> GetAsync(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourcePoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _resourcePoolClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ResourcePool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements resourcePool GET method.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}
        /// Operation Id: ResourcePools_Get
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual Response<ResourcePool> Get(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.Get");
            scope.Start();
            try
            {
                var response = _resourcePoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken);
                if (response.Value == null)
                    throw _resourcePoolClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourcePool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of resourcePools in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools
        /// Operation Id: ResourcePools_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourcePool" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourcePool> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ResourcePool>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourcePoolRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourcePool(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourcePool>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resourcePoolRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourcePool(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List of resourcePools in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools
        /// Operation Id: ResourcePools_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourcePool" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourcePool> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ResourcePool> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourcePoolRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourcePool(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ResourcePool> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resourcePoolRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourcePool(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}
        /// Operation Id: ResourcePools_Get
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(resourcePoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}
        /// Operation Id: ResourcePools_Get
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(resourcePoolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}
        /// Operation Id: ResourcePools_Get
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public async virtual Task<Response<ResourcePool>> GetIfExistsAsync(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _resourcePoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ResourcePool>(null, response.GetRawResponse());
                return Response.FromValue(new ResourcePool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}
        /// Operation Id: ResourcePools_Get
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual Response<ResourcePool> GetIfExists(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _resourcePoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ResourcePool>(null, response.GetRawResponse());
                return Response.FromValue(new ResourcePool(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourcePool> IEnumerable<ResourcePool>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourcePool> IAsyncEnumerable<ResourcePool>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
