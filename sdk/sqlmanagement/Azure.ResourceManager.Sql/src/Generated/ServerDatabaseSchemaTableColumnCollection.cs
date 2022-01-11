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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of DatabaseColumn and their operations over its parent. </summary>
    public partial class ServerDatabaseSchemaTableColumnCollection : ArmCollection, IEnumerable<ServerDatabaseSchemaTableColumn>, IAsyncEnumerable<ServerDatabaseSchemaTableColumn>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DatabaseColumnsRestOperations _databaseColumnsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerDatabaseSchemaTableColumnCollection"/> class for mocking. </summary>
        protected ServerDatabaseSchemaTableColumnCollection()
        {
        }

        /// <summary> Initializes a new instance of ServerDatabaseSchemaTableColumnCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServerDatabaseSchemaTableColumnCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _databaseColumnsRestClient = new DatabaseColumnsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ServerDatabaseSchemaTable.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// OperationId: DatabaseColumns_Get
        /// <summary> Get database column. </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public virtual Response<ServerDatabaseSchemaTableColumn> Get(string columnName, CancellationToken cancellationToken = default)
        {
            if (columnName == null)
            {
                throw new ArgumentNullException(nameof(columnName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnCollection.Get");
            scope.Start();
            try
            {
                var response = _databaseColumnsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, columnName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDatabaseSchemaTableColumn(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// OperationId: DatabaseColumns_Get
        /// <summary> Get database column. </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public async virtual Task<Response<ServerDatabaseSchemaTableColumn>> GetAsync(string columnName, CancellationToken cancellationToken = default)
        {
            if (columnName == null)
            {
                throw new ArgumentNullException(nameof(columnName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnCollection.Get");
            scope.Start();
            try
            {
                var response = await _databaseColumnsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, columnName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerDatabaseSchemaTableColumn(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public virtual Response<ServerDatabaseSchemaTableColumn> GetIfExists(string columnName, CancellationToken cancellationToken = default)
        {
            if (columnName == null)
            {
                throw new ArgumentNullException(nameof(columnName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _databaseColumnsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, columnName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ServerDatabaseSchemaTableColumn>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerDatabaseSchemaTableColumn(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public async virtual Task<Response<ServerDatabaseSchemaTableColumn>> GetIfExistsAsync(string columnName, CancellationToken cancellationToken = default)
        {
            if (columnName == null)
            {
                throw new ArgumentNullException(nameof(columnName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _databaseColumnsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, columnName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ServerDatabaseSchemaTableColumn>(null, response.GetRawResponse())
                    : Response.FromValue(new ServerDatabaseSchemaTableColumn(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public virtual Response<bool> Exists(string columnName, CancellationToken cancellationToken = default)
        {
            if (columnName == null)
            {
                throw new ArgumentNullException(nameof(columnName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(columnName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string columnName, CancellationToken cancellationToken = default)
        {
            if (columnName == null)
            {
                throw new ArgumentNullException(nameof(columnName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(columnName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// OperationId: DatabaseColumns_ListByTable
        /// <summary> List database columns. </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerDatabaseSchemaTableColumn" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerDatabaseSchemaTableColumn> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<ServerDatabaseSchemaTableColumn> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _databaseColumnsRestClient.ListByTable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDatabaseSchemaTableColumn(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerDatabaseSchemaTableColumn> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _databaseColumnsRestClient.ListByTableNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDatabaseSchemaTableColumn(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// OperationId: DatabaseColumns_ListByTable
        /// <summary> List database columns. </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerDatabaseSchemaTableColumn" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerDatabaseSchemaTableColumn> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerDatabaseSchemaTableColumn>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _databaseColumnsRestClient.ListByTableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDatabaseSchemaTableColumn(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerDatabaseSchemaTableColumn>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerDatabaseSchemaTableColumnCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _databaseColumnsRestClient.ListByTableNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDatabaseSchemaTableColumn(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ServerDatabaseSchemaTableColumn> IEnumerable<ServerDatabaseSchemaTableColumn>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerDatabaseSchemaTableColumn> IAsyncEnumerable<ServerDatabaseSchemaTableColumn>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ServerDatabaseSchemaTableColumn, DatabaseColumnData> Construct() { }
    }
}
