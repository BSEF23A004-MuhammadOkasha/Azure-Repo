// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The ip configurations for the private link service. </summary>
    public partial class HDInsightIPConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightIPConfiguration"/>. </summary>
        /// <param name="name"> The name of private link IP configuration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public HDInsightIPConfiguration(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightIPConfiguration"/>. </summary>
        /// <param name="id"> The private link IP configuration id. </param>
        /// <param name="name"> The name of private link IP configuration. </param>
        /// <param name="resourceType"> The type of the private link IP configuration. </param>
        /// <param name="provisioningState"> The private link configuration provisioning state, which only appears in the response. </param>
        /// <param name="isPrimary"> Indicates whether this IP configuration is primary for the corresponding NIC. </param>
        /// <param name="privateIPAddress"> The IP address. </param>
        /// <param name="privateIPAllocationMethod"> The method that private IP address is allocated. </param>
        /// <param name="subnet"> The subnet resource id. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightIPConfiguration(ResourceIdentifier id, string name, ResourceType? resourceType, HDInsightPrivateLinkConfigurationProvisioningState? provisioningState, bool? isPrimary, IPAddress privateIPAddress, HDInsightPrivateIPAllocationMethod? privateIPAllocationMethod, WritableSubResource subnet, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
            ProvisioningState = provisioningState;
            IsPrimary = isPrimary;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightIPConfiguration"/> for deserialization. </summary>
        internal HDInsightIPConfiguration()
        {
        }

        /// <summary> The private link IP configuration id. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> The name of private link IP configuration. </summary>
        public string Name { get; set; }
        /// <summary> The type of the private link IP configuration. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> The private link configuration provisioning state, which only appears in the response. </summary>
        public HDInsightPrivateLinkConfigurationProvisioningState? ProvisioningState { get; }
        /// <summary> Indicates whether this IP configuration is primary for the corresponding NIC. </summary>
        public bool? IsPrimary { get; set; }
        /// <summary> The IP address. </summary>
        public IPAddress PrivateIPAddress { get; set; }
        /// <summary> The method that private IP address is allocated. </summary>
        public HDInsightPrivateIPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary> The subnet resource id. </summary>
        internal WritableSubResource Subnet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SubnetId
        {
            get => Subnet is null ? default : Subnet.Id;
            set
            {
                if (Subnet is null)
                    Subnet = new WritableSubResource();
                Subnet.Id = value;
            }
        }
    }
}
