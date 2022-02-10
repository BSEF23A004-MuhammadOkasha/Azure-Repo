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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of DeletedServer and their operations over its parent. </summary>
    public partial class DeletedServerCollection : ArmCollection, IEnumerable<DeletedServer>, IAsyncEnumerable<DeletedServer>
    {
        private readonly ClientDiagnostics _deletedServerClientDiagnostics;
        private readonly DeletedServersRestOperations _deletedServerRestClient;
        private readonly string _locationName;

        /// <summary> Initializes a new instance of the <see cref="DeletedServerCollection"/> class for mocking. </summary>
        protected DeletedServerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedServerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        internal DeletedServerCollection(ArmClient client, ResourceIdentifier id, string locationName) : base(client, id)
        {
            _locationName = locationName;
            _deletedServerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", DeletedServer.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(DeletedServer.ResourceType, out string deletedServerApiVersion);
            _deletedServerRestClient = new DeletedServersRestOperations(_deletedServerClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, deletedServerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a deleted server.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers/{deletedServerName}
        /// Operation Id: DeletedServers_Get
        /// </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public async virtual Task<Response<DeletedServer>> GetAsync(string deletedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deletedServerName, nameof(deletedServerName));

            using var scope = _deletedServerClientDiagnostics.CreateScope("DeletedServerCollection.Get");
            scope.Start();
            try
            {
                var response = await _deletedServerRestClient.GetAsync(Id.SubscriptionId, _locationName, deletedServerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _deletedServerClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DeletedServer(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a deleted server.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers/{deletedServerName}
        /// Operation Id: DeletedServers_Get
        /// </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public virtual Response<DeletedServer> Get(string deletedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deletedServerName, nameof(deletedServerName));

            using var scope = _deletedServerClientDiagnostics.CreateScope("DeletedServerCollection.Get");
            scope.Start();
            try
            {
                var response = _deletedServerRestClient.Get(Id.SubscriptionId, _locationName, deletedServerName, cancellationToken);
                if (response.Value == null)
                    throw _deletedServerClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedServer(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of deleted servers for a location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers
        /// Operation Id: DeletedServers_ListByLocation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedServer" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedServer> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeletedServer>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _deletedServerClientDiagnostics.CreateScope("DeletedServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deletedServerRestClient.ListByLocationAsync(Id.SubscriptionId, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedServer(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeletedServer>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _deletedServerClientDiagnostics.CreateScope("DeletedServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deletedServerRestClient.ListByLocationNextPageAsync(nextLink, Id.SubscriptionId, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedServer(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of deleted servers for a location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers
        /// Operation Id: DeletedServers_ListByLocation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedServer" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedServer> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DeletedServer> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _deletedServerClientDiagnostics.CreateScope("DeletedServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deletedServerRestClient.ListByLocation(Id.SubscriptionId, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedServer(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeletedServer> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _deletedServerClientDiagnostics.CreateScope("DeletedServerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deletedServerRestClient.ListByLocationNextPage(nextLink, Id.SubscriptionId, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedServer(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers/{deletedServerName}
        /// Operation Id: DeletedServers_Get
        /// </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string deletedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deletedServerName, nameof(deletedServerName));

            using var scope = _deletedServerClientDiagnostics.CreateScope("DeletedServerCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(deletedServerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers/{deletedServerName}
        /// Operation Id: DeletedServers_Get
        /// </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public virtual Response<bool> Exists(string deletedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deletedServerName, nameof(deletedServerName));

            using var scope = _deletedServerClientDiagnostics.CreateScope("DeletedServerCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(deletedServerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers/{deletedServerName}
        /// Operation Id: DeletedServers_Get
        /// </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public async virtual Task<Response<DeletedServer>> GetIfExistsAsync(string deletedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deletedServerName, nameof(deletedServerName));

            using var scope = _deletedServerClientDiagnostics.CreateScope("DeletedServerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deletedServerRestClient.GetAsync(Id.SubscriptionId, _locationName, deletedServerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DeletedServer>(null, response.GetRawResponse());
                return Response.FromValue(new DeletedServer(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/deletedServers/{deletedServerName}
        /// Operation Id: DeletedServers_Get
        /// </summary>
        /// <param name="deletedServerName"> The name of the deleted server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deletedServerName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedServerName"/> is null. </exception>
        public virtual Response<DeletedServer> GetIfExists(string deletedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deletedServerName, nameof(deletedServerName));

            using var scope = _deletedServerClientDiagnostics.CreateScope("DeletedServerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deletedServerRestClient.Get(Id.SubscriptionId, _locationName, deletedServerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DeletedServer>(null, response.GetRawResponse());
                return Response.FromValue(new DeletedServer(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeletedServer> IEnumerable<DeletedServer>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeletedServer> IAsyncEnumerable<DeletedServer>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
