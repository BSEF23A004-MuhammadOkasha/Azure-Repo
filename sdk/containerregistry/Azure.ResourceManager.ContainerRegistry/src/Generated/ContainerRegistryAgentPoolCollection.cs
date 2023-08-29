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

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerRegistryAgentPoolResource" /> and their operations.
    /// Each <see cref="ContainerRegistryAgentPoolResource" /> in the collection will belong to the same instance of <see cref="ContainerRegistryResource" />.
    /// To get a <see cref="ContainerRegistryAgentPoolCollection" /> instance call the GetContainerRegistryAgentPools method from an instance of <see cref="ContainerRegistryResource" />.
    /// </summary>
    public partial class ContainerRegistryAgentPoolCollection : ArmCollection, IEnumerable<ContainerRegistryAgentPoolResource>, IAsyncEnumerable<ContainerRegistryAgentPoolResource>
    {
        private readonly ClientDiagnostics _containerRegistryAgentPoolAgentPoolsClientDiagnostics;
        private readonly AgentPoolsRestOperations _containerRegistryAgentPoolAgentPoolsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryAgentPoolCollection"/> class for mocking. </summary>
        protected ContainerRegistryAgentPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryAgentPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerRegistryAgentPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerRegistryAgentPoolAgentPoolsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerRegistry", ContainerRegistryAgentPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerRegistryAgentPoolResource.ResourceType, out string containerRegistryAgentPoolAgentPoolsApiVersion);
            _containerRegistryAgentPoolAgentPoolsRestClient = new AgentPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerRegistryAgentPoolAgentPoolsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerRegistryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerRegistryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates an agent pool for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AgentPools_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="agentPoolName"> The name of the agent pool. </param>
        /// <param name="data"> The parameters of an agent pool that needs to scheduled. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerRegistryAgentPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string agentPoolName, ContainerRegistryAgentPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerRegistryAgentPoolAgentPoolsClientDiagnostics.CreateScope("ContainerRegistryAgentPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerRegistryAgentPoolAgentPoolsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryAgentPoolResource>(new ContainerRegistryAgentPoolOperationSource(Client), _containerRegistryAgentPoolAgentPoolsClientDiagnostics, Pipeline, _containerRegistryAgentPoolAgentPoolsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates an agent pool for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AgentPools_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="agentPoolName"> The name of the agent pool. </param>
        /// <param name="data"> The parameters of an agent pool that needs to scheduled. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerRegistryAgentPoolResource> CreateOrUpdate(WaitUntil waitUntil, string agentPoolName, ContainerRegistryAgentPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerRegistryAgentPoolAgentPoolsClientDiagnostics.CreateScope("ContainerRegistryAgentPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerRegistryAgentPoolAgentPoolsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, data, cancellationToken);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryAgentPoolResource>(new ContainerRegistryAgentPoolOperationSource(Client), _containerRegistryAgentPoolAgentPoolsClientDiagnostics, Pipeline, _containerRegistryAgentPoolAgentPoolsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the detailed information for a given agent pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AgentPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> The name of the agent pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual async Task<Response<ContainerRegistryAgentPoolResource>> GetAsync(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _containerRegistryAgentPoolAgentPoolsClientDiagnostics.CreateScope("ContainerRegistryAgentPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerRegistryAgentPoolAgentPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryAgentPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the detailed information for a given agent pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AgentPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> The name of the agent pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual Response<ContainerRegistryAgentPoolResource> Get(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _containerRegistryAgentPoolAgentPoolsClientDiagnostics.CreateScope("ContainerRegistryAgentPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _containerRegistryAgentPoolAgentPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryAgentPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the agent pools for a specified container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/agentPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AgentPools_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerRegistryAgentPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerRegistryAgentPoolResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryAgentPoolAgentPoolsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryAgentPoolAgentPoolsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ContainerRegistryAgentPoolResource(Client, ContainerRegistryAgentPoolData.DeserializeContainerRegistryAgentPoolData(e)), _containerRegistryAgentPoolAgentPoolsClientDiagnostics, Pipeline, "ContainerRegistryAgentPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the agent pools for a specified container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/agentPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AgentPools_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerRegistryAgentPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerRegistryAgentPoolResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryAgentPoolAgentPoolsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryAgentPoolAgentPoolsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ContainerRegistryAgentPoolResource(Client, ContainerRegistryAgentPoolData.DeserializeContainerRegistryAgentPoolData(e)), _containerRegistryAgentPoolAgentPoolsClientDiagnostics, Pipeline, "ContainerRegistryAgentPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AgentPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> The name of the agent pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _containerRegistryAgentPoolAgentPoolsClientDiagnostics.CreateScope("ContainerRegistryAgentPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerRegistryAgentPoolAgentPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AgentPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> The name of the agent pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string agentPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentPoolName, nameof(agentPoolName));

            using var scope = _containerRegistryAgentPoolAgentPoolsClientDiagnostics.CreateScope("ContainerRegistryAgentPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerRegistryAgentPoolAgentPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentPoolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerRegistryAgentPoolResource> IEnumerable<ContainerRegistryAgentPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerRegistryAgentPoolResource> IAsyncEnumerable<ContainerRegistryAgentPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
