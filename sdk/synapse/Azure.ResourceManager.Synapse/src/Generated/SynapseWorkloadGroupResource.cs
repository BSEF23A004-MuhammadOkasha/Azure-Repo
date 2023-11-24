// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing a SynapseWorkloadGroup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SynapseWorkloadGroupResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSynapseWorkloadGroupResource method.
    /// Otherwise you can get one from its parent resource <see cref="SynapseSqlPoolResource"/> using the GetSynapseWorkloadGroup method.
    /// </summary>
    public partial class SynapseWorkloadGroupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SynapseWorkloadGroupResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workspaceName"> The workspaceName. </param>
        /// <param name="sqlPoolName"> The sqlPoolName. </param>
        /// <param name="workloadGroupName"> The workloadGroupName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics;
        private readonly SqlPoolWorkloadGroupRestOperations _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient;
        private readonly SynapseWorkloadGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="SynapseWorkloadGroupResource"/> class for mocking. </summary>
        protected SynapseWorkloadGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseWorkloadGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SynapseWorkloadGroupResource(ArmClient client, SynapseWorkloadGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseWorkloadGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SynapseWorkloadGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string synapseWorkloadGroupSqlPoolWorkloadGroupApiVersion);
            _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient = new SqlPoolWorkloadGroupRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseWorkloadGroupSqlPoolWorkloadGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/sqlPools/workloadGroups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SynapseWorkloadGroupData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SynapseWorkloadClassifierResources in the SynapseWorkloadGroup. </summary>
        /// <returns> An object representing collection of SynapseWorkloadClassifierResources and their operations over a SynapseWorkloadClassifierResource. </returns>
        public virtual SynapseWorkloadClassifierCollection GetSynapseWorkloadClassifiers()
        {
            return GetCachedClient(client => new SynapseWorkloadClassifierCollection(client, Id));
        }

        /// <summary>
        /// Get a workload classifier of Sql pool's workload group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}/workloadClassifiers/{workloadClassifierName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolWorkloadClassifier_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workloadClassifierName"> The name of the workload classifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadClassifierName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workloadClassifierName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SynapseWorkloadClassifierResource>> GetSynapseWorkloadClassifierAsync(string workloadClassifierName, CancellationToken cancellationToken = default)
        {
            return await GetSynapseWorkloadClassifiers().GetAsync(workloadClassifierName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a workload classifier of Sql pool's workload group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}/workloadClassifiers/{workloadClassifierName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolWorkloadClassifier_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workloadClassifierName"> The name of the workload classifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadClassifierName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workloadClassifierName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SynapseWorkloadClassifierResource> GetSynapseWorkloadClassifier(string workloadClassifierName, CancellationToken cancellationToken = default)
        {
            return GetSynapseWorkloadClassifiers().Get(workloadClassifierName, cancellationToken);
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseWorkloadGroupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("SynapseWorkloadGroupResource.Get");
            scope.Start();
            try
            {
                var response = await _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseWorkloadGroupResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("SynapseWorkloadGroupResource.Get");
            scope.Start();
            try
            {
                var response = _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Remove Sql pool's workload group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolWorkloadGroup_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("SynapseWorkloadGroupResource.Delete");
            scope.Start();
            try
            {
                var response = await _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation(_synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics, Pipeline, _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Remove Sql pool's workload group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolWorkloadGroup_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("SynapseWorkloadGroupResource.Delete");
            scope.Start();
            try
            {
                var response = _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SynapseArmOperation(_synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics, Pipeline, _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
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
        /// <param name="data"> The requested workload group state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseWorkloadGroupResource>> UpdateAsync(WaitUntil waitUntil, SynapseWorkloadGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("SynapseWorkloadGroupResource.Update");
            scope.Start();
            try
            {
                var response = await _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseWorkloadGroupResource>(new SynapseWorkloadGroupOperationSource(Client), _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics, Pipeline, _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// <param name="data"> The requested workload group state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseWorkloadGroupResource> Update(WaitUntil waitUntil, SynapseWorkloadGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("SynapseWorkloadGroupResource.Update");
            scope.Start();
            try
            {
                var response = _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseWorkloadGroupResource>(new SynapseWorkloadGroupOperationSource(Client), _synapseWorkloadGroupSqlPoolWorkloadGroupClientDiagnostics, Pipeline, _synapseWorkloadGroupSqlPoolWorkloadGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
    }
}
