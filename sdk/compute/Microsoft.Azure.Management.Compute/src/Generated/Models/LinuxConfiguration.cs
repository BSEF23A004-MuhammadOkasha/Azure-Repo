// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies the Linux operating system settings on the virtual machine.
    /// &lt;br&gt;&lt;br&gt;For a list of supported Linux distributions, see
    /// [Linux on Azure-Endorsed
    /// Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    /// </summary>
    public partial class LinuxConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the LinuxConfiguration class.
        /// </summary>
        public LinuxConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LinuxConfiguration class.
        /// </summary>
        /// <param name="disablePasswordAuthentication">Specifies whether
        /// password authentication should be disabled.</param>
        /// <param name="ssh">Specifies the ssh key configuration for a Linux
        /// OS.</param>
        /// <param name="provisionVMAgent">Indicates whether virtual machine
        /// agent should be provisioned on the virtual machine.
        /// &lt;br&gt;&lt;br&gt; When this property is not specified in the
        /// request body, default behavior is to set it to true.  This will
        /// ensure that VM Agent is installed on the VM so that extensions can
        /// be added to the VM later.</param>
        /// <param name="patchSettings">[Preview Feature] Specifies settings
        /// related to VM Guest Patching on Linux.</param>
        public LinuxConfiguration(bool? disablePasswordAuthentication = default(bool?), SshConfiguration ssh = default(SshConfiguration), bool? provisionVMAgent = default(bool?), LinuxPatchSettings patchSettings = default(LinuxPatchSettings))
        {
            DisablePasswordAuthentication = disablePasswordAuthentication;
            Ssh = ssh;
            ProvisionVMAgent = provisionVMAgent;
            PatchSettings = patchSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies whether password authentication should be
        /// disabled.
        /// </summary>
        [JsonProperty(PropertyName = "disablePasswordAuthentication")]
        public bool? DisablePasswordAuthentication { get; set; }

        /// <summary>
        /// Gets or sets specifies the ssh key configuration for a Linux OS.
        /// </summary>
        [JsonProperty(PropertyName = "ssh")]
        public SshConfiguration Ssh { get; set; }

        /// <summary>
        /// Gets or sets indicates whether virtual machine agent should be
        /// provisioned on the virtual machine.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; When this property is not
        /// specified in the request body, default behavior is to set it to
        /// true.  This will ensure that VM Agent is installed on the VM so
        /// that extensions can be added to the VM later.
        /// </summary>
        [JsonProperty(PropertyName = "provisionVMAgent")]
        public bool? ProvisionVMAgent { get; set; }

        /// <summary>
        /// Gets or sets [Preview Feature] Specifies settings related to VM
        /// Guest Patching on Linux.
        /// </summary>
        [JsonProperty(PropertyName = "patchSettings")]
        public LinuxPatchSettings PatchSettings { get; set; }

    }
}
