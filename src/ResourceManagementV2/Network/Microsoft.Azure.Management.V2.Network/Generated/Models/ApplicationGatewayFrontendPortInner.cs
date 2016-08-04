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
    /// Frontend Port of application gateway
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayFrontendPortInner : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayFrontendPortInner class.
        /// </summary>
        public ApplicationGatewayFrontendPortInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayFrontendPortInner class.
        /// </summary>
        /// <param name="port">Frontend port</param>
        /// <param name="provisioningState">Provisioning state of the frontend
        /// port resource Updating/Deleting/Failed</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated</param>
        public ApplicationGatewayFrontendPortInner(String id = default(String), int? port = default(int?), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            Port = port;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets frontend port
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the frontend port resource
        /// Updating/Deleting/Failed
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
