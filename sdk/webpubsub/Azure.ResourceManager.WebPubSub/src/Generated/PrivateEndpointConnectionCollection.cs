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

namespace Azure.ResourceManager.WebPubSub
{
    /// <summary> A class representing collection of PrivateEndpointConnection and their operations over its parent. </summary>
    public partial class PrivateEndpointConnectionCollection : ArmCollection, IEnumerable<PrivateEndpointConnection>, IAsyncEnumerable<PrivateEndpointConnection>
    {
        private readonly ClientDiagnostics _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics;
        private readonly WebPubSubPrivateEndpointConnectionsRestOperations _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected PrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PrivateEndpointConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.WebPubSub", PrivateEndpointConnection.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(PrivateEndpointConnection.ResourceType, out string privateEndpointConnectionWebPubSubPrivateEndpointConnectionsApiVersion);
            _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient = new WebPubSubPrivateEndpointConnectionsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, privateEndpointConnectionWebPubSubPrivateEndpointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebPubSub.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebPubSub.ResourceType), nameof(id));
        }

        /// <summary>
        /// Update the state of specified private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebPubSubPrivateEndpointConnections_Update
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="parameters"> The resource of private endpoint and its properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<PrivateEndpointConnection>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateEndpointConnectionName, PrivateEndpointConnectionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new WebPubSubArmOperation<PrivateEndpointConnection>(Response.FromValue(new PrivateEndpointConnection(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
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
        /// Update the state of specified private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebPubSubPrivateEndpointConnections_Update
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="parameters"> The resource of private endpoint and its properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<PrivateEndpointConnection> CreateOrUpdate(WaitUntil waitUntil, string privateEndpointConnectionName, PrivateEndpointConnectionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, parameters, cancellationToken);
                var operation = new WebPubSubArmOperation<PrivateEndpointConnection>(Response.FromValue(new PrivateEndpointConnection(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
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
        /// Get the specified private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebPubSubPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<PrivateEndpointConnection>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified private endpoint connection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebPubSubPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<PrivateEndpointConnection> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List private endpoint connections
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/privateEndpointConnections
        /// Operation Id: WebPubSubPrivateEndpointConnections_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateEndpointConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateEndpointConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PrivateEndpointConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PrivateEndpointConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List private endpoint connections
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/privateEndpointConnections
        /// Operation Id: WebPubSubPrivateEndpointConnections_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateEndpointConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateEndpointConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PrivateEndpointConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PrivateEndpointConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnection(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebPubSubPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebPubSubPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(privateEndpointConnectionName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebPubSubPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<PrivateEndpointConnection>> GetIfExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<PrivateEndpointConnection>(null, response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: WebPubSubPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<PrivateEndpointConnection> GetIfExists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<PrivateEndpointConnection>(null, response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PrivateEndpointConnection> IEnumerable<PrivateEndpointConnection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PrivateEndpointConnection> IAsyncEnumerable<PrivateEndpointConnection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
