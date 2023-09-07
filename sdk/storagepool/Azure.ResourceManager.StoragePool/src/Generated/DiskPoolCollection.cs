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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.StoragePool.Models;

namespace Azure.ResourceManager.StoragePool
{
    /// <summary>
    /// A class representing a collection of <see cref="DiskPoolResource" /> and their operations.
    /// Each <see cref="DiskPoolResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DiskPoolCollection" /> instance call the GetDiskPools method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DiskPoolCollection : ArmCollection, IEnumerable<DiskPoolResource>, IAsyncEnumerable<DiskPoolResource>
    {
        private readonly ClientDiagnostics _diskPoolClientDiagnostics;
        private readonly DiskPoolsRestOperations _diskPoolRestClient;

        /// <summary> Initializes a new instance of the <see cref="DiskPoolCollection"/> class for mocking. </summary>
        protected DiskPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DiskPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DiskPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diskPoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StoragePool", DiskPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DiskPoolResource.ResourceType, out string diskPoolApiVersion);
            _diskPoolRestClient = new DiskPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, diskPoolApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update Disk pool. This create or update operation can take 15 minutes to complete. This is expected service behavior.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPools_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="content"> Request payload for Disk Pool create operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<DiskPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string diskPoolName, DiskPoolCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskPoolName, nameof(diskPoolName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _diskPoolRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, diskPoolName, content, cancellationToken).ConfigureAwait(false);
                var operation = new StoragePoolArmOperation<DiskPoolResource>(new DiskPoolOperationSource(Client), _diskPoolClientDiagnostics, Pipeline, _diskPoolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, diskPoolName, content).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or Update Disk pool. This create or update operation can take 15 minutes to complete. This is expected service behavior.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPools_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="content"> Request payload for Disk Pool create operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<DiskPoolResource> CreateOrUpdate(WaitUntil waitUntil, string diskPoolName, DiskPoolCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskPoolName, nameof(diskPoolName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _diskPoolRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, diskPoolName, content, cancellationToken);
                var operation = new StoragePoolArmOperation<DiskPoolResource>(new DiskPoolOperationSource(Client), _diskPoolClientDiagnostics, Pipeline, _diskPoolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, diskPoolName, content).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a Disk pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> is null. </exception>
        public virtual async Task<Response<DiskPoolResource>> GetAsync(string diskPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskPoolName, nameof(diskPoolName));

            using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _diskPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, diskPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Disk pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> is null. </exception>
        public virtual Response<DiskPoolResource> Get(string diskPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskPoolName, nameof(diskPoolName));

            using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _diskPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, diskPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of DiskPools in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPools_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiskPoolResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _diskPoolRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _diskPoolRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DiskPoolResource(Client, DiskPoolData.DeserializeDiskPoolData(e)), _diskPoolClientDiagnostics, Pipeline, "DiskPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of DiskPools in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPools_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiskPoolResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _diskPoolRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _diskPoolRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DiskPoolResource(Client, DiskPoolData.DeserializeDiskPoolData(e)), _diskPoolClientDiagnostics, Pipeline, "DiskPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string diskPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskPoolName, nameof(diskPoolName));

            using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _diskPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, diskPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string diskPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskPoolName, nameof(diskPoolName));

            using var scope = _diskPoolClientDiagnostics.CreateScope("DiskPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _diskPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, diskPoolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DiskPoolResource> IEnumerable<DiskPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DiskPoolResource> IAsyncEnumerable<DiskPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
