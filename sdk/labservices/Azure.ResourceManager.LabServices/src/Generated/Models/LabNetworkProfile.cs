// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Profile for how to handle networking for Labs. </summary>
    public partial class LabNetworkProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LabNetworkProfile"/>. </summary>
        public LabNetworkProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LabNetworkProfile"/>. </summary>
        /// <param name="subnetId"> The external subnet resource id. </param>
        /// <param name="loadBalancerId"> The external load balancer resource id. </param>
        /// <param name="publicIPId"> The external public IP resource id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LabNetworkProfile(ResourceIdentifier subnetId, ResourceIdentifier loadBalancerId, ResourceIdentifier publicIPId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SubnetId = subnetId;
            LoadBalancerId = loadBalancerId;
            PublicIPId = publicIPId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The external subnet resource id. </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> The external load balancer resource id. </summary>
        public ResourceIdentifier LoadBalancerId { get; set; }
        /// <summary> The external public IP resource id. </summary>
        public ResourceIdentifier PublicIPId { get; set; }
    }
}
