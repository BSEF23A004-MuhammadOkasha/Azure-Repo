// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkFabricInternetGateway data model.
    /// The Internet Gateway resource definition.
    /// </summary>
    public partial class NetworkFabricInternetGatewayData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NetworkFabricInternetGatewayData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="typePropertiesType"> Gateway Type of the resource. </param>
        /// <param name="networkFabricControllerId"> ARM Resource ID of the Network Fabric Controller. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricControllerId"/> is null. </exception>
        public NetworkFabricInternetGatewayData(AzureLocation location, InternetGatewayType typePropertiesType, ResourceIdentifier networkFabricControllerId) : base(location)
        {
            Argument.AssertNotNull(networkFabricControllerId, nameof(networkFabricControllerId));

            TypePropertiesType = typePropertiesType;
            NetworkFabricControllerId = networkFabricControllerId;
        }

        /// <summary> Initializes a new instance of NetworkFabricInternetGatewayData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="internetGatewayRuleId"> ARM Resource ID of the Internet Gateway Rule. </param>
        /// <param name="ipv4Address"> IPv4 Address of Internet Gateway. </param>
        /// <param name="port"> Port number of Internet Gateway. </param>
        /// <param name="typePropertiesType"> Gateway Type of the resource. </param>
        /// <param name="networkFabricControllerId"> ARM Resource ID of the Network Fabric Controller. </param>
        /// <param name="provisioningState"> Provisioning state of resource. </param>
        internal NetworkFabricInternetGatewayData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string annotation, ResourceIdentifier internetGatewayRuleId, IPAddress ipv4Address, int? port, InternetGatewayType typePropertiesType, ResourceIdentifier networkFabricControllerId, NetworkFabricProvisioningState? provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            Annotation = annotation;
            InternetGatewayRuleId = internetGatewayRuleId;
            IPv4Address = ipv4Address;
            Port = port;
            TypePropertiesType = typePropertiesType;
            NetworkFabricControllerId = networkFabricControllerId;
            ProvisioningState = provisioningState;
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> ARM Resource ID of the Internet Gateway Rule. </summary>
        public ResourceIdentifier InternetGatewayRuleId { get; set; }
        /// <summary> IPv4 Address of Internet Gateway. </summary>
        public IPAddress IPv4Address { get; }
        /// <summary> Port number of Internet Gateway. </summary>
        public int? Port { get; }
        /// <summary> Gateway Type of the resource. </summary>
        public InternetGatewayType TypePropertiesType { get; set; }
        /// <summary> ARM Resource ID of the Network Fabric Controller. </summary>
        public ResourceIdentifier NetworkFabricControllerId { get; set; }
        /// <summary> Provisioning state of resource. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
    }
}
