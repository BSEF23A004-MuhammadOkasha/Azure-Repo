// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machine scale set network profile's network configurations. </summary>
    public partial class VirtualMachineScaleSetNetworkConfiguration : ComputeWriteableSubResourceData
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetNetworkConfiguration"/>. </summary>
        /// <param name="name"> The network configuration name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public VirtualMachineScaleSetNetworkConfiguration(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            IPConfigurations = new ChangeTrackingList<VirtualMachineScaleSetIPConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetNetworkConfiguration"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="name"> The network configuration name. </param>
        /// <param name="primary"> Specifies the primary network interface in case the virtual machine has more than 1 network interface. </param>
        /// <param name="enableAcceleratedNetworking"> Specifies whether the network interface is accelerated networking-enabled. </param>
        /// <param name="isTcpStateTrackingDisabled"> Specifies whether the network interface is disabled for tcp state tracking. </param>
        /// <param name="enableFpga"> Specifies whether the network interface is FPGA networking-enabled. </param>
        /// <param name="networkSecurityGroup"> The network security group. </param>
        /// <param name="dnsSettings"> The dns settings to be applied on the network interfaces. </param>
        /// <param name="ipConfigurations"> Specifies the IP configurations of the network interface. </param>
        /// <param name="enableIPForwarding"> Whether IP forwarding enabled on this NIC. </param>
        /// <param name="deleteOption"> Specify what happens to the network interface when the VM is deleted. </param>
        /// <param name="auxiliaryMode"> Specifies whether the Auxiliary mode is enabled for the Network Interface resource. </param>
        /// <param name="auxiliarySku"> Specifies whether the Auxiliary sku is enabled for the Network Interface resource. </param>
        internal VirtualMachineScaleSetNetworkConfiguration(ResourceIdentifier id, IDictionary<string, BinaryData> serializedAdditionalRawData, string name, bool? primary, bool? enableAcceleratedNetworking, bool? isTcpStateTrackingDisabled, bool? enableFpga, WritableSubResource networkSecurityGroup, VirtualMachineScaleSetNetworkConfigurationDnsSettings dnsSettings, IList<VirtualMachineScaleSetIPConfiguration> ipConfigurations, bool? enableIPForwarding, ComputeDeleteOption? deleteOption, ComputeNetworkInterfaceAuxiliaryMode? auxiliaryMode, ComputeNetworkInterfaceAuxiliarySku? auxiliarySku) : base(id, serializedAdditionalRawData)
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetNetworkConfiguration"/> for deserialization. </summary>
        internal VirtualMachineScaleSetNetworkConfiguration()
        {
        }

        /// <summary> The network configuration name. </summary>
        public string Name { get; set; }
        /// <summary> Specifies the primary network interface in case the virtual machine has more than 1 network interface. </summary>
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

        /// <summary> Specifies the IP configurations of the network interface. </summary>
        public IList<VirtualMachineScaleSetIPConfiguration> IPConfigurations { get; }
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
