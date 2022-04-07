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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="CassandraTableResource" /> and their operations.
    /// Each <see cref="CassandraTableResource" /> in the collection will belong to the same instance of <see cref="CassandraKeyspaceResource" />.
    /// To get a <see cref="CassandraTableCollection" /> instance call the GetCassandraTables method from an instance of <see cref="CassandraKeyspaceResource" />.
    /// </summary>
    public partial class CassandraTableCollection : ArmCollection, IEnumerable<CassandraTableResource>, IAsyncEnumerable<CassandraTableResource>
    {
        private readonly ClientDiagnostics _cassandraTableCassandraResourcesClientDiagnostics;
        private readonly CassandraResourcesRestOperations _cassandraTableCassandraResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CassandraTableCollection"/> class for mocking. </summary>
        protected CassandraTableCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CassandraTableCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CassandraTableCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cassandraTableCassandraResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CassandraTableResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CassandraTableResource.ResourceType, out string cassandraTableCassandraResourcesApiVersion);
            _cassandraTableCassandraResourcesRestClient = new CassandraResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cassandraTableCassandraResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CassandraKeyspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CassandraKeyspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an Azure Cosmos DB Cassandra Table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/tables/{tableName}
        /// Operation Id: CassandraResources_CreateUpdateCassandraTable
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="content"> The parameters to provide for the current Cassandra Table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CassandraTableResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string tableName, CassandraTableCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cassandraTableCassandraResourcesRestClient.CreateUpdateCassandraTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CassandraTableResource>(new CassandraTableOperationSource(Client), _cassandraTableCassandraResourcesClientDiagnostics, Pipeline, _cassandraTableCassandraResourcesRestClient.CreateCreateUpdateCassandraTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update an Azure Cosmos DB Cassandra Table
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/tables/{tableName}
        /// Operation Id: CassandraResources_CreateUpdateCassandraTable
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="content"> The parameters to provide for the current Cassandra Table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CassandraTableResource> CreateOrUpdate(WaitUntil waitUntil, string tableName, CassandraTableCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cassandraTableCassandraResourcesRestClient.CreateUpdateCassandraTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, content, cancellationToken);
                var operation = new CosmosDBArmOperation<CassandraTableResource>(new CassandraTableOperationSource(Client), _cassandraTableCassandraResourcesClientDiagnostics, Pipeline, _cassandraTableCassandraResourcesRestClient.CreateCreateUpdateCassandraTableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the Cassandra table under an existing Azure Cosmos DB database account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/tables/{tableName}
        /// Operation Id: CassandraResources_GetCassandraTable
        /// </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual async Task<Response<CassandraTableResource>> GetAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.Get");
            scope.Start();
            try
            {
                var response = await _cassandraTableCassandraResourcesRestClient.GetCassandraTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CassandraTableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the Cassandra table under an existing Azure Cosmos DB database account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/tables/{tableName}
        /// Operation Id: CassandraResources_GetCassandraTable
        /// </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<CassandraTableResource> Get(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.Get");
            scope.Start();
            try
            {
                var response = _cassandraTableCassandraResourcesRestClient.GetCassandraTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CassandraTableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Cassandra table under an existing Azure Cosmos DB database account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/tables
        /// Operation Id: CassandraResources_ListCassandraTables
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CassandraTableResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CassandraTableResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CassandraTableResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cassandraTableCassandraResourcesRestClient.ListCassandraTablesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CassandraTableResource(Client, value)), null, response.GetRawResponse());
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
        /// Lists the Cassandra table under an existing Azure Cosmos DB database account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/tables
        /// Operation Id: CassandraResources_ListCassandraTables
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CassandraTableResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CassandraTableResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CassandraTableResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cassandraTableCassandraResourcesRestClient.ListCassandraTables(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CassandraTableResource(Client, value)), null, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/tables/{tableName}
        /// Operation Id: CassandraResources_GetCassandraTable
        /// </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cassandraTableCassandraResourcesRestClient.GetCassandraTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/cassandraKeyspaces/{keyspaceName}/tables/{tableName}
        /// Operation Id: CassandraResources_GetCassandraTable
        /// </summary>
        /// <param name="tableName"> Cosmos DB table name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public virtual Response<bool> Exists(string tableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var scope = _cassandraTableCassandraResourcesClientDiagnostics.CreateScope("CassandraTableCollection.Exists");
            scope.Start();
            try
            {
                var response = _cassandraTableCassandraResourcesRestClient.GetCassandraTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, tableName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CassandraTableResource> IEnumerable<CassandraTableResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CassandraTableResource> IAsyncEnumerable<CassandraTableResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
