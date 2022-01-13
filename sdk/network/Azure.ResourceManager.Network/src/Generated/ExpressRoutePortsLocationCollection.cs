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
    /// <summary> A class representing collection of ExpressRoutePortsLocation and their operations over its parent. </summary>
    public partial class ExpressRoutePortsLocationCollection : ArmCollection, IEnumerable<ExpressRoutePortsLocation>, IAsyncEnumerable<ExpressRoutePortsLocation>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ExpressRoutePortsLocationsRestOperations _expressRoutePortsLocationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRoutePortsLocationCollection"/> class for mocking. </summary>
        protected ExpressRoutePortsLocationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRoutePortsLocationCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ExpressRoutePortsLocationCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _expressRoutePortsLocationsRestClient = new ExpressRoutePortsLocationsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Retrieves a single ExpressRoutePort peering location, including the list of available bandwidths available at said peering location. </summary>
        /// <param name="locationName"> Name of the requested ExpressRoutePort peering location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        public virtual Response<ExpressRoutePortsLocation> Get(string locationName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRoutePortsLocationsRestClient.Get(Id.SubscriptionId, locationName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRoutePortsLocation(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves a single ExpressRoutePort peering location, including the list of available bandwidths available at said peering location. </summary>
        /// <param name="locationName"> Name of the requested ExpressRoutePort peering location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        public async virtual Task<Response<ExpressRoutePortsLocation>> GetAsync(string locationName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRoutePortsLocationsRestClient.GetAsync(Id.SubscriptionId, locationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ExpressRoutePortsLocation(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="locationName"> Name of the requested ExpressRoutePort peering location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        public virtual Response<ExpressRoutePortsLocation> GetIfExists(string locationName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRoutePortsLocationsRestClient.Get(Id.SubscriptionId, locationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ExpressRoutePortsLocation>(null, response.GetRawResponse());
                return Response.FromValue(new ExpressRoutePortsLocation(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="locationName"> Name of the requested ExpressRoutePort peering location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        public async virtual Task<Response<ExpressRoutePortsLocation>> GetIfExistsAsync(string locationName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _expressRoutePortsLocationsRestClient.GetAsync(Id.SubscriptionId, locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ExpressRoutePortsLocation>(null, response.GetRawResponse());
                return Response.FromValue(new ExpressRoutePortsLocation(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="locationName"> Name of the requested ExpressRoutePort peering location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        public virtual Response<bool> Exists(string locationName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(locationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="locationName"> Name of the requested ExpressRoutePort peering location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string locationName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves all ExpressRoutePort peering locations. Does not return available bandwidths for each location. Available bandwidths can only be obtained when retrieving a specific peering location. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRoutePortsLocation" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRoutePortsLocation> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExpressRoutePortsLocation> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRoutePortsLocationsRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRoutePortsLocation(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExpressRoutePortsLocation> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRoutePortsLocationsRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRoutePortsLocation(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves all ExpressRoutePort peering locations. Does not return available bandwidths for each location. Available bandwidths can only be obtained when retrieving a specific peering location. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRoutePortsLocation" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRoutePortsLocation> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRoutePortsLocation>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRoutePortsLocationsRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRoutePortsLocation(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExpressRoutePortsLocation>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRoutePortsLocationsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRoutePortsLocation(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="ExpressRoutePortsLocation" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ExpressRoutePortsLocation.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ExpressRoutePortsLocation" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRoutePortsLocationCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ExpressRoutePortsLocation.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRoutePortsLocation> IEnumerable<ExpressRoutePortsLocation>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRoutePortsLocation> IAsyncEnumerable<ExpressRoutePortsLocation>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ExpressRoutePortsLocation, ExpressRoutePortsLocationData> Construct() { }
    }
}
