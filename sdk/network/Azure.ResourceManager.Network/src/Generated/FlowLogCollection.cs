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
    /// A class representing a collection of <see cref="FlowLogResource" /> and their operations.
    /// Each <see cref="FlowLogResource" /> in the collection will belong to the same instance of <see cref="NetworkWatcherResource" />.
    /// To get a <see cref="FlowLogCollection" /> instance call the GetFlowLogs method from an instance of <see cref="NetworkWatcherResource" />.
    /// </summary>
    public partial class FlowLogCollection : ArmCollection, IEnumerable<FlowLogResource>, IAsyncEnumerable<FlowLogResource>
    {
        private readonly ClientDiagnostics _flowLogClientDiagnostics;
        private readonly FlowLogsRestOperations _flowLogRestClient;

        /// <summary> Initializes a new instance of the <see cref="FlowLogCollection"/> class for mocking. </summary>
        protected FlowLogCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FlowLogCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FlowLogCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _flowLogClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", FlowLogResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FlowLogResource.ResourceType, out string flowLogApiVersion);
            _flowLogRestClient = new FlowLogsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, flowLogApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkWatcherResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkWatcherResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a flow log for the specified network security group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FlowLogs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="flowLogName"> The name of the flow log. </param>
        /// <param name="data"> Parameters that define the create or update flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="flowLogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FlowLogResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string flowLogName, FlowLogData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(flowLogName, nameof(flowLogName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _flowLogRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<FlowLogResource>(new FlowLogOperationSource(Client), _flowLogClientDiagnostics, Pipeline, _flowLogRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update a flow log for the specified network security group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FlowLogs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="flowLogName"> The name of the flow log. </param>
        /// <param name="data"> Parameters that define the create or update flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="flowLogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FlowLogResource> CreateOrUpdate(WaitUntil waitUntil, string flowLogName, FlowLogData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(flowLogName, nameof(flowLogName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _flowLogRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, data, cancellationToken);
                var operation = new NetworkArmOperation<FlowLogResource>(new FlowLogOperationSource(Client), _flowLogClientDiagnostics, Pipeline, _flowLogRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a flow log resource by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FlowLogs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="flowLogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public virtual async Task<Response<FlowLogResource>> GetAsync(string flowLogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(flowLogName, nameof(flowLogName));

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.Get");
            scope.Start();
            try
            {
                var response = await _flowLogRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FlowLogResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a flow log resource by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FlowLogs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="flowLogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public virtual Response<FlowLogResource> Get(string flowLogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(flowLogName, nameof(flowLogName));

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.Get");
            scope.Start();
            try
            {
                var response = _flowLogRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FlowLogResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all flow log resources for the specified Network Watcher.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FlowLogs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FlowLogResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FlowLogResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _flowLogRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _flowLogRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new FlowLogResource(Client, FlowLogData.DeserializeFlowLogData(e)), _flowLogClientDiagnostics, Pipeline, "FlowLogCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all flow log resources for the specified Network Watcher.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FlowLogs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FlowLogResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FlowLogResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _flowLogRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _flowLogRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new FlowLogResource(Client, FlowLogData.DeserializeFlowLogData(e)), _flowLogClientDiagnostics, Pipeline, "FlowLogCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FlowLogs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="flowLogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string flowLogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(flowLogName, nameof(flowLogName));

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.Exists");
            scope.Start();
            try
            {
                var response = await _flowLogRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FlowLogs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="flowLogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public virtual Response<bool> Exists(string flowLogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(flowLogName, nameof(flowLogName));

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.Exists");
            scope.Start();
            try
            {
                var response = _flowLogRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FlowLogs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="flowLogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public virtual async Task<NullableResponse<FlowLogResource>> GetIfExistsAsync(string flowLogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(flowLogName, nameof(flowLogName));

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _flowLogRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<FlowLogResource>(response.GetRawResponse());
                return Response.FromValue(new FlowLogResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FlowLogs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="flowLogName"> The name of the flow log resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="flowLogName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="flowLogName"/> is null. </exception>
        public virtual NullableResponse<FlowLogResource> GetIfExists(string flowLogName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(flowLogName, nameof(flowLogName));

            using var scope = _flowLogClientDiagnostics.CreateScope("FlowLogCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _flowLogRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, flowLogName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<FlowLogResource>(response.GetRawResponse());
                return Response.FromValue(new FlowLogResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FlowLogResource> IEnumerable<FlowLogResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FlowLogResource> IAsyncEnumerable<FlowLogResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
