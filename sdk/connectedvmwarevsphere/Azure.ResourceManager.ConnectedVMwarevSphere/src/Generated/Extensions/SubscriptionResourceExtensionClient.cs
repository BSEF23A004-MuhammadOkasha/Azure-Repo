// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _resourcePoolClientDiagnostics;
        private ResourcePoolsRestOperations _resourcePoolRestClient;
        private ClientDiagnostics _vMwareClusterClustersClientDiagnostics;
        private ClustersRestOperations _vMwareClusterClustersRestClient;
        private ClientDiagnostics _vMwareHostHostsClientDiagnostics;
        private HostsRestOperations _vMwareHostHostsRestClient;
        private ClientDiagnostics _vMwareDatastoreDatastoresClientDiagnostics;
        private DatastoresRestOperations _vMwareDatastoreDatastoresRestClient;
        private ClientDiagnostics _vCenterClientDiagnostics;
        private VCentersRestOperations _vCenterRestClient;
        private ClientDiagnostics _virtualMachineClientDiagnostics;
        private VirtualMachinesRestOperations _virtualMachineRestClient;
        private ClientDiagnostics _virtualMachineTemplateClientDiagnostics;
        private VirtualMachineTemplatesRestOperations _virtualMachineTemplateRestClient;
        private ClientDiagnostics _virtualNetworkClientDiagnostics;
        private VirtualNetworksRestOperations _virtualNetworkRestClient;

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

        private ClientDiagnostics ResourcePoolClientDiagnostics => _resourcePoolClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", ResourcePoolResource.ResourceType.Namespace, Diagnostics);
        private ResourcePoolsRestOperations ResourcePoolRestClient => _resourcePoolRestClient ??= new ResourcePoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ResourcePoolResource.ResourceType));
        private ClientDiagnostics VMwareClusterClustersClientDiagnostics => _vMwareClusterClustersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", VMwareClusterResource.ResourceType.Namespace, Diagnostics);
        private ClustersRestOperations VMwareClusterClustersRestClient => _vMwareClusterClustersRestClient ??= new ClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(VMwareClusterResource.ResourceType));
        private ClientDiagnostics VMwareHostHostsClientDiagnostics => _vMwareHostHostsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", VMwareHostResource.ResourceType.Namespace, Diagnostics);
        private HostsRestOperations VMwareHostHostsRestClient => _vMwareHostHostsRestClient ??= new HostsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(VMwareHostResource.ResourceType));
        private ClientDiagnostics VMwareDatastoreDatastoresClientDiagnostics => _vMwareDatastoreDatastoresClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", VMwareDatastoreResource.ResourceType.Namespace, Diagnostics);
        private DatastoresRestOperations VMwareDatastoreDatastoresRestClient => _vMwareDatastoreDatastoresRestClient ??= new DatastoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(VMwareDatastoreResource.ResourceType));
        private ClientDiagnostics VCenterClientDiagnostics => _vCenterClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", VCenterResource.ResourceType.Namespace, Diagnostics);
        private VCentersRestOperations VCenterRestClient => _vCenterRestClient ??= new VCentersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(VCenterResource.ResourceType));
        private ClientDiagnostics VirtualMachineClientDiagnostics => _virtualMachineClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", VirtualMachineResource.ResourceType.Namespace, Diagnostics);
        private VirtualMachinesRestOperations VirtualMachineRestClient => _virtualMachineRestClient ??= new VirtualMachinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(VirtualMachineResource.ResourceType));
        private ClientDiagnostics VirtualMachineTemplateClientDiagnostics => _virtualMachineTemplateClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", VirtualMachineTemplateResource.ResourceType.Namespace, Diagnostics);
        private VirtualMachineTemplatesRestOperations VirtualMachineTemplateRestClient => _virtualMachineTemplateRestClient ??= new VirtualMachineTemplatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(VirtualMachineTemplateResource.ResourceType));
        private ClientDiagnostics VirtualNetworkClientDiagnostics => _virtualNetworkClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", VirtualNetworkResource.ResourceType.Namespace, Diagnostics);
        private VirtualNetworksRestOperations VirtualNetworkRestClient => _virtualNetworkRestClient ??= new VirtualNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(VirtualNetworkResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List of resourcePools in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourcePoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourcePoolResource> GetResourcePoolsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ResourcePoolRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ResourcePoolRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ResourcePoolResource(Client, ResourcePoolData.DeserializeResourcePoolData(e)), ResourcePoolClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetResourcePools", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of resourcePools in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourcePoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourcePoolResource> GetResourcePools(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ResourcePoolRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ResourcePoolRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ResourcePoolResource(Client, ResourcePoolData.DeserializeResourcePoolData(e)), ResourcePoolClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetResourcePools", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of clusters in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConnectedVMwarevSphere/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VMwareClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VMwareClusterResource> GetVMwareClustersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VMwareClusterClustersRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VMwareClusterClustersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new VMwareClusterResource(Client, VMwareClusterData.DeserializeVMwareClusterData(e)), VMwareClusterClustersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetVMwareClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of clusters in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConnectedVMwarevSphere/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VMwareClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VMwareClusterResource> GetVMwareClusters(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VMwareClusterClustersRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VMwareClusterClustersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new VMwareClusterResource(Client, VMwareClusterData.DeserializeVMwareClusterData(e)), VMwareClusterClustersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetVMwareClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of hosts in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConnectedVMwarevSphere/hosts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Hosts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VMwareHostResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VMwareHostResource> GetVMwareHostsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VMwareHostHostsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VMwareHostHostsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new VMwareHostResource(Client, VMwareHostData.DeserializeVMwareHostData(e)), VMwareHostHostsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetVMwareHosts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of hosts in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConnectedVMwarevSphere/hosts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Hosts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VMwareHostResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VMwareHostResource> GetVMwareHosts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VMwareHostHostsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VMwareHostHostsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new VMwareHostResource(Client, VMwareHostData.DeserializeVMwareHostData(e)), VMwareHostHostsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetVMwareHosts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of datastores in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConnectedVMwarevSphere/datastores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VMwareDatastoreResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VMwareDatastoreResource> GetVMwareDatastoresAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VMwareDatastoreDatastoresRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VMwareDatastoreDatastoresRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new VMwareDatastoreResource(Client, VMwareDatastoreData.DeserializeVMwareDatastoreData(e)), VMwareDatastoreDatastoresClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetVMwareDatastores", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of datastores in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConnectedVMwarevSphere/datastores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VMwareDatastoreResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VMwareDatastoreResource> GetVMwareDatastores(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VMwareDatastoreDatastoresRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VMwareDatastoreDatastoresRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new VMwareDatastoreResource(Client, VMwareDatastoreData.DeserializeVMwareDatastoreData(e)), VMwareDatastoreDatastoresClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetVMwareDatastores", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of vCenters in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConnectedVMwarevSphere/vcenters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VCenters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VCenterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VCenterResource> GetVCentersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VCenterRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VCenterRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new VCenterResource(Client, VCenterData.DeserializeVCenterData(e)), VCenterClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetVCenters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of vCenters in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConnectedVMwarevSphere/vcenters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VCenters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VCenterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VCenterResource> GetVCenters(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VCenterRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VCenterRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new VCenterResource(Client, VCenterData.DeserializeVCenterData(e)), VCenterClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetVCenters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of virtualMachines in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineResource> GetVirtualMachinesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VirtualMachineRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VirtualMachineRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new VirtualMachineResource(Client, VirtualMachineData.DeserializeVirtualMachineData(e)), VirtualMachineClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetVirtualMachines", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of virtualMachines in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineResource> GetVirtualMachines(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VirtualMachineRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VirtualMachineRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new VirtualMachineResource(Client, VirtualMachineData.DeserializeVirtualMachineData(e)), VirtualMachineClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetVirtualMachines", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of virtualMachineTemplates in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineTemplateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineTemplateResource> GetVirtualMachineTemplatesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VirtualMachineTemplateRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VirtualMachineTemplateRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new VirtualMachineTemplateResource(Client, VirtualMachineTemplateData.DeserializeVirtualMachineTemplateData(e)), VirtualMachineTemplateClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetVirtualMachineTemplates", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of virtualMachineTemplates in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineTemplateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineTemplateResource> GetVirtualMachineTemplates(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VirtualMachineTemplateRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VirtualMachineTemplateRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new VirtualMachineTemplateResource(Client, VirtualMachineTemplateData.DeserializeVirtualMachineTemplateData(e)), VirtualMachineTemplateClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetVirtualMachineTemplates", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of virtualNetworks in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConnectedVMwarevSphere/virtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkResource> GetVirtualNetworksAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VirtualNetworkRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VirtualNetworkRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new VirtualNetworkResource(Client, VirtualNetworkData.DeserializeVirtualNetworkData(e)), VirtualNetworkClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetVirtualNetworks", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of virtualNetworks in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ConnectedVMwarevSphere/virtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkResource> GetVirtualNetworks(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VirtualNetworkRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VirtualNetworkRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new VirtualNetworkResource(Client, VirtualNetworkData.DeserializeVirtualNetworkData(e)), VirtualNetworkClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetVirtualNetworks", "value", "nextLink", cancellationToken);
        }
    }
}
