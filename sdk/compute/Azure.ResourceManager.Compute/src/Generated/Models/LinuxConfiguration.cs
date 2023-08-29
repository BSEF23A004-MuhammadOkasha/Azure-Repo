// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the Linux operating system settings on the virtual machine. For a list of supported Linux distributions, see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros). </summary>
    public partial class LinuxConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LinuxConfiguration"/>. </summary>
        public LinuxConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinuxConfiguration"/>. </summary>
        /// <param name="isPasswordAuthenticationDisabled"> Specifies whether password authentication should be disabled. </param>
        /// <param name="ssh"> Specifies the ssh key configuration for a Linux OS. </param>
        /// <param name="provisionVmAgent"> Indicates whether virtual machine agent should be provisioned on the virtual machine. When this property is not specified in the request body, default behavior is to set it to true. This will ensure that VM Agent is installed on the VM so that extensions can be added to the VM later. </param>
        /// <param name="patchSettings"> [Preview Feature] Specifies settings related to VM Guest Patching on Linux. </param>
        /// <param name="isVmAgentPlatformUpdatesEnabled"> Indicates whether VMAgent Platform Updates is enabled for the Linux virtual machine. Default value is false. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LinuxConfiguration(bool? isPasswordAuthenticationDisabled, SshConfiguration ssh, bool? provisionVmAgent, LinuxPatchSettings patchSettings, bool? isVmAgentPlatformUpdatesEnabled, Dictionary<string, BinaryData> rawData)
        {
            IsPasswordAuthenticationDisabled = isPasswordAuthenticationDisabled;
            Ssh = ssh;
            ProvisionVmAgent = provisionVmAgent;
            PatchSettings = patchSettings;
            IsVmAgentPlatformUpdatesEnabled = isVmAgentPlatformUpdatesEnabled;
            _rawData = rawData;
        }

        /// <summary> Specifies whether password authentication should be disabled. </summary>
        public bool? IsPasswordAuthenticationDisabled { get; set; }
        /// <summary> Specifies the ssh key configuration for a Linux OS. </summary>
        internal SshConfiguration Ssh { get; set; }
        /// <summary> The list of SSH public keys used to authenticate with linux based VMs. </summary>
        public IList<SshPublicKeyConfiguration> SshPublicKeys
        {
            get
            {
                if (Ssh is null)
                    Ssh = new SshConfiguration();
                return Ssh.PublicKeys;
            }
        }

        /// <summary> Indicates whether virtual machine agent should be provisioned on the virtual machine. When this property is not specified in the request body, default behavior is to set it to true. This will ensure that VM Agent is installed on the VM so that extensions can be added to the VM later. </summary>
        public bool? ProvisionVmAgent { get; set; }
        /// <summary> [Preview Feature] Specifies settings related to VM Guest Patching on Linux. </summary>
        public LinuxPatchSettings PatchSettings { get; set; }
        /// <summary> Indicates whether VMAgent Platform Updates is enabled for the Linux virtual machine. Default value is false. </summary>
        public bool? IsVmAgentPlatformUpdatesEnabled { get; set; }
    }
}
