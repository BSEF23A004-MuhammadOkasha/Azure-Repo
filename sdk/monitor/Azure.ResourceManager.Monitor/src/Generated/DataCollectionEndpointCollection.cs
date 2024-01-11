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

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing a collection of <see cref="DataCollectionEndpointResource"/> and their operations.
    /// Each <see cref="DataCollectionEndpointResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="DataCollectionEndpointCollection"/> instance call the GetDataCollectionEndpoints method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class DataCollectionEndpointCollection : ArmCollection, IEnumerable<DataCollectionEndpointResource>, IAsyncEnumerable<DataCollectionEndpointResource>
    {
        private readonly ClientDiagnostics _dataCollectionEndpointClientDiagnostics;
        private readonly DataCollectionEndpointsRestOperations _dataCollectionEndpointRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataCollectionEndpointCollection"/> class for mocking. </summary>
        protected DataCollectionEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataCollectionEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataCollectionEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataCollectionEndpointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", DataCollectionEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataCollectionEndpointResource.ResourceType, out string dataCollectionEndpointApiVersion);
            _dataCollectionEndpointRestClient = new DataCollectionEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataCollectionEndpointApiVersion);
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
        /// Creates or updates a data collection endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionEndpoints_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="data"> The payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataCollectionEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dataCollectionEndpointName, DataCollectionEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionEndpointName, nameof(dataCollectionEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataCollectionEndpointRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, data, cancellationToken).ConfigureAwait(false);
                var uri = _dataCollectionEndpointRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new MonitorArmOperation<DataCollectionEndpointResource>(Response.FromValue(new DataCollectionEndpointResource(Client, response), response.GetRawResponse()), operationId);
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
        /// Creates or updates a data collection endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionEndpoints_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="data"> The payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataCollectionEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string dataCollectionEndpointName, DataCollectionEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionEndpointName, nameof(dataCollectionEndpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataCollectionEndpointRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, data, cancellationToken);
                var uri = _dataCollectionEndpointRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new MonitorArmOperation<DataCollectionEndpointResource>(Response.FromValue(new DataCollectionEndpointResource(Client, response), response.GetRawResponse()), operationId);
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
        /// Returns the specified data collection endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public virtual async Task<Response<DataCollectionEndpointResource>> GetAsync(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionEndpointName, nameof(dataCollectionEndpointName));

            using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataCollectionEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataCollectionEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the specified data collection endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public virtual Response<DataCollectionEndpointResource> Get(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionEndpointName, nameof(dataCollectionEndpointName));

            using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _dataCollectionEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataCollectionEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all data collection endpoints in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionEndpoints_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataCollectionEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataCollectionEndpointResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataCollectionEndpointRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataCollectionEndpointRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataCollectionEndpointResource(Client, DataCollectionEndpointData.DeserializeDataCollectionEndpointData(e)), _dataCollectionEndpointClientDiagnostics, Pipeline, "DataCollectionEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all data collection endpoints in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionEndpoints_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataCollectionEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataCollectionEndpointResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataCollectionEndpointRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataCollectionEndpointRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataCollectionEndpointResource(Client, DataCollectionEndpointData.DeserializeDataCollectionEndpointData(e)), _dataCollectionEndpointClientDiagnostics, Pipeline, "DataCollectionEndpointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionEndpointName, nameof(dataCollectionEndpointName));

            using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataCollectionEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionEndpointName, nameof(dataCollectionEndpointName));

            using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataCollectionEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataCollectionEndpointResource>> GetIfExistsAsync(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionEndpointName, nameof(dataCollectionEndpointName));

            using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataCollectionEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataCollectionEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new DataCollectionEndpointResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataCollectionEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataCollectionEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public virtual NullableResponse<DataCollectionEndpointResource> GetIfExists(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionEndpointName, nameof(dataCollectionEndpointName));

            using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataCollectionEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataCollectionEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new DataCollectionEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataCollectionEndpointResource> IEnumerable<DataCollectionEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataCollectionEndpointResource> IAsyncEnumerable<DataCollectionEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
