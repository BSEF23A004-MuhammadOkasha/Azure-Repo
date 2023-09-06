// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the PrivateEndpoint data model.
    /// Private endpoint resource.
    /// </summary>
    public partial class PrivateEndpointData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="PrivateEndpointData"/>. </summary>
        public PrivateEndpointData()
        {
            NetworkInterfaces = new ChangeTrackingList<NetworkInterfaceData>();
            PrivateLinkServiceConnections = new ChangeTrackingList<NetworkPrivateLinkServiceConnection>();
            ManualPrivateLinkServiceConnections = new ChangeTrackingList<NetworkPrivateLinkServiceConnection>();
            CustomDnsConfigs = new ChangeTrackingList<CustomDnsConfigProperties>();
            ApplicationSecurityGroups = new ChangeTrackingList<ApplicationSecurityGroupData>();
            IPConfigurations = new ChangeTrackingList<PrivateEndpointIPConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateEndpointData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="extendedLocation"> The extended location of the load balancer. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="subnet"> The ID of the subnet from which the private IP will be allocated. </param>
        /// <param name="networkInterfaces"> An array of references to the network interfaces created for this private endpoint. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint resource. </param>
        /// <param name="privateLinkServiceConnections"> A grouping of information about the connection to the remote resource. </param>
        /// <param name="manualPrivateLinkServiceConnections"> A grouping of information about the connection to the remote resource. Used when the network admin does not have access to approve connections to the remote resource. </param>
        /// <param name="customDnsConfigs"> An array of custom dns configurations. </param>
        /// <param name="applicationSecurityGroups"> Application security groups in which the private endpoint IP configuration is included. </param>
        /// <param name="ipConfigurations"> A list of IP configurations of the private endpoint. This will be used to map to the First Party Service's endpoints. </param>
        /// <param name="customNetworkInterfaceName"> The custom name of the network interface attached to the private endpoint. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateEndpointData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ExtendedLocation extendedLocation, ETag? etag, SubnetData subnet, IReadOnlyList<NetworkInterfaceData> networkInterfaces, NetworkProvisioningState? provisioningState, IList<NetworkPrivateLinkServiceConnection> privateLinkServiceConnections, IList<NetworkPrivateLinkServiceConnection> manualPrivateLinkServiceConnections, IList<CustomDnsConfigProperties> customDnsConfigs, IList<ApplicationSecurityGroupData> applicationSecurityGroups, IList<PrivateEndpointIPConfiguration> ipConfigurations, string customNetworkInterfaceName, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, location, tags, rawData)
        {
            ExtendedLocation = extendedLocation;
            ETag = etag;
            Subnet = subnet;
            NetworkInterfaces = networkInterfaces;
            ProvisioningState = provisioningState;
            PrivateLinkServiceConnections = privateLinkServiceConnections;
            ManualPrivateLinkServiceConnections = manualPrivateLinkServiceConnections;
            CustomDnsConfigs = customDnsConfigs;
            ApplicationSecurityGroups = applicationSecurityGroups;
            IPConfigurations = ipConfigurations;
            CustomNetworkInterfaceName = customNetworkInterfaceName;
        }

        /// <summary> The extended location of the load balancer. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The ID of the subnet from which the private IP will be allocated. </summary>
        public SubnetData Subnet { get; set; }
        /// <summary> An array of references to the network interfaces created for this private endpoint. </summary>
        public IReadOnlyList<NetworkInterfaceData> NetworkInterfaces { get; }
        /// <summary> The provisioning state of the private endpoint resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> A grouping of information about the connection to the remote resource. </summary>
        public IList<NetworkPrivateLinkServiceConnection> PrivateLinkServiceConnections { get; }
        /// <summary> A grouping of information about the connection to the remote resource. Used when the network admin does not have access to approve connections to the remote resource. </summary>
        public IList<NetworkPrivateLinkServiceConnection> ManualPrivateLinkServiceConnections { get; }
        /// <summary> An array of custom dns configurations. </summary>
        public IList<CustomDnsConfigProperties> CustomDnsConfigs { get; }
        /// <summary> Application security groups in which the private endpoint IP configuration is included. </summary>
        public IList<ApplicationSecurityGroupData> ApplicationSecurityGroups { get; }
        /// <summary> A list of IP configurations of the private endpoint. This will be used to map to the First Party Service's endpoints. </summary>
        public IList<PrivateEndpointIPConfiguration> IPConfigurations { get; }
        /// <summary> The custom name of the network interface attached to the private endpoint. </summary>
        public string CustomNetworkInterfaceName { get; set; }
    }
}
