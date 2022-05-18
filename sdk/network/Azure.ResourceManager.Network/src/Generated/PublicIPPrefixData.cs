// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the PublicIPPrefix data model. </summary>
    public partial class PublicIPPrefixData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of PublicIPPrefixData. </summary>
        public PublicIPPrefixData()
        {
            Zones = new ChangeTrackingList<string>();
            IPTags = new ChangeTrackingList<IPTag>();
            PublicIPAddresses = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of PublicIPPrefixData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="extendedLocation"> The extended location of the public ip address. </param>
        /// <param name="sku"> The public IP prefix SKU. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="zones"> A list of availability zones denoting the IP allocated for the resource needs to come from. </param>
        /// <param name="publicIPAddressVersion"> The public IP address version. </param>
        /// <param name="ipTags"> The list of tags associated with the public IP prefix. </param>
        /// <param name="prefixLength"> The Length of the Public IP Prefix. </param>
        /// <param name="ipPrefix"> The allocated Prefix. </param>
        /// <param name="publicIPAddresses"> The list of all referenced PublicIPAddresses. </param>
        /// <param name="loadBalancerFrontendIPConfiguration"> The reference to load balancer frontend IP configuration associated with the public IP prefix. </param>
        /// <param name="customIPPrefix"> The customIpPrefix that this prefix is associated with. </param>
        /// <param name="resourceGuid"> The resource GUID property of the public IP prefix resource. </param>
        /// <param name="provisioningState"> The provisioning state of the public IP prefix resource. </param>
        /// <param name="natGateway"> NatGateway of Public IP Prefix. </param>
        internal PublicIPPrefixData(string id, string name, string resourceType, string location, IDictionary<string, string> tags, Models.ExtendedLocation extendedLocation, PublicIPPrefixSku sku, string etag, IList<string> zones, IPVersion? publicIPAddressVersion, IList<IPTag> ipTags, int? prefixLength, string ipPrefix, IReadOnlyList<SubResource> publicIPAddresses, WritableSubResource loadBalancerFrontendIPConfiguration, WritableSubResource customIPPrefix, string resourceGuid, ProvisioningState? provisioningState, NatGatewayData natGateway) : base(id, name, resourceType, location, tags)
        {
            ExtendedLocation = extendedLocation;
            Sku = sku;
            Etag = etag;
            Zones = zones;
            PublicIPAddressVersion = publicIPAddressVersion;
            IPTags = ipTags;
            PrefixLength = prefixLength;
            IPPrefix = ipPrefix;
            PublicIPAddresses = publicIPAddresses;
            LoadBalancerFrontendIPConfiguration = loadBalancerFrontendIPConfiguration;
            CustomIPPrefix = customIPPrefix;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            NatGateway = natGateway;
        }

        /// <summary> The extended location of the public ip address. </summary>
        public Models.ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The public IP prefix SKU. </summary>
        public PublicIPPrefixSku Sku { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> A list of availability zones denoting the IP allocated for the resource needs to come from. </summary>
        public IList<string> Zones { get; }
        /// <summary> The public IP address version. </summary>
        public IPVersion? PublicIPAddressVersion { get; set; }
        /// <summary> The list of tags associated with the public IP prefix. </summary>
        public IList<IPTag> IPTags { get; }
        /// <summary> The Length of the Public IP Prefix. </summary>
        public int? PrefixLength { get; set; }
        /// <summary> The allocated Prefix. </summary>
        public string IPPrefix { get; }
        /// <summary> The list of all referenced PublicIPAddresses. </summary>
        public IReadOnlyList<SubResource> PublicIPAddresses { get; }
        /// <summary> The reference to load balancer frontend IP configuration associated with the public IP prefix. </summary>
        internal WritableSubResource LoadBalancerFrontendIPConfiguration { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier LoadBalancerFrontendIPConfigurationId
        {
            get => LoadBalancerFrontendIPConfiguration?.Id;
        }

        /// <summary> The customIpPrefix that this prefix is associated with. </summary>
        internal WritableSubResource CustomIPPrefix { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier CustomIPPrefixId
        {
            get => CustomIPPrefix is null ? default : CustomIPPrefix.Id;
            set
            {
                if (CustomIPPrefix is null)
                    CustomIPPrefix = new WritableSubResource();
                CustomIPPrefix.Id = value;
            }
        }

        /// <summary> The resource GUID property of the public IP prefix resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the public IP prefix resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> NatGateway of Public IP Prefix. </summary>
        public NatGatewayData NatGateway { get; set; }
    }
}
