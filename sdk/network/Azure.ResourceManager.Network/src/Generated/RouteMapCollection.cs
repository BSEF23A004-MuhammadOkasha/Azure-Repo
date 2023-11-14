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
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="RouteMapResource" /> and their operations.
    /// Each <see cref="RouteMapResource" /> in the collection will belong to the same instance of <see cref="VirtualHubResource" />.
    /// To get a <see cref="RouteMapCollection" /> instance call the GetRouteMaps method from an instance of <see cref="VirtualHubResource" />.
    /// </summary>
    public partial class RouteMapCollection : ArmCollection, IEnumerable<RouteMapResource>, IAsyncEnumerable<RouteMapResource>
    {
        private readonly ClientDiagnostics _routeMapClientDiagnostics;
        private readonly RouteMapsRestOperations _routeMapRestClient;

        /// <summary> Initializes a new instance of the <see cref="RouteMapCollection"/> class for mocking. </summary>
        protected RouteMapCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RouteMapCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RouteMapCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _routeMapClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", RouteMapResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RouteMapResource.ResourceType, out string routeMapApiVersion);
            _routeMapRestClient = new RouteMapsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, routeMapApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualHubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualHubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a RouteMap if it doesn't exist else updates the existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routeMaps/{routeMapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteMaps_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="routeMapName"> The name of the RouteMap. </param>
        /// <param name="data"> Parameters supplied to create or update a RouteMap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeMapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeMapName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RouteMapResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string routeMapName, RouteMapData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeMapName, nameof(routeMapName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _routeMapClientDiagnostics.CreateScope("RouteMapCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _routeMapRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeMapName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<RouteMapResource>(new RouteMapOperationSource(Client), _routeMapClientDiagnostics, Pipeline, _routeMapRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeMapName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a RouteMap if it doesn't exist else updates the existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routeMaps/{routeMapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteMaps_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="routeMapName"> The name of the RouteMap. </param>
        /// <param name="data"> Parameters supplied to create or update a RouteMap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeMapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeMapName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RouteMapResource> CreateOrUpdate(WaitUntil waitUntil, string routeMapName, RouteMapData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeMapName, nameof(routeMapName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _routeMapClientDiagnostics.CreateScope("RouteMapCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _routeMapRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeMapName, data, cancellationToken);
                var operation = new NetworkArmOperation<RouteMapResource>(new RouteMapOperationSource(Client), _routeMapClientDiagnostics, Pipeline, _routeMapRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeMapName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a RouteMap.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routeMaps/{routeMapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteMaps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeMapName"> The name of the RouteMap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeMapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeMapName"/> is null. </exception>
        public virtual async Task<Response<RouteMapResource>> GetAsync(string routeMapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeMapName, nameof(routeMapName));

            using var scope = _routeMapClientDiagnostics.CreateScope("RouteMapCollection.Get");
            scope.Start();
            try
            {
                var response = await _routeMapRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeMapName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RouteMapResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a RouteMap.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routeMaps/{routeMapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteMaps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeMapName"> The name of the RouteMap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeMapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeMapName"/> is null. </exception>
        public virtual Response<RouteMapResource> Get(string routeMapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeMapName, nameof(routeMapName));

            using var scope = _routeMapClientDiagnostics.CreateScope("RouteMapCollection.Get");
            scope.Start();
            try
            {
                var response = _routeMapRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeMapName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RouteMapResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of all RouteMaps.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routeMaps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteMaps_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RouteMapResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RouteMapResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _routeMapRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _routeMapRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new RouteMapResource(Client, RouteMapData.DeserializeRouteMapData(e)), _routeMapClientDiagnostics, Pipeline, "RouteMapCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of all RouteMaps.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routeMaps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteMaps_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RouteMapResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RouteMapResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _routeMapRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _routeMapRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new RouteMapResource(Client, RouteMapData.DeserializeRouteMapData(e)), _routeMapClientDiagnostics, Pipeline, "RouteMapCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routeMaps/{routeMapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteMaps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeMapName"> The name of the RouteMap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeMapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeMapName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string routeMapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeMapName, nameof(routeMapName));

            using var scope = _routeMapClientDiagnostics.CreateScope("RouteMapCollection.Exists");
            scope.Start();
            try
            {
                var response = await _routeMapRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeMapName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routeMaps/{routeMapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteMaps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeMapName"> The name of the RouteMap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeMapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeMapName"/> is null. </exception>
        public virtual Response<bool> Exists(string routeMapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeMapName, nameof(routeMapName));

            using var scope = _routeMapClientDiagnostics.CreateScope("RouteMapCollection.Exists");
            scope.Start();
            try
            {
                var response = _routeMapRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeMapName, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routeMaps/{routeMapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteMaps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeMapName"> The name of the RouteMap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeMapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeMapName"/> is null. </exception>
        public virtual async Task<NullableResponse<RouteMapResource>> GetIfExistsAsync(string routeMapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeMapName, nameof(routeMapName));

            using var scope = _routeMapClientDiagnostics.CreateScope("RouteMapCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _routeMapRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeMapName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RouteMapResource>(response.GetRawResponse());
                return Response.FromValue(new RouteMapResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/routeMaps/{routeMapName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteMaps_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeMapName"> The name of the RouteMap. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeMapName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeMapName"/> is null. </exception>
        public virtual NullableResponse<RouteMapResource> GetIfExists(string routeMapName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeMapName, nameof(routeMapName));

            using var scope = _routeMapClientDiagnostics.CreateScope("RouteMapCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _routeMapRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeMapName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RouteMapResource>(response.GetRawResponse());
                return Response.FromValue(new RouteMapResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RouteMapResource> IEnumerable<RouteMapResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RouteMapResource> IAsyncEnumerable<RouteMapResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
