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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of RestorePoint and their operations over its parent. </summary>
    public partial class RestorePointCollection : ArmCollection, IEnumerable<RestorePoint>, IAsyncEnumerable<RestorePoint>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly RestorePointsRestOperations _restorePointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RestorePointCollection"/> class for mocking. </summary>
        protected RestorePointCollection()
        {
        }

        /// <summary> Initializes a new instance of RestorePointCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RestorePointCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restorePointsRestClient = new RestorePointsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Database.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints/{restorePointName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: RestorePoints_Get
        /// <summary> Gets a restore point. </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual Response<RestorePoint> Get(string restorePointName, CancellationToken cancellationToken = default)
        {
            if (restorePointName == null)
            {
                throw new ArgumentNullException(nameof(restorePointName));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.Get");
            scope.Start();
            try
            {
                var response = _restorePointsRestClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, restorePointName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorePoint(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints/{restorePointName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: RestorePoints_Get
        /// <summary> Gets a restore point. </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public async virtual Task<Response<RestorePoint>> GetAsync(string restorePointName, CancellationToken cancellationToken = default)
        {
            if (restorePointName == null)
            {
                throw new ArgumentNullException(nameof(restorePointName));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.Get");
            scope.Start();
            try
            {
                var response = await _restorePointsRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, restorePointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RestorePoint(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual Response<RestorePoint> GetIfExists(string restorePointName, CancellationToken cancellationToken = default)
        {
            if (restorePointName == null)
            {
                throw new ArgumentNullException(nameof(restorePointName));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _restorePointsRestClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, restorePointName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<RestorePoint>(null, response.GetRawResponse())
                    : Response.FromValue(new RestorePoint(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public async virtual Task<Response<RestorePoint>> GetIfExistsAsync(string restorePointName, CancellationToken cancellationToken = default)
        {
            if (restorePointName == null)
            {
                throw new ArgumentNullException(nameof(restorePointName));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _restorePointsRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, restorePointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<RestorePoint>(null, response.GetRawResponse())
                    : Response.FromValue(new RestorePoint(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string restorePointName, CancellationToken cancellationToken = default)
        {
            if (restorePointName == null)
            {
                throw new ArgumentNullException(nameof(restorePointName));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(restorePointName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string restorePointName, CancellationToken cancellationToken = default)
        {
            if (restorePointName == null)
            {
                throw new ArgumentNullException(nameof(restorePointName));
            }

            using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(restorePointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: RestorePoints_ListByDatabase
        /// <summary> Gets a list of database restore points. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorePoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorePoint> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RestorePoint> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restorePointsRestClient.ListByDatabase(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorePoint(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RestorePoint> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restorePointsRestClient.ListByDatabaseNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorePoint(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: RestorePoints_ListByDatabase
        /// <summary> Gets a list of database restore points. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorePoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorePoint> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RestorePoint>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restorePointsRestClient.ListByDatabaseAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorePoint(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RestorePoint>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RestorePointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restorePointsRestClient.ListByDatabaseNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RestorePoint(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<RestorePoint> IEnumerable<RestorePoint>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RestorePoint> IAsyncEnumerable<RestorePoint>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, RestorePoint, RestorePointData> Construct() { }
    }
}
