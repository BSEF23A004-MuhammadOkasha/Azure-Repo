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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VirtualNetworkPeering and their operations over its parent. </summary>
    public partial class VirtualNetworkPeeringCollection : ArmCollection, IEnumerable<VirtualNetworkPeering>, IAsyncEnumerable<VirtualNetworkPeering>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualNetworkPeeringsRestOperations _virtualNetworkPeeringsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkPeeringCollection"/> class for mocking. </summary>
        protected VirtualNetworkPeeringCollection()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkPeeringCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualNetworkPeeringCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _virtualNetworkPeeringsRestClient = new VirtualNetworkPeeringsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => VirtualNetwork.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a peering in the specified virtual network. </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the peering. </param>
        /// <param name="virtualNetworkPeeringParameters"> Parameters supplied to the create or update virtual network peering operation. </param>
        /// <param name="syncRemoteAddressSpace"> Parameter indicates the intention to sync the peering with the current address space on the remote vNet after it&apos;s updated. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> or <paramref name="virtualNetworkPeeringParameters"/> is null. </exception>
        public virtual VirtualNetworkPeeringCreateOrUpdateOperation CreateOrUpdate(string virtualNetworkPeeringName, VirtualNetworkPeeringData virtualNetworkPeeringParameters, SyncRemoteAddressSpace? syncRemoteAddressSpace = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkPeeringName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
            }
            if (virtualNetworkPeeringParameters == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworkPeeringsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, virtualNetworkPeeringParameters, syncRemoteAddressSpace, cancellationToken);
                var operation = new VirtualNetworkPeeringCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _virtualNetworkPeeringsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, virtualNetworkPeeringParameters, syncRemoteAddressSpace).Request, response);
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

        /// <summary> Creates or updates a peering in the specified virtual network. </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the peering. </param>
        /// <param name="virtualNetworkPeeringParameters"> Parameters supplied to the create or update virtual network peering operation. </param>
        /// <param name="syncRemoteAddressSpace"> Parameter indicates the intention to sync the peering with the current address space on the remote vNet after it&apos;s updated. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> or <paramref name="virtualNetworkPeeringParameters"/> is null. </exception>
        public async virtual Task<VirtualNetworkPeeringCreateOrUpdateOperation> CreateOrUpdateAsync(string virtualNetworkPeeringName, VirtualNetworkPeeringData virtualNetworkPeeringParameters, SyncRemoteAddressSpace? syncRemoteAddressSpace = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkPeeringName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
            }
            if (virtualNetworkPeeringParameters == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworkPeeringsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, virtualNetworkPeeringParameters, syncRemoteAddressSpace, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualNetworkPeeringCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _virtualNetworkPeeringsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, virtualNetworkPeeringParameters, syncRemoteAddressSpace).Request, response);
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

        /// <summary> Gets the specified virtual network peering. </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> is null. </exception>
        public virtual Response<VirtualNetworkPeering> Get(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkPeeringName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkPeeringsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkPeering(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified virtual network peering. </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkPeering>> GetAsync(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkPeeringName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkPeeringsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualNetworkPeering(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> is null. </exception>
        public virtual Response<VirtualNetworkPeering> GetIfExists(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkPeeringName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualNetworkPeeringsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VirtualNetworkPeering>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualNetworkPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkPeering>> GetIfExistsAsync(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkPeeringName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _virtualNetworkPeeringsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkPeeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VirtualNetworkPeering>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualNetworkPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkPeeringName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(virtualNetworkPeeringName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkPeeringName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkPeeringName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(virtualNetworkPeeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all virtual network peerings in a virtual network. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkPeering" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkPeering> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualNetworkPeering> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkPeeringsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualNetworkPeering> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkPeeringsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all virtual network peerings in a virtual network. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkPeering" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkPeering> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualNetworkPeering>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkPeeringsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualNetworkPeering>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkPeeringsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<VirtualNetworkPeering> IEnumerable<VirtualNetworkPeering>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualNetworkPeering> IAsyncEnumerable<VirtualNetworkPeering>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VirtualNetworkPeering, VirtualNetworkPeeringData> Construct() { }
    }
}
