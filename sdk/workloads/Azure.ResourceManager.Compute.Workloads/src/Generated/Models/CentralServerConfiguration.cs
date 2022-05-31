// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    /// <summary> Gets or sets the central server configuration. </summary>
    public partial class CentralServerConfiguration
    {
        /// <summary> Initializes a new instance of CentralServerConfiguration. </summary>
        /// <param name="subnetId"> The subnet id. </param>
        /// <param name="virtualMachineConfiguration"> Gets or sets the virtual machine configuration. </param>
        /// <param name="instanceCount"> The number of central server VMs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnetId"/> or <paramref name="virtualMachineConfiguration"/> is null. </exception>
        public CentralServerConfiguration(string subnetId, VirtualMachineConfiguration virtualMachineConfiguration, long instanceCount)
        {
            if (subnetId == null)
            {
                throw new ArgumentNullException(nameof(subnetId));
            }
            if (virtualMachineConfiguration == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineConfiguration));
            }

            SubnetId = subnetId;
            VirtualMachineConfiguration = virtualMachineConfiguration;
            InstanceCount = instanceCount;
        }

        /// <summary> The subnet id. </summary>
        public string SubnetId { get; set; }
        /// <summary> Gets or sets the virtual machine configuration. </summary>
        public VirtualMachineConfiguration VirtualMachineConfiguration { get; set; }
        /// <summary> The number of central server VMs. </summary>
        public long InstanceCount { get; set; }
    }
}
