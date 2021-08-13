// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VirtualNetworkGatewayConnection and their operations over a ResourceGroup. </summary>
    public partial class VirtualNetworkGatewayConnectionContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualNetworkGatewayConnectionsRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayConnectionContainer"/> class for mocking. </summary>
        protected VirtualNetworkGatewayConnectionContainer()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkGatewayConnectionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualNetworkGatewayConnectionContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new VirtualNetworkGatewayConnectionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a virtual network gateway connection in the specified resource group. </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network gateway connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<VirtualNetworkGatewayConnection> CreateOrUpdate(string virtualNetworkGatewayConnectionName, VirtualNetworkGatewayConnectionData parameters, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkGatewayConnectionName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayConnectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(virtualNetworkGatewayConnectionName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a virtual network gateway connection in the specified resource group. </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network gateway connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkGatewayConnection>> CreateOrUpdateAsync(string virtualNetworkGatewayConnectionName, VirtualNetworkGatewayConnectionData parameters, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkGatewayConnectionName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayConnectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(virtualNetworkGatewayConnectionName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a virtual network gateway connection in the specified resource group. </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network gateway connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VirtualNetworkGatewayConnectionCreateOrUpdateOperation StartCreateOrUpdate(string virtualNetworkGatewayConnectionName, VirtualNetworkGatewayConnectionData parameters, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkGatewayConnectionName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayConnectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, virtualNetworkGatewayConnectionName, parameters, cancellationToken);
                return new VirtualNetworkGatewayConnectionCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, virtualNetworkGatewayConnectionName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a virtual network gateway connection in the specified resource group. </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network gateway connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayConnectionName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualNetworkGatewayConnectionCreateOrUpdateOperation> StartCreateOrUpdateAsync(string virtualNetworkGatewayConnectionName, VirtualNetworkGatewayConnectionData parameters, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkGatewayConnectionName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkGatewayConnectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, virtualNetworkGatewayConnectionName, parameters, cancellationToken).ConfigureAwait(false);
                return new VirtualNetworkGatewayConnectionCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, virtualNetworkGatewayConnectionName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualNetworkGatewayConnection> Get(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionContainer.Get");
            scope.Start();
            try
            {
                if (virtualNetworkGatewayConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkGatewayConnectionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, virtualNetworkGatewayConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualNetworkGatewayConnection>> GetAsync(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionContainer.Get");
            scope.Start();
            try
            {
                if (virtualNetworkGatewayConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkGatewayConnectionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, virtualNetworkGatewayConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualNetworkGatewayConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualNetworkGatewayConnection> GetIfExists(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (virtualNetworkGatewayConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkGatewayConnectionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, virtualNetworkGatewayConnectionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VirtualNetworkGatewayConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualNetworkGatewayConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualNetworkGatewayConnection>> GetIfExistsAsync(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (virtualNetworkGatewayConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkGatewayConnectionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, virtualNetworkGatewayConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VirtualNetworkGatewayConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualNetworkGatewayConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (virtualNetworkGatewayConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkGatewayConnectionName));
                }

                var response = GetIfExists(virtualNetworkGatewayConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkGatewayConnectionName"> The name of the virtual network gateway connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string virtualNetworkGatewayConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (virtualNetworkGatewayConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(virtualNetworkGatewayConnectionName));
                }

                var response = await GetIfExistsAsync(virtualNetworkGatewayConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The List VirtualNetworkGatewayConnections operation retrieves all the virtual network gateways connections created. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkGatewayConnection" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<VirtualNetworkGatewayConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualNetworkGatewayConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualNetworkGatewayConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The List VirtualNetworkGatewayConnections operation retrieves all the virtual network gateways connections created. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkGatewayConnection" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<VirtualNetworkGatewayConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualNetworkGatewayConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualNetworkGatewayConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualNetworkGatewayConnection" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetworkGatewayConnection.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualNetworkGatewayConnection" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetworkGatewayConnection.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, VirtualNetworkGatewayConnection, VirtualNetworkGatewayConnectionData> Construct() { }
    }
}
