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
    /// A class representing the NetworkFabricExternalNetwork data model.
    /// Defines the External Network resource.
    /// </summary>
    public partial class NetworkFabricExternalNetworkData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkFabricExternalNetworkData"/>. </summary>
        /// <param name="peeringOption"> Peering option list. </param>
        public NetworkFabricExternalNetworkData(PeeringOption peeringOption)
        {
            PeeringOption = peeringOption;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricExternalNetworkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="importRoutePolicyId"> ARM Resource ID of the RoutePolicy. This is used for the backward compatibility. </param>
        /// <param name="exportRoutePolicyId"> ARM Resource ID of the RoutePolicy. This is used for the backward compatibility. </param>
        /// <param name="importRoutePolicy"> Import Route Policy either IPv4 or IPv6. </param>
        /// <param name="exportRoutePolicy"> Export Route Policy either IPv4 or IPv6. </param>
        /// <param name="networkToNetworkInterconnectId"> Gets the networkToNetworkInterconnectId of the resource. </param>
        /// <param name="peeringOption"> Peering option list. </param>
        /// <param name="optionBProperties"> option B properties object. </param>
        /// <param name="optionAProperties"> option A properties object. </param>
        /// <param name="configurationState"> Configuration state of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="administrativeState"> Administrative state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkFabricExternalNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string annotation, ResourceIdentifier importRoutePolicyId, ResourceIdentifier exportRoutePolicyId, ImportRoutePolicy importRoutePolicy, ExportRoutePolicy exportRoutePolicy, ResourceIdentifier networkToNetworkInterconnectId, PeeringOption peeringOption, L3OptionBProperties optionBProperties, ExternalNetworkOptionAProperties optionAProperties, NetworkFabricConfigurationState? configurationState, NetworkFabricProvisioningState? provisioningState, NetworkFabricAdministrativeState? administrativeState, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Annotation = annotation;
            ImportRoutePolicyId = importRoutePolicyId;
            ExportRoutePolicyId = exportRoutePolicyId;
            ImportRoutePolicy = importRoutePolicy;
            ExportRoutePolicy = exportRoutePolicy;
            NetworkToNetworkInterconnectId = networkToNetworkInterconnectId;
            PeeringOption = peeringOption;
            OptionBProperties = optionBProperties;
            OptionAProperties = optionAProperties;
            ConfigurationState = configurationState;
            ProvisioningState = provisioningState;
            AdministrativeState = administrativeState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricExternalNetworkData"/> for deserialization. </summary>
        internal NetworkFabricExternalNetworkData()
        {
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> ARM Resource ID of the RoutePolicy. This is used for the backward compatibility. </summary>
        public ResourceIdentifier ImportRoutePolicyId { get; set; }
        /// <summary> ARM Resource ID of the RoutePolicy. This is used for the backward compatibility. </summary>
        public ResourceIdentifier ExportRoutePolicyId { get; set; }
        /// <summary> Import Route Policy either IPv4 or IPv6. </summary>
        public ImportRoutePolicy ImportRoutePolicy { get; set; }
        /// <summary> Export Route Policy either IPv4 or IPv6. </summary>
        public ExportRoutePolicy ExportRoutePolicy { get; set; }
        /// <summary> Gets the networkToNetworkInterconnectId of the resource. </summary>
        public ResourceIdentifier NetworkToNetworkInterconnectId { get; }
        /// <summary> Peering option list. </summary>
        public PeeringOption PeeringOption { get; set; }
        /// <summary> option B properties object. </summary>
        public L3OptionBProperties OptionBProperties { get; set; }
        /// <summary> option A properties object. </summary>
        public ExternalNetworkOptionAProperties OptionAProperties { get; set; }
        /// <summary> Configuration state of the resource. </summary>
        public NetworkFabricConfigurationState? ConfigurationState { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
        /// <summary> Administrative state of the resource. </summary>
        public NetworkFabricAdministrativeState? AdministrativeState { get; }
    }
}
