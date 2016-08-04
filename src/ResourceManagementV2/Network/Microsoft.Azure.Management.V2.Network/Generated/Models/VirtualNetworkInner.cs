// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Virtual Network resource
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class VirtualNetworkInner : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkInner class.
        /// </summary>
        public VirtualNetworkInner() { }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkInner class.
        /// </summary>
        /// <param name="addressSpace">Gets or sets AddressSpace that contains
        /// an array of IP address ranges that can be used by subnets</param>
        /// <param name="dhcpOptions">Gets or sets DHCPOptions that contains
        /// an array of DNS servers available to VMs deployed in the virtual
        /// network</param>
        /// <param name="subnets">Gets or sets list of subnets in a
        /// VirtualNetwork</param>
        /// <param name="virtualNetworkPeerings">Gets or sets list of peerings
        /// in a VirtualNetwork</param>
        /// <param name="resourceGuid">Gets or sets resource guid property of
        /// the VirtualNetwork resource</param>
        /// <param name="provisioningState">Gets provisioning state of the
        /// PublicIP resource Updating/Deleting/Failed</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated</param>
        public VirtualNetworkInner(String location = default(String), String id = default(String), String name = default(String), String type = default(String), IDictionary<string, String> tags = default(IDictionary<string, String>), AddressSpace addressSpace = default(AddressSpace), DhcpOptions dhcpOptions = default(DhcpOptions), System.Collections.Generic.IList<SubnetInner> subnets = default(System.Collections.Generic.IList<SubnetInner>), System.Collections.Generic.IList<VirtualNetworkPeeringInner> virtualNetworkPeerings = default(System.Collections.Generic.IList<VirtualNetworkPeeringInner>), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            AddressSpace = addressSpace;
            DhcpOptions = dhcpOptions;
            Subnets = subnets;
            VirtualNetworkPeerings = virtualNetworkPeerings;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets AddressSpace that contains an array of IP address
        /// ranges that can be used by subnets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.addressSpace")]
        public AddressSpace AddressSpace { get; set; }

        /// <summary>
        /// Gets or sets DHCPOptions that contains an array of DNS servers
        /// available to VMs deployed in the virtual network
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dhcpOptions")]
        public DhcpOptions DhcpOptions { get; set; }

        /// <summary>
        /// Gets or sets list of subnets in a VirtualNetwork
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.subnets")]
        public System.Collections.Generic.IList<SubnetInner> Subnets { get; set; }

        /// <summary>
        /// Gets or sets list of peerings in a VirtualNetwork
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.VirtualNetworkPeerings")]
        public System.Collections.Generic.IList<VirtualNetworkPeeringInner> VirtualNetworkPeerings { get; set; }

        /// <summary>
        /// Gets or sets resource guid property of the VirtualNetwork resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
