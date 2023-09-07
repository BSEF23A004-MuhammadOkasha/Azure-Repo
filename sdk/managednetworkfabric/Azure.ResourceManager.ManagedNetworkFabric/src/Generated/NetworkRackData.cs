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
    /// A class representing the NetworkRack data model.
    /// The Network Rack resource definition.
    /// </summary>
    public partial class NetworkRackData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkRackData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="networkFabricId"> ARM resource ID of the Network Fabric. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricId"/> is null. </exception>
        public NetworkRackData(AzureLocation location, ResourceIdentifier networkFabricId) : base(location)
        {
            Argument.AssertNotNull(networkFabricId, nameof(networkFabricId));

            NetworkFabricId = networkFabricId;
            NetworkDevices = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkRackData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="networkRackType"> Network Rack SKU name. </param>
        /// <param name="networkFabricId"> ARM resource ID of the Network Fabric. </param>
        /// <param name="networkDevices"> List of network device ARM resource IDs. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkRackData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string annotation, NetworkRackType? networkRackType, ResourceIdentifier networkFabricId, IReadOnlyList<ResourceIdentifier> networkDevices, NetworkFabricProvisioningState? provisioningState, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Annotation = annotation;
            NetworkRackType = networkRackType;
            NetworkFabricId = networkFabricId;
            NetworkDevices = networkDevices;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkRackData"/> for deserialization. </summary>
        internal NetworkRackData()
        {
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> Network Rack SKU name. </summary>
        public NetworkRackType? NetworkRackType { get; set; }
        /// <summary> ARM resource ID of the Network Fabric. </summary>
        public ResourceIdentifier NetworkFabricId { get; set; }
        /// <summary> List of network device ARM resource IDs. </summary>
        public IReadOnlyList<ResourceIdentifier> NetworkDevices { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
    }
}
