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

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseWorkloadGroupResource" /> and their operations.
    /// Each <see cref="SynapseWorkloadGroupResource" /> in the collection will belong to the same instance of <see cref="SynapseSqlPoolResource" />.
    /// To get a <see cref="SynapseWorkloadGroupCollection" /> instance call the GetSynapseWorkloadGroups method from an instance of <see cref="SynapseSqlPoolResource" />.
    /// </summary>
    public partial class SynapseWorkloadGroupCollection : ArmCollection, IEnumerable<SynapseWorkloadGroupResource>, IAsyncEnumerable<SynapseWorkloadGroupResource>
    {
        private readonly ClientDiagnostics _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics;
        private readonly SqlPoolWorkloadGroupRestOperations _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseWorkloadGroupCollection"/> class for mocking. </summary>
        protected SynapseWorkloadGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseWorkloadGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseWorkloadGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseWorkloadGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseWorkloadGroupResource.ResourceType, out string synapseWorkloadGroupSqlPoolWorkloadGroupApiVersion);
            _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient = new SqlPoolWorkloadGroupRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseWorkloadGroupSqlPoolWorkloadGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseSqlPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseSqlPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create Or Update a Sql pool's workload group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolWorkloadGroup_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="data"> The requested workload group state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseWorkloadGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string workloadGroupName, SynapseWorkloadGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("SynapseWorkloadGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseWorkloadGroupResource>(new SynapseWorkloadGroupOperationSource(Client), _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics, Pipeline, _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create Or Update a Sql pool's workload group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolWorkloadGroup_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="data"> The requested workload group state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseWorkloadGroupResource> CreateOrUpdate(WaitUntil waitUntil, string workloadGroupName, SynapseWorkloadGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("SynapseWorkloadGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseWorkloadGroupResource>(new SynapseWorkloadGroupOperationSource(Client), _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics, Pipeline, _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a Sql pool's workload group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolWorkloadGroup_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public virtual async Task<Response<SynapseWorkloadGroupResource>> GetAsync(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));

            using var scope = _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("SynapseWorkloadGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseWorkloadGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Sql pool's workload group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolWorkloadGroup_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public virtual Response<SynapseWorkloadGroupResource> Get(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));

            using var scope = _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("SynapseWorkloadGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseWorkloadGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get list of  Sql pool's workload groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolWorkloadGroup_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseWorkloadGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseWorkloadGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SynapseWorkloadGroupResource(Client, SynapseWorkloadGroupData.DeserializeSynapseWorkloadGroupData(e)), _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics, Pipeline, "SynapseWorkloadGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get list of  Sql pool's workload groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolWorkloadGroup_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseWorkloadGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseWorkloadGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SynapseWorkloadGroupResource(Client, SynapseWorkloadGroupData.DeserializeSynapseWorkloadGroupData(e)), _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics, Pipeline, "SynapseWorkloadGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolWorkloadGroup_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));

            using var scope = _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("SynapseWorkloadGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolWorkloadGroup_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadGroupName, nameof(workloadGroupName));

            using var scope = _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("SynapseWorkloadGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseWorkloadGroupResource> IEnumerable<SynapseWorkloadGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseWorkloadGroupResource> IAsyncEnumerable<SynapseWorkloadGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
