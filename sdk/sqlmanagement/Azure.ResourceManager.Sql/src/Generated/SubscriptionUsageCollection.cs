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

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of SubscriptionUsage and their operations over its parent. </summary>
    public partial class SubscriptionUsageCollection : ArmCollection, IEnumerable<SubscriptionUsage>, IAsyncEnumerable<SubscriptionUsage>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SubscriptionUsagesRestOperations _subscriptionUsagesRestClient;
        private readonly string _locationName;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionUsageCollection"/> class for mocking. </summary>
        protected SubscriptionUsageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionUsageCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        internal SubscriptionUsageCollection(ArmResource parent, string locationName) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _subscriptionUsagesRestClient = new SubscriptionUsagesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _locationName = locationName;
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

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages/{usageName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubscriptionUsages_Get
        /// <summary> Gets a subscription usage metric. </summary>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="usageName"/> is null. </exception>
        public virtual Response<SubscriptionUsage> Get(string usageName, CancellationToken cancellationToken = default)
        {
            if (usageName == null)
            {
                throw new ArgumentNullException(nameof(usageName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionUsageCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionUsagesRestClient.Get(Id.SubscriptionId, _locationName, usageName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionUsage(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages/{usageName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubscriptionUsages_Get
        /// <summary> Gets a subscription usage metric. </summary>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="usageName"/> is null. </exception>
        public async virtual Task<Response<SubscriptionUsage>> GetAsync(string usageName, CancellationToken cancellationToken = default)
        {
            if (usageName == null)
            {
                throw new ArgumentNullException(nameof(usageName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionUsageCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionUsagesRestClient.GetAsync(Id.SubscriptionId, _locationName, usageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SubscriptionUsage(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="usageName"/> is null. </exception>
        public virtual Response<SubscriptionUsage> GetIfExists(string usageName, CancellationToken cancellationToken = default)
        {
            if (usageName == null)
            {
                throw new ArgumentNullException(nameof(usageName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionUsageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subscriptionUsagesRestClient.Get(Id.SubscriptionId, _locationName, usageName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SubscriptionUsage>(null, response.GetRawResponse());
                return Response.FromValue(new SubscriptionUsage(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="usageName"/> is null. </exception>
        public async virtual Task<Response<SubscriptionUsage>> GetIfExistsAsync(string usageName, CancellationToken cancellationToken = default)
        {
            if (usageName == null)
            {
                throw new ArgumentNullException(nameof(usageName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionUsageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _subscriptionUsagesRestClient.GetAsync(Id.SubscriptionId, _locationName, usageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SubscriptionUsage>(null, response.GetRawResponse());
                return Response.FromValue(new SubscriptionUsage(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="usageName"/> is null. </exception>
        public virtual Response<bool> Exists(string usageName, CancellationToken cancellationToken = default)
        {
            if (usageName == null)
            {
                throw new ArgumentNullException(nameof(usageName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionUsageCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(usageName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="usageName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string usageName, CancellationToken cancellationToken = default)
        {
            if (usageName == null)
            {
                throw new ArgumentNullException(nameof(usageName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionUsageCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(usageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubscriptionUsages_ListByLocation
        /// <summary> Gets all subscription usage metrics in a given location. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionUsage> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SubscriptionUsage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionUsageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subscriptionUsagesRestClient.ListByLocation(Id.SubscriptionId, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionUsage(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubscriptionUsage> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionUsageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subscriptionUsagesRestClient.ListByLocationNextPage(nextLink, Id.SubscriptionId, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionUsage(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubscriptionUsages_ListByLocation
        /// <summary> Gets all subscription usage metrics in a given location. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionUsage> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SubscriptionUsage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionUsageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subscriptionUsagesRestClient.ListByLocationAsync(Id.SubscriptionId, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionUsage(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubscriptionUsage>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionUsageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subscriptionUsagesRestClient.ListByLocationNextPageAsync(nextLink, Id.SubscriptionId, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionUsage(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="SubscriptionUsage" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubscriptionUsageCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubscriptionUsage.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="SubscriptionUsage" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubscriptionUsageCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubscriptionUsage.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubscriptionUsage> IEnumerable<SubscriptionUsage>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionUsage> IAsyncEnumerable<SubscriptionUsage>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SubscriptionUsage, SubscriptionUsageData> Construct() { }
    }
}
