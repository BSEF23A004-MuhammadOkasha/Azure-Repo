// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> VirtualMachinePowerOffParameters represents the body of the request to power off virtual machine. </summary>
    public partial class VirtualMachinePowerOffContent
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachinePowerOffContent"/>. </summary>
        public VirtualMachinePowerOffContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachinePowerOffContent"/>. </summary>
        /// <param name="skipShutdown"> The indicator of whether to skip the graceful OS shutdown and power off the virtual machine immediately. </param>
        internal VirtualMachinePowerOffContent(SkipShutdown? skipShutdown)
        {
            SkipShutdown = skipShutdown;
        }

        /// <summary> The indicator of whether to skip the graceful OS shutdown and power off the virtual machine immediately. </summary>
        public SkipShutdown? SkipShutdown { get; set; }
    }
}
