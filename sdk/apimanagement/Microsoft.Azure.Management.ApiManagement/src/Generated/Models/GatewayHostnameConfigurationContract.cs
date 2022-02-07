// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Gateway hostname configuration details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class GatewayHostnameConfigurationContract : Resource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GatewayHostnameConfigurationContract class.
        /// </summary>
        public GatewayHostnameConfigurationContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GatewayHostnameConfigurationContract class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="hostname">Hostname value. Supports valid domain name,
        /// partial or full wildcard</param>
        /// <param name="certificateId">Identifier of Certificate entity that
        /// will be used for TLS connection establishment</param>
        /// <param name="negotiateClientCertificate">Determines whether gateway
        /// requests client certificate</param>
        /// <param name="tls10Enabled">Specifies if TLS 1.0 is
        /// supported</param>
        /// <param name="tls11Enabled">Specifies if TLS 1.1 is
        /// supported</param>
        /// <param name="http2Enabled">Specifies if HTTP/2.0 is
        /// supported</param>
        public GatewayHostnameConfigurationContract(string id = default(string), string name = default(string), string type = default(string), string hostname = default(string), string certificateId = default(string), bool? negotiateClientCertificate = default(bool?), bool? tls10Enabled = default(bool?), bool? tls11Enabled = default(bool?), bool? http2Enabled = default(bool?))
            : base(id, name, type)
        {
            Hostname = hostname;
            CertificateId = certificateId;
            NegotiateClientCertificate = negotiateClientCertificate;
            Tls10Enabled = tls10Enabled;
            Tls11Enabled = tls11Enabled;
            Http2Enabled = http2Enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets hostname value. Supports valid domain name, partial or
        /// full wildcard
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or sets identifier of Certificate entity that will be used for
        /// TLS connection establishment
        /// </summary>
        [JsonProperty(PropertyName = "properties.certificateId")]
        public string CertificateId { get; set; }

        /// <summary>
        /// Gets or sets determines whether gateway requests client certificate
        /// </summary>
        [JsonProperty(PropertyName = "properties.negotiateClientCertificate")]
        public bool? NegotiateClientCertificate { get; set; }

        /// <summary>
        /// Gets or sets specifies if TLS 1.0 is supported
        /// </summary>
        [JsonProperty(PropertyName = "properties.tls10Enabled")]
        public bool? Tls10Enabled { get; set; }

        /// <summary>
        /// Gets or sets specifies if TLS 1.1 is supported
        /// </summary>
        [JsonProperty(PropertyName = "properties.tls11Enabled")]
        public bool? Tls11Enabled { get; set; }

        /// <summary>
        /// Gets or sets specifies if HTTP/2.0 is supported
        /// </summary>
        [JsonProperty(PropertyName = "properties.http2Enabled")]
        public bool? Http2Enabled { get; set; }

    }
}
