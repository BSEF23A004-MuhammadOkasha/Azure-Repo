// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> BareMetalMachineReplaceParameters represents the body of the request to physically swap a bare metal machine for another. </summary>
    public partial class BareMetalMachineReplaceContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineReplaceContent"/>. </summary>
        public BareMetalMachineReplaceContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineReplaceContent"/>. </summary>
        /// <param name="bmcCredentials"> The credentials of the baseboard management controller on this bare metal machine. </param>
        /// <param name="bmcMacAddress"> The MAC address of the BMC device. </param>
        /// <param name="bootMacAddress"> The MAC address of a NIC connected to the PXE network. </param>
        /// <param name="machineName"> The OS-level hostname assigned to this machine. </param>
        /// <param name="serialNumber"> The serial number of the bare metal machine. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BareMetalMachineReplaceContent(AdministrativeCredentials bmcCredentials, string bmcMacAddress, string bootMacAddress, string machineName, string serialNumber, Dictionary<string, BinaryData> rawData)
        {
            BmcCredentials = bmcCredentials;
            BmcMacAddress = bmcMacAddress;
            BootMacAddress = bootMacAddress;
            MachineName = machineName;
            SerialNumber = serialNumber;
            _rawData = rawData;
        }

        /// <summary> The credentials of the baseboard management controller on this bare metal machine. </summary>
        public AdministrativeCredentials BmcCredentials { get; set; }
        /// <summary> The MAC address of the BMC device. </summary>
        public string BmcMacAddress { get; set; }
        /// <summary> The MAC address of a NIC connected to the PXE network. </summary>
        public string BootMacAddress { get; set; }
        /// <summary> The OS-level hostname assigned to this machine. </summary>
        public string MachineName { get; set; }
        /// <summary> The serial number of the bare metal machine. </summary>
        public string SerialNumber { get; set; }
    }
}
