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
    /// <summary> A class representing collection of RouteFilter and their operations over its parent. </summary>
    public partial class RouteFilterCollection : ArmCollection, IEnumerable<RouteFilter>, IAsyncEnumerable<RouteFilter>
    {
        private readonly ClientDiagnostics _routeFilterClientDiagnostics;
        private readonly RouteFiltersRestOperations _routeFilterRestClient;

        /// <summary> Initializes a new instance of the <see cref="RouteFilterCollection"/> class for mocking. </summary>
        protected RouteFilterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RouteFilterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RouteFilterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _routeFilterClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", RouteFilter.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(RouteFilter.ResourceType, out string routeFilterApiVersion);
            _routeFilterRestClient = new RouteFiltersRestOperations(_routeFilterClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, routeFilterApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary> Creates or updates a route filter in a specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="routeFilterParameters"> Parameters supplied to the create or update route filter operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeFilterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> or <paramref name="routeFilterParameters"/> is null. </exception>
        public async virtual Task<RouteFilterCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string routeFilterName, RouteFilterData routeFilterParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeFilterName, nameof(routeFilterName));
            if (routeFilterParameters == null)
            {
                throw new ArgumentNullException(nameof(routeFilterParameters));
            }

            using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _routeFilterRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, routeFilterParameters, cancellationToken).ConfigureAwait(false);
                var operation = new RouteFilterCreateOrUpdateOperation(Client, _routeFilterClientDiagnostics, Pipeline, _routeFilterRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, routeFilterParameters).Request, response);
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

        /// <summary> Creates or updates a route filter in a specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="routeFilterParameters"> Parameters supplied to the create or update route filter operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeFilterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> or <paramref name="routeFilterParameters"/> is null. </exception>
        public virtual RouteFilterCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string routeFilterName, RouteFilterData routeFilterParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeFilterName, nameof(routeFilterName));
            if (routeFilterParameters == null)
            {
                throw new ArgumentNullException(nameof(routeFilterParameters));
            }

            using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _routeFilterRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, routeFilterParameters, cancellationToken);
                var operation = new RouteFilterCreateOrUpdateOperation(Client, _routeFilterClientDiagnostics, Pipeline, _routeFilterRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, routeFilterParameters).Request, response);
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

        /// <summary> Gets the specified route filter. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeFilterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> is null. </exception>
        public async virtual Task<Response<RouteFilter>> GetAsync(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeFilterName, nameof(routeFilterName));

            using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.Get");
            scope.Start();
            try
            {
                var response = await _routeFilterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _routeFilterClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RouteFilter(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified route filter. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeFilterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> is null. </exception>
        public virtual Response<RouteFilter> Get(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeFilterName, nameof(routeFilterName));

            using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.Get");
            scope.Start();
            try
            {
                var response = _routeFilterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, expand, cancellationToken);
                if (response.Value == null)
                    throw _routeFilterClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RouteFilter(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all route filters in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RouteFilter" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RouteFilter> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RouteFilter>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _routeFilterRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteFilter(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RouteFilter>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _routeFilterRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteFilter(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all route filters in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RouteFilter" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RouteFilter> GetAll(CancellationToken cancellationToken = default)
        {
            Page<RouteFilter> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _routeFilterRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteFilter(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RouteFilter> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _routeFilterRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RouteFilter(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeFilterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeFilterName, nameof(routeFilterName));

            using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(routeFilterName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeFilterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> is null. </exception>
        public virtual Response<bool> Exists(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeFilterName, nameof(routeFilterName));

            using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(routeFilterName, expand: expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeFilterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> is null. </exception>
        public async virtual Task<Response<RouteFilter>> GetIfExistsAsync(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeFilterName, nameof(routeFilterName));

            using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _routeFilterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<RouteFilter>(null, response.GetRawResponse());
                return Response.FromValue(new RouteFilter(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeFilterName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> is null. </exception>
        public virtual Response<RouteFilter> GetIfExists(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeFilterName, nameof(routeFilterName));

            using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _routeFilterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<RouteFilter>(null, response.GetRawResponse());
                return Response.FromValue(new RouteFilter(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RouteFilter> IEnumerable<RouteFilter>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RouteFilter> IAsyncEnumerable<RouteFilter>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
