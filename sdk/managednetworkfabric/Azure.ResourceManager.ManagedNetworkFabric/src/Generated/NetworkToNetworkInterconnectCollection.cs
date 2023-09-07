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

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkToNetworkInterconnectResource" /> and their operations.
    /// Each <see cref="NetworkToNetworkInterconnectResource" /> in the collection will belong to the same instance of <see cref="NetworkFabricResource" />.
    /// To get a <see cref="NetworkToNetworkInterconnectCollection" /> instance call the GetNetworkToNetworkInterconnects method from an instance of <see cref="NetworkFabricResource" />.
    /// </summary>
    public partial class NetworkToNetworkInterconnectCollection : ArmCollection, IEnumerable<NetworkToNetworkInterconnectResource>, IAsyncEnumerable<NetworkToNetworkInterconnectResource>
    {
        private readonly ClientDiagnostics _networkToNetworkInterconnectClientDiagnostics;
        private readonly NetworkToNetworkInterconnectsRestOperations _networkToNetworkInterconnectRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkToNetworkInterconnectCollection"/> class for mocking. </summary>
        protected NetworkToNetworkInterconnectCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkToNetworkInterconnectCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkToNetworkInterconnectCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkToNetworkInterconnectClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkToNetworkInterconnectResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkToNetworkInterconnectResource.ResourceType, out string networkToNetworkInterconnectApiVersion);
            _networkToNetworkInterconnectRestClient = new NetworkToNetworkInterconnectsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkToNetworkInterconnectApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkFabricResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkFabricResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Configuration used to setup CE-PE connectivity PUT Method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics/{networkFabricName}/networkToNetworkInterconnects/{networkToNetworkInterconnectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkToNetworkInterconnects_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkToNetworkInterconnectName"> Name of the Network to Network Interconnect. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkToNetworkInterconnectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkToNetworkInterconnectName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkToNetworkInterconnectResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkToNetworkInterconnectName, NetworkToNetworkInterconnectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkToNetworkInterconnectName, nameof(networkToNetworkInterconnectName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkToNetworkInterconnectClientDiagnostics.CreateScope("NetworkToNetworkInterconnectCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkToNetworkInterconnectRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkToNetworkInterconnectName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkFabricArmOperation<NetworkToNetworkInterconnectResource>(new NetworkToNetworkInterconnectOperationSource(Client), _networkToNetworkInterconnectClientDiagnostics, Pipeline, _networkToNetworkInterconnectRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkToNetworkInterconnectName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Configuration used to setup CE-PE connectivity PUT Method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics/{networkFabricName}/networkToNetworkInterconnects/{networkToNetworkInterconnectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkToNetworkInterconnects_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkToNetworkInterconnectName"> Name of the Network to Network Interconnect. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkToNetworkInterconnectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkToNetworkInterconnectName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkToNetworkInterconnectResource> CreateOrUpdate(WaitUntil waitUntil, string networkToNetworkInterconnectName, NetworkToNetworkInterconnectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkToNetworkInterconnectName, nameof(networkToNetworkInterconnectName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkToNetworkInterconnectClientDiagnostics.CreateScope("NetworkToNetworkInterconnectCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkToNetworkInterconnectRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkToNetworkInterconnectName, data, cancellationToken);
                var operation = new ManagedNetworkFabricArmOperation<NetworkToNetworkInterconnectResource>(new NetworkToNetworkInterconnectOperationSource(Client), _networkToNetworkInterconnectClientDiagnostics, Pipeline, _networkToNetworkInterconnectRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkToNetworkInterconnectName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements NetworkToNetworkInterconnects GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics/{networkFabricName}/networkToNetworkInterconnects/{networkToNetworkInterconnectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkToNetworkInterconnects_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkToNetworkInterconnectName"> Name of the Network to Network Interconnect. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkToNetworkInterconnectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkToNetworkInterconnectName"/> is null. </exception>
        public virtual async Task<Response<NetworkToNetworkInterconnectResource>> GetAsync(string networkToNetworkInterconnectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkToNetworkInterconnectName, nameof(networkToNetworkInterconnectName));

            using var scope = _networkToNetworkInterconnectClientDiagnostics.CreateScope("NetworkToNetworkInterconnectCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkToNetworkInterconnectRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkToNetworkInterconnectName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkToNetworkInterconnectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements NetworkToNetworkInterconnects GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics/{networkFabricName}/networkToNetworkInterconnects/{networkToNetworkInterconnectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkToNetworkInterconnects_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkToNetworkInterconnectName"> Name of the Network to Network Interconnect. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkToNetworkInterconnectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkToNetworkInterconnectName"/> is null. </exception>
        public virtual Response<NetworkToNetworkInterconnectResource> Get(string networkToNetworkInterconnectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkToNetworkInterconnectName, nameof(networkToNetworkInterconnectName));

            using var scope = _networkToNetworkInterconnectClientDiagnostics.CreateScope("NetworkToNetworkInterconnectCollection.Get");
            scope.Start();
            try
            {
                var response = _networkToNetworkInterconnectRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkToNetworkInterconnectName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkToNetworkInterconnectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements Network To Network Interconnects list by Network Fabric GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics/{networkFabricName}/networkToNetworkInterconnects</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkToNetworkInterconnects_ListByNetworkFabric</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkToNetworkInterconnectResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkToNetworkInterconnectResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkToNetworkInterconnectRestClient.CreateListByNetworkFabricRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkToNetworkInterconnectRestClient.CreateListByNetworkFabricNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkToNetworkInterconnectResource(Client, NetworkToNetworkInterconnectData.DeserializeNetworkToNetworkInterconnectData(e)), _networkToNetworkInterconnectClientDiagnostics, Pipeline, "NetworkToNetworkInterconnectCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Implements Network To Network Interconnects list by Network Fabric GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics/{networkFabricName}/networkToNetworkInterconnects</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkToNetworkInterconnects_ListByNetworkFabric</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkToNetworkInterconnectResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkToNetworkInterconnectResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkToNetworkInterconnectRestClient.CreateListByNetworkFabricRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkToNetworkInterconnectRestClient.CreateListByNetworkFabricNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkToNetworkInterconnectResource(Client, NetworkToNetworkInterconnectData.DeserializeNetworkToNetworkInterconnectData(e)), _networkToNetworkInterconnectClientDiagnostics, Pipeline, "NetworkToNetworkInterconnectCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics/{networkFabricName}/networkToNetworkInterconnects/{networkToNetworkInterconnectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkToNetworkInterconnects_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkToNetworkInterconnectName"> Name of the Network to Network Interconnect. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkToNetworkInterconnectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkToNetworkInterconnectName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkToNetworkInterconnectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkToNetworkInterconnectName, nameof(networkToNetworkInterconnectName));

            using var scope = _networkToNetworkInterconnectClientDiagnostics.CreateScope("NetworkToNetworkInterconnectCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkToNetworkInterconnectRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkToNetworkInterconnectName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics/{networkFabricName}/networkToNetworkInterconnects/{networkToNetworkInterconnectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkToNetworkInterconnects_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkToNetworkInterconnectName"> Name of the Network to Network Interconnect. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkToNetworkInterconnectName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkToNetworkInterconnectName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkToNetworkInterconnectName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkToNetworkInterconnectName, nameof(networkToNetworkInterconnectName));

            using var scope = _networkToNetworkInterconnectClientDiagnostics.CreateScope("NetworkToNetworkInterconnectCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkToNetworkInterconnectRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkToNetworkInterconnectName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkToNetworkInterconnectResource> IEnumerable<NetworkToNetworkInterconnectResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkToNetworkInterconnectResource> IAsyncEnumerable<NetworkToNetworkInterconnectResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
