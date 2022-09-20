// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Profile for how to handle networking for Labs. </summary>
    public partial class LabNetworkProfile
    {
        /// <summary> Initializes a new instance of LabNetworkProfile. </summary>
        public LabNetworkProfile()
        {
        }

        /// <summary> Initializes a new instance of LabNetworkProfile. </summary>
        /// <param name="subnetId"> The external subnet resource id. </param>
        /// <param name="loadBalancerId"> The external load balancer resource id. </param>
        /// <param name="publicIPId"> The external public IP resource id. </param>
        internal LabNetworkProfile(string subnetId, string loadBalancerId, string publicIPId)
        {
            SubnetId = subnetId;
            LoadBalancerId = loadBalancerId;
            PublicIPId = publicIPId;
        }

        /// <summary> The external subnet resource id. </summary>
        public string SubnetId { get; set; }
        /// <summary> The external load balancer resource id. </summary>
        public string LoadBalancerId { get; set; }
        /// <summary> The external public IP resource id. </summary>
        public string PublicIPId { get; set; }
    }
}
