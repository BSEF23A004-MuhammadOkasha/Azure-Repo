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
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ExpressRouteConnection and their operations over a ExpressRouteGateway. </summary>
    public partial class ExpressRouteConnectionCollection : ArmCollection, IEnumerable<ExpressRouteConnection>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ExpressRouteConnectionsRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteConnectionCollection"/> class for mocking. </summary>
        protected ExpressRouteConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteConnectionCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ExpressRouteConnectionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new ExpressRouteConnectionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        IEnumerator<ExpressRouteConnection> IEnumerable<ExpressRouteConnection>.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ExpressRouteGateway.ResourceType;

        // Collection level operations.

        /// <summary> Creates a connection between an ExpressRoute gateway and an ExpressRoute circuit. </summary>
        /// <param name="connectionName"> The name of the connection subresource. </param>
        /// <param name="putExpressRouteConnectionParameters"> Parameters required in an ExpressRouteConnection PUT operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="putExpressRouteConnectionParameters"/> is null. </exception>
        public virtual ExpressRouteConnectionCreateOrUpdateOperation CreateOrUpdate(string connectionName, ExpressRouteConnectionData putExpressRouteConnectionParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (putExpressRouteConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(putExpressRouteConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, connectionName, putExpressRouteConnectionParameters, cancellationToken);
                var operation = new ExpressRouteConnectionCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, connectionName, putExpressRouteConnectionParameters).Request, response);
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

        /// <summary> Creates a connection between an ExpressRoute gateway and an ExpressRoute circuit. </summary>
        /// <param name="connectionName"> The name of the connection subresource. </param>
        /// <param name="putExpressRouteConnectionParameters"> Parameters required in an ExpressRouteConnection PUT operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="putExpressRouteConnectionParameters"/> is null. </exception>
        public async virtual Task<ExpressRouteConnectionCreateOrUpdateOperation> CreateOrUpdateAsync(string connectionName, ExpressRouteConnectionData putExpressRouteConnectionParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (putExpressRouteConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(putExpressRouteConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, connectionName, putExpressRouteConnectionParameters, cancellationToken).ConfigureAwait(false);
                var operation = new ExpressRouteConnectionCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, connectionName, putExpressRouteConnectionParameters).Request, response);
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

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ExpressRouteConnection> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionCollection.Get");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<ExpressRouteConnection>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionCollection.Get");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ExpressRouteConnection> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ExpressRouteConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new ExpressRouteConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<ExpressRouteConnection>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ExpressRouteConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new ExpressRouteConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionCollection.CheckIfExists");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                var response = GetIfExists(connectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionCollection.CheckIfExists");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                var response = await GetIfExistsAsync(connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists ExpressRouteConnections. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<ExpressRouteConnection>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionCollection.GetAll");
            scope.Start();
            try
            {
                var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value.Select(data => new ExpressRouteConnection(Parent, data)).ToArray() as IReadOnlyList<ExpressRouteConnection>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists ExpressRouteConnections. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<ExpressRouteConnection>> GetAll(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionCollection.GetAll");
            scope.Start();
            try
            {
                var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(response.Value.Value.Select(data => new ExpressRouteConnection(Parent, data)).ToArray() as IReadOnlyList<ExpressRouteConnection>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, ExpressRouteConnection, ExpressRouteConnectionData> Construct() { }
    }
}
