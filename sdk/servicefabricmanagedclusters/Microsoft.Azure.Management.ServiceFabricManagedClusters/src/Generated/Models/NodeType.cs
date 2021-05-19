// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a node type in the cluster, each node type represents sub set
    /// of nodes in the cluster.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NodeType : ManagedProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the NodeType class.
        /// </summary>
        public NodeType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NodeType class.
        /// </summary>
        /// <param name="isPrimary">The node type on which system services will
        /// run. Only one node type should be marked as primary. Primary node
        /// type cannot be deleted or changed for existing clusters.</param>
        /// <param name="vmInstanceCount">The number of nodes in the node
        /// type.</param>
        /// <param name="dataDiskSizeGB">Disk size for each vm in the node type
        /// in GBs.</param>
        /// <param name="id">Azure resource identifier.</param>
        /// <param name="name">Azure resource name.</param>
        /// <param name="type">Azure resource type.</param>
        /// <param name="tags">Azure resource tags.</param>
        /// <param name="placementProperties">The placement tags applied to
        /// nodes in the node type, which can be used to indicate where certain
        /// services (workload) should run.</param>
        /// <param name="capacities">The capacity tags applied to the nodes in
        /// the node type, the cluster resource manager uses these tags to
        /// understand how much resource a node has.</param>
        /// <param name="applicationPorts">The range of ports from which
        /// cluster assigned port to Service Fabric applications.</param>
        /// <param name="ephemeralPorts">The range of ephemeral ports that
        /// nodes in this node type should be configured with.</param>
        /// <param name="vmSize">The size of virtual machines in the pool. All
        /// virtual machines in a pool are the same size. For example,
        /// Standard_D3.</param>
        /// <param name="vmImagePublisher">The publisher of the Azure Virtual
        /// Machines Marketplace image. For example, Canonical or
        /// MicrosoftWindowsServer.</param>
        /// <param name="vmImageOffer">The offer type of the Azure Virtual
        /// Machines Marketplace image. For example, UbuntuServer or
        /// WindowsServer.</param>
        /// <param name="vmImageSku">The SKU of the Azure Virtual Machines
        /// Marketplace image. For example, 14.04.0-LTS or
        /// 2012-R2-Datacenter.</param>
        /// <param name="vmImageVersion">The version of the Azure Virtual
        /// Machines Marketplace image. A value of 'latest' can be specified to
        /// select the latest version of an image. If omitted, the default is
        /// 'latest'.</param>
        /// <param name="vmSecrets">virtual machine secretes.</param>
        /// <param name="vmExtensions">virtual machine extensions.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// managed cluster resource. Possible values include: 'None',
        /// 'Creating', 'Created', 'Updating', 'Succeeded', 'Failed',
        /// 'Canceled', 'Deleting', 'Deleted', 'Other'</param>
        public NodeType(bool isPrimary, int vmInstanceCount, int dataDiskSizeGB, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SystemData systemData = default(SystemData), IDictionary<string, string> placementProperties = default(IDictionary<string, string>), IDictionary<string, string> capacities = default(IDictionary<string, string>), EndpointRangeDescription applicationPorts = default(EndpointRangeDescription), EndpointRangeDescription ephemeralPorts = default(EndpointRangeDescription), string vmSize = default(string), string vmImagePublisher = default(string), string vmImageOffer = default(string), string vmImageSku = default(string), string vmImageVersion = default(string), IList<VaultSecretGroup> vmSecrets = default(IList<VaultSecretGroup>), IList<VMSSExtension> vmExtensions = default(IList<VMSSExtension>), VmManagedIdentity vmManagedIdentity = default(VmManagedIdentity), string provisioningState = default(string))
            : base(id, name, type, tags, systemData)
        {
            IsPrimary = isPrimary;
            VmInstanceCount = vmInstanceCount;
            DataDiskSizeGB = dataDiskSizeGB;
            PlacementProperties = placementProperties;
            Capacities = capacities;
            ApplicationPorts = applicationPorts;
            EphemeralPorts = ephemeralPorts;
            VmSize = vmSize;
            VmImagePublisher = vmImagePublisher;
            VmImageOffer = vmImageOffer;
            VmImageSku = vmImageSku;
            VmImageVersion = vmImageVersion;
            VmSecrets = vmSecrets;
            VmExtensions = vmExtensions;
            VmManagedIdentity = vmManagedIdentity;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the node type on which system services will run. Only
        /// one node type should be marked as primary. Primary node type cannot
        /// be deleted or changed for existing clusters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isPrimary")]
        public bool IsPrimary { get; set; }

        /// <summary>
        /// Gets or sets the number of nodes in the node type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmInstanceCount")]
        public int VmInstanceCount { get; set; }

        /// <summary>
        /// Gets or sets disk size for each vm in the node type in GBs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataDiskSizeGB")]
        public int DataDiskSizeGB { get; set; }

        /// <summary>
        /// Gets or sets the placement tags applied to nodes in the node type,
        /// which can be used to indicate where certain services (workload)
        /// should run.
        /// </summary>
        [JsonProperty(PropertyName = "properties.placementProperties")]
        public IDictionary<string, string> PlacementProperties { get; set; }

        /// <summary>
        /// Gets or sets the capacity tags applied to the nodes in the node
        /// type, the cluster resource manager uses these tags to understand
        /// how much resource a node has.
        /// </summary>
        [JsonProperty(PropertyName = "properties.capacities")]
        public IDictionary<string, string> Capacities { get; set; }

        /// <summary>
        /// Gets or sets the range of ports from which cluster assigned port to
        /// Service Fabric applications.
        /// </summary>
        [JsonProperty(PropertyName = "properties.applicationPorts")]
        public EndpointRangeDescription ApplicationPorts { get; set; }

        /// <summary>
        /// Gets or sets the range of ephemeral ports that nodes in this node
        /// type should be configured with.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ephemeralPorts")]
        public EndpointRangeDescription EphemeralPorts { get; set; }

        /// <summary>
        /// Gets or sets the size of virtual machines in the pool. All virtual
        /// machines in a pool are the same size. For example, Standard_D3.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets the publisher of the Azure Virtual Machines
        /// Marketplace image. For example, Canonical or
        /// MicrosoftWindowsServer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmImagePublisher")]
        public string VmImagePublisher { get; set; }

        /// <summary>
        /// Gets or sets the offer type of the Azure Virtual Machines
        /// Marketplace image. For example, UbuntuServer or WindowsServer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmImageOffer")]
        public string VmImageOffer { get; set; }

        /// <summary>
        /// Gets or sets the SKU of the Azure Virtual Machines Marketplace
        /// image. For example, 14.04.0-LTS or 2012-R2-Datacenter.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmImageSku")]
        public string VmImageSku { get; set; }

        /// <summary>
        /// Gets or sets the version of the Azure Virtual Machines Marketplace
        /// image. A value of 'latest' can be specified to select the latest
        /// version of an image. If omitted, the default is 'latest'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmImageVersion")]
        public string VmImageVersion { get; set; }

        /// <summary>
        /// Gets or sets virtual machine secretes.
        /// </summary>
        /// <remarks>
        /// The secrets to install in the virtual machines.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.vmSecrets")]
        public IList<VaultSecretGroup> VmSecrets { get; set; }

        /// <summary>
        /// Gets or sets virtual machine extensions.
        /// </summary>
        /// <remarks>
        /// Set of extensions that should be installed onto the virtual
        /// machines.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.vmExtensions")]
        public IList<VMSSExtension> VmExtensions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmManagedIdentity")]
        public VmManagedIdentity VmManagedIdentity { get; set; }

        /// <summary>
        /// Gets the provisioning state of the managed cluster resource.
        /// Possible values include: 'None', 'Creating', 'Created', 'Updating',
        /// 'Succeeded', 'Failed', 'Canceled', 'Deleting', 'Deleted', 'Other'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VmInstanceCount > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "VmInstanceCount", 2147483647);
            }
            if (VmInstanceCount < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "VmInstanceCount", 1);
            }
            if (ApplicationPorts != null)
            {
                ApplicationPorts.Validate();
            }
            if (EphemeralPorts != null)
            {
                EphemeralPorts.Validate();
            }
            if (VmSecrets != null)
            {
                foreach (var element in VmSecrets)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (VmExtensions != null)
            {
                foreach (var element1 in VmExtensions)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
