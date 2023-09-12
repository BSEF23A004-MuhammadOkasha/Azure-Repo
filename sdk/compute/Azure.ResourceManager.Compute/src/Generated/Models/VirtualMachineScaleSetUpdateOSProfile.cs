// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machine scale set OS profile. </summary>
    public partial class VirtualMachineScaleSetUpdateOSProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdateOSProfile"/>. </summary>
        public VirtualMachineScaleSetUpdateOSProfile()
        {
            Secrets = new ChangeTrackingList<VaultSecretGroup>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdateOSProfile"/>. </summary>
        /// <param name="customData"> A base-64 encoded string of custom data. </param>
        /// <param name="windowsConfiguration"> The Windows Configuration of the OS profile. </param>
        /// <param name="linuxConfiguration"> The Linux Configuration of the OS profile. </param>
        /// <param name="secrets"> The List of certificates for addition to the VM. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetUpdateOSProfile(string customData, WindowsConfiguration windowsConfiguration, LinuxConfiguration linuxConfiguration, IList<VaultSecretGroup> secrets, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CustomData = customData;
            WindowsConfiguration = windowsConfiguration;
            LinuxConfiguration = linuxConfiguration;
            Secrets = secrets;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A base-64 encoded string of custom data. </summary>
        public string CustomData { get; set; }
        /// <summary> The Windows Configuration of the OS profile. </summary>
        public WindowsConfiguration WindowsConfiguration { get; set; }
        /// <summary> The Linux Configuration of the OS profile. </summary>
        public LinuxConfiguration LinuxConfiguration { get; set; }
        /// <summary> The List of certificates for addition to the VM. </summary>
        public IList<VaultSecretGroup> Secrets { get; }
    }
}
