// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machine scale set OS profile.
    /// </summary>
    public partial class VirtualMachineScaleSetOSProfile
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetOSProfile
        /// class.
        /// </summary>
        public VirtualMachineScaleSetOSProfile()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetOSProfile
        /// class.
        /// </summary>
        /// <param name="computerNamePrefix">The computer name prefix.</param>
        /// <param name="adminUsername">The admin user name.</param>
        /// <param name="adminPassword">The admin user password.</param>
        /// <param name="customData">A base-64 encoded string of custom
        /// data.</param>
        /// <param name="windowsConfiguration">The Windows Configuration of the
        /// OS profile.</param>
        /// <param name="linuxConfiguration">The Linux Configuration of the OS
        /// profile.</param>
        /// <param name="secrets">The List of certificates for addition to the
        /// VM.</param>
        public VirtualMachineScaleSetOSProfile(string computerNamePrefix = default(string), string adminUsername = default(string), string adminPassword = default(string), string customData = default(string), WindowsConfiguration windowsConfiguration = default(WindowsConfiguration), LinuxConfiguration linuxConfiguration = default(LinuxConfiguration), IList<VaultSecretGroup> secrets = default(IList<VaultSecretGroup>))
        {
            ComputerNamePrefix = computerNamePrefix;
            AdminUsername = adminUsername;
            AdminPassword = adminPassword;
            CustomData = customData;
            WindowsConfiguration = windowsConfiguration;
            LinuxConfiguration = linuxConfiguration;
            Secrets = secrets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the computer name prefix.
        /// </summary>
        [JsonProperty(PropertyName = "computerNamePrefix")]
        public string ComputerNamePrefix { get; set; }

        /// <summary>
        /// Gets or sets the admin user name.
        /// </summary>
        [JsonProperty(PropertyName = "adminUsername")]
        public string AdminUsername { get; set; }

        /// <summary>
        /// Gets or sets the admin user password.
        /// </summary>
        [JsonProperty(PropertyName = "adminPassword")]
        public string AdminPassword { get; set; }

        /// <summary>
        /// Gets or sets a base-64 encoded string of custom data.
        /// </summary>
        [JsonProperty(PropertyName = "customData")]
        public string CustomData { get; set; }

        /// <summary>
        /// Gets or sets the Windows Configuration of the OS profile.
        /// </summary>
        [JsonProperty(PropertyName = "windowsConfiguration")]
        public WindowsConfiguration WindowsConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the Linux Configuration of the OS profile.
        /// </summary>
        [JsonProperty(PropertyName = "linuxConfiguration")]
        public LinuxConfiguration LinuxConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the List of certificates for addition to the VM.
        /// </summary>
        [JsonProperty(PropertyName = "secrets")]
        public IList<VaultSecretGroup> Secrets { get; set; }

    }
}
