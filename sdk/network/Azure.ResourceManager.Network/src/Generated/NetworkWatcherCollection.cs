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

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of NetworkWatcher and their operations over its parent. </summary>
    public partial class NetworkWatcherCollection : ArmCollection, IEnumerable<NetworkWatcher>, IAsyncEnumerable<NetworkWatcher>
    {
        private readonly ClientDiagnostics _networkWatcherClientDiagnostics;
        private readonly NetworkWatchersRestOperations _networkWatcherRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkWatcherCollection"/> class for mocking. </summary>
        protected NetworkWatcherCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkWatcherCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkWatcherCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkWatcherClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkWatcher.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(NetworkWatcher.ResourceType, out string networkWatcherApiVersion);
            _networkWatcherRestClient = new NetworkWatchersRestOperations(_networkWatcherClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, networkWatcherApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a network watcher in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}
        /// Operation Id: NetworkWatchers_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="parameters"> Parameters that define the network watcher resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkWatcherName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<NetworkWatcher>> CreateOrUpdateAsync(bool waitForCompletion, string networkWatcherName, NetworkWatcherData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkWatcherName, nameof(networkWatcherName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkWatcherRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<NetworkWatcher>(Response.FromValue(new NetworkWatcher(Client, response), response.GetRawResponse()));
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

        /// <summary>
        /// Creates or updates a network watcher in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}
        /// Operation Id: NetworkWatchers_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="parameters"> Parameters that define the network watcher resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkWatcherName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<NetworkWatcher> CreateOrUpdate(bool waitForCompletion, string networkWatcherName, NetworkWatcherData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkWatcherName, nameof(networkWatcherName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkWatcherRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<NetworkWatcher>(Response.FromValue(new NetworkWatcher(Client, response), response.GetRawResponse()));
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

        /// <summary>
        /// Gets the specified network watcher by resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}
        /// Operation Id: NetworkWatchers_Get
        /// </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkWatcherName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public async virtual Task<Response<NetworkWatcher>> GetAsync(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkWatcherName, nameof(networkWatcherName));

            using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkWatcherRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _networkWatcherClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NetworkWatcher(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified network watcher by resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}
        /// Operation Id: NetworkWatchers_Get
        /// </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkWatcherName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public virtual Response<NetworkWatcher> Get(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkWatcherName, nameof(networkWatcherName));

            using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.Get");
            scope.Start();
            try
            {
                var response = _networkWatcherRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, cancellationToken);
                if (response.Value == null)
                    throw _networkWatcherClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkWatcher(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all network watchers by resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers
        /// Operation Id: NetworkWatchers_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkWatcher" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkWatcher> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkWatcher>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkWatcherRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkWatcher(Client, value)), null, response.GetRawResponse());
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
        /// Gets all network watchers by resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers
        /// Operation Id: NetworkWatchers_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkWatcher" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkWatcher> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NetworkWatcher> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _networkWatcherRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkWatcher(Client, value)), null, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}
        /// Operation Id: NetworkWatchers_Get
        /// </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkWatcherName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkWatcherName, nameof(networkWatcherName));

            using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(networkWatcherName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}
        /// Operation Id: NetworkWatchers_Get
        /// </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkWatcherName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkWatcherName, nameof(networkWatcherName));

            using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(networkWatcherName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}
        /// Operation Id: NetworkWatchers_Get
        /// </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkWatcherName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public async virtual Task<Response<NetworkWatcher>> GetIfExistsAsync(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkWatcherName, nameof(networkWatcherName));

            using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkWatcherRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<NetworkWatcher>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkWatcher(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}
        /// Operation Id: NetworkWatchers_Get
        /// </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkWatcherName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public virtual Response<NetworkWatcher> GetIfExists(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkWatcherName, nameof(networkWatcherName));

            using var scope = _networkWatcherClientDiagnostics.CreateScope("NetworkWatcherCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkWatcherRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<NetworkWatcher>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkWatcher(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkWatcher> IEnumerable<NetworkWatcher>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkWatcher> IAsyncEnumerable<NetworkWatcher>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
