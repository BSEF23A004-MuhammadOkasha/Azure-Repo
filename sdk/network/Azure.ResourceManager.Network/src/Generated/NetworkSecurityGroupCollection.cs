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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of NetworkSecurityGroup and their operations over its parent. </summary>
    public partial class NetworkSecurityGroupCollection : ArmCollection, IEnumerable<NetworkSecurityGroup>, IAsyncEnumerable<NetworkSecurityGroup>
    {
        private readonly ClientDiagnostics _networkSecurityGroupClientDiagnostics;
        private readonly NetworkSecurityGroupsRestOperations _networkSecurityGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkSecurityGroupCollection"/> class for mocking. </summary>
        protected NetworkSecurityGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkSecurityGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkSecurityGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkSecurityGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkSecurityGroup.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(NetworkSecurityGroup.ResourceType, out string networkSecurityGroupApiVersion);
            _networkSecurityGroupRestClient = new NetworkSecurityGroupsRestOperations(_networkSecurityGroupClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, networkSecurityGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary> Creates or updates a network security group in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="parameters"> Parameters supplied to the create or update network security group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<NetworkSecurityGroupCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string networkSecurityGroupName, NetworkSecurityGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityGroupName, nameof(networkSecurityGroupName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkSecurityGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkSecurityGroupCreateOrUpdateOperation(Client, _networkSecurityGroupClientDiagnostics, Pipeline, _networkSecurityGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, parameters).Request, response);
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

        /// <summary> Creates or updates a network security group in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="parameters"> Parameters supplied to the create or update network security group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual NetworkSecurityGroupCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string networkSecurityGroupName, NetworkSecurityGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityGroupName, nameof(networkSecurityGroupName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkSecurityGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, parameters, cancellationToken);
                var operation = new NetworkSecurityGroupCreateOrUpdateOperation(Client, _networkSecurityGroupClientDiagnostics, Pipeline, _networkSecurityGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, parameters).Request, response);
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

        /// <summary> Gets the specified network security group. </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public async virtual Task<Response<NetworkSecurityGroup>> GetAsync(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityGroupName, nameof(networkSecurityGroupName));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkSecurityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _networkSecurityGroupClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NetworkSecurityGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified network security group. </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public virtual Response<NetworkSecurityGroup> Get(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityGroupName, nameof(networkSecurityGroupName));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _networkSecurityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, expand, cancellationToken);
                if (response.Value == null)
                    throw _networkSecurityGroupClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all network security groups in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkSecurityGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkSecurityGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkSecurityGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkSecurityGroupRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkSecurityGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetworkSecurityGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkSecurityGroupRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkSecurityGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all network security groups in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkSecurityGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkSecurityGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NetworkSecurityGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _networkSecurityGroupRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkSecurityGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetworkSecurityGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _networkSecurityGroupRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkSecurityGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityGroupName, nameof(networkSecurityGroupName));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(networkSecurityGroupName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityGroupName, nameof(networkSecurityGroupName));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(networkSecurityGroupName, expand: expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public async virtual Task<Response<NetworkSecurityGroup>> GetIfExistsAsync(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityGroupName, nameof(networkSecurityGroupName));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkSecurityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<NetworkSecurityGroup>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public virtual Response<NetworkSecurityGroup> GetIfExists(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityGroupName, nameof(networkSecurityGroupName));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkSecurityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<NetworkSecurityGroup>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkSecurityGroup> IEnumerable<NetworkSecurityGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkSecurityGroup> IAsyncEnumerable<NetworkSecurityGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
