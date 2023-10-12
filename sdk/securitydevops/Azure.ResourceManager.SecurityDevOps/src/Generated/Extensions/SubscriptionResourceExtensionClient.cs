// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityDevOps
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _azureDevOpsConnectorClientDiagnostics;
        private AzureDevOpsConnectorRestOperations _azureDevOpsConnectorRestClient;
        private ClientDiagnostics _gitHubConnectorClientDiagnostics;
        private GitHubConnectorRestOperations _gitHubConnectorRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AzureDevOpsConnectorClientDiagnostics => _azureDevOpsConnectorClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.SecurityDevOps", AzureDevOpsConnectorResource.ResourceType.Namespace, Diagnostics);
        private AzureDevOpsConnectorRestOperations AzureDevOpsConnectorRestClient => _azureDevOpsConnectorRestClient ??= new AzureDevOpsConnectorRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(AzureDevOpsConnectorResource.ResourceType));
        private ClientDiagnostics GitHubConnectorClientDiagnostics => _gitHubConnectorClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.SecurityDevOps", GitHubConnectorResource.ResourceType.Namespace, Diagnostics);
        private GitHubConnectorRestOperations GitHubConnectorRestClient => _gitHubConnectorRestClient ??= new GitHubConnectorRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(GitHubConnectorResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Returns a list of monitored AzureDevOps Connectors.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureDevOpsConnectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AzureDevOpsConnectorResource> GetAzureDevOpsConnectorsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AzureDevOpsConnectorRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AzureDevOpsConnectorRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AzureDevOpsConnectorResource(Client, AzureDevOpsConnectorData.DeserializeAzureDevOpsConnectorData(e)), AzureDevOpsConnectorClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAzureDevOpsConnectors", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of monitored AzureDevOps Connectors.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureDevOpsConnectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AzureDevOpsConnectorResource> GetAzureDevOpsConnectors(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AzureDevOpsConnectorRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AzureDevOpsConnectorRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AzureDevOpsConnectorResource(Client, AzureDevOpsConnectorData.DeserializeAzureDevOpsConnectorData(e)), AzureDevOpsConnectorClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAzureDevOpsConnectors", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of monitored GitHub Connectors.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SecurityDevOps/gitHubConnectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubConnector_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GitHubConnectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GitHubConnectorResource> GetGitHubConnectorsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => GitHubConnectorRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => GitHubConnectorRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new GitHubConnectorResource(Client, GitHubConnectorData.DeserializeGitHubConnectorData(e)), GitHubConnectorClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetGitHubConnectors", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of monitored GitHub Connectors.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.SecurityDevOps/gitHubConnectors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubConnector_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GitHubConnectorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GitHubConnectorResource> GetGitHubConnectors(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => GitHubConnectorRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => GitHubConnectorRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new GitHubConnectorResource(Client, GitHubConnectorData.DeserializeGitHubConnectorData(e)), GitHubConnectorClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetGitHubConnectors", "value", "nextLink", cancellationToken);
        }
    }
}
