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
    /// A class representing a collection of <see cref="SynapseAadOnlyAuthenticationResource"/> and their operations.
    /// Each <see cref="SynapseAadOnlyAuthenticationResource"/> in the collection will belong to the same instance of <see cref="SynapseWorkspaceResource"/>.
    /// To get a <see cref="SynapseAadOnlyAuthenticationCollection"/> instance call the GetSynapseAadOnlyAuthentications method from an instance of <see cref="SynapseWorkspaceResource"/>.
    /// </summary>
    public partial class SynapseAadOnlyAuthenticationCollection : ArmCollection, IEnumerable<SynapseAadOnlyAuthenticationResource>, IAsyncEnumerable<SynapseAadOnlyAuthenticationResource>
    {
        private readonly ClientDiagnostics _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsClientDiagnostics;
        private readonly AzureADOnlyAuthenticationsRestOperations _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseAadOnlyAuthenticationCollection"/> class for mocking. </summary>
        protected SynapseAadOnlyAuthenticationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseAadOnlyAuthenticationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseAadOnlyAuthenticationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseAadOnlyAuthenticationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseAadOnlyAuthenticationResource.ResourceType, out string synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsApiVersion);
            _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsRestClient = new AzureADOnlyAuthenticationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsApiVersion);
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
        /// Create or Update a Azure Active Directory only authentication property for the workspaces
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/azureADOnlyAuthentications/{azureADOnlyAuthenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADOnlyAuthentications_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="azureADOnlyAuthenticationName"> name of the property. </param>
        /// <param name="data"> Azure Active Directory Property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseAadOnlyAuthenticationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SynapseAadOnlyAuthenticationName azureADOnlyAuthenticationName, SynapseAadOnlyAuthenticationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SynapseAadOnlyAuthenticationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, azureADOnlyAuthenticationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseAadOnlyAuthenticationResource>(new SynapseAadOnlyAuthenticationOperationSource(Client), _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsClientDiagnostics, Pipeline, _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, azureADOnlyAuthenticationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or Update a Azure Active Directory only authentication property for the workspaces
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/azureADOnlyAuthentications/{azureADOnlyAuthenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADOnlyAuthentications_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="azureADOnlyAuthenticationName"> name of the property. </param>
        /// <param name="data"> Azure Active Directory Property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseAadOnlyAuthenticationResource> CreateOrUpdate(WaitUntil waitUntil, SynapseAadOnlyAuthenticationName azureADOnlyAuthenticationName, SynapseAadOnlyAuthenticationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SynapseAadOnlyAuthenticationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, azureADOnlyAuthenticationName, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseAadOnlyAuthenticationResource>(new SynapseAadOnlyAuthenticationOperationSource(Client), _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsClientDiagnostics, Pipeline, _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, azureADOnlyAuthenticationName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a Azure Active Directory only authentication property
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/azureADOnlyAuthentications/{azureADOnlyAuthenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADOnlyAuthentications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureADOnlyAuthenticationName"> name of the property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseAadOnlyAuthenticationResource>> GetAsync(SynapseAadOnlyAuthenticationName azureADOnlyAuthenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SynapseAadOnlyAuthenticationCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, azureADOnlyAuthenticationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseAadOnlyAuthenticationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Azure Active Directory only authentication property
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/azureADOnlyAuthentications/{azureADOnlyAuthenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADOnlyAuthentications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureADOnlyAuthenticationName"> name of the property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseAadOnlyAuthenticationResource> Get(SynapseAadOnlyAuthenticationName azureADOnlyAuthenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SynapseAadOnlyAuthenticationCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, azureADOnlyAuthenticationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseAadOnlyAuthenticationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of Azure Active Directory only authentication property for a workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/azureADOnlyAuthentications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADOnlyAuthentications_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseAadOnlyAuthenticationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseAadOnlyAuthenticationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SynapseAadOnlyAuthenticationResource(Client, SynapseAadOnlyAuthenticationData.DeserializeSynapseAadOnlyAuthenticationData(e)), _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsClientDiagnostics, Pipeline, "SynapseAadOnlyAuthenticationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of Azure Active Directory only authentication property for a workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/azureADOnlyAuthentications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADOnlyAuthentications_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseAadOnlyAuthenticationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseAadOnlyAuthenticationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SynapseAadOnlyAuthenticationResource(Client, SynapseAadOnlyAuthenticationData.DeserializeSynapseAadOnlyAuthenticationData(e)), _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsClientDiagnostics, Pipeline, "SynapseAadOnlyAuthenticationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/azureADOnlyAuthentications/{azureADOnlyAuthenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADOnlyAuthentications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureADOnlyAuthenticationName"> name of the property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SynapseAadOnlyAuthenticationName azureADOnlyAuthenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SynapseAadOnlyAuthenticationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, azureADOnlyAuthenticationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/azureADOnlyAuthentications/{azureADOnlyAuthenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADOnlyAuthentications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureADOnlyAuthenticationName"> name of the property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SynapseAadOnlyAuthenticationName azureADOnlyAuthenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SynapseAadOnlyAuthenticationCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, azureADOnlyAuthenticationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/azureADOnlyAuthentications/{azureADOnlyAuthenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADOnlyAuthentications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureADOnlyAuthenticationName"> name of the property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<SynapseAadOnlyAuthenticationResource>> GetIfExistsAsync(SynapseAadOnlyAuthenticationName azureADOnlyAuthenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SynapseAadOnlyAuthenticationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, azureADOnlyAuthenticationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SynapseAadOnlyAuthenticationResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseAadOnlyAuthenticationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/azureADOnlyAuthentications/{azureADOnlyAuthenticationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureADOnlyAuthentications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureADOnlyAuthenticationName"> name of the property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<SynapseAadOnlyAuthenticationResource> GetIfExists(SynapseAadOnlyAuthenticationName azureADOnlyAuthenticationName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsClientDiagnostics.CreateScope("SynapseAadOnlyAuthenticationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _synapseAadOnlyAuthenticationAzureADOnlyAuthenticationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, azureADOnlyAuthenticationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SynapseAadOnlyAuthenticationResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseAadOnlyAuthenticationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseAadOnlyAuthenticationResource> IEnumerable<SynapseAadOnlyAuthenticationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseAadOnlyAuthenticationResource> IAsyncEnumerable<SynapseAadOnlyAuthenticationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
