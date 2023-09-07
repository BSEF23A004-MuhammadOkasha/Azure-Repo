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

namespace Azure.ResourceManager.HybridContainerService
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageSpaceResource" /> and their operations.
    /// Each <see cref="StorageSpaceResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="StorageSpaceCollection" /> instance call the GetStorageSpaces method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class StorageSpaceCollection : ArmCollection, IEnumerable<StorageSpaceResource>, IAsyncEnumerable<StorageSpaceResource>
    {
        private readonly ClientDiagnostics _storageSpacestorageSpacesClientDiagnostics;
        private readonly StorageSpacesRestOperations _storageSpacestorageSpacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageSpaceCollection"/> class for mocking. </summary>
        protected StorageSpaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageSpaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageSpaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageSpacestorageSpacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridContainerService", StorageSpaceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageSpaceResource.ResourceType, out string storageSpacestorageSpacesApiVersion);
            _storageSpacestorageSpacesRestClient = new StorageSpacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageSpacestorageSpacesApiVersion);
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
        /// Puts the Hybrid AKS storage object
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/storageSpaces/{storageSpacesName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>storageSpaces_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageSpacesName"> Parameter for the name of the storage object. </param>
        /// <param name="data"> The StorageSpace to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSpacesName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSpacesName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageSpaceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string storageSpacesName, StorageSpaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageSpacesName, nameof(storageSpacesName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageSpacestorageSpacesClientDiagnostics.CreateScope("StorageSpaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageSpacestorageSpacesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, storageSpacesName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridContainerServiceArmOperation<StorageSpaceResource>(new StorageSpaceOperationSource(Client), _storageSpacestorageSpacesClientDiagnostics, Pipeline, _storageSpacestorageSpacesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, storageSpacesName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Puts the Hybrid AKS storage object
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/storageSpaces/{storageSpacesName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>storageSpaces_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageSpacesName"> Parameter for the name of the storage object. </param>
        /// <param name="data"> The StorageSpace to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSpacesName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSpacesName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StorageSpaceResource> CreateOrUpdate(WaitUntil waitUntil, string storageSpacesName, StorageSpaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageSpacesName, nameof(storageSpacesName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageSpacestorageSpacesClientDiagnostics.CreateScope("StorageSpaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageSpacestorageSpacesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, storageSpacesName, data, cancellationToken);
                var operation = new HybridContainerServiceArmOperation<StorageSpaceResource>(new StorageSpaceOperationSource(Client), _storageSpacestorageSpacesClientDiagnostics, Pipeline, _storageSpacestorageSpacesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, storageSpacesName, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the Hybrid AKS storage space object
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/storageSpaces/{storageSpacesName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>storageSpaces_Retrieve</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageSpacesName"> Parameter for the name of the storage object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSpacesName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSpacesName"/> is null. </exception>
        public virtual async Task<Response<StorageSpaceResource>> GetAsync(string storageSpacesName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageSpacesName, nameof(storageSpacesName));

            using var scope = _storageSpacestorageSpacesClientDiagnostics.CreateScope("StorageSpaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageSpacestorageSpacesRestClient.RetrieveAsync(Id.SubscriptionId, Id.ResourceGroupName, storageSpacesName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSpaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Hybrid AKS storage space object
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/storageSpaces/{storageSpacesName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>storageSpaces_Retrieve</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageSpacesName"> Parameter for the name of the storage object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSpacesName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSpacesName"/> is null. </exception>
        public virtual Response<StorageSpaceResource> Get(string storageSpacesName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageSpacesName, nameof(storageSpacesName));

            using var scope = _storageSpacestorageSpacesClientDiagnostics.CreateScope("StorageSpaceCollection.Get");
            scope.Start();
            try
            {
                var response = _storageSpacestorageSpacesRestClient.Retrieve(Id.SubscriptionId, Id.ResourceGroupName, storageSpacesName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageSpaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the Hybrid AKS storage object by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/storageSpaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>storageSpaces_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageSpaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageSpaceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageSpacestorageSpacesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageSpacestorageSpacesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StorageSpaceResource(Client, StorageSpaceData.DeserializeStorageSpaceData(e)), _storageSpacestorageSpacesClientDiagnostics, Pipeline, "StorageSpaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List the Hybrid AKS storage object by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/storageSpaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>storageSpaces_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageSpaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageSpaceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageSpacestorageSpacesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageSpacestorageSpacesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StorageSpaceResource(Client, StorageSpaceData.DeserializeStorageSpaceData(e)), _storageSpacestorageSpacesClientDiagnostics, Pipeline, "StorageSpaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/storageSpaces/{storageSpacesName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>storageSpaces_Retrieve</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageSpacesName"> Parameter for the name of the storage object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSpacesName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSpacesName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storageSpacesName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageSpacesName, nameof(storageSpacesName));

            using var scope = _storageSpacestorageSpacesClientDiagnostics.CreateScope("StorageSpaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageSpacestorageSpacesRestClient.RetrieveAsync(Id.SubscriptionId, Id.ResourceGroupName, storageSpacesName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/storageSpaces/{storageSpacesName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>storageSpaces_Retrieve</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageSpacesName"> Parameter for the name of the storage object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageSpacesName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSpacesName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageSpacesName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageSpacesName, nameof(storageSpacesName));

            using var scope = _storageSpacestorageSpacesClientDiagnostics.CreateScope("StorageSpaceCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageSpacestorageSpacesRestClient.Retrieve(Id.SubscriptionId, Id.ResourceGroupName, storageSpacesName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageSpaceResource> IEnumerable<StorageSpaceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageSpaceResource> IAsyncEnumerable<StorageSpaceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
