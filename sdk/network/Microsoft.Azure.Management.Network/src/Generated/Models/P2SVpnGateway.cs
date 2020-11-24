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
    /// P2SVpnGateway Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class P2SVpnGateway : Resource
    {
        /// <summary>
        /// Initializes a new instance of the P2SVpnGateway class.
        /// </summary>
        public P2SVpnGateway()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the P2SVpnGateway class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="virtualHub">The VirtualHub to which the gateway
        /// belongs.</param>
        /// <param name="p2SConnectionConfigurations">List of all p2s
        /// connection configurations of the gateway.</param>
        /// <param name="provisioningState">The provisioning state of the P2S
        /// VPN gateway resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="vpnGatewayScaleUnit">The scale unit for this p2s vpn
        /// gateway.</param>
        /// <param name="vpnServerConfiguration">The VpnServerConfiguration to
        /// which the p2sVpnGateway is attached to.</param>
        /// <param name="vpnClientConnectionHealth">All P2S VPN clients'
        /// connection health status.</param>
        /// <param name="customDnsServers">List of all customer specified DNS
        /// servers IP addresses.</param>
        /// <param name="isRoutingPreferenceInternet">Enable Routing Preference
        /// property for the Public IP Interface of the P2SVpnGateway.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public P2SVpnGateway(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SubResource virtualHub = default(SubResource), IList<P2SConnectionConfiguration> p2SConnectionConfigurations = default(IList<P2SConnectionConfiguration>), string provisioningState = default(string), int? vpnGatewayScaleUnit = default(int?), SubResource vpnServerConfiguration = default(SubResource), VpnClientConnectionHealth vpnClientConnectionHealth = default(VpnClientConnectionHealth), IList<string> customDnsServers = default(IList<string>), bool? isRoutingPreferenceInternet = default(bool?), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            VirtualHub = virtualHub;
            P2SConnectionConfigurations = p2SConnectionConfigurations;
            ProvisioningState = provisioningState;
            VpnGatewayScaleUnit = vpnGatewayScaleUnit;
            VpnServerConfiguration = vpnServerConfiguration;
            VpnClientConnectionHealth = vpnClientConnectionHealth;
            CustomDnsServers = customDnsServers;
            IsRoutingPreferenceInternet = isRoutingPreferenceInternet;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the VirtualHub to which the gateway belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualHub")]
        public SubResource VirtualHub { get; set; }

        /// <summary>
        /// Gets or sets list of all p2s connection configurations of the
        /// gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.p2SConnectionConfigurations")]
        public IList<P2SConnectionConfiguration> P2SConnectionConfigurations { get; set; }

        /// <summary>
        /// Gets the provisioning state of the P2S VPN gateway resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the scale unit for this p2s vpn gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnGatewayScaleUnit")]
        public int? VpnGatewayScaleUnit { get; set; }

        /// <summary>
        /// Gets or sets the VpnServerConfiguration to which the p2sVpnGateway
        /// is attached to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnServerConfiguration")]
        public SubResource VpnServerConfiguration { get; set; }

        /// <summary>
        /// Gets all P2S VPN clients' connection health status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnClientConnectionHealth")]
        public VpnClientConnectionHealth VpnClientConnectionHealth { get; private set; }

        /// <summary>
        /// Gets or sets list of all customer specified DNS servers IP
        /// addresses.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customDnsServers")]
        public IList<string> CustomDnsServers { get; set; }

        /// <summary>
        /// Gets or sets enable Routing Preference property for the Public IP
        /// Interface of the P2SVpnGateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isRoutingPreferenceInternet")]
        public bool? IsRoutingPreferenceInternet { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
