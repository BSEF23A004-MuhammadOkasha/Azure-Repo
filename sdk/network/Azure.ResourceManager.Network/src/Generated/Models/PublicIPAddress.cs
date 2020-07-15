// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Public IP address resource. </summary>
    public partial class PublicIPAddress : Resource
    {
        /// <summary> Initializes a new instance of PublicIPAddress. </summary>
        public PublicIPAddress()
        {
        }

        /// <summary> Initializes a new instance of PublicIPAddress. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="sku"> The public IP address SKU. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="zones"> A list of availability zones denoting the IP allocated for the resource needs to come from. </param>
        /// <param name="publicIPAllocationMethod"> The public IP address allocation method. </param>
        /// <param name="publicIPAddressVersion"> The public IP address version. </param>
        /// <param name="ipConfiguration"> The IP configuration associated with the public IP address. </param>
        /// <param name="dnsSettings"> The FQDN of the DNS record associated with the public IP address. </param>
        /// <param name="ddosSettings"> The DDoS protection custom policy associated with the public IP address. </param>
        /// <param name="ipTags"> The list of tags associated with the public IP address. </param>
        /// <param name="ipAddress"> The IP address associated with the public IP address resource. </param>
        /// <param name="publicIPPrefix"> The Public IP Prefix this Public IP Address should be allocated from. </param>
        /// <param name="idleTimeoutInMinutes"> The idle timeout of the public IP address. </param>
        /// <param name="resourceGuid"> The resource GUID property of the public IP address resource. </param>
        /// <param name="provisioningState"> The provisioning state of the public IP address resource. </param>
        internal PublicIPAddress(string id, string name, string type, string location, IDictionary<string, string> tags, PublicIPAddressSku sku, string etag, IList<string> zones, IPAllocationMethod? publicIPAllocationMethod, IPVersion? publicIPAddressVersion, IPConfiguration ipConfiguration, PublicIPAddressDnsSettings dnsSettings, DdosSettings ddosSettings, IList<IpTag> ipTags, string ipAddress, SubResource publicIPPrefix, int? idleTimeoutInMinutes, string resourceGuid, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            Sku = sku;
            Etag = etag;
            Zones = zones;
            PublicIPAllocationMethod = publicIPAllocationMethod;
            PublicIPAddressVersion = publicIPAddressVersion;
            IpConfiguration = ipConfiguration;
            DnsSettings = dnsSettings;
            DdosSettings = ddosSettings;
            IpTags = ipTags;
            IpAddress = ipAddress;
            PublicIPPrefix = publicIPPrefix;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> The public IP address SKU. </summary>
        public PublicIPAddressSku Sku { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> A list of availability zones denoting the IP allocated for the resource needs to come from. </summary>
        public IList<string> Zones { get; set; }
        /// <summary> The public IP address allocation method. </summary>
        public IPAllocationMethod? PublicIPAllocationMethod { get; set; }
        /// <summary> The public IP address version. </summary>
        public IPVersion? PublicIPAddressVersion { get; set; }
        /// <summary> The IP configuration associated with the public IP address. </summary>
        public IPConfiguration IpConfiguration { get; }
        /// <summary> The FQDN of the DNS record associated with the public IP address. </summary>
        public PublicIPAddressDnsSettings DnsSettings { get; set; }
        /// <summary> The DDoS protection custom policy associated with the public IP address. </summary>
        public DdosSettings DdosSettings { get; set; }
        /// <summary> The list of tags associated with the public IP address. </summary>
        public IList<IpTag> IpTags { get; set; }
        /// <summary> The IP address associated with the public IP address resource. </summary>
        public string IpAddress { get; set; }
        /// <summary> The Public IP Prefix this Public IP Address should be allocated from. </summary>
        public SubResource PublicIPPrefix { get; set; }
        /// <summary> The idle timeout of the public IP address. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
        /// <summary> The resource GUID property of the public IP address resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the public IP address resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
