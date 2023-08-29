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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="CassandraKeyspaceResource" /> and their operations.
    /// Each <see cref="CassandraKeyspaceResource" /> in the collection will belong to the same instance of <see cref="CosmosDBAccountResource" />.
    /// To get a <see cref="CassandraKeyspaceCollection" /> instance call the GetCassandraKeyspaces method from an instance of <see cref="CosmosDBAccountResource" />.
    /// </summary>
    public partial class CassandraKeyspaceCollection : ArmCollection, IEnumerable<CassandraKeyspaceResource>, IAsyncEnumerable<CassandraKeyspaceResource>
    {
        private readonly ClientDiagnostics _cassandraKeyspaceCassandraResourcesClientDiagnostics;
        private readonly CassandraResourcesRestOperations _cassandraKeyspaceCassandraResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CassandraKeyspaceCollection"/> class for mocking. </summary>
        protected CassandraKeyspaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CassandraKeyspaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CassandraKeyspaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cassandraKeyspaceCassandraResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CassandraKeyspaceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CassandraKeyspaceResource.ResourceType, out string cassandraKeyspaceCassandraResourcesApiVersion);
            _cassandraKeyspaceCassandraResourcesRestClient = new CassandraResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cassandraKeyspaceCassandraResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an Azure Cosmos DB Cassandra keyspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_CreateUpdateCassandraKeyspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="keyspaceName"> Cosmos DB keyspace name. </param>
        /// <param name="content"> The parameters to provide for the current Cassandra keyspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyspaceName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CassandraKeyspaceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string keyspaceName, CassandraKeyspaceCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyspaceName, nameof(keyspaceName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cassandraKeyspaceCassandraResourcesClientDiagnostics.CreateScope("CassandraKeyspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cassandraKeyspaceCassandraResourcesRestClient.CreateUpdateCassandraKeyspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyspaceName, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CassandraKeyspaceResource>(new CassandraKeyspaceOperationSource(Client), _cassandraKeyspaceCassandraResourcesClientDiagnostics, Pipeline, _cassandraKeyspaceCassandraResourcesRestClient.CreateCreateUpdateCassandraKeyspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyspaceName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update an Azure Cosmos DB Cassandra keyspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_CreateUpdateCassandraKeyspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="keyspaceName"> Cosmos DB keyspace name. </param>
        /// <param name="content"> The parameters to provide for the current Cassandra keyspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyspaceName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CassandraKeyspaceResource> CreateOrUpdate(WaitUntil waitUntil, string keyspaceName, CassandraKeyspaceCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyspaceName, nameof(keyspaceName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cassandraKeyspaceCassandraResourcesClientDiagnostics.CreateScope("CassandraKeyspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cassandraKeyspaceCassandraResourcesRestClient.CreateUpdateCassandraKeyspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyspaceName, content, cancellationToken);
                var operation = new CosmosDBArmOperation<CassandraKeyspaceResource>(new CassandraKeyspaceOperationSource(Client), _cassandraKeyspaceCassandraResourcesClientDiagnostics, Pipeline, _cassandraKeyspaceCassandraResourcesRestClient.CreateCreateUpdateCassandraKeyspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyspaceName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the Cassandra keyspaces under an existing Azure Cosmos DB database account with the provided name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_GetCassandraKeyspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyspaceName"> Cosmos DB keyspace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyspaceName"/> is null. </exception>
        public virtual async Task<Response<CassandraKeyspaceResource>> GetAsync(string keyspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyspaceName, nameof(keyspaceName));

            using var scope = _cassandraKeyspaceCassandraResourcesClientDiagnostics.CreateScope("CassandraKeyspaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _cassandraKeyspaceCassandraResourcesRestClient.GetCassandraKeyspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyspaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CassandraKeyspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Cassandra keyspaces under an existing Azure Cosmos DB database account with the provided name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_GetCassandraKeyspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyspaceName"> Cosmos DB keyspace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyspaceName"/> is null. </exception>
        public virtual Response<CassandraKeyspaceResource> Get(string keyspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyspaceName, nameof(keyspaceName));

            using var scope = _cassandraKeyspaceCassandraResourcesClientDiagnostics.CreateScope("CassandraKeyspaceCollection.Get");
            scope.Start();
            try
            {
                var response = _cassandraKeyspaceCassandraResourcesRestClient.GetCassandraKeyspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyspaceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CassandraKeyspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Cassandra keyspaces under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_ListCassandraKeyspaces</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CassandraKeyspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CassandraKeyspaceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cassandraKeyspaceCassandraResourcesRestClient.CreateListCassandraKeyspacesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new CassandraKeyspaceResource(Client, CassandraKeyspaceData.DeserializeCassandraKeyspaceData(e)), _cassandraKeyspaceCassandraResourcesClientDiagnostics, Pipeline, "CassandraKeyspaceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the Cassandra keyspaces under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_ListCassandraKeyspaces</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CassandraKeyspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CassandraKeyspaceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cassandraKeyspaceCassandraResourcesRestClient.CreateListCassandraKeyspacesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new CassandraKeyspaceResource(Client, CassandraKeyspaceData.DeserializeCassandraKeyspaceData(e)), _cassandraKeyspaceCassandraResourcesClientDiagnostics, Pipeline, "CassandraKeyspaceCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_GetCassandraKeyspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyspaceName"> Cosmos DB keyspace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyspaceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string keyspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyspaceName, nameof(keyspaceName));

            using var scope = _cassandraKeyspaceCassandraResourcesClientDiagnostics.CreateScope("CassandraKeyspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cassandraKeyspaceCassandraResourcesRestClient.GetCassandraKeyspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraResources_GetCassandraKeyspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="keyspaceName"> Cosmos DB keyspace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="keyspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="keyspaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string keyspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(keyspaceName, nameof(keyspaceName));

            using var scope = _cassandraKeyspaceCassandraResourcesClientDiagnostics.CreateScope("CassandraKeyspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = _cassandraKeyspaceCassandraResourcesRestClient.GetCassandraKeyspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, keyspaceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CassandraKeyspaceResource> IEnumerable<CassandraKeyspaceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CassandraKeyspaceResource> IAsyncEnumerable<CassandraKeyspaceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
