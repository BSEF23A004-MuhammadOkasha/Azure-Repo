// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the load balancer configuration. </summary>
    public partial class CloudServiceLoadBalancerConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CloudServiceLoadBalancerConfiguration"/>. </summary>
        /// <param name="name"> The name of the Load balancer. </param>
        /// <param name="frontendIPConfigurations"> Specifies the frontend IP to be used for the load balancer. Only IPv4 frontend IP address is supported. Each load balancer configuration must have exactly one frontend IP configuration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="frontendIPConfigurations"/> is null. </exception>
        public CloudServiceLoadBalancerConfiguration(string name, IEnumerable<LoadBalancerFrontendIPConfiguration> frontendIPConfigurations)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(frontendIPConfigurations, nameof(frontendIPConfigurations));

            Name = name;
            FrontendIPConfigurations = frontendIPConfigurations.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CloudServiceLoadBalancerConfiguration"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> The name of the Load balancer. </param>
        /// <param name="frontendIPConfigurations"> Specifies the frontend IP to be used for the load balancer. Only IPv4 frontend IP address is supported. Each load balancer configuration must have exactly one frontend IP configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudServiceLoadBalancerConfiguration(ResourceIdentifier id, string name, IList<LoadBalancerFrontendIPConfiguration> frontendIPConfigurations, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            FrontendIPConfigurations = frontendIPConfigurations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CloudServiceLoadBalancerConfiguration"/> for deserialization. </summary>
        internal CloudServiceLoadBalancerConfiguration()
        {
        }

        /// <summary> Resource Id. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> The name of the Load balancer. </summary>
        public string Name { get; set; }
        /// <summary> Specifies the frontend IP to be used for the load balancer. Only IPv4 frontend IP address is supported. Each load balancer configuration must have exactly one frontend IP configuration. </summary>
        public IList<LoadBalancerFrontendIPConfiguration> FrontendIPConfigurations { get; }
    }
}
