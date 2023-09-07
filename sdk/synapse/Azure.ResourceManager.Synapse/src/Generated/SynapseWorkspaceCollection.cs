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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseWorkspaceResource" /> and their operations.
    /// Each <see cref="SynapseWorkspaceResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="SynapseWorkspaceCollection" /> instance call the GetSynapseWorkspaces method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class SynapseWorkspaceCollection : ArmCollection, IEnumerable<SynapseWorkspaceResource>, IAsyncEnumerable<SynapseWorkspaceResource>
    {
        private readonly ClientDiagnostics _synapseWorkspaceWorkspacesClientDiagnostics;
        private readonly WorkspacesRestOperations _synapseWorkspaceWorkspacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseWorkspaceCollection"/> class for mocking. </summary>
        protected SynapseWorkspaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseWorkspaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseWorkspaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseWorkspaceWorkspacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseWorkspaceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseWorkspaceResource.ResourceType, out string synapseWorkspaceWorkspacesApiVersion);
            _synapseWorkspaceWorkspacesRestClient = new WorkspacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseWorkspaceWorkspacesApiVersion);
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
        /// Creates or updates a workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="data"> Workspace create or update request properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseWorkspaceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string workspaceName, SynapseWorkspaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseWorkspaceWorkspacesClientDiagnostics.CreateScope("SynapseWorkspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseWorkspaceWorkspacesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseWorkspaceResource>(new SynapseWorkspaceOperationSource(Client), _synapseWorkspaceWorkspacesClientDiagnostics, Pipeline, _synapseWorkspaceWorkspacesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Creates or updates a workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="data"> Workspace create or update request properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseWorkspaceResource> CreateOrUpdate(WaitUntil waitUntil, string workspaceName, SynapseWorkspaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseWorkspaceWorkspacesClientDiagnostics.CreateScope("SynapseWorkspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseWorkspaceWorkspacesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseWorkspaceResource>(new SynapseWorkspaceOperationSource(Client), _synapseWorkspaceWorkspacesClientDiagnostics, Pipeline, _synapseWorkspaceWorkspacesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, data).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Gets a workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<Response<SynapseWorkspaceResource>> GetAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _synapseWorkspaceWorkspacesClientDiagnostics.CreateScope("SynapseWorkspaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseWorkspaceWorkspacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<SynapseWorkspaceResource> Get(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _synapseWorkspaceWorkspacesClientDiagnostics.CreateScope("SynapseWorkspaceCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseWorkspaceWorkspacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of workspaces in a resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseWorkspaceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseWorkspaceWorkspacesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseWorkspaceWorkspacesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SynapseWorkspaceResource(Client, SynapseWorkspaceData.DeserializeSynapseWorkspaceData(e)), _synapseWorkspaceWorkspacesClientDiagnostics, Pipeline, "SynapseWorkspaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of workspaces in a resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseWorkspaceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseWorkspaceWorkspacesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseWorkspaceWorkspacesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SynapseWorkspaceResource(Client, SynapseWorkspaceData.DeserializeSynapseWorkspaceData(e)), _synapseWorkspaceWorkspacesClientDiagnostics, Pipeline, "SynapseWorkspaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _synapseWorkspaceWorkspacesClientDiagnostics.CreateScope("SynapseWorkspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseWorkspaceWorkspacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string workspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));

            using var scope = _synapseWorkspaceWorkspacesClientDiagnostics.CreateScope("SynapseWorkspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseWorkspaceWorkspacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, workspaceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseWorkspaceResource> IEnumerable<SynapseWorkspaceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseWorkspaceResource> IAsyncEnumerable<SynapseWorkspaceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
