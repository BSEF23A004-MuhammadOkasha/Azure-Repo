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
    /// <summary> A class representing the VirtualNetwork data model. </summary>
    public partial class VirtualNetworkData : Resource
    {
        /// <summary> Initializes a new instance of VirtualNetworkData. </summary>
        public VirtualNetworkData()
        {
            Subnets = new ChangeTrackingList<SubnetData>();
            VirtualNetworkPeerings = new ChangeTrackingList<VirtualNetworkPeeringData>();
            IpAllocations = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of VirtualNetworkData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="extendedLocation"> The extended location of the virtual network. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="addressSpace"> The AddressSpace that contains an array of IP address ranges that can be used by subnets. </param>
        /// <param name="dhcpOptions"> The dhcpOptions that contains an array of DNS servers available to VMs deployed in the virtual network. </param>
        /// <param name="flowTimeoutInMinutes"> The FlowTimeout value (in minutes) for the Virtual Network. </param>
        /// <param name="subnets"> A list of subnets in a Virtual Network. </param>
        /// <param name="virtualNetworkPeerings"> A list of peerings in a Virtual Network. </param>
        /// <param name="resourceGuid"> The resourceGuid property of the Virtual Network resource. </param>
        /// <param name="provisioningState"> The provisioning state of the virtual network resource. </param>
        /// <param name="enableDdosProtection"> Indicates if DDoS protection is enabled for all the protected resources in the virtual network. It requires a DDoS protection plan associated with the resource. </param>
        /// <param name="enableVmProtection"> Indicates if VM protection is enabled for all the subnets in the virtual network. </param>
        /// <param name="ddosProtectionPlan"> The DDoS protection plan associated with the virtual network. </param>
        /// <param name="bgpCommunities"> Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET. </param>
        /// <param name="ipAllocations"> Array of IpAllocation which reference this VNET. </param>
        internal VirtualNetworkData(string id, string name, string type, string location, IDictionary<string, string> tags, Models.ExtendedLocation extendedLocation, string etag, AddressSpace addressSpace, DhcpOptions dhcpOptions, int? flowTimeoutInMinutes, IList<SubnetData> subnets, IList<VirtualNetworkPeeringData> virtualNetworkPeerings, string resourceGuid, ProvisioningState? provisioningState, bool? enableDdosProtection, bool? enableVmProtection, WritableSubResource ddosProtectionPlan, VirtualNetworkBgpCommunities bgpCommunities, IList<WritableSubResource> ipAllocations) : base(id, name, type, location, tags)
        {
            ExtendedLocation = extendedLocation;
            Etag = etag;
            AddressSpace = addressSpace;
            DhcpOptions = dhcpOptions;
            FlowTimeoutInMinutes = flowTimeoutInMinutes;
            Subnets = subnets;
            VirtualNetworkPeerings = virtualNetworkPeerings;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            EnableDdosProtection = enableDdosProtection;
            EnableVmProtection = enableVmProtection;
            DdosProtectionPlan = ddosProtectionPlan;
            BgpCommunities = bgpCommunities;
            IpAllocations = ipAllocations;
        }

        /// <summary> The extended location of the virtual network. </summary>
        public Models.ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The AddressSpace that contains an array of IP address ranges that can be used by subnets. </summary>
        internal AddressSpace AddressSpace { get; set; }
        /// <summary> A list of address blocks reserved for this virtual network in CIDR notation. </summary>
        public IList<string> AddressPrefixes
        {
            get
            {
                if (AddressSpace is null)
                    AddressSpace = new AddressSpace();
                return AddressSpace.AddressPrefixes;
            }
        }

        /// <summary> The dhcpOptions that contains an array of DNS servers available to VMs deployed in the virtual network. </summary>
        internal DhcpOptions DhcpOptions { get; set; }
        /// <summary> The list of DNS servers IP addresses. </summary>
        public IList<string> DhcpOptionsDnsServers
        {
            get
            {
                if (DhcpOptions is null)
                    DhcpOptions = new DhcpOptions();
                return DhcpOptions.DnsServers;
            }
        }

        /// <summary> The FlowTimeout value (in minutes) for the Virtual Network. </summary>
        public int? FlowTimeoutInMinutes { get; set; }
        /// <summary> A list of subnets in a Virtual Network. </summary>
        public IList<SubnetData> Subnets { get; }
        /// <summary> A list of peerings in a Virtual Network. </summary>
        public IList<VirtualNetworkPeeringData> VirtualNetworkPeerings { get; }
        /// <summary> The resourceGuid property of the Virtual Network resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the virtual network resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Indicates if DDoS protection is enabled for all the protected resources in the virtual network. It requires a DDoS protection plan associated with the resource. </summary>
        public bool? EnableDdosProtection { get; set; }
        /// <summary> Indicates if VM protection is enabled for all the subnets in the virtual network. </summary>
        public bool? EnableVmProtection { get; set; }
        /// <summary> The DDoS protection plan associated with the virtual network. </summary>
        internal WritableSubResource DdosProtectionPlan { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DdosProtectionPlanId
        {
            get => DdosProtectionPlan is null ? default : DdosProtectionPlan.Id;
            set
            {
                if (DdosProtectionPlan is null)
                    DdosProtectionPlan = new WritableSubResource();
                DdosProtectionPlan.Id = value;
            }
        }

        /// <summary> Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET. </summary>
        public VirtualNetworkBgpCommunities BgpCommunities { get; set; }
        /// <summary> Array of IpAllocation which reference this VNET. </summary>
        public IList<WritableSubResource> IpAllocations { get; }
    }
}
