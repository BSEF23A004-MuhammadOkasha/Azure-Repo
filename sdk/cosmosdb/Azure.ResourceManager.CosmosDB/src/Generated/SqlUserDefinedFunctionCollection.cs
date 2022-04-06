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
    /// A class representing a collection of <see cref="SqlUserDefinedFunctionResource" /> and their operations.
    /// Each <see cref="SqlUserDefinedFunctionResource" /> in the collection will belong to the same instance of <see cref="SqlContainerResource" />.
    /// To get a <see cref="SqlUserDefinedFunctionCollection" /> instance call the GetSqlUserDefinedFunctions method from an instance of <see cref="SqlContainerResource" />.
    /// </summary>
    public partial class SqlUserDefinedFunctionCollection : ArmCollection, IEnumerable<SqlUserDefinedFunctionResource>, IAsyncEnumerable<SqlUserDefinedFunctionResource>
    {
        private readonly ClientDiagnostics _sqlUserDefinedFunctionSqlResourcesClientDiagnostics;
        private readonly SqlResourcesRestOperations _sqlUserDefinedFunctionSqlResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlUserDefinedFunctionCollection"/> class for mocking. </summary>
        protected SqlUserDefinedFunctionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlUserDefinedFunctionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlUserDefinedFunctionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlUserDefinedFunctionSqlResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", SqlUserDefinedFunctionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlUserDefinedFunctionResource.ResourceType, out string sqlUserDefinedFunctionSqlResourcesApiVersion);
            _sqlUserDefinedFunctionSqlResourcesRestClient = new SqlResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlUserDefinedFunctionSqlResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlContainerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlContainerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an Azure Cosmos DB SQL userDefinedFunction
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/userDefinedFunctions/{userDefinedFunctionName}
        /// Operation Id: SqlResources_CreateUpdateSqlUserDefinedFunction
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="content"> The parameters to provide for the current SQL userDefinedFunction. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userDefinedFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlUserDefinedFunctionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string userDefinedFunctionName, SqlUserDefinedFunctionCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userDefinedFunctionName, nameof(userDefinedFunctionName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _sqlUserDefinedFunctionSqlResourcesClientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlUserDefinedFunctionSqlResourcesRestClient.CreateUpdateSqlUserDefinedFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<SqlUserDefinedFunctionResource>(new SqlUserDefinedFunctionOperationSource(Client), _sqlUserDefinedFunctionSqlResourcesClientDiagnostics, Pipeline, _sqlUserDefinedFunctionSqlResourcesRestClient.CreateCreateUpdateSqlUserDefinedFunctionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update an Azure Cosmos DB SQL userDefinedFunction
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/userDefinedFunctions/{userDefinedFunctionName}
        /// Operation Id: SqlResources_CreateUpdateSqlUserDefinedFunction
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="content"> The parameters to provide for the current SQL userDefinedFunction. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userDefinedFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<SqlUserDefinedFunctionResource> CreateOrUpdate(WaitUntil waitUntil, string userDefinedFunctionName, SqlUserDefinedFunctionCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userDefinedFunctionName, nameof(userDefinedFunctionName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _sqlUserDefinedFunctionSqlResourcesClientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlUserDefinedFunctionSqlResourcesRestClient.CreateUpdateSqlUserDefinedFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, content, cancellationToken);
                var operation = new CosmosDBArmOperation<SqlUserDefinedFunctionResource>(new SqlUserDefinedFunctionOperationSource(Client), _sqlUserDefinedFunctionSqlResourcesClientDiagnostics, Pipeline, _sqlUserDefinedFunctionSqlResourcesRestClient.CreateCreateUpdateSqlUserDefinedFunctionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the SQL userDefinedFunction under an existing Azure Cosmos DB database account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/userDefinedFunctions/{userDefinedFunctionName}
        /// Operation Id: SqlResources_GetSqlUserDefinedFunction
        /// </summary>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userDefinedFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> is null. </exception>
        public virtual async Task<Response<SqlUserDefinedFunctionResource>> GetAsync(string userDefinedFunctionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userDefinedFunctionName, nameof(userDefinedFunctionName));

            using var scope = _sqlUserDefinedFunctionSqlResourcesClientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlUserDefinedFunctionSqlResourcesRestClient.GetSqlUserDefinedFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlUserDefinedFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the SQL userDefinedFunction under an existing Azure Cosmos DB database account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/userDefinedFunctions/{userDefinedFunctionName}
        /// Operation Id: SqlResources_GetSqlUserDefinedFunction
        /// </summary>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userDefinedFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> is null. </exception>
        public virtual Response<SqlUserDefinedFunctionResource> Get(string userDefinedFunctionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userDefinedFunctionName, nameof(userDefinedFunctionName));

            using var scope = _sqlUserDefinedFunctionSqlResourcesClientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlUserDefinedFunctionSqlResourcesRestClient.GetSqlUserDefinedFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlUserDefinedFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the SQL userDefinedFunction under an existing Azure Cosmos DB database account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/userDefinedFunctions
        /// Operation Id: SqlResources_ListSqlUserDefinedFunctions
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlUserDefinedFunctionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlUserDefinedFunctionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlUserDefinedFunctionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlUserDefinedFunctionSqlResourcesClientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlUserDefinedFunctionSqlResourcesRestClient.ListSqlUserDefinedFunctionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlUserDefinedFunctionResource(Client, value)), null, response.GetRawResponse());
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
        /// Lists the SQL userDefinedFunction under an existing Azure Cosmos DB database account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/userDefinedFunctions
        /// Operation Id: SqlResources_ListSqlUserDefinedFunctions
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlUserDefinedFunctionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlUserDefinedFunctionResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SqlUserDefinedFunctionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlUserDefinedFunctionSqlResourcesClientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlUserDefinedFunctionSqlResourcesRestClient.ListSqlUserDefinedFunctions(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlUserDefinedFunctionResource(Client, value)), null, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/userDefinedFunctions/{userDefinedFunctionName}
        /// Operation Id: SqlResources_GetSqlUserDefinedFunction
        /// </summary>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userDefinedFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string userDefinedFunctionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userDefinedFunctionName, nameof(userDefinedFunctionName));

            using var scope = _sqlUserDefinedFunctionSqlResourcesClientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlUserDefinedFunctionSqlResourcesRestClient.GetSqlUserDefinedFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/userDefinedFunctions/{userDefinedFunctionName}
        /// Operation Id: SqlResources_GetSqlUserDefinedFunction
        /// </summary>
        /// <param name="userDefinedFunctionName"> Cosmos DB userDefinedFunction name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userDefinedFunctionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userDefinedFunctionName"/> is null. </exception>
        public virtual Response<bool> Exists(string userDefinedFunctionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userDefinedFunctionName, nameof(userDefinedFunctionName));

            using var scope = _sqlUserDefinedFunctionSqlResourcesClientDiagnostics.CreateScope("SqlUserDefinedFunctionCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlUserDefinedFunctionSqlResourcesRestClient.GetSqlUserDefinedFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, userDefinedFunctionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlUserDefinedFunctionResource> IEnumerable<SqlUserDefinedFunctionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlUserDefinedFunctionResource> IAsyncEnumerable<SqlUserDefinedFunctionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
