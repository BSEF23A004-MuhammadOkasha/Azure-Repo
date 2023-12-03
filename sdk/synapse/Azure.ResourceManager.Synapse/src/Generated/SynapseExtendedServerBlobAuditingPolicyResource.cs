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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing a SynapseExtendedServerBlobAuditingPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SynapseExtendedServerBlobAuditingPolicyResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSynapseExtendedServerBlobAuditingPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="SynapseWorkspaceResource"/> using the GetSynapseExtendedServerBlobAuditingPolicy method.
    /// </summary>
    public partial class SynapseExtendedServerBlobAuditingPolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SynapseExtendedServerBlobAuditingPolicyResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workspaceName"> The workspaceName. </param>
        /// <param name="blobAuditingPolicyName"> The blobAuditingPolicyName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, SynapseBlobAuditingPolicyName blobAuditingPolicyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/extendedAuditingSettings/{blobAuditingPolicyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics;
        private readonly WorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestOperations _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient;
        private readonly SynapseExtendedServerBlobAuditingPolicyData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/extendedAuditingSettings";

        /// <summary> Initializes a new instance of the <see cref="SynapseExtendedServerBlobAuditingPolicyResource"/> class for mocking. </summary>
        protected SynapseExtendedServerBlobAuditingPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseExtendedServerBlobAuditingPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SynapseExtendedServerBlobAuditingPolicyResource(ArmClient client, SynapseExtendedServerBlobAuditingPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseExtendedServerBlobAuditingPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SynapseExtendedServerBlobAuditingPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesApiVersion);
            _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient = new WorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SynapseExtendedServerBlobAuditingPolicyData Data
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

        /// <summary>
        /// Get a workspace SQL server's extended blob auditing policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/extendedAuditingSettings/{blobAuditingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseExtendedServerBlobAuditingPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseExtendedServerBlobAuditingPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseExtendedServerBlobAuditingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a workspace SQL server's extended blob auditing policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/extendedAuditingSettings/{blobAuditingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseExtendedServerBlobAuditingPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseExtendedServerBlobAuditingPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseExtendedServerBlobAuditingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or Update a workspace managed sql server's extended blob auditing policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/extendedAuditingSettings/{blobAuditingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Properties of extended blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseExtendedServerBlobAuditingPolicyResource>> UpdateAsync(WaitUntil waitUntil, SynapseExtendedServerBlobAuditingPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseExtendedServerBlobAuditingPolicyResource.Update");
            scope.Start();
            try
            {
                var response = await _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseExtendedServerBlobAuditingPolicyResource>(new SynapseExtendedServerBlobAuditingPolicyOperationSource(Client), _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics, Pipeline, _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or Update a workspace managed sql server's extended blob auditing policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/extendedAuditingSettings/{blobAuditingPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerExtendedBlobAuditingPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Properties of extended blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseExtendedServerBlobAuditingPolicyResource> Update(WaitUntil waitUntil, SynapseExtendedServerBlobAuditingPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseExtendedServerBlobAuditingPolicyResource.Update");
            scope.Start();
            try
            {
                var response = _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseExtendedServerBlobAuditingPolicyResource>(new SynapseExtendedServerBlobAuditingPolicyOperationSource(Client), _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesClientDiagnostics, Pipeline, _synapseExtendedServerBlobAuditingPolicyWorkspaceManagedSqlServerExtendedBlobAuditingPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
