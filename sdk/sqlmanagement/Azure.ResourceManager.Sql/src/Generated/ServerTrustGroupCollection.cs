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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ServerTrustGroup and their operations over its parent. </summary>
    public partial class ServerTrustGroupCollection : ArmCollection, IEnumerable<ServerTrustGroup>, IAsyncEnumerable<ServerTrustGroup>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ServerTrustGroupsRestOperations _serverTrustGroupsRestClient;
        private readonly string _locationName;

        /// <summary> Initializes a new instance of the <see cref="ServerTrustGroupCollection"/> class for mocking. </summary>
        protected ServerTrustGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerTrustGroupCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        internal ServerTrustGroupCollection(ArmResource parent, string locationName) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ServerTrustGroup.ResourceType, out string apiVersion);
            _serverTrustGroupsRestClient = new ServerTrustGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _locationName = locationName;
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ServerTrustGroups_CreateOrUpdate
        /// <summary> Creates or updates a server trust group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="parameters"> The server trust group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ServerTrustGroupCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string serverTrustGroupName, ServerTrustGroupData parameters, CancellationToken cancellationToken = default)
        {
            if (serverTrustGroupName == null)
            {
                throw new ArgumentNullException(nameof(serverTrustGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerTrustGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverTrustGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, parameters, cancellationToken);
                var operation = new ServerTrustGroupCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _serverTrustGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ServerTrustGroups_CreateOrUpdate
        /// <summary> Creates or updates a server trust group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="parameters"> The server trust group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ServerTrustGroupCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string serverTrustGroupName, ServerTrustGroupData parameters, CancellationToken cancellationToken = default)
        {
            if (serverTrustGroupName == null)
            {
                throw new ArgumentNullException(nameof(serverTrustGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerTrustGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverTrustGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ServerTrustGroupCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _serverTrustGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ServerTrustGroups_Get
        /// <summary> Gets a server trust group. </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual Response<ServerTrustGroup> Get(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            if (serverTrustGroupName == null)
            {
                throw new ArgumentNullException(nameof(serverTrustGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerTrustGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _serverTrustGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerTrustGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups/{serverTrustGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ServerTrustGroups_Get
        /// <summary> Gets a server trust group. </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public async virtual Task<Response<ServerTrustGroup>> GetAsync(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            if (serverTrustGroupName == null)
            {
                throw new ArgumentNullException(nameof(serverTrustGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerTrustGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverTrustGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerTrustGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual Response<ServerTrustGroup> GetIfExists(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            if (serverTrustGroupName == null)
            {
                throw new ArgumentNullException(nameof(serverTrustGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerTrustGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverTrustGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerTrustGroup>(null, response.GetRawResponse());
                return Response.FromValue(new ServerTrustGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public async virtual Task<Response<ServerTrustGroup>> GetIfExistsAsync(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            if (serverTrustGroupName == null)
            {
                throw new ArgumentNullException(nameof(serverTrustGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerTrustGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverTrustGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, serverTrustGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerTrustGroup>(null, response.GetRawResponse());
                return Response.FromValue(new ServerTrustGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            if (serverTrustGroupName == null)
            {
                throw new ArgumentNullException(nameof(serverTrustGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerTrustGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(serverTrustGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serverTrustGroupName"> The name of the server trust group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serverTrustGroupName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string serverTrustGroupName, CancellationToken cancellationToken = default)
        {
            if (serverTrustGroupName == null)
            {
                throw new ArgumentNullException(nameof(serverTrustGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerTrustGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(serverTrustGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ServerTrustGroups_ListByLocation
        /// <summary> Lists a server trust group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerTrustGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerTrustGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerTrustGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerTrustGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverTrustGroupsRestClient.ListByLocation(Id.SubscriptionId, Id.ResourceGroupName, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerTrustGroup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerTrustGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerTrustGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverTrustGroupsRestClient.ListByLocationNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerTrustGroup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/serverTrustGroups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: ServerTrustGroups_ListByLocation
        /// <summary> Lists a server trust group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerTrustGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerTrustGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerTrustGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerTrustGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverTrustGroupsRestClient.ListByLocationAsync(Id.SubscriptionId, Id.ResourceGroupName, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerTrustGroup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerTrustGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServerTrustGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverTrustGroupsRestClient.ListByLocationNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerTrustGroup(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="ServerTrustGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerTrustGroupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ServerTrustGroup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ServerTrustGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServerTrustGroupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ServerTrustGroup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerTrustGroup> IEnumerable<ServerTrustGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerTrustGroup> IAsyncEnumerable<ServerTrustGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ServerTrustGroup, ServerTrustGroupData> Construct() { }
    }
}
