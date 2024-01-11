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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="SubscriptionNetworkManagerConnectionResource"/> and their operations.
    /// Each <see cref="SubscriptionNetworkManagerConnectionResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="SubscriptionNetworkManagerConnectionCollection"/> instance call the GetSubscriptionNetworkManagerConnections method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class SubscriptionNetworkManagerConnectionCollection : ArmCollection, IEnumerable<SubscriptionNetworkManagerConnectionResource>, IAsyncEnumerable<SubscriptionNetworkManagerConnectionResource>
    {
        private readonly ClientDiagnostics _subscriptionNetworkManagerConnectionClientDiagnostics;
        private readonly SubscriptionNetworkManagerConnectionsRestOperations _subscriptionNetworkManagerConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionNetworkManagerConnectionCollection"/> class for mocking. </summary>
        protected SubscriptionNetworkManagerConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionNetworkManagerConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubscriptionNetworkManagerConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionNetworkManagerConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", SubscriptionNetworkManagerConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionNetworkManagerConnectionResource.ResourceType, out string subscriptionNetworkManagerConnectionApiVersion);
            _subscriptionNetworkManagerConnectionRestClient = new SubscriptionNetworkManagerConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionNetworkManagerConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a network manager connection on this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionNetworkManagerConnections_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionNetworkManagerConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkManagerConnectionName"> Name for the network manager connection. </param>
        /// <param name="data"> Network manager connection to be created/updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SubscriptionNetworkManagerConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkManagerConnectionName, NetworkManagerConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkManagerConnectionName, nameof(networkManagerConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionNetworkManagerConnectionClientDiagnostics.CreateScope("SubscriptionNetworkManagerConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subscriptionNetworkManagerConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, networkManagerConnectionName, data, cancellationToken).ConfigureAwait(false);
                var uri = _subscriptionNetworkManagerConnectionRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, networkManagerConnectionName, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new NetworkArmOperation<SubscriptionNetworkManagerConnectionResource>(Response.FromValue(new SubscriptionNetworkManagerConnectionResource(Client, response), response.GetRawResponse()), operationId);
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
        /// Create a network manager connection on this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionNetworkManagerConnections_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionNetworkManagerConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkManagerConnectionName"> Name for the network manager connection. </param>
        /// <param name="data"> Network manager connection to be created/updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SubscriptionNetworkManagerConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string networkManagerConnectionName, NetworkManagerConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkManagerConnectionName, nameof(networkManagerConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionNetworkManagerConnectionClientDiagnostics.CreateScope("SubscriptionNetworkManagerConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subscriptionNetworkManagerConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, networkManagerConnectionName, data, cancellationToken);
                var uri = _subscriptionNetworkManagerConnectionRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, networkManagerConnectionName, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new NetworkArmOperation<SubscriptionNetworkManagerConnectionResource>(Response.FromValue(new SubscriptionNetworkManagerConnectionResource(Client, response), response.GetRawResponse()), operationId);
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
        /// Get a specified connection created by this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionNetworkManagerConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionNetworkManagerConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkManagerConnectionName"> Name for the network manager connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerConnectionName"/> is null. </exception>
        public virtual async Task<Response<SubscriptionNetworkManagerConnectionResource>> GetAsync(string networkManagerConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkManagerConnectionName, nameof(networkManagerConnectionName));

            using var scope = _subscriptionNetworkManagerConnectionClientDiagnostics.CreateScope("SubscriptionNetworkManagerConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionNetworkManagerConnectionRestClient.GetAsync(Id.SubscriptionId, networkManagerConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionNetworkManagerConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a specified connection created by this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionNetworkManagerConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionNetworkManagerConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkManagerConnectionName"> Name for the network manager connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerConnectionName"/> is null. </exception>
        public virtual Response<SubscriptionNetworkManagerConnectionResource> Get(string networkManagerConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkManagerConnectionName, nameof(networkManagerConnectionName));

            using var scope = _subscriptionNetworkManagerConnectionClientDiagnostics.CreateScope("SubscriptionNetworkManagerConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionNetworkManagerConnectionRestClient.Get(Id.SubscriptionId, networkManagerConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionNetworkManagerConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all network manager connections created by this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkManagerConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionNetworkManagerConnections_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionNetworkManagerConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionNetworkManagerConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionNetworkManagerConnectionResource> GetAllAsync(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionNetworkManagerConnectionRestClient.CreateListRequest(Id.SubscriptionId, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionNetworkManagerConnectionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, top, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SubscriptionNetworkManagerConnectionResource(Client, NetworkManagerConnectionData.DeserializeNetworkManagerConnectionData(e)), _subscriptionNetworkManagerConnectionClientDiagnostics, Pipeline, "SubscriptionNetworkManagerConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all network manager connections created by this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkManagerConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionNetworkManagerConnections_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionNetworkManagerConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionNetworkManagerConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionNetworkManagerConnectionResource> GetAll(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionNetworkManagerConnectionRestClient.CreateListRequest(Id.SubscriptionId, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionNetworkManagerConnectionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, top, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SubscriptionNetworkManagerConnectionResource(Client, NetworkManagerConnectionData.DeserializeNetworkManagerConnectionData(e)), _subscriptionNetworkManagerConnectionClientDiagnostics, Pipeline, "SubscriptionNetworkManagerConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionNetworkManagerConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionNetworkManagerConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkManagerConnectionName"> Name for the network manager connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkManagerConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkManagerConnectionName, nameof(networkManagerConnectionName));

            using var scope = _subscriptionNetworkManagerConnectionClientDiagnostics.CreateScope("SubscriptionNetworkManagerConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _subscriptionNetworkManagerConnectionRestClient.GetAsync(Id.SubscriptionId, networkManagerConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionNetworkManagerConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionNetworkManagerConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkManagerConnectionName"> Name for the network manager connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkManagerConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkManagerConnectionName, nameof(networkManagerConnectionName));

            using var scope = _subscriptionNetworkManagerConnectionClientDiagnostics.CreateScope("SubscriptionNetworkManagerConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _subscriptionNetworkManagerConnectionRestClient.Get(Id.SubscriptionId, networkManagerConnectionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionNetworkManagerConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionNetworkManagerConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkManagerConnectionName"> Name for the network manager connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerConnectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<SubscriptionNetworkManagerConnectionResource>> GetIfExistsAsync(string networkManagerConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkManagerConnectionName, nameof(networkManagerConnectionName));

            using var scope = _subscriptionNetworkManagerConnectionClientDiagnostics.CreateScope("SubscriptionNetworkManagerConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _subscriptionNetworkManagerConnectionRestClient.GetAsync(Id.SubscriptionId, networkManagerConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SubscriptionNetworkManagerConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new SubscriptionNetworkManagerConnectionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/networkManagerConnections/{networkManagerConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionNetworkManagerConnections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionNetworkManagerConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkManagerConnectionName"> Name for the network manager connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkManagerConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkManagerConnectionName"/> is null. </exception>
        public virtual NullableResponse<SubscriptionNetworkManagerConnectionResource> GetIfExists(string networkManagerConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkManagerConnectionName, nameof(networkManagerConnectionName));

            using var scope = _subscriptionNetworkManagerConnectionClientDiagnostics.CreateScope("SubscriptionNetworkManagerConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subscriptionNetworkManagerConnectionRestClient.Get(Id.SubscriptionId, networkManagerConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SubscriptionNetworkManagerConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new SubscriptionNetworkManagerConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubscriptionNetworkManagerConnectionResource> IEnumerable<SubscriptionNetworkManagerConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionNetworkManagerConnectionResource> IAsyncEnumerable<SubscriptionNetworkManagerConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
