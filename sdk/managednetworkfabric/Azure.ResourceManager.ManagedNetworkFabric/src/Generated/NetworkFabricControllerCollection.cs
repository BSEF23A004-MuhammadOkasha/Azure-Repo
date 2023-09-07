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

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkFabricControllerResource" /> and their operations.
    /// Each <see cref="NetworkFabricControllerResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkFabricControllerCollection" /> instance call the GetNetworkFabricControllers method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkFabricControllerCollection : ArmCollection, IEnumerable<NetworkFabricControllerResource>, IAsyncEnumerable<NetworkFabricControllerResource>
    {
        private readonly ClientDiagnostics _networkFabricControllerClientDiagnostics;
        private readonly NetworkFabricControllersRestOperations _networkFabricControllerRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricControllerCollection"/> class for mocking. </summary>
        protected NetworkFabricControllerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricControllerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkFabricControllerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFabricControllerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkFabricControllerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkFabricControllerResource.ResourceType, out string networkFabricControllerApiVersion);
            _networkFabricControllerRestClient = new NetworkFabricControllersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFabricControllerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a Network Fabric Controller.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabricControllers/{networkFabricControllerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabricControllers_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkFabricControllerName"> Name of the Network Fabric Controller. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricControllerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricControllerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkFabricControllerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkFabricControllerName, NetworkFabricControllerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricControllerName, nameof(networkFabricControllerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricControllerClientDiagnostics.CreateScope("NetworkFabricControllerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkFabricControllerRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkFabricControllerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricControllerResource>(new NetworkFabricControllerOperationSource(Client), _networkFabricControllerClientDiagnostics, Pipeline, _networkFabricControllerRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkFabricControllerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a Network Fabric Controller.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabricControllers/{networkFabricControllerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabricControllers_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkFabricControllerName"> Name of the Network Fabric Controller. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricControllerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricControllerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkFabricControllerResource> CreateOrUpdate(WaitUntil waitUntil, string networkFabricControllerName, NetworkFabricControllerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricControllerName, nameof(networkFabricControllerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricControllerClientDiagnostics.CreateScope("NetworkFabricControllerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkFabricControllerRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, networkFabricControllerName, data, cancellationToken);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricControllerResource>(new NetworkFabricControllerOperationSource(Client), _networkFabricControllerClientDiagnostics, Pipeline, _networkFabricControllerRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkFabricControllerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Shows the provisioning status of Network Fabric Controller.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabricControllers/{networkFabricControllerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabricControllers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFabricControllerName"> Name of the Network Fabric Controller. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricControllerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricControllerName"/> is null. </exception>
        public virtual async Task<Response<NetworkFabricControllerResource>> GetAsync(string networkFabricControllerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricControllerName, nameof(networkFabricControllerName));

            using var scope = _networkFabricControllerClientDiagnostics.CreateScope("NetworkFabricControllerCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkFabricControllerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkFabricControllerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricControllerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Shows the provisioning status of Network Fabric Controller.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabricControllers/{networkFabricControllerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabricControllers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFabricControllerName"> Name of the Network Fabric Controller. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricControllerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricControllerName"/> is null. </exception>
        public virtual Response<NetworkFabricControllerResource> Get(string networkFabricControllerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricControllerName, nameof(networkFabricControllerName));

            using var scope = _networkFabricControllerClientDiagnostics.CreateScope("NetworkFabricControllerCollection.Get");
            scope.Start();
            try
            {
                var response = _networkFabricControllerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkFabricControllerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricControllerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the NetworkFabricControllers thats available in the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabricControllers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabricControllers_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkFabricControllerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkFabricControllerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricControllerRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricControllerRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricControllerResource(Client, NetworkFabricControllerData.DeserializeNetworkFabricControllerData(e)), _networkFabricControllerClientDiagnostics, Pipeline, "NetworkFabricControllerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the NetworkFabricControllers thats available in the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabricControllers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabricControllers_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkFabricControllerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkFabricControllerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricControllerRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricControllerRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricControllerResource(Client, NetworkFabricControllerData.DeserializeNetworkFabricControllerData(e)), _networkFabricControllerClientDiagnostics, Pipeline, "NetworkFabricControllerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabricControllers/{networkFabricControllerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabricControllers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFabricControllerName"> Name of the Network Fabric Controller. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricControllerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricControllerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkFabricControllerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricControllerName, nameof(networkFabricControllerName));

            using var scope = _networkFabricControllerClientDiagnostics.CreateScope("NetworkFabricControllerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkFabricControllerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkFabricControllerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabricControllers/{networkFabricControllerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabricControllers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFabricControllerName"> Name of the Network Fabric Controller. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricControllerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricControllerName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkFabricControllerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricControllerName, nameof(networkFabricControllerName));

            using var scope = _networkFabricControllerClientDiagnostics.CreateScope("NetworkFabricControllerCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkFabricControllerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkFabricControllerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkFabricControllerResource> IEnumerable<NetworkFabricControllerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkFabricControllerResource> IAsyncEnumerable<NetworkFabricControllerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
