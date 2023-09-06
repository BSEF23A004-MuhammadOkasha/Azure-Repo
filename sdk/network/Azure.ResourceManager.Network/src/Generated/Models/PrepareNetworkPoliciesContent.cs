// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Details of PrepareNetworkPolicies for Subnet. </summary>
    public partial class PrepareNetworkPoliciesContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrepareNetworkPoliciesContent"/>. </summary>
        public PrepareNetworkPoliciesContent()
        {
            NetworkIntentPolicyConfigurations = new ChangeTrackingList<NetworkIntentPolicyConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="PrepareNetworkPoliciesContent"/>. </summary>
        /// <param name="serviceName"> The name of the service for which subnet is being prepared for. </param>
        /// <param name="networkIntentPolicyConfigurations"> A list of NetworkIntentPolicyConfiguration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrepareNetworkPoliciesContent(string serviceName, IList<NetworkIntentPolicyConfiguration> networkIntentPolicyConfigurations, Dictionary<string, BinaryData> rawData)
        {
            ServiceName = serviceName;
            NetworkIntentPolicyConfigurations = networkIntentPolicyConfigurations;
            _rawData = rawData;
        }

        /// <summary> The name of the service for which subnet is being prepared for. </summary>
        public string ServiceName { get; set; }
        /// <summary> A list of NetworkIntentPolicyConfiguration. </summary>
        public IList<NetworkIntentPolicyConfiguration> NetworkIntentPolicyConfigurations { get; }
    }
}
