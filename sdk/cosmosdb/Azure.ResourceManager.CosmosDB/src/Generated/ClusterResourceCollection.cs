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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="ClusterResource" /> and their operations.
    /// Each <see cref="ClusterResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ClusterResourceCollection" /> instance call the GetClusterResources method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ClusterResourceCollection : ArmCollection, IEnumerable<ClusterResource>, IAsyncEnumerable<ClusterResource>
    {
        private readonly ClientDiagnostics _clusterResourceCassandraClustersClientDiagnostics;
        private readonly CassandraClustersRestOperations _clusterResourceCassandraClustersRestClient;

        /// <summary> Initializes a new instance of the <see cref="ClusterResourceCollection"/> class for mocking. </summary>
        protected ClusterResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ClusterResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ClusterResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _clusterResourceCassandraClustersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ClusterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ClusterResource.ResourceType, out string clusterResourceCassandraClustersApiVersion);
            _clusterResourceCassandraClustersRestClient = new CassandraClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, clusterResourceCassandraClustersApiVersion);
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
        /// Create or update a managed Cassandra cluster. When updating, you must specify all writable properties. To update only some properties, use PATCH.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}
        /// Operation Id: CassandraClusters_CreateUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clusterName"> Managed Cassandra cluster name. </param>
        /// <param name="data"> The properties specifying the desired state of the managed Cassandra cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ClusterResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string clusterName, ClusterResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _clusterResourceCassandraClustersClientDiagnostics.CreateScope("ClusterResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _clusterResourceCassandraClustersRestClient.CreateUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<ClusterResource>(new ClusterResourceOperationSource(Client), _clusterResourceCassandraClustersClientDiagnostics, Pipeline, _clusterResourceCassandraClustersRestClient.CreateCreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a managed Cassandra cluster. When updating, you must specify all writable properties. To update only some properties, use PATCH.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}
        /// Operation Id: CassandraClusters_CreateUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clusterName"> Managed Cassandra cluster name. </param>
        /// <param name="data"> The properties specifying the desired state of the managed Cassandra cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ClusterResource> CreateOrUpdate(WaitUntil waitUntil, string clusterName, ClusterResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _clusterResourceCassandraClustersClientDiagnostics.CreateScope("ClusterResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _clusterResourceCassandraClustersRestClient.CreateUpdate(Id.SubscriptionId, Id.ResourceGroupName, clusterName, data, cancellationToken);
                var operation = new CosmosDBArmOperation<ClusterResource>(new ClusterResourceOperationSource(Client), _clusterResourceCassandraClustersClientDiagnostics, Pipeline, _clusterResourceCassandraClustersRestClient.CreateCreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get the properties of a managed Cassandra cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}
        /// Operation Id: CassandraClusters_Get
        /// </summary>
        /// <param name="clusterName"> Managed Cassandra cluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual async Task<Response<ClusterResource>> GetAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _clusterResourceCassandraClustersClientDiagnostics.CreateScope("ClusterResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _clusterResourceCassandraClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of a managed Cassandra cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}
        /// Operation Id: CassandraClusters_Get
        /// </summary>
        /// <param name="clusterName"> Managed Cassandra cluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<ClusterResource> Get(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _clusterResourceCassandraClustersClientDiagnostics.CreateScope("ClusterResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _clusterResourceCassandraClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all managed Cassandra clusters in this resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters
        /// Operation Id: CassandraClusters_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ClusterResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ClusterResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clusterResourceCassandraClustersClientDiagnostics.CreateScope("ClusterResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _clusterResourceCassandraClustersRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ClusterResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List all managed Cassandra clusters in this resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters
        /// Operation Id: CassandraClusters_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ClusterResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ClusterResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clusterResourceCassandraClustersClientDiagnostics.CreateScope("ClusterResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _clusterResourceCassandraClustersRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ClusterResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}
        /// Operation Id: CassandraClusters_Get
        /// </summary>
        /// <param name="clusterName"> Managed Cassandra cluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _clusterResourceCassandraClustersClientDiagnostics.CreateScope("ClusterResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _clusterResourceCassandraClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/cassandraClusters/{clusterName}
        /// Operation Id: CassandraClusters_Get
        /// </summary>
        /// <param name="clusterName"> Managed Cassandra cluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<bool> Exists(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _clusterResourceCassandraClustersClientDiagnostics.CreateScope("ClusterResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _clusterResourceCassandraClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ClusterResource> IEnumerable<ClusterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ClusterResource> IAsyncEnumerable<ClusterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
