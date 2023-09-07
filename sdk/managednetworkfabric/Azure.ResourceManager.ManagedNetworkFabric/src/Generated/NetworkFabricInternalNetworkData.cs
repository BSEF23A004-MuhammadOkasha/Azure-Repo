// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkFabricInternalNetwork data model.
    /// Defines the Internal Network resource.
    /// </summary>
    public partial class NetworkFabricInternalNetworkData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkFabricInternalNetworkData"/>. </summary>
        /// <param name="vlanId"> Vlan identifier. Example: 1001. </param>
        public NetworkFabricInternalNetworkData(int vlanId)
        {
            ConnectedIPv4Subnets = new ChangeTrackingList<ConnectedSubnet>();
            ConnectedIPv6Subnets = new ChangeTrackingList<ConnectedSubnet>();
            VlanId = vlanId;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricInternalNetworkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="mtu"> Maximum transmission unit. Default value is 1500. </param>
        /// <param name="connectedIPv4Subnets"> List of Connected IPv4 Subnets. </param>
        /// <param name="connectedIPv6Subnets"> List of connected IPv6 Subnets. </param>
        /// <param name="importRoutePolicyId"> ARM Resource ID of the RoutePolicy. This is used for the backward compatibility. </param>
        /// <param name="exportRoutePolicyId"> ARM Resource ID of the RoutePolicy. This is used for the backward compatibility. </param>
        /// <param name="importRoutePolicy"> Import Route Policy either IPv4 or IPv6. </param>
        /// <param name="exportRoutePolicy"> Export Route Policy either IPv4 or IPv6. </param>
        /// <param name="ingressAclId"> Ingress Acl. ARM resource ID of Access Control Lists. </param>
        /// <param name="egressAclId"> Egress Acl. ARM resource ID of Access Control Lists. </param>
        /// <param name="isMonitoringEnabled"> To check whether monitoring of internal network is enabled or not. </param>
        /// <param name="extension"> Extension. Example: NoExtension | NPB. </param>
        /// <param name="vlanId"> Vlan identifier. Example: 1001. </param>
        /// <param name="bgpConfiguration"> BGP configuration properties. </param>
        /// <param name="staticRouteConfiguration"> Static Route Configuration properties. </param>
        /// <param name="configurationState"> Configuration state of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="administrativeState"> Administrative state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkFabricInternalNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string annotation, int? mtu, IList<ConnectedSubnet> connectedIPv4Subnets, IList<ConnectedSubnet> connectedIPv6Subnets, ResourceIdentifier importRoutePolicyId, ResourceIdentifier exportRoutePolicyId, ImportRoutePolicy importRoutePolicy, ExportRoutePolicy exportRoutePolicy, ResourceIdentifier ingressAclId, ResourceIdentifier egressAclId, IsMonitoringEnabled? isMonitoringEnabled, StaticRouteConfigurationExtension? extension, int vlanId, InternalNetworkBgpConfiguration bgpConfiguration, InternalNetworkStaticRouteConfiguration staticRouteConfiguration, NetworkFabricConfigurationState? configurationState, NetworkFabricProvisioningState? provisioningState, NetworkFabricAdministrativeState? administrativeState, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Annotation = annotation;
            Mtu = mtu;
            ConnectedIPv4Subnets = connectedIPv4Subnets;
            ConnectedIPv6Subnets = connectedIPv6Subnets;
            ImportRoutePolicyId = importRoutePolicyId;
            ExportRoutePolicyId = exportRoutePolicyId;
            ImportRoutePolicy = importRoutePolicy;
            ExportRoutePolicy = exportRoutePolicy;
            IngressAclId = ingressAclId;
            EgressAclId = egressAclId;
            IsMonitoringEnabled = isMonitoringEnabled;
            Extension = extension;
            VlanId = vlanId;
            BgpConfiguration = bgpConfiguration;
            StaticRouteConfiguration = staticRouteConfiguration;
            ConfigurationState = configurationState;
            ProvisioningState = provisioningState;
            AdministrativeState = administrativeState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricInternalNetworkData"/> for deserialization. </summary>
        internal NetworkFabricInternalNetworkData()
        {
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> Maximum transmission unit. Default value is 1500. </summary>
        public int? Mtu { get; set; }
        /// <summary> List of Connected IPv4 Subnets. </summary>
        public IList<ConnectedSubnet> ConnectedIPv4Subnets { get; }
        /// <summary> List of connected IPv6 Subnets. </summary>
        public IList<ConnectedSubnet> ConnectedIPv6Subnets { get; }
        /// <summary> ARM Resource ID of the RoutePolicy. This is used for the backward compatibility. </summary>
        public ResourceIdentifier ImportRoutePolicyId { get; set; }
        /// <summary> ARM Resource ID of the RoutePolicy. This is used for the backward compatibility. </summary>
        public ResourceIdentifier ExportRoutePolicyId { get; set; }
        /// <summary> Import Route Policy either IPv4 or IPv6. </summary>
        public ImportRoutePolicy ImportRoutePolicy { get; set; }
        /// <summary> Export Route Policy either IPv4 or IPv6. </summary>
        public ExportRoutePolicy ExportRoutePolicy { get; set; }
        /// <summary> Ingress Acl. ARM resource ID of Access Control Lists. </summary>
        public ResourceIdentifier IngressAclId { get; set; }
        /// <summary> Egress Acl. ARM resource ID of Access Control Lists. </summary>
        public ResourceIdentifier EgressAclId { get; set; }
        /// <summary> To check whether monitoring of internal network is enabled or not. </summary>
        public IsMonitoringEnabled? IsMonitoringEnabled { get; set; }
        /// <summary> Extension. Example: NoExtension | NPB. </summary>
        public StaticRouteConfigurationExtension? Extension { get; set; }
        /// <summary> Vlan identifier. Example: 1001. </summary>
        public int VlanId { get; set; }
        /// <summary> BGP configuration properties. </summary>
        public InternalNetworkBgpConfiguration BgpConfiguration { get; set; }
        /// <summary> Static Route Configuration properties. </summary>
        public InternalNetworkStaticRouteConfiguration StaticRouteConfiguration { get; set; }
        /// <summary> Configuration state of the resource. </summary>
        public NetworkFabricConfigurationState? ConfigurationState { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
        /// <summary> Administrative state of the resource. </summary>
        public NetworkFabricAdministrativeState? AdministrativeState { get; }
    }
}
