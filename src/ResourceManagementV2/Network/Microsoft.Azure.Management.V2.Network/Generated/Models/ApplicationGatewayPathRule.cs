// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Path rule of URL path map of application gateway
    /// </summary>
    [JsonTransformation]
    public partial class ApplicationGatewayPathRule : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayPathRule class.
        /// </summary>
        public ApplicationGatewayPathRule() { }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayPathRule class.
        /// </summary>
        /// <param name="paths">Gets or sets the path rules of URL path
        /// map</param>
        /// <param name="backendAddressPool">Gets or sets backend address pool
        /// resource of URL path map </param>
        /// <param name="backendHttpSettings">Gets or sets backend http
        /// settings resource of URL path map </param>
        /// <param name="provisioningState">Gets or sets path rule of URL path
        /// map resource Updating/Deleting/Failed</param>
        /// <param name="name">Gets name of the resource that is unique within
        /// a resource group. This name can be used to access the
        /// resource</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated</param>
        public ApplicationGatewayPathRule(String location = default(String), String id = default(String), String name = default(String), String type = default(String), IDictionary<string, String> tags = default(IDictionary<string, String>), IList<string> paths = default(IList<string>), SubResource backendAddressPool = default(SubResource), SubResource backendHttpSettings = default(SubResource), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            Paths = paths;
            BackendAddressPool = backendAddressPool;
            BackendHttpSettings = backendHttpSettings;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets the path rules of URL path map
        /// </summary>
        [JsonProperty(PropertyName = "properties.paths")]
        public IList<string> Paths { get; set; }

        /// <summary>
        /// Gets or sets backend address pool resource of URL path map
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendAddressPool")]
        public SubResource BackendAddressPool { get; set; }

        /// <summary>
        /// Gets or sets backend http settings resource of URL path map
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendHttpSettings")]
        public SubResource BackendHttpSettings { get; set; }

        /// <summary>
        /// Gets or sets path rule of URL path map resource
        /// Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
