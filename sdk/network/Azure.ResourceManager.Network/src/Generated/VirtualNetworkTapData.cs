// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the VirtualNetworkTap data model. </summary>
    public partial class VirtualNetworkTapData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of VirtualNetworkTapData. </summary>
        public VirtualNetworkTapData()
        {
            NetworkInterfaceTapConfigurations = new ChangeTrackingList<NetworkInterfaceTapConfigurationData>();
        }

        /// <summary> Initializes a new instance of VirtualNetworkTapData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="networkInterfaceTapConfigurations"> Specifies the list of resource IDs for the network interface IP configuration that needs to be tapped. </param>
        /// <param name="resourceGuid"> The resource GUID property of the virtual network tap resource. </param>
        /// <param name="provisioningState"> The provisioning state of the virtual network tap resource. </param>
        /// <param name="destinationNetworkInterfaceIPConfiguration"> The reference to the private IP Address of the collector nic that will receive the tap. </param>
        /// <param name="destinationLoadBalancerFrontEndIPConfiguration"> The reference to the private IP address on the internal Load Balancer that will receive the tap. </param>
        /// <param name="destinationPort"> The VXLAN destination port that will receive the tapped traffic. </param>
        internal VirtualNetworkTapData(string id, string name, string resourceType, string location, IDictionary<string, string> tags, string etag, IReadOnlyList<NetworkInterfaceTapConfigurationData> networkInterfaceTapConfigurations, string resourceGuid, ProvisioningState? provisioningState, NetworkInterfaceIPConfigurationData destinationNetworkInterfaceIPConfiguration, FrontendIPConfigurationData destinationLoadBalancerFrontEndIPConfiguration, int? destinationPort) : base(id, name, resourceType, location, tags)
        {
            Etag = etag;
            NetworkInterfaceTapConfigurations = networkInterfaceTapConfigurations;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            DestinationNetworkInterfaceIPConfiguration = destinationNetworkInterfaceIPConfiguration;
            DestinationLoadBalancerFrontEndIPConfiguration = destinationLoadBalancerFrontEndIPConfiguration;
            DestinationPort = destinationPort;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Specifies the list of resource IDs for the network interface IP configuration that needs to be tapped. </summary>
        public IReadOnlyList<NetworkInterfaceTapConfigurationData> NetworkInterfaceTapConfigurations { get; }
        /// <summary> The resource GUID property of the virtual network tap resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the virtual network tap resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The reference to the private IP Address of the collector nic that will receive the tap. </summary>
        public NetworkInterfaceIPConfigurationData DestinationNetworkInterfaceIPConfiguration { get; set; }
        /// <summary> The reference to the private IP address on the internal Load Balancer that will receive the tap. </summary>
        public FrontendIPConfigurationData DestinationLoadBalancerFrontEndIPConfiguration { get; set; }
        /// <summary> The VXLAN destination port that will receive the tapped traffic. </summary>
        public int? DestinationPort { get; set; }
    }
}
