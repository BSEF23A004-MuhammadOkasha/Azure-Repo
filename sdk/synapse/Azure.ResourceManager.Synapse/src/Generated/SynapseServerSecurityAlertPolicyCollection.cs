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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseServerSecurityAlertPolicyResource" /> and their operations.
    /// Each <see cref="SynapseServerSecurityAlertPolicyResource" /> in the collection will belong to the same instance of <see cref="SynapseWorkspaceResource" />.
    /// To get a <see cref="SynapseServerSecurityAlertPolicyCollection" /> instance call the GetSynapseServerSecurityAlertPolicies method from an instance of <see cref="SynapseWorkspaceResource" />.
    /// </summary>
    public partial class SynapseServerSecurityAlertPolicyCollection : ArmCollection, IEnumerable<SynapseServerSecurityAlertPolicyResource>, IAsyncEnumerable<SynapseServerSecurityAlertPolicyResource>
    {
        private readonly ClientDiagnostics _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics;
        private readonly WorkspaceManagedSqlServerSecurityAlertPolicyRestOperations _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseServerSecurityAlertPolicyCollection"/> class for mocking. </summary>
        protected SynapseServerSecurityAlertPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseServerSecurityAlertPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseServerSecurityAlertPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseServerSecurityAlertPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseServerSecurityAlertPolicyResource.ResourceType, out string synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyApiVersion);
            _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient = new WorkspaceManagedSqlServerSecurityAlertPolicyRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update a workspace managed sql server's threat detection policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerSecurityAlertPolicy_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="data"> The workspace managed sql server security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseServerSecurityAlertPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SqlServerSecurityAlertPolicyName securityAlertPolicyName, SynapseServerSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("SynapseServerSecurityAlertPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseServerSecurityAlertPolicyResource>(new SynapseServerSecurityAlertPolicyOperationSource(Client), _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics, Pipeline, _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or Update a workspace managed sql server's threat detection policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerSecurityAlertPolicy_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="data"> The workspace managed sql server security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseServerSecurityAlertPolicyResource> CreateOrUpdate(WaitUntil waitUntil, SqlServerSecurityAlertPolicyName securityAlertPolicyName, SynapseServerSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("SynapseServerSecurityAlertPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseServerSecurityAlertPolicyResource>(new SynapseServerSecurityAlertPolicyOperationSource(Client), _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics, Pipeline, _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a workspace managed sql server's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerSecurityAlertPolicy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseServerSecurityAlertPolicyResource>> GetAsync(SqlServerSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("SynapseServerSecurityAlertPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseServerSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a workspace managed sql server's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerSecurityAlertPolicy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseServerSecurityAlertPolicyResource> Get(SqlServerSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("SynapseServerSecurityAlertPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseServerSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get workspace managed sql server's threat detection policies.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerSecurityAlertPolicy_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseServerSecurityAlertPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseServerSecurityAlertPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SynapseServerSecurityAlertPolicyResource(Client, SynapseServerSecurityAlertPolicyData.DeserializeSynapseServerSecurityAlertPolicyData(e)), _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics, Pipeline, "SynapseServerSecurityAlertPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get workspace managed sql server's threat detection policies.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerSecurityAlertPolicy_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseServerSecurityAlertPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseServerSecurityAlertPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SynapseServerSecurityAlertPolicyResource(Client, SynapseServerSecurityAlertPolicyData.DeserializeSynapseServerSecurityAlertPolicyData(e)), _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics, Pipeline, "SynapseServerSecurityAlertPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerSecurityAlertPolicy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SqlServerSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("SynapseServerSecurityAlertPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerSecurityAlertPolicy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SqlServerSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("SynapseServerSecurityAlertPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerSecurityAlertPolicy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<SynapseServerSecurityAlertPolicyResource>> GetIfExistsAsync(SqlServerSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("SynapseServerSecurityAlertPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SynapseServerSecurityAlertPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseServerSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceManagedSqlServerSecurityAlertPolicy_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<SynapseServerSecurityAlertPolicyResource> GetIfExists(SqlServerSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyClientDiagnostics.CreateScope("SynapseServerSecurityAlertPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _synapseServerSecurityAlertPolicyWorkspaceManagedSqlServerSecurityAlertPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SynapseServerSecurityAlertPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseServerSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseServerSecurityAlertPolicyResource> IEnumerable<SynapseServerSecurityAlertPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseServerSecurityAlertPolicyResource> IAsyncEnumerable<SynapseServerSecurityAlertPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
