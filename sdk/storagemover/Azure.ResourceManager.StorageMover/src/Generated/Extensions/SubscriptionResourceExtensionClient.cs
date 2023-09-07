// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.StorageMover
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _storageMoverClientDiagnostics;
        private StorageMoversRestOperations _storageMoverRestClient;

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

        private ClientDiagnostics StorageMoverClientDiagnostics => _storageMoverClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.StorageMover", StorageMoverResource.ResourceType.Namespace, Diagnostics);
        private StorageMoversRestOperations StorageMoverRestClient => _storageMoverRestClient ??= new StorageMoversRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(StorageMoverResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all Storage Movers in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageMover/storageMovers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageMovers_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageMoverResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageMoverResource> GetStorageMoversAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => StorageMoverRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => StorageMoverRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StorageMoverResource(Client, StorageMoverData.DeserializeStorageMoverData(e)), StorageMoverClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetStorageMovers", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all Storage Movers in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageMover/storageMovers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageMovers_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageMoverResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageMoverResource> GetStorageMovers(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => StorageMoverRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => StorageMoverRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StorageMoverResource(Client, StorageMoverData.DeserializeStorageMoverData(e)), StorageMoverClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetStorageMovers", "value", "nextLink", cancellationToken);
        }
    }
}
