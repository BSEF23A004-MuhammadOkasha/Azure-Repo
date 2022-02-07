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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of SqlContainer and their operations over its parent. </summary>
    public partial class SqlContainerCollection : ArmCollection, IEnumerable<SqlContainer>, IAsyncEnumerable<SqlContainer>
    {
        private readonly ClientDiagnostics _sqlContainerSqlResourcesClientDiagnostics;
        private readonly SqlResourcesRestOperations _sqlContainerSqlResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlContainerCollection"/> class for mocking. </summary>
        protected SqlContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlContainerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlContainerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlContainerSqlResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", SqlContainer.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(SqlContainer.ResourceType, out string sqlContainerSqlResourcesApiVersion);
            _sqlContainerSqlResourcesRestClient = new SqlResourcesRestOperations(_sqlContainerSqlResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, sqlContainerSqlResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabase.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabase.ResourceType), nameof(id));
        }

        /// <summary> Create or update an Azure Cosmos DB SQL container. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="createUpdateSqlContainerParameters"> The parameters to provide for the current SQL container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="createUpdateSqlContainerParameters"/> is null. </exception>
        public async virtual Task<SqlContainerCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string containerName, SqlContainerCreateUpdateOptions createUpdateSqlContainerParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            if (createUpdateSqlContainerParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateSqlContainerParameters));
            }

            using var scope = _sqlContainerSqlResourcesClientDiagnostics.CreateScope("SqlContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlContainerSqlResourcesRestClient.CreateUpdateSqlContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, createUpdateSqlContainerParameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlContainerCreateOrUpdateOperation(Client, _sqlContainerSqlResourcesClientDiagnostics, Pipeline, _sqlContainerSqlResourcesRestClient.CreateCreateUpdateSqlContainerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, createUpdateSqlContainerParameters).Request, response);
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

        /// <summary> Create or update an Azure Cosmos DB SQL container. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="createUpdateSqlContainerParameters"> The parameters to provide for the current SQL container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="createUpdateSqlContainerParameters"/> is null. </exception>
        public virtual SqlContainerCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string containerName, SqlContainerCreateUpdateOptions createUpdateSqlContainerParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));
            if (createUpdateSqlContainerParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateSqlContainerParameters));
            }

            using var scope = _sqlContainerSqlResourcesClientDiagnostics.CreateScope("SqlContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlContainerSqlResourcesRestClient.CreateUpdateSqlContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, createUpdateSqlContainerParameters, cancellationToken);
                var operation = new SqlContainerCreateOrUpdateOperation(Client, _sqlContainerSqlResourcesClientDiagnostics, Pipeline, _sqlContainerSqlResourcesRestClient.CreateCreateUpdateSqlContainerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, createUpdateSqlContainerParameters).Request, response);
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

        /// <summary> Gets the SQL container under an existing Azure Cosmos DB database account. </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public async virtual Task<Response<SqlContainer>> GetAsync(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _sqlContainerSqlResourcesClientDiagnostics.CreateScope("SqlContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlContainerSqlResourcesRestClient.GetSqlContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _sqlContainerSqlResourcesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SqlContainer(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the SQL container under an existing Azure Cosmos DB database account. </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual Response<SqlContainer> Get(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _sqlContainerSqlResourcesClientDiagnostics.CreateScope("SqlContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlContainerSqlResourcesRestClient.GetSqlContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, cancellationToken);
                if (response.Value == null)
                    throw _sqlContainerSqlResourcesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlContainer(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the SQL container under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlContainer" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlContainer> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlContainer>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlContainerSqlResourcesClientDiagnostics.CreateScope("SqlContainerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlContainerSqlResourcesRestClient.ListSqlContainersAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlContainer(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists the SQL container under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlContainer" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlContainer> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SqlContainer> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlContainerSqlResourcesClientDiagnostics.CreateScope("SqlContainerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlContainerSqlResourcesRestClient.ListSqlContainers(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlContainer(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _sqlContainerSqlResourcesClientDiagnostics.CreateScope("SqlContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(containerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual Response<bool> Exists(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _sqlContainerSqlResourcesClientDiagnostics.CreateScope("SqlContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(containerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public async virtual Task<Response<SqlContainer>> GetIfExistsAsync(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _sqlContainerSqlResourcesClientDiagnostics.CreateScope("SqlContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlContainerSqlResourcesRestClient.GetSqlContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SqlContainer>(null, response.GetRawResponse());
                return Response.FromValue(new SqlContainer(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="containerName"> Cosmos DB container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="containerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual Response<SqlContainer> GetIfExists(string containerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(containerName, nameof(containerName));

            using var scope = _sqlContainerSqlResourcesClientDiagnostics.CreateScope("SqlContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlContainerSqlResourcesRestClient.GetSqlContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, containerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SqlContainer>(null, response.GetRawResponse());
                return Response.FromValue(new SqlContainer(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlContainer> IEnumerable<SqlContainer>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlContainer> IAsyncEnumerable<SqlContainer>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
