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
    /// A Class representing a SynapseDedicatedSqlMinimalTlsSetting along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SynapseDedicatedSqlMinimalTlsSettingResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSynapseDedicatedSqlMinimalTlsSettingResource method.
    /// Otherwise you can get one from its parent resource <see cref="SynapseWorkspaceResource" /> using the GetSynapseDedicatedSqlMinimalTlsSetting method.
    /// </summary>
    public partial class SynapseDedicatedSqlMinimalTlsSettingResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SynapseDedicatedSqlMinimalTlsSettingResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string dedicatedSQLminimalTlsSettingsName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/dedicatedSQLminimalTlsSettings/{dedicatedSQLminimalTlsSettingsName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsClientDiagnostics;
        private readonly WorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsRestOperations _synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsRestClient;
        private readonly SynapseDedicatedSqlMinimalTlsSettingData _data;

        /// <summary> Initializes a new instance of the <see cref="SynapseDedicatedSqlMinimalTlsSettingResource"/> class for mocking. </summary>
        protected SynapseDedicatedSqlMinimalTlsSettingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SynapseDedicatedSqlMinimalTlsSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SynapseDedicatedSqlMinimalTlsSettingResource(ArmClient client, SynapseDedicatedSqlMinimalTlsSettingData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseDedicatedSqlMinimalTlsSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SynapseDedicatedSqlMinimalTlsSettingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsApiVersion);
            _synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsRestClient = new WorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/dedicatedSQLminimalTlsSettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SynapseDedicatedSqlMinimalTlsSettingData Data
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
        /// Get workspace managed sql server's minimal tls settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/dedicatedSQLminimalTlsSettings/{dedicatedSQLminimalTlsSettingsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseDedicatedSqlMinimalTlsSettingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsClientDiagnostics.CreateScope("SynapseDedicatedSqlMinimalTlsSettingResource.Get");
            scope.Start();
            try
            {
                var response = await _synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseDedicatedSqlMinimalTlsSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get workspace managed sql server's minimal tls settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/dedicatedSQLminimalTlsSettings/{dedicatedSQLminimalTlsSettingsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseDedicatedSqlMinimalTlsSettingResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsClientDiagnostics.CreateScope("SynapseDedicatedSqlMinimalTlsSettingResource.Get");
            scope.Start();
            try
            {
                var response = _synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseDedicatedSqlMinimalTlsSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update workspace managed sql server's minimal tls settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/dedicatedSQLminimalTlsSettings/{dedicatedSQLminimalTlsSettingsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettings_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> minimal tls settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseDedicatedSqlMinimalTlsSettingResource>> UpdateAsync(WaitUntil waitUntil, SynapseDedicatedSqlMinimalTlsSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsClientDiagnostics.CreateScope("SynapseDedicatedSqlMinimalTlsSettingResource.Update");
            scope.Start();
            try
            {
                var response = await _synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseDedicatedSqlMinimalTlsSettingResource>(new SynapseDedicatedSqlMinimalTlsSettingOperationSource(Client), _synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsClientDiagnostics, Pipeline, _synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Update workspace managed sql server's minimal tls settings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/dedicatedSQLminimalTlsSettings/{dedicatedSQLminimalTlsSettingsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettings_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> minimal tls settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseDedicatedSqlMinimalTlsSettingResource> Update(WaitUntil waitUntil, SynapseDedicatedSqlMinimalTlsSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsClientDiagnostics.CreateScope("SynapseDedicatedSqlMinimalTlsSettingResource.Update");
            scope.Start();
            try
            {
                var response = _synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseDedicatedSqlMinimalTlsSettingResource>(new SynapseDedicatedSqlMinimalTlsSettingOperationSource(Client), _synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsClientDiagnostics, Pipeline, _synapseDedicatedSqlMinimalTlsSettingWorkspaceManagedSqlServerDedicatedSQLMinimalTlsSettingsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, Core.OperationFinalStateVia.Location);
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
