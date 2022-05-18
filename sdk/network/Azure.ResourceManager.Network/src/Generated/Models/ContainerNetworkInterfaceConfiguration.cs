// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Container network interface configuration child resource. </summary>
    public partial class ContainerNetworkInterfaceConfiguration : NetworkWritableSubResource
    {
        /// <summary> Initializes a new instance of ContainerNetworkInterfaceConfiguration. </summary>
        public ContainerNetworkInterfaceConfiguration()
        {
            IPConfigurations = new ChangeTrackingList<IPConfigurationProfile>();
            ContainerNetworkInterfaces = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of ContainerNetworkInterfaceConfiguration. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource. This name can be used to access the resource. </param>
        /// <param name="resourceType"> Sub Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="ipConfigurations"> A list of ip configurations of the container network interface configuration. </param>
        /// <param name="containerNetworkInterfaces"> A list of container network interfaces created from this container network interface configuration. </param>
        /// <param name="provisioningState"> The provisioning state of the container network interface configuration resource. </param>
        internal ContainerNetworkInterfaceConfiguration(ResourceIdentifier id, string name, string resourceType, string etag, IList<IPConfigurationProfile> ipConfigurations, IList<WritableSubResource> containerNetworkInterfaces, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            ResourceType = resourceType;
            Etag = etag;
            IPConfigurations = ipConfigurations;
            ContainerNetworkInterfaces = containerNetworkInterfaces;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> Sub Resource type. </summary>
        public string ResourceType { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> A list of ip configurations of the container network interface configuration. </summary>
        public IList<IPConfigurationProfile> IPConfigurations { get; }
        /// <summary> A list of container network interfaces created from this container network interface configuration. </summary>
        public IList<WritableSubResource> ContainerNetworkInterfaces { get; }
        /// <summary> The provisioning state of the container network interface configuration resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
