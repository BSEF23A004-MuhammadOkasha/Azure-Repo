// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Azure;
    using Management;
    using Network;
    using Fluent;
    using Rest;
    using Rest.Azure;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Public IP address resource.
    /// </summary>
    [JsonTransformation]
    public partial class PublicIPAddressInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the PublicIPAddressInner class.
        /// </summary>
        public PublicIPAddressInner() { }

        /// <summary>
        /// Initializes a new instance of the PublicIPAddressInner class.
        /// </summary>
        /// <param name="publicIPAllocationMethod">The public IP allocation
        /// method. Possible values are: 'Static' and 'Dynamic'. Possible
        /// values include: 'Static', 'Dynamic'</param>
        /// <param name="publicIPAddressVersion">The public IP address version.
        /// Possible values are: 'IPv4' and 'IPv6'. Possible values include:
        /// 'IPv4', 'IPv6'</param>
        /// <param name="dnsSettings">The FQDN of the DNS record associated
        /// with the public IP address.</param>
        /// <param name="idleTimeoutInMinutes">The idle timeout of the public
        /// IP address.</param>
        /// <param name="resourceGuid">The resource GUID property of the public
        /// IP resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// PublicIP resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public PublicIPAddressInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string publicIPAllocationMethod = default(string), string publicIPAddressVersion = default(string), IPConfigurationInner ipConfiguration = default(IPConfigurationInner), PublicIPAddressDnsSettings dnsSettings = default(PublicIPAddressDnsSettings), string ipAddress = default(string), int? idleTimeoutInMinutes = default(int?), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            PublicIPAllocationMethod = publicIPAllocationMethod;
            PublicIPAddressVersion = publicIPAddressVersion;
            IpConfiguration = ipConfiguration;
            DnsSettings = dnsSettings;
            IpAddress = ipAddress;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets the public IP allocation method. Possible values are:
        /// 'Static' and 'Dynamic'. Possible values include: 'Static',
        /// 'Dynamic'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAllocationMethod")]
        public string PublicIPAllocationMethod { get; set; }

        /// <summary>
        /// Gets or sets the public IP address version. Possible values are:
        /// 'IPv4' and 'IPv6'. Possible values include: 'IPv4', 'IPv6'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddressVersion")]
        public string PublicIPAddressVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfiguration")]
        public IPConfigurationInner IpConfiguration { get; protected set; }

        /// <summary>
        /// Gets or sets the FQDN of the DNS record associated with the public
        /// IP address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsSettings")]
        public PublicIPAddressDnsSettings DnsSettings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the idle timeout of the public IP address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.idleTimeoutInMinutes")]
        public int? IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the resource GUID property of the public IP resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the PublicIP resource.
        /// Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}

