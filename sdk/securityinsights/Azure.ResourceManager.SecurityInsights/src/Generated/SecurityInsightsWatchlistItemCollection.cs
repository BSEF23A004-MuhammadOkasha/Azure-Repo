// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityInsightsWatchlistItemResource" /> and their operations.
    /// Each <see cref="SecurityInsightsWatchlistItemResource" /> in the collection will belong to the same instance of <see cref="SecurityInsightsWatchlistResource" />.
    /// To get a <see cref="SecurityInsightsWatchlistItemCollection" /> instance call the GetSecurityInsightsWatchlistItems method from an instance of <see cref="SecurityInsightsWatchlistResource" />.
    /// </summary>
    public partial class SecurityInsightsWatchlistItemCollection : ArmCollection, IEnumerable<SecurityInsightsWatchlistItemResource>, IAsyncEnumerable<SecurityInsightsWatchlistItemResource>
    {
        private readonly ClientDiagnostics _securityInsightsWatchlistItemWatchlistItemsClientDiagnostics;
        private readonly WatchlistItemsRestOperations _securityInsightsWatchlistItemWatchlistItemsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsWatchlistItemCollection"/> class for mocking. </summary>
        protected SecurityInsightsWatchlistItemCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsWatchlistItemCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityInsightsWatchlistItemCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityInsightsWatchlistItemWatchlistItemsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", SecurityInsightsWatchlistItemResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityInsightsWatchlistItemResource.ResourceType, out string securityInsightsWatchlistItemWatchlistItemsApiVersion);
            _securityInsightsWatchlistItemWatchlistItemsRestClient = new WatchlistItemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityInsightsWatchlistItemWatchlistItemsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SecurityInsightsWatchlistResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SecurityInsightsWatchlistResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a watchlist item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}/watchlistItems/{watchlistItemId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WatchlistItems_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="watchlistItemId"> The watchlist item id (GUID). </param>
        /// <param name="data"> The watchlist item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watchlistItemId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistItemId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityInsightsWatchlistItemResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string watchlistItemId, SecurityInsightsWatchlistItemData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watchlistItemId, nameof(watchlistItemId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsWatchlistItemWatchlistItemsClientDiagnostics.CreateScope("SecurityInsightsWatchlistItemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityInsightsWatchlistItemWatchlistItemsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, watchlistItemId, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityInsightsArmOperation<SecurityInsightsWatchlistItemResource>(Response.FromValue(new SecurityInsightsWatchlistItemResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a watchlist item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}/watchlistItems/{watchlistItemId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WatchlistItems_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="watchlistItemId"> The watchlist item id (GUID). </param>
        /// <param name="data"> The watchlist item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watchlistItemId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistItemId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityInsightsWatchlistItemResource> CreateOrUpdate(WaitUntil waitUntil, string watchlistItemId, SecurityInsightsWatchlistItemData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watchlistItemId, nameof(watchlistItemId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsWatchlistItemWatchlistItemsClientDiagnostics.CreateScope("SecurityInsightsWatchlistItemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityInsightsWatchlistItemWatchlistItemsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, watchlistItemId, data, cancellationToken);
                var operation = new SecurityInsightsArmOperation<SecurityInsightsWatchlistItemResource>(Response.FromValue(new SecurityInsightsWatchlistItemResource(Client, response), response.GetRawResponse()));
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
        /// Get a watchlist item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}/watchlistItems/{watchlistItemId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WatchlistItems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watchlistItemId"> The watchlist item id (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watchlistItemId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistItemId"/> is null. </exception>
        public virtual async Task<Response<SecurityInsightsWatchlistItemResource>> GetAsync(string watchlistItemId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watchlistItemId, nameof(watchlistItemId));

            using var scope = _securityInsightsWatchlistItemWatchlistItemsClientDiagnostics.CreateScope("SecurityInsightsWatchlistItemCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityInsightsWatchlistItemWatchlistItemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, watchlistItemId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsWatchlistItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a watchlist item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}/watchlistItems/{watchlistItemId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WatchlistItems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watchlistItemId"> The watchlist item id (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watchlistItemId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistItemId"/> is null. </exception>
        public virtual Response<SecurityInsightsWatchlistItemResource> Get(string watchlistItemId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watchlistItemId, nameof(watchlistItemId));

            using var scope = _securityInsightsWatchlistItemWatchlistItemsClientDiagnostics.CreateScope("SecurityInsightsWatchlistItemCollection.Get");
            scope.Start();
            try
            {
                var response = _securityInsightsWatchlistItemWatchlistItemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, watchlistItemId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsWatchlistItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all watchlist Items.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}/watchlistItems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WatchlistItems_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityInsightsWatchlistItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityInsightsWatchlistItemResource> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsWatchlistItemWatchlistItemsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsWatchlistItemWatchlistItemsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsWatchlistItemResource(Client, SecurityInsightsWatchlistItemData.DeserializeSecurityInsightsWatchlistItemData(e)), _securityInsightsWatchlistItemWatchlistItemsClientDiagnostics, Pipeline, "SecurityInsightsWatchlistItemCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all watchlist Items.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}/watchlistItems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WatchlistItems_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityInsightsWatchlistItemResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityInsightsWatchlistItemResource> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsWatchlistItemWatchlistItemsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsWatchlistItemWatchlistItemsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skipToken);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsWatchlistItemResource(Client, SecurityInsightsWatchlistItemData.DeserializeSecurityInsightsWatchlistItemData(e)), _securityInsightsWatchlistItemWatchlistItemsClientDiagnostics, Pipeline, "SecurityInsightsWatchlistItemCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}/watchlistItems/{watchlistItemId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WatchlistItems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watchlistItemId"> The watchlist item id (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watchlistItemId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistItemId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string watchlistItemId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watchlistItemId, nameof(watchlistItemId));

            using var scope = _securityInsightsWatchlistItemWatchlistItemsClientDiagnostics.CreateScope("SecurityInsightsWatchlistItemCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityInsightsWatchlistItemWatchlistItemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, watchlistItemId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}/watchlistItems/{watchlistItemId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WatchlistItems_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watchlistItemId"> The watchlist item id (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watchlistItemId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistItemId"/> is null. </exception>
        public virtual Response<bool> Exists(string watchlistItemId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watchlistItemId, nameof(watchlistItemId));

            using var scope = _securityInsightsWatchlistItemWatchlistItemsClientDiagnostics.CreateScope("SecurityInsightsWatchlistItemCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityInsightsWatchlistItemWatchlistItemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, watchlistItemId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityInsightsWatchlistItemResource> IEnumerable<SecurityInsightsWatchlistItemResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityInsightsWatchlistItemResource> IAsyncEnumerable<SecurityInsightsWatchlistItemResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
