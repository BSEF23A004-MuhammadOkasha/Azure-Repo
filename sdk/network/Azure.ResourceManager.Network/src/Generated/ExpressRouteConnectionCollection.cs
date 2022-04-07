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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ExpressRouteConnectionResource" /> and their operations.
    /// Each <see cref="ExpressRouteConnectionResource" /> in the collection will belong to the same instance of <see cref="ExpressRouteGatewayResource" />.
    /// To get an <see cref="ExpressRouteConnectionCollection" /> instance call the GetExpressRouteConnections method from an instance of <see cref="ExpressRouteGatewayResource" />.
    /// </summary>
    public partial class ExpressRouteConnectionCollection : ArmCollection, IEnumerable<ExpressRouteConnectionResource>, IAsyncEnumerable<ExpressRouteConnectionResource>
    {
        private readonly ClientDiagnostics _expressRouteConnectionClientDiagnostics;
        private readonly ExpressRouteConnectionsRestOperations _expressRouteConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteConnectionCollection"/> class for mocking. </summary>
        protected ExpressRouteConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRouteConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRouteConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExpressRouteConnectionResource.ResourceType, out string expressRouteConnectionApiVersion);
            _expressRouteConnectionRestClient = new ExpressRouteConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRouteConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ExpressRouteGatewayResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ExpressRouteGatewayResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a connection between an ExpressRoute gateway and an ExpressRoute circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}/expressRouteConnections/{connectionName}
        /// Operation Id: ExpressRouteConnections_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the connection subresource. </param>
        /// <param name="data"> Parameters required in an ExpressRouteConnection PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ExpressRouteConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string connectionName, ExpressRouteConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRouteConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRouteConnectionResource>(new ExpressRouteConnectionOperationSource(Client), _expressRouteConnectionClientDiagnostics, Pipeline, _expressRouteConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a connection between an ExpressRoute gateway and an ExpressRoute circuit.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}/expressRouteConnections/{connectionName}
        /// Operation Id: ExpressRouteConnections_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the connection subresource. </param>
        /// <param name="data"> Parameters required in an ExpressRouteConnection PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ExpressRouteConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string connectionName, ExpressRouteConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRouteConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRouteConnectionResource>(new ExpressRouteConnectionOperationSource(Client), _expressRouteConnectionClientDiagnostics, Pipeline, _expressRouteConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified ExpressRouteConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}/expressRouteConnections/{connectionName}
        /// Operation Id: ExpressRouteConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<ExpressRouteConnectionResource>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified ExpressRouteConnection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}/expressRouteConnections/{connectionName}
        /// Operation Id: ExpressRouteConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<ExpressRouteConnectionResource> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists ExpressRouteConnections.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}/expressRouteConnections
        /// Operation Id: ExpressRouteConnections_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRouteConnectionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteConnectionRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteConnectionResource(Client, value)), null, response.GetRawResponse());
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
        /// Lists ExpressRouteConnections.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}/expressRouteConnections
        /// Operation Id: ExpressRouteConnections_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExpressRouteConnectionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteConnectionRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteConnectionResource(Client, value)), null, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}/expressRouteConnections/{connectionName}
        /// Operation Id: ExpressRouteConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _expressRouteConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/expressRouteGateways/{expressRouteGatewayName}/expressRouteConnections/{connectionName}
        /// Operation Id: ExpressRouteConnections_Get
        /// </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var scope = _expressRouteConnectionClientDiagnostics.CreateScope("ExpressRouteConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _expressRouteConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRouteConnectionResource> IEnumerable<ExpressRouteConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteConnectionResource> IAsyncEnumerable<ExpressRouteConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
