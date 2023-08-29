// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machines scale set IP Configuration's PublicIPAddress configuration. </summary>
    public partial class VirtualMachineScaleSetUpdatePublicIPAddressConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdatePublicIPAddressConfiguration"/>. </summary>
        public VirtualMachineScaleSetUpdatePublicIPAddressConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdatePublicIPAddressConfiguration"/>. </summary>
        /// <param name="name"> The publicIP address configuration name. </param>
        /// <param name="idleTimeoutInMinutes"> The idle timeout of the public IP address. </param>
        /// <param name="dnsSettings"> The dns settings to be applied on the publicIP addresses . </param>
        /// <param name="publicIPPrefix"> The PublicIPPrefix from which to allocate publicIP addresses. </param>
        /// <param name="deleteOption"> Specify what happens to the public IP when the VM is deleted. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetUpdatePublicIPAddressConfiguration(string name, int? idleTimeoutInMinutes, VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings dnsSettings, WritableSubResource publicIPPrefix, ComputeDeleteOption? deleteOption, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            DnsSettings = dnsSettings;
            PublicIPPrefix = publicIPPrefix;
            DeleteOption = deleteOption;
            _rawData = rawData;
        }

        /// <summary> The publicIP address configuration name. </summary>
        public string Name { get; set; }
        /// <summary> The idle timeout of the public IP address. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
        /// <summary> The dns settings to be applied on the publicIP addresses . </summary>
        public VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings DnsSettings { get; set; }
        /// <summary> The PublicIPPrefix from which to allocate publicIP addresses. </summary>
        internal WritableSubResource PublicIPPrefix { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PublicIPPrefixId
        {
            get => PublicIPPrefix is null ? default : PublicIPPrefix.Id;
            set
            {
                if (PublicIPPrefix is null)
                    PublicIPPrefix = new WritableSubResource();
                PublicIPPrefix.Id = value;
            }
        }

        /// <summary> Specify what happens to the public IP when the VM is deleted. </summary>
        public ComputeDeleteOption? DeleteOption { get; set; }
    }
}
