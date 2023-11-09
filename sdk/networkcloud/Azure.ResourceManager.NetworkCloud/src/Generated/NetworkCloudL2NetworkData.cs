// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing the NetworkCloudL2Network data model.
    /// L2Network represents a network that utilizes a single isolation domain set up for layer-2 resources.
    /// </summary>
    public partial class NetworkCloudL2NetworkData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkCloudL2NetworkData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster associated with the resource. </param>
        /// <param name="l2IsolationDomainId"> The resource ID of the Network Fabric l2IsolationDomain. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extendedLocation"/> or <paramref name="l2IsolationDomainId"/> is null. </exception>
        public NetworkCloudL2NetworkData(AzureLocation location, ExtendedLocation extendedLocation, ResourceIdentifier l2IsolationDomainId) : base(location)
        {
            Argument.AssertNotNull(extendedLocation, nameof(extendedLocation));
            Argument.AssertNotNull(l2IsolationDomainId, nameof(l2IsolationDomainId));

            ExtendedLocation = extendedLocation;
            AssociatedResourceIds = new ChangeTrackingList<ResourceIdentifier>();
            HybridAksClustersAssociatedIds = new ChangeTrackingList<ResourceIdentifier>();
            L2IsolationDomainId = l2IsolationDomainId;
            VirtualMachinesAssociatedIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudL2NetworkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster associated with the resource. </param>
        /// <param name="associatedResourceIds"> The list of resource IDs for the other Microsoft.NetworkCloud resources that have attached this network. </param>
        /// <param name="clusterId"> The resource ID of the Network Cloud cluster this L2 network is associated with. </param>
        /// <param name="detailedStatus"> The more detailed status of the L2 network. </param>
        /// <param name="detailedStatusMessage"> The descriptive message about the current detailed status. </param>
        /// <param name="hybridAksClustersAssociatedIds"> Field Deprecated. These fields will be empty/omitted. The list of Hybrid AKS cluster resource ID(s) that are associated with this L2 network. </param>
        /// <param name="hybridAksPluginType"> Field Deprecated. The field was previously optional, now it will have no defined behavior and will be ignored. The network plugin type for Hybrid AKS. </param>
        /// <param name="interfaceName"> The default interface name for this L2 network in the virtual machine. This name can be overridden by the name supplied in the network attachment configuration of that virtual machine. </param>
        /// <param name="l2IsolationDomainId"> The resource ID of the Network Fabric l2IsolationDomain. </param>
        /// <param name="provisioningState"> The provisioning state of the L2 network. </param>
        /// <param name="virtualMachinesAssociatedIds"> Field Deprecated. These fields will be empty/omitted. The list of virtual machine resource ID(s), excluding any Hybrid AKS virtual machines, that are currently using this L2 network. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkCloudL2NetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, IReadOnlyList<ResourceIdentifier> associatedResourceIds, ResourceIdentifier clusterId, L2NetworkDetailedStatus? detailedStatus, string detailedStatusMessage, IReadOnlyList<ResourceIdentifier> hybridAksClustersAssociatedIds, HybridAksPluginType? hybridAksPluginType, string interfaceName, ResourceIdentifier l2IsolationDomainId, L2NetworkProvisioningState? provisioningState, IReadOnlyList<ResourceIdentifier> virtualMachinesAssociatedIds, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            AssociatedResourceIds = associatedResourceIds;
            ClusterId = clusterId;
            DetailedStatus = detailedStatus;
            DetailedStatusMessage = detailedStatusMessage;
            HybridAksClustersAssociatedIds = hybridAksClustersAssociatedIds;
            HybridAksPluginType = hybridAksPluginType;
            InterfaceName = interfaceName;
            L2IsolationDomainId = l2IsolationDomainId;
            ProvisioningState = provisioningState;
            VirtualMachinesAssociatedIds = virtualMachinesAssociatedIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudL2NetworkData"/> for deserialization. </summary>
        internal NetworkCloudL2NetworkData()
        {
        }

        /// <summary> The extended location of the cluster associated with the resource. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The list of resource IDs for the other Microsoft.NetworkCloud resources that have attached this network. </summary>
        public IReadOnlyList<ResourceIdentifier> AssociatedResourceIds { get; }
        /// <summary> The resource ID of the Network Cloud cluster this L2 network is associated with. </summary>
        public ResourceIdentifier ClusterId { get; }
        /// <summary> The more detailed status of the L2 network. </summary>
        public L2NetworkDetailedStatus? DetailedStatus { get; }
        /// <summary> The descriptive message about the current detailed status. </summary>
        public string DetailedStatusMessage { get; }
        /// <summary> Field Deprecated. These fields will be empty/omitted. The list of Hybrid AKS cluster resource ID(s) that are associated with this L2 network. </summary>
        public IReadOnlyList<ResourceIdentifier> HybridAksClustersAssociatedIds { get; }
        /// <summary> Field Deprecated. The field was previously optional, now it will have no defined behavior and will be ignored. The network plugin type for Hybrid AKS. </summary>
        public HybridAksPluginType? HybridAksPluginType { get; set; }
        /// <summary> The default interface name for this L2 network in the virtual machine. This name can be overridden by the name supplied in the network attachment configuration of that virtual machine. </summary>
        public string InterfaceName { get; set; }
        /// <summary> The resource ID of the Network Fabric l2IsolationDomain. </summary>
        public ResourceIdentifier L2IsolationDomainId { get; set; }
        /// <summary> The provisioning state of the L2 network. </summary>
        public L2NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Field Deprecated. These fields will be empty/omitted. The list of virtual machine resource ID(s), excluding any Hybrid AKS virtual machines, that are currently using this L2 network. </summary>
        public IReadOnlyList<ResourceIdentifier> VirtualMachinesAssociatedIds { get; }
    }
}
