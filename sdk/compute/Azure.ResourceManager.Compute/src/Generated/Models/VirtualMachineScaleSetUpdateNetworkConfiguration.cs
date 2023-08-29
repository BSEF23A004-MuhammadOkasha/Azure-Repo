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
    /// <summary> Describes a virtual machine scale set network profile's network configurations. </summary>
    public partial class VirtualMachineScaleSetUpdateNetworkConfiguration : ComputeWriteableSubResourceData
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdateNetworkConfiguration"/>. </summary>
        public VirtualMachineScaleSetUpdateNetworkConfiguration()
        {
            IPConfigurations = new ChangeTrackingList<VirtualMachineScaleSetUpdateIPConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdateNetworkConfiguration"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> The network configuration name. </param>
        /// <param name="primary"> Whether this is a primary NIC on a virtual machine. </param>
        /// <param name="enableAcceleratedNetworking"> Specifies whether the network interface is accelerated networking-enabled. </param>
        /// <param name="isTcpStateTrackingDisabled"> Specifies whether the network interface is disabled for tcp state tracking. </param>
        /// <param name="enableFpga"> Specifies whether the network interface is FPGA networking-enabled. </param>
        /// <param name="networkSecurityGroup"> The network security group. </param>
        /// <param name="dnsSettings"> The dns settings to be applied on the network interfaces. </param>
        /// <param name="ipConfigurations"> The virtual machine scale set IP Configuration. </param>
        /// <param name="enableIPForwarding"> Whether IP forwarding enabled on this NIC. </param>
        /// <param name="deleteOption"> Specify what happens to the network interface when the VM is deleted. </param>
        /// <param name="auxiliaryMode"> Specifies whether the Auxiliary mode is enabled for the Network Interface resource. </param>
        /// <param name="auxiliarySku"> Specifies whether the Auxiliary sku is enabled for the Network Interface resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetUpdateNetworkConfiguration(ResourceIdentifier id, string name, bool? primary, bool? enableAcceleratedNetworking, bool? isTcpStateTrackingDisabled, bool? enableFpga, WritableSubResource networkSecurityGroup, VirtualMachineScaleSetNetworkConfigurationDnsSettings dnsSettings, IList<VirtualMachineScaleSetUpdateIPConfiguration> ipConfigurations, bool? enableIPForwarding, ComputeDeleteOption? deleteOption, ComputeNetworkInterfaceAuxiliaryMode? auxiliaryMode, ComputeNetworkInterfaceAuxiliarySku? auxiliarySku, Dictionary<string, BinaryData> rawData) : base(id, rawData)
        {
            Name = name;
            Primary = primary;
            EnableAcceleratedNetworking = enableAcceleratedNetworking;
            IsTcpStateTrackingDisabled = isTcpStateTrackingDisabled;
            EnableFpga = enableFpga;
            NetworkSecurityGroup = networkSecurityGroup;
            DnsSettings = dnsSettings;
            IPConfigurations = ipConfigurations;
            EnableIPForwarding = enableIPForwarding;
            DeleteOption = deleteOption;
            AuxiliaryMode = auxiliaryMode;
            AuxiliarySku = auxiliarySku;
        }

        /// <summary> The network configuration name. </summary>
        public string Name { get; set; }
        /// <summary> Whether this is a primary NIC on a virtual machine. </summary>
        public bool? Primary { get; set; }
        /// <summary> Specifies whether the network interface is accelerated networking-enabled. </summary>
        public bool? EnableAcceleratedNetworking { get; set; }
        /// <summary> Specifies whether the network interface is disabled for tcp state tracking. </summary>
        public bool? IsTcpStateTrackingDisabled { get; set; }
        /// <summary> Specifies whether the network interface is FPGA networking-enabled. </summary>
        public bool? EnableFpga { get; set; }
        /// <summary> The network security group. </summary>
        internal WritableSubResource NetworkSecurityGroup { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier NetworkSecurityGroupId
        {
            get => NetworkSecurityGroup is null ? default : NetworkSecurityGroup.Id;
            set
            {
                if (NetworkSecurityGroup is null)
                    NetworkSecurityGroup = new WritableSubResource();
                NetworkSecurityGroup.Id = value;
            }
        }

        /// <summary> The dns settings to be applied on the network interfaces. </summary>
        internal VirtualMachineScaleSetNetworkConfigurationDnsSettings DnsSettings { get; set; }
        /// <summary> List of DNS servers IP addresses. </summary>
        public IList<string> DnsServers
        {
            get
            {
                if (DnsSettings is null)
                    DnsSettings = new VirtualMachineScaleSetNetworkConfigurationDnsSettings();
                return DnsSettings.DnsServers;
            }
        }

        /// <summary> The virtual machine scale set IP Configuration. </summary>
        public IList<VirtualMachineScaleSetUpdateIPConfiguration> IPConfigurations { get; }
        /// <summary> Whether IP forwarding enabled on this NIC. </summary>
        public bool? EnableIPForwarding { get; set; }
        /// <summary> Specify what happens to the network interface when the VM is deleted. </summary>
        public ComputeDeleteOption? DeleteOption { get; set; }
        /// <summary> Specifies whether the Auxiliary mode is enabled for the Network Interface resource. </summary>
        public ComputeNetworkInterfaceAuxiliaryMode? AuxiliaryMode { get; set; }
        /// <summary> Specifies whether the Auxiliary sku is enabled for the Network Interface resource. </summary>
        public ComputeNetworkInterfaceAuxiliarySku? AuxiliarySku { get; set; }
    }
}
