// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Chaos
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _experimentClientDiagnostics;
        private ExperimentsRestOperations _experimentRestClient;

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

        private ClientDiagnostics ExperimentClientDiagnostics => _experimentClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Chaos", ExperimentResource.ResourceType.Namespace, Diagnostics);
        private ExperimentsRestOperations ExperimentRestClient => _experimentRestClient ??= new ExperimentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ExperimentResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of TargetTypeResources in the SubscriptionResource. </summary>
        /// <param name="locationName"> String that represents a Location resource name. </param>
        /// <returns> An object representing collection of TargetTypeResources and their operations over a TargetTypeResource. </returns>
        public virtual TargetTypeCollection GetTargetTypes(string locationName)
        {
            return new TargetTypeCollection(Client, Id, locationName);
        }

        /// <summary>
        /// Get a list of Experiment resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/experiments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_ListAll</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="running"> Optional value that indicates whether to filter results based on if the Experiment is currently running. If null, then the results will not be filtered. </param>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExperimentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExperimentResource> GetExperimentsAsync(bool? running = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ExperimentRestClient.CreateListAllRequest(Id.SubscriptionId, running, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ExperimentRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId, running, continuationToken);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ExperimentResource(Client, ExperimentData.DeserializeExperimentData(e)), ExperimentClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetExperiments", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of Experiment resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/experiments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_ListAll</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="running"> Optional value that indicates whether to filter results based on if the Experiment is currently running. If null, then the results will not be filtered. </param>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExperimentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExperimentResource> GetExperiments(bool? running = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ExperimentRestClient.CreateListAllRequest(Id.SubscriptionId, running, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ExperimentRestClient.CreateListAllNextPageRequest(nextLink, Id.SubscriptionId, running, continuationToken);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ExperimentResource(Client, ExperimentData.DeserializeExperimentData(e)), ExperimentClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetExperiments", "value", "nextLink", cancellationToken);
        }
    }
}
