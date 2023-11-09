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

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkCloudClusterMetricsConfigurationResource" /> and their operations.
    /// Each <see cref="NetworkCloudClusterMetricsConfigurationResource" /> in the collection will belong to the same instance of <see cref="NetworkCloudClusterResource" />.
    /// To get a <see cref="NetworkCloudClusterMetricsConfigurationCollection" /> instance call the GetNetworkCloudClusterMetricsConfigurations method from an instance of <see cref="NetworkCloudClusterResource" />.
    /// </summary>
    public partial class NetworkCloudClusterMetricsConfigurationCollection : ArmCollection, IEnumerable<NetworkCloudClusterMetricsConfigurationResource>, IAsyncEnumerable<NetworkCloudClusterMetricsConfigurationResource>
    {
        private readonly ClientDiagnostics _networkCloudClusterMetricsConfigurationMetricsConfigurationsClientDiagnostics;
        private readonly MetricsConfigurationsRestOperations _networkCloudClusterMetricsConfigurationMetricsConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudClusterMetricsConfigurationCollection"/> class for mocking. </summary>
        protected NetworkCloudClusterMetricsConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudClusterMetricsConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkCloudClusterMetricsConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkCloudClusterMetricsConfigurationMetricsConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkCloud", NetworkCloudClusterMetricsConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkCloudClusterMetricsConfigurationResource.ResourceType, out string networkCloudClusterMetricsConfigurationMetricsConfigurationsApiVersion);
            _networkCloudClusterMetricsConfigurationMetricsConfigurationsRestClient = new MetricsConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkCloudClusterMetricsConfigurationMetricsConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkCloudClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkCloudClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create new or update the existing metrics configuration of the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/metricsConfigurations/{metricsConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MetricsConfigurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="metricsConfigurationName"> The name of the metrics configuration for the cluster. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="metricsConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="metricsConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkCloudClusterMetricsConfigurationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string metricsConfigurationName, NetworkCloudClusterMetricsConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(metricsConfigurationName, nameof(metricsConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudClusterMetricsConfigurationMetricsConfigurationsClientDiagnostics.CreateScope("NetworkCloudClusterMetricsConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkCloudClusterMetricsConfigurationMetricsConfigurationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metricsConfigurationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkCloudArmOperation<NetworkCloudClusterMetricsConfigurationResource>(new NetworkCloudClusterMetricsConfigurationOperationSource(Client), _networkCloudClusterMetricsConfigurationMetricsConfigurationsClientDiagnostics, Pipeline, _networkCloudClusterMetricsConfigurationMetricsConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metricsConfigurationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create new or update the existing metrics configuration of the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/metricsConfigurations/{metricsConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MetricsConfigurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="metricsConfigurationName"> The name of the metrics configuration for the cluster. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="metricsConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="metricsConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkCloudClusterMetricsConfigurationResource> CreateOrUpdate(WaitUntil waitUntil, string metricsConfigurationName, NetworkCloudClusterMetricsConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(metricsConfigurationName, nameof(metricsConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudClusterMetricsConfigurationMetricsConfigurationsClientDiagnostics.CreateScope("NetworkCloudClusterMetricsConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkCloudClusterMetricsConfigurationMetricsConfigurationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metricsConfigurationName, data, cancellationToken);
                var operation = new NetworkCloudArmOperation<NetworkCloudClusterMetricsConfigurationResource>(new NetworkCloudClusterMetricsConfigurationOperationSource(Client), _networkCloudClusterMetricsConfigurationMetricsConfigurationsClientDiagnostics, Pipeline, _networkCloudClusterMetricsConfigurationMetricsConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metricsConfigurationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get metrics configuration of the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/metricsConfigurations/{metricsConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MetricsConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="metricsConfigurationName"> The name of the metrics configuration for the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="metricsConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="metricsConfigurationName"/> is null. </exception>
        public virtual async Task<Response<NetworkCloudClusterMetricsConfigurationResource>> GetAsync(string metricsConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(metricsConfigurationName, nameof(metricsConfigurationName));

            using var scope = _networkCloudClusterMetricsConfigurationMetricsConfigurationsClientDiagnostics.CreateScope("NetworkCloudClusterMetricsConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkCloudClusterMetricsConfigurationMetricsConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metricsConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudClusterMetricsConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get metrics configuration of the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/metricsConfigurations/{metricsConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MetricsConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="metricsConfigurationName"> The name of the metrics configuration for the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="metricsConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="metricsConfigurationName"/> is null. </exception>
        public virtual Response<NetworkCloudClusterMetricsConfigurationResource> Get(string metricsConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(metricsConfigurationName, nameof(metricsConfigurationName));

            using var scope = _networkCloudClusterMetricsConfigurationMetricsConfigurationsClientDiagnostics.CreateScope("NetworkCloudClusterMetricsConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _networkCloudClusterMetricsConfigurationMetricsConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metricsConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudClusterMetricsConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of metrics configurations for the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/metricsConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MetricsConfigurations_ListByCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkCloudClusterMetricsConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkCloudClusterMetricsConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudClusterMetricsConfigurationMetricsConfigurationsRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudClusterMetricsConfigurationMetricsConfigurationsRestClient.CreateListByClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new NetworkCloudClusterMetricsConfigurationResource(Client, NetworkCloudClusterMetricsConfigurationData.DeserializeNetworkCloudClusterMetricsConfigurationData(e)), _networkCloudClusterMetricsConfigurationMetricsConfigurationsClientDiagnostics, Pipeline, "NetworkCloudClusterMetricsConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of metrics configurations for the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/metricsConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MetricsConfigurations_ListByCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkCloudClusterMetricsConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkCloudClusterMetricsConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudClusterMetricsConfigurationMetricsConfigurationsRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudClusterMetricsConfigurationMetricsConfigurationsRestClient.CreateListByClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new NetworkCloudClusterMetricsConfigurationResource(Client, NetworkCloudClusterMetricsConfigurationData.DeserializeNetworkCloudClusterMetricsConfigurationData(e)), _networkCloudClusterMetricsConfigurationMetricsConfigurationsClientDiagnostics, Pipeline, "NetworkCloudClusterMetricsConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/metricsConfigurations/{metricsConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MetricsConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="metricsConfigurationName"> The name of the metrics configuration for the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="metricsConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="metricsConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string metricsConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(metricsConfigurationName, nameof(metricsConfigurationName));

            using var scope = _networkCloudClusterMetricsConfigurationMetricsConfigurationsClientDiagnostics.CreateScope("NetworkCloudClusterMetricsConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkCloudClusterMetricsConfigurationMetricsConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metricsConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/metricsConfigurations/{metricsConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MetricsConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="metricsConfigurationName"> The name of the metrics configuration for the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="metricsConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="metricsConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string metricsConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(metricsConfigurationName, nameof(metricsConfigurationName));

            using var scope = _networkCloudClusterMetricsConfigurationMetricsConfigurationsClientDiagnostics.CreateScope("NetworkCloudClusterMetricsConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkCloudClusterMetricsConfigurationMetricsConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metricsConfigurationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/metricsConfigurations/{metricsConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MetricsConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="metricsConfigurationName"> The name of the metrics configuration for the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="metricsConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="metricsConfigurationName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkCloudClusterMetricsConfigurationResource>> GetIfExistsAsync(string metricsConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(metricsConfigurationName, nameof(metricsConfigurationName));

            using var scope = _networkCloudClusterMetricsConfigurationMetricsConfigurationsClientDiagnostics.CreateScope("NetworkCloudClusterMetricsConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkCloudClusterMetricsConfigurationMetricsConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metricsConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudClusterMetricsConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudClusterMetricsConfigurationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/metricsConfigurations/{metricsConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MetricsConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="metricsConfigurationName"> The name of the metrics configuration for the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="metricsConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="metricsConfigurationName"/> is null. </exception>
        public virtual NullableResponse<NetworkCloudClusterMetricsConfigurationResource> GetIfExists(string metricsConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(metricsConfigurationName, nameof(metricsConfigurationName));

            using var scope = _networkCloudClusterMetricsConfigurationMetricsConfigurationsClientDiagnostics.CreateScope("NetworkCloudClusterMetricsConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkCloudClusterMetricsConfigurationMetricsConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, metricsConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkCloudClusterMetricsConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudClusterMetricsConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkCloudClusterMetricsConfigurationResource> IEnumerable<NetworkCloudClusterMetricsConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkCloudClusterMetricsConfigurationResource> IAsyncEnumerable<NetworkCloudClusterMetricsConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
