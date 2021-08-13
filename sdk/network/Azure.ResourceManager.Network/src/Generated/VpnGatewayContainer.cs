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
    /// <summary> A class representing collection of VpnGateway and their operations over a ResourceGroup. </summary>
    public partial class VpnGatewayContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VpnGatewaysRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="VpnGatewayContainer"/> class for mocking. </summary>
        protected VpnGatewayContainer()
        {
        }

        /// <summary> Initializes a new instance of VpnGatewayContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VpnGatewayContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new VpnGatewaysRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// <summary> Creates a virtual wan vpn gateway if it doesn&apos;t exist else updates the existing gateway. </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="vpnGatewayParameters"> Parameters supplied to create or Update a virtual wan vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="vpnGatewayParameters"/> is null. </exception>
        public virtual Response<VpnGateway> CreateOrUpdate(string gatewayName, VpnGatewayData vpnGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (vpnGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(gatewayName, vpnGatewayParameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a virtual wan vpn gateway if it doesn&apos;t exist else updates the existing gateway. </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="vpnGatewayParameters"> Parameters supplied to create or Update a virtual wan vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="vpnGatewayParameters"/> is null. </exception>
        public async virtual Task<Response<VpnGateway>> CreateOrUpdateAsync(string gatewayName, VpnGatewayData vpnGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (vpnGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(gatewayName, vpnGatewayParameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a virtual wan vpn gateway if it doesn&apos;t exist else updates the existing gateway. </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="vpnGatewayParameters"> Parameters supplied to create or Update a virtual wan vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="vpnGatewayParameters"/> is null. </exception>
        public virtual VpnGatewayCreateOrUpdateOperation StartCreateOrUpdate(string gatewayName, VpnGatewayData vpnGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (vpnGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, gatewayName, vpnGatewayParameters, cancellationToken);
                return new VpnGatewayCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, gatewayName, vpnGatewayParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a virtual wan vpn gateway if it doesn&apos;t exist else updates the existing gateway. </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="vpnGatewayParameters"> Parameters supplied to create or Update a virtual wan vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="vpnGatewayParameters"/> is null. </exception>
        public async virtual Task<VpnGatewayCreateOrUpdateOperation> StartCreateOrUpdateAsync(string gatewayName, VpnGatewayData vpnGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (vpnGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnGatewayContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, gatewayName, vpnGatewayParameters, cancellationToken).ConfigureAwait(false);
                return new VpnGatewayCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, gatewayName, vpnGatewayParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VpnGateway> Get(string gatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGatewayContainer.Get");
            scope.Start();
            try
            {
                if (gatewayName == null)
                {
                    throw new ArgumentNullException(nameof(gatewayName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, gatewayName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnGateway(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VpnGateway>> GetAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGatewayContainer.Get");
            scope.Start();
            try
            {
                if (gatewayName == null)
                {
                    throw new ArgumentNullException(nameof(gatewayName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, gatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VpnGateway(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VpnGateway> GetIfExists(string gatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGatewayContainer.GetIfExists");
            scope.Start();
            try
            {
                if (gatewayName == null)
                {
                    throw new ArgumentNullException(nameof(gatewayName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, gatewayName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VpnGateway>(null, response.GetRawResponse())
                    : Response.FromValue(new VpnGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VpnGateway>> GetIfExistsAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGatewayContainer.GetIfExists");
            scope.Start();
            try
            {
                if (gatewayName == null)
                {
                    throw new ArgumentNullException(nameof(gatewayName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, gatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VpnGateway>(null, response.GetRawResponse())
                    : Response.FromValue(new VpnGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string gatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGatewayContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (gatewayName == null)
                {
                    throw new ArgumentNullException(nameof(gatewayName));
                }

                var response = GetIfExists(gatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGatewayContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (gatewayName == null)
                {
                    throw new ArgumentNullException(nameof(gatewayName));
                }

                var response = await GetIfExistsAsync(gatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the VpnGateways in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VpnGateway" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<VpnGateway> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VpnGateway> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnGateway> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the VpnGateways in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VpnGateway" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<VpnGateway> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VpnGateway>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnGateway>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnGatewayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VpnGateway" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGatewayContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VpnGateway.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VpnGateway" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnGatewayContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VpnGateway.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, VpnGateway, VpnGatewayData> Construct() { }
    }
}
