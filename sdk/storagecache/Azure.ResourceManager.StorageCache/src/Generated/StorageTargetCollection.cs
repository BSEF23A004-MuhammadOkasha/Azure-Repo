// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.StorageCache
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageTargetResource" /> and their operations.
    /// Each <see cref="StorageTargetResource" /> in the collection will belong to the same instance of <see cref="StorageCacheResource" />.
    /// To get a <see cref="StorageTargetCollection" /> instance call the GetStorageTargets method from an instance of <see cref="StorageCacheResource" />.
    /// </summary>
    public partial class StorageTargetCollection : ArmCollection, IEnumerable<StorageTargetResource>, IAsyncEnumerable<StorageTargetResource>
    {
        private readonly ClientDiagnostics _storageTargetClientDiagnostics;
        private readonly StorageTargetsRestOperations _storageTargetRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageTargetCollection"/> class for mocking. </summary>
        protected StorageTargetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageTargetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageTargetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageTargetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageCache", StorageTargetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageTargetResource.ResourceType, out string storageTargetApiVersion);
            _storageTargetRestClient = new StorageTargetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageTargetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StorageCacheResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StorageCacheResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Storage Target. This operation is allowed at any time, but if the cache is down or unhealthy, the actual creation/modification of the Storage Target may be delayed until the cache is healthy again.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}/storageTargets/{storageTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTargets_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageTargetName"> Name of Storage Target. </param>
        /// <param name="data"> Object containing the definition of a Storage Target. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTargetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageTargetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string storageTargetName, StorageTargetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageTargetName, nameof(storageTargetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageTargetClientDiagnostics.CreateScope("StorageTargetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageTargetRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTargetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new StorageCacheArmOperation<StorageTargetResource>(new StorageTargetOperationSource(Client), _storageTargetClientDiagnostics, Pipeline, _storageTargetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTargetName, data).Request, response, Core.OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
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
        /// Create or update a Storage Target. This operation is allowed at any time, but if the cache is down or unhealthy, the actual creation/modification of the Storage Target may be delayed until the cache is healthy again.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}/storageTargets/{storageTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTargets_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageTargetName"> Name of Storage Target. </param>
        /// <param name="data"> Object containing the definition of a Storage Target. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTargetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StorageTargetResource> CreateOrUpdate(WaitUntil waitUntil, string storageTargetName, StorageTargetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageTargetName, nameof(storageTargetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageTargetClientDiagnostics.CreateScope("StorageTargetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageTargetRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTargetName, data, cancellationToken);
                var operation = new StorageCacheArmOperation<StorageTargetResource>(new StorageTargetOperationSource(Client), _storageTargetClientDiagnostics, Pipeline, _storageTargetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTargetName, data).Request, response, Core.OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
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
        /// Returns a Storage Target from a cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}/storageTargets/{storageTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTargets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageTargetName"> Name of Storage Target. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTargetName"/> is null. </exception>
        public virtual async Task<Response<StorageTargetResource>> GetAsync(string storageTargetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageTargetName, nameof(storageTargetName));

            using var scope = _storageTargetClientDiagnostics.CreateScope("StorageTargetCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageTargetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTargetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a Storage Target from a cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}/storageTargets/{storageTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTargets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageTargetName"> Name of Storage Target. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTargetName"/> is null. </exception>
        public virtual Response<StorageTargetResource> Get(string storageTargetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageTargetName, nameof(storageTargetName));

            using var scope = _storageTargetClientDiagnostics.CreateScope("StorageTargetCollection.Get");
            scope.Start();
            try
            {
                var response = _storageTargetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTargetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageTargetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of Storage Targets for the specified cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}/storageTargets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTargets_ListByCache</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageTargetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageTargetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageTargetRestClient.CreateListByCacheRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageTargetRestClient.CreateListByCacheNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StorageTargetResource(Client, StorageTargetData.DeserializeStorageTargetData(e)), _storageTargetClientDiagnostics, Pipeline, "StorageTargetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of Storage Targets for the specified cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}/storageTargets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTargets_ListByCache</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageTargetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageTargetResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageTargetRestClient.CreateListByCacheRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageTargetRestClient.CreateListByCacheNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StorageTargetResource(Client, StorageTargetData.DeserializeStorageTargetData(e)), _storageTargetClientDiagnostics, Pipeline, "StorageTargetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}/storageTargets/{storageTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTargets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageTargetName"> Name of Storage Target. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTargetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storageTargetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageTargetName, nameof(storageTargetName));

            using var scope = _storageTargetClientDiagnostics.CreateScope("StorageTargetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageTargetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTargetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}/storageTargets/{storageTargetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTargets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageTargetName"> Name of Storage Target. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageTargetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTargetName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageTargetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageTargetName, nameof(storageTargetName));

            using var scope = _storageTargetClientDiagnostics.CreateScope("StorageTargetCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageTargetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, storageTargetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageTargetResource> IEnumerable<StorageTargetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageTargetResource> IAsyncEnumerable<StorageTargetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
