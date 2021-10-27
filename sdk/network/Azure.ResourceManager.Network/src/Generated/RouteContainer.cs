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

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of Route and their operations over a RouteTable. </summary>
    public partial class RouteContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly RoutesRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="RouteContainer"/> class for mocking. </summary>
        protected RouteContainer()
        {
        }

        /// <summary> Initializes a new instance of RouteContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RouteContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new RoutesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => RouteTable.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a route in the specified route table. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="routeParameters"> Parameters supplied to the create or update route operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="routeParameters"/> is null. </exception>
        public virtual RouteCreateOrUpdateOperation CreateOrUpdate(string routeName, RouteData routeParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }
            if (routeParameters == null)
            {
                throw new ArgumentNullException(nameof(routeParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, routeName, routeParameters, cancellationToken);
                var operation = new RouteCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, routeName, routeParameters).Request, response);
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

        /// <summary> Creates or updates a route in the specified route table. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="routeParameters"> Parameters supplied to the create or update route operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="routeParameters"/> is null. </exception>
        public async virtual Task<RouteCreateOrUpdateOperation> CreateOrUpdateAsync(string routeName, RouteData routeParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }
            if (routeParameters == null)
            {
                throw new ArgumentNullException(nameof(routeParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, routeName, routeParameters, cancellationToken).ConfigureAwait(false);
                var operation = new RouteCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, routeName, routeParameters).Request, response);
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
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<Route> Get(string routeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteContainer.Get");
            scope.Start();
            try
            {
                if (routeName == null)
                {
                    throw new ArgumentNullException(nameof(routeName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, routeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Route(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<Route>> GetAsync(string routeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteContainer.Get");
            scope.Start();
            try
            {
                if (routeName == null)
                {
                    throw new ArgumentNullException(nameof(routeName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, routeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Route(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<Route> GetIfExists(string routeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteContainer.GetIfExists");
            scope.Start();
            try
            {
                if (routeName == null)
                {
                    throw new ArgumentNullException(nameof(routeName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, routeName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Route>(null, response.GetRawResponse())
                    : Response.FromValue(new Route(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<Route>> GetIfExistsAsync(string routeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteContainer.GetIfExists");
            scope.Start();
            try
            {
                if (routeName == null)
                {
                    throw new ArgumentNullException(nameof(routeName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, routeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Route>(null, response.GetRawResponse())
                    : Response.FromValue(new Route(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string routeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (routeName == null)
                {
                    throw new ArgumentNullException(nameof(routeName));
                }

                var response = GetIfExists(routeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string routeName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RouteContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (routeName == null)
                {
                    throw new ArgumentNullException(nameof(routeName));
                }

                var response = await GetIfExistsAsync(routeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all routes in a route table. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Route" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Route> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Route> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Route(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Route> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Route(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all routes in a route table. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Route" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Route> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Route>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Route(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Route>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Route(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, Route, RouteData> Construct() { }
    }
}
