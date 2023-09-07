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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ConnectionMonitorResource" /> and their operations.
    /// Each <see cref="ConnectionMonitorResource" /> in the collection will belong to the same instance of <see cref="NetworkWatcherResource" />.
    /// To get a <see cref="ConnectionMonitorCollection" /> instance call the GetConnectionMonitors method from an instance of <see cref="NetworkWatcherResource" />.
    /// </summary>
    public partial class ConnectionMonitorCollection : ArmCollection, IEnumerable<ConnectionMonitorResource>, IAsyncEnumerable<ConnectionMonitorResource>
    {
        private readonly ClientDiagnostics _connectionMonitorClientDiagnostics;
        private readonly ConnectionMonitorsRestOperations _connectionMonitorRestClient;

        /// <summary> Initializes a new instance of the <see cref="ConnectionMonitorCollection"/> class for mocking. </summary>
        protected ConnectionMonitorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ConnectionMonitorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ConnectionMonitorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _connectionMonitorClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ConnectionMonitorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ConnectionMonitorResource.ResourceType, out string connectionMonitorApiVersion);
            _connectionMonitorRestClient = new ConnectionMonitorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, connectionMonitorApiVersion);
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
        /// Create or update a connection monitor.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/connectionMonitors/{connectionMonitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionMonitors_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="content"> Parameters that define the operation to create a connection monitor. </param>
        /// <param name="migrate"> Value indicating whether connection monitor V1 should be migrated to V2 format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionMonitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionMonitorName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ConnectionMonitorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string connectionMonitorName, ConnectionMonitorCreateOrUpdateContent content, string migrate = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionMonitorName, nameof(connectionMonitorName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _connectionMonitorClientDiagnostics.CreateScope("ConnectionMonitorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _connectionMonitorRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionMonitorName, content, migrate, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ConnectionMonitorResource>(new ConnectionMonitorOperationSource(Client), _connectionMonitorClientDiagnostics, Pipeline, _connectionMonitorRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionMonitorName, content, migrate).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update a connection monitor.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/connectionMonitors/{connectionMonitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionMonitors_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="content"> Parameters that define the operation to create a connection monitor. </param>
        /// <param name="migrate"> Value indicating whether connection monitor V1 should be migrated to V2 format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionMonitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionMonitorName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ConnectionMonitorResource> CreateOrUpdate(WaitUntil waitUntil, string connectionMonitorName, ConnectionMonitorCreateOrUpdateContent content, string migrate = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionMonitorName, nameof(connectionMonitorName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _connectionMonitorClientDiagnostics.CreateScope("ConnectionMonitorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _connectionMonitorRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionMonitorName, content, migrate, cancellationToken);
                var operation = new NetworkArmOperation<ConnectionMonitorResource>(new ConnectionMonitorOperationSource(Client), _connectionMonitorClientDiagnostics, Pipeline, _connectionMonitorRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionMonitorName, content, migrate).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a connection monitor by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/connectionMonitors/{connectionMonitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionMonitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionMonitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionMonitorName"/> is null. </exception>
        public virtual async Task<Response<ConnectionMonitorResource>> GetAsync(string connectionMonitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionMonitorName, nameof(connectionMonitorName));

            using var scope = _connectionMonitorClientDiagnostics.CreateScope("ConnectionMonitorCollection.Get");
            scope.Start();
            try
            {
                var response = await _connectionMonitorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionMonitorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConnectionMonitorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a connection monitor by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/connectionMonitors/{connectionMonitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionMonitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionMonitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionMonitorName"/> is null. </exception>
        public virtual Response<ConnectionMonitorResource> Get(string connectionMonitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionMonitorName, nameof(connectionMonitorName));

            using var scope = _connectionMonitorClientDiagnostics.CreateScope("ConnectionMonitorCollection.Get");
            scope.Start();
            try
            {
                var response = _connectionMonitorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionMonitorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConnectionMonitorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all connection monitors for the specified Network Watcher.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/connectionMonitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionMonitors_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConnectionMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConnectionMonitorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _connectionMonitorRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new ConnectionMonitorResource(Client, ConnectionMonitorData.DeserializeConnectionMonitorData(e)), _connectionMonitorClientDiagnostics, Pipeline, "ConnectionMonitorCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all connection monitors for the specified Network Watcher.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/connectionMonitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionMonitors_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConnectionMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConnectionMonitorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _connectionMonitorRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new ConnectionMonitorResource(Client, ConnectionMonitorData.DeserializeConnectionMonitorData(e)), _connectionMonitorClientDiagnostics, Pipeline, "ConnectionMonitorCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/connectionMonitors/{connectionMonitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionMonitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionMonitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionMonitorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectionMonitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionMonitorName, nameof(connectionMonitorName));

            using var scope = _connectionMonitorClientDiagnostics.CreateScope("ConnectionMonitorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _connectionMonitorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionMonitorName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/connectionMonitors/{connectionMonitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionMonitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionMonitorName"> The name of the connection monitor. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionMonitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionMonitorName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionMonitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectionMonitorName, nameof(connectionMonitorName));

            using var scope = _connectionMonitorClientDiagnostics.CreateScope("ConnectionMonitorCollection.Exists");
            scope.Start();
            try
            {
                var response = _connectionMonitorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionMonitorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ConnectionMonitorResource> IEnumerable<ConnectionMonitorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ConnectionMonitorResource> IAsyncEnumerable<ConnectionMonitorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
