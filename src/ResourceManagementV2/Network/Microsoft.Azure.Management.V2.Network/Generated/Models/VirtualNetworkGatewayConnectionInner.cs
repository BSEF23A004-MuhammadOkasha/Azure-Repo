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
    /// A common class for general resource information
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class VirtualNetworkGatewayConnectionInner : Resource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualNetworkGatewayConnectionInner class.
        /// </summary>
        public VirtualNetworkGatewayConnectionInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualNetworkGatewayConnectionInner class.
        /// </summary>
        /// <param name="authorizationKey">The authorizationKey.</param>
        /// <param name="connectionType">Gateway connection type
        /// -Ipsec/Dedicated/VpnClient/Vnet2Vnet. Possible values include:
        /// 'IPsec', 'Vnet2Vnet', 'ExpressRoute', 'VPNClient'</param>
        /// <param name="routingWeight">The Routing weight.</param>
        /// <param name="sharedKey">The Ipsec share key.</param>
        /// <param name="connectionStatus">Virtual network Gateway connection
        /// status. Possible values include: 'Unknown', 'Connecting',
        /// 'Connected', 'NotConnected'</param>
        /// <param name="egressBytesTransferred">The Egress Bytes Transferred
        /// in this connection</param>
        /// <param name="ingressBytesTransferred">The Ingress Bytes
        /// Transferred in this connection</param>
        /// <param name="peer">The reference to peerings resource.</param>
        /// <param name="enableBgp">EnableBgp Flag</param>
        /// <param name="resourceGuid">Gets or sets resource guid property of
        /// the VirtualNetworkGatewayConnection resource</param>
        /// <param name="provisioningState">Gets provisioning state of the
        /// VirtualNetworkGatewayConnection resource
        /// Updating/Deleting/Failed</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated</param>
        public VirtualNetworkGatewayConnectionInner(String location = default(String), String id = default(String), String name = default(String), String type = default(String), IDictionary<string, String> tags = default(IDictionary<string, String>), string authorizationKey = default(string), VirtualNetworkGatewayInner virtualNetworkGateway1 = default(VirtualNetworkGatewayInner), VirtualNetworkGatewayInner virtualNetworkGateway2 = default(VirtualNetworkGatewayInner), LocalNetworkGatewayInner localNetworkGateway2 = default(LocalNetworkGatewayInner), string connectionType = default(string), int? routingWeight = default(int?), string sharedKey = default(string), string connectionStatus = default(string), long? egressBytesTransferred = default(long?), long? ingressBytesTransferred = default(long?), SubResource peer = default(SubResource), bool? enableBgp = default(bool?), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            AuthorizationKey = authorizationKey;
            VirtualNetworkGateway1 = virtualNetworkGateway1;
            VirtualNetworkGateway2 = virtualNetworkGateway2;
            LocalNetworkGateway2 = localNetworkGateway2;
            ConnectionType = connectionType;
            RoutingWeight = routingWeight;
            SharedKey = sharedKey;
            ConnectionStatus = connectionStatus;
            EgressBytesTransferred = egressBytesTransferred;
            IngressBytesTransferred = ingressBytesTransferred;
            Peer = peer;
            EnableBgp = enableBgp;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets the authorizationKey.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.authorizationKey")]
        public string AuthorizationKey { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.virtualNetworkGateway1")]
        public VirtualNetworkGatewayInner VirtualNetworkGateway1 { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.virtualNetworkGateway2")]
        public VirtualNetworkGatewayInner VirtualNetworkGateway2 { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.localNetworkGateway2")]
        public LocalNetworkGatewayInner LocalNetworkGateway2 { get; set; }

        /// <summary>
        /// Gets or sets gateway connection type
        /// -Ipsec/Dedicated/VpnClient/Vnet2Vnet. Possible values include:
        /// 'IPsec', 'Vnet2Vnet', 'ExpressRoute', 'VPNClient'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.connectionType")]
        public string ConnectionType { get; set; }

        /// <summary>
        /// Gets or sets the Routing weight.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.routingWeight")]
        public int? RoutingWeight { get; set; }

        /// <summary>
        /// Gets or sets the Ipsec share key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sharedKey")]
        public string SharedKey { get; set; }

        /// <summary>
        /// Gets or sets virtual network Gateway connection status. Possible
        /// values include: 'Unknown', 'Connecting', 'Connected',
        /// 'NotConnected'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.connectionStatus")]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// Gets or sets the Egress Bytes Transferred in this connection
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.egressBytesTransferred")]
        public long? EgressBytesTransferred { get; set; }

        /// <summary>
        /// Gets or sets the Ingress Bytes Transferred in this connection
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.ingressBytesTransferred")]
        public long? IngressBytesTransferred { get; set; }

        /// <summary>
        /// Gets or sets the reference to peerings resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.peer")]
        public SubResource Peer { get; set; }

        /// <summary>
        /// Gets or sets enableBgp Flag
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.enableBgp")]
        public bool? EnableBgp { get; set; }

        /// <summary>
        /// Gets or sets resource guid property of the
        /// VirtualNetworkGatewayConnection resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets provisioning state of the VirtualNetworkGatewayConnection
        /// resource Updating/Deleting/Failed
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
