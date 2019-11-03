// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Container network interface child resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ContainerNetworkInterface : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ContainerNetworkInterface class.
        /// </summary>
        public ContainerNetworkInterface()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerNetworkInterface class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="containerNetworkInterfaceConfiguration">Container
        /// network interface configuration from which this container network
        /// interface is created.</param>
        /// <param name="container">Reference to the container to which this
        /// container network interface is attached.</param>
        /// <param name="ipConfigurations">Reference to the ip configuration on
        /// this container nic.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// container network interface resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="name">The name of the resource. This name can be used
        /// to access the resource.</param>
        /// <param name="type">Sub Resource type.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ContainerNetworkInterface(string id = default(string), ContainerNetworkInterfaceConfiguration containerNetworkInterfaceConfiguration = default(ContainerNetworkInterfaceConfiguration), Container container = default(Container), IList<ContainerNetworkInterfaceIpConfiguration> ipConfigurations = default(IList<ContainerNetworkInterfaceIpConfiguration>), string provisioningState = default(string), string name = default(string), string type = default(string), string etag = default(string))
            : base(id)
        {
            ContainerNetworkInterfaceConfiguration = containerNetworkInterfaceConfiguration;
            Container = container;
            IpConfigurations = ipConfigurations;
            ProvisioningState = provisioningState;
            Name = name;
            Type = type;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets container network interface configuration from which this
        /// container network interface is created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.containerNetworkInterfaceConfiguration")]
        public ContainerNetworkInterfaceConfiguration ContainerNetworkInterfaceConfiguration { get; private set; }

        /// <summary>
        /// Gets or sets reference to the container to which this container
        /// network interface is attached.
        /// </summary>
        [JsonProperty(PropertyName = "properties.container")]
        public Container Container { get; set; }

        /// <summary>
        /// Gets reference to the ip configuration on this container nic.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfigurations")]
        public IList<ContainerNetworkInterfaceIpConfiguration> IpConfigurations { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the container network interface
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the name of the resource. This name can be used to
        /// access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets sub Resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
