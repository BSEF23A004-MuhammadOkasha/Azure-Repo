// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Disk.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableDiskSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _managedDiskDisksClientDiagnostics;
        private DisksRestOperations _managedDiskDisksRestClient;
        private ClientDiagnostics _diskAccessClientDiagnostics;
        private DiskAccessesRestOperations _diskAccessRestClient;
        private ClientDiagnostics _diskEncryptionSetClientDiagnostics;
        private DiskEncryptionSetsRestOperations _diskEncryptionSetRestClient;
        private ClientDiagnostics _snapshotClientDiagnostics;
        private SnapshotsRestOperations _snapshotRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableDiskSubscriptionResource"/> class for mocking. </summary>
        protected MockableDiskSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDiskSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDiskSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ManagedDiskDisksClientDiagnostics => _managedDiskDisksClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Disk", ManagedDiskResource.ResourceType.Namespace, Diagnostics);
        private DisksRestOperations ManagedDiskDisksRestClient => _managedDiskDisksRestClient ??= new DisksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ManagedDiskResource.ResourceType));
        private ClientDiagnostics DiskAccessClientDiagnostics => _diskAccessClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Disk", DiskAccessResource.ResourceType.Namespace, Diagnostics);
        private DiskAccessesRestOperations DiskAccessRestClient => _diskAccessRestClient ??= new DiskAccessesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DiskAccessResource.ResourceType));
        private ClientDiagnostics DiskEncryptionSetClientDiagnostics => _diskEncryptionSetClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Disk", DiskEncryptionSetResource.ResourceType.Namespace, Diagnostics);
        private DiskEncryptionSetsRestOperations DiskEncryptionSetRestClient => _diskEncryptionSetRestClient ??= new DiskEncryptionSetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DiskEncryptionSetResource.ResourceType));
        private ClientDiagnostics SnapshotClientDiagnostics => _snapshotClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Disk", SnapshotResource.ResourceType.Namespace, Diagnostics);
        private SnapshotsRestOperations SnapshotRestClient => _snapshotRestClient ??= new SnapshotsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(SnapshotResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all the disks under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/disks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Disks_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDiskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedDiskResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedDiskResource> GetManagedDisksAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedDiskDisksRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ManagedDiskDisksRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagedDiskResource(Client, ManagedDiskData.DeserializeManagedDiskData(e)), ManagedDiskDisksClientDiagnostics, Pipeline, "MockableDiskSubscriptionResource.GetManagedDisks", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the disks under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/disks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Disks_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedDiskResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedDiskResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedDiskResource> GetManagedDisks(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedDiskDisksRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ManagedDiskDisksRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagedDiskResource(Client, ManagedDiskData.DeserializeManagedDiskData(e)), ManagedDiskDisksClientDiagnostics, Pipeline, "MockableDiskSubscriptionResource.GetManagedDisks", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the disk access resources under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/diskAccesses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskAccesses_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskAccessResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskAccessResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiskAccessResource> GetDiskAccessesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DiskAccessRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DiskAccessRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DiskAccessResource(Client, DiskAccessData.DeserializeDiskAccessData(e)), DiskAccessClientDiagnostics, Pipeline, "MockableDiskSubscriptionResource.GetDiskAccesses", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the disk access resources under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/diskAccesses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskAccesses_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskAccessResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskAccessResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiskAccessResource> GetDiskAccesses(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DiskAccessRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DiskAccessRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DiskAccessResource(Client, DiskAccessData.DeserializeDiskAccessData(e)), DiskAccessClientDiagnostics, Pipeline, "MockableDiskSubscriptionResource.GetDiskAccesses", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the disk encryption sets under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/diskEncryptionSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskEncryptionSets_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskEncryptionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskEncryptionSetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiskEncryptionSetResource> GetDiskEncryptionSetsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DiskEncryptionSetRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DiskEncryptionSetRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DiskEncryptionSetResource(Client, DiskEncryptionSetData.DeserializeDiskEncryptionSetData(e)), DiskEncryptionSetClientDiagnostics, Pipeline, "MockableDiskSubscriptionResource.GetDiskEncryptionSets", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the disk encryption sets under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/diskEncryptionSets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskEncryptionSets_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DiskEncryptionSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskEncryptionSetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiskEncryptionSetResource> GetDiskEncryptionSets(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DiskEncryptionSetRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DiskEncryptionSetRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DiskEncryptionSetResource(Client, DiskEncryptionSetData.DeserializeDiskEncryptionSetData(e)), DiskEncryptionSetClientDiagnostics, Pipeline, "MockableDiskSubscriptionResource.GetDiskEncryptionSets", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists snapshots under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/snapshots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshots_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SnapshotResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SnapshotResource> GetSnapshotsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SnapshotRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SnapshotRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SnapshotResource(Client, SnapshotData.DeserializeSnapshotData(e)), SnapshotClientDiagnostics, Pipeline, "MockableDiskSubscriptionResource.GetSnapshots", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists snapshots under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Compute/snapshots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Snapshots_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-02</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SnapshotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SnapshotResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SnapshotResource> GetSnapshots(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SnapshotRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SnapshotRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SnapshotResource(Client, SnapshotData.DeserializeSnapshotData(e)), SnapshotClientDiagnostics, Pipeline, "MockableDiskSubscriptionResource.GetSnapshots", "value", "nextLink", cancellationToken);
        }
    }
}
