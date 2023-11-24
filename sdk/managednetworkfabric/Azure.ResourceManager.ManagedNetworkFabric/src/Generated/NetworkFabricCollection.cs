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
    /// A class representing a collection of <see cref="NetworkFabricResource"/> and their operations.
    /// Each <see cref="NetworkFabricResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="NetworkFabricCollection"/> instance call the GetNetworkFabrics method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class NetworkFabricCollection : ArmCollection, IEnumerable<NetworkFabricResource>, IAsyncEnumerable<NetworkFabricResource>
    {
        private readonly ClientDiagnostics _networkFabricClientDiagnostics;
        private readonly NetworkFabricsRestOperations _networkFabricRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricCollection"/> class for mocking. </summary>
        protected NetworkFabricCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkFabricCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFabricClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkFabricResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkFabricResource.ResourceType, out string networkFabricApiVersion);
            _networkFabricRestClient = new NetworkFabricsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFabricApiVersion);
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
        /// Create Network Fabric resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics/{networkFabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabrics_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkFabricName"> Name of the Network Fabric. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkFabricResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkFabricName, NetworkFabricData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricName, nameof(networkFabricName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricClientDiagnostics.CreateScope("NetworkFabricCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkFabricRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkFabricName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricResource>(new NetworkFabricOperationSource(Client), _networkFabricClientDiagnostics, Pipeline, _networkFabricRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkFabricName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create Network Fabric resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics/{networkFabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabrics_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkFabricName"> Name of the Network Fabric. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkFabricResource> CreateOrUpdate(WaitUntil waitUntil, string networkFabricName, NetworkFabricData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricName, nameof(networkFabricName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkFabricClientDiagnostics.CreateScope("NetworkFabricCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkFabricRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, networkFabricName, data, cancellationToken);
                var operation = new ManagedNetworkFabricArmOperation<NetworkFabricResource>(new NetworkFabricOperationSource(Client), _networkFabricClientDiagnostics, Pipeline, _networkFabricRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkFabricName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get Network Fabric resource details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics/{networkFabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabrics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFabricName"> Name of the Network Fabric. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricName"/> is null. </exception>
        public virtual async Task<Response<NetworkFabricResource>> GetAsync(string networkFabricName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricName, nameof(networkFabricName));

            using var scope = _networkFabricClientDiagnostics.CreateScope("NetworkFabricCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkFabricRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkFabricName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Network Fabric resource details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics/{networkFabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabrics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFabricName"> Name of the Network Fabric. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricName"/> is null. </exception>
        public virtual Response<NetworkFabricResource> Get(string networkFabricName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricName, nameof(networkFabricName));

            using var scope = _networkFabricClientDiagnostics.CreateScope("NetworkFabricCollection.Get");
            scope.Start();
            try
            {
                var response = _networkFabricRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkFabricName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the Network Fabric resources in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabrics_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkFabricResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkFabricResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricResource(Client, NetworkFabricData.DeserializeNetworkFabricData(e)), _networkFabricClientDiagnostics, Pipeline, "NetworkFabricCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the Network Fabric resources in the given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabrics_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkFabricResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkFabricResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFabricRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFabricRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkFabricResource(Client, NetworkFabricData.DeserializeNetworkFabricData(e)), _networkFabricClientDiagnostics, Pipeline, "NetworkFabricCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics/{networkFabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabrics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFabricName"> Name of the Network Fabric. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkFabricName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricName, nameof(networkFabricName));

            using var scope = _networkFabricClientDiagnostics.CreateScope("NetworkFabricCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkFabricRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkFabricName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics/{networkFabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabrics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFabricName"> Name of the Network Fabric. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkFabricName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricName, nameof(networkFabricName));

            using var scope = _networkFabricClientDiagnostics.CreateScope("NetworkFabricCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkFabricRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkFabricName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics/{networkFabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabrics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFabricName"> Name of the Network Fabric. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkFabricResource>> GetIfExistsAsync(string networkFabricName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricName, nameof(networkFabricName));

            using var scope = _networkFabricClientDiagnostics.CreateScope("NetworkFabricCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkFabricRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkFabricName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkFabricResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkFabrics/{networkFabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabrics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFabricName"> Name of the Network Fabric. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFabricName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricName"/> is null. </exception>
        public virtual NullableResponse<NetworkFabricResource> GetIfExists(string networkFabricName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFabricName, nameof(networkFabricName));

            using var scope = _networkFabricClientDiagnostics.CreateScope("NetworkFabricCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkFabricRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkFabricName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkFabricResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkFabricResource> IEnumerable<NetworkFabricResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkFabricResource> IAsyncEnumerable<NetworkFabricResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
