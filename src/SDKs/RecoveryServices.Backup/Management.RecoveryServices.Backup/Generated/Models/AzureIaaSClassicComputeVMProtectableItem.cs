// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// IaaS VM workload-specific backup item representing the Classic Compute
    /// VM.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.ClassicCompute/virtualMachines")]
    public partial class AzureIaaSClassicComputeVMProtectableItem : IaaSVMProtectableItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureIaaSClassicComputeVMProtectableItem class.
        /// </summary>
        public AzureIaaSClassicComputeVMProtectableItem()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureIaaSClassicComputeVMProtectableItem class.
        /// </summary>
        /// <param name="backupManagementType">Type of backup managemenent to
        /// backup an item.</param>
        /// <param name="friendlyName">Friendly name of the backup
        /// item.</param>
        /// <param name="protectionState">State of the back up item. Possible
        /// values include: 'Invalid', 'NotProtected', 'Protecting',
        /// 'Protected'</param>
        /// <param name="virtualMachineId">Fully qualified ARM ID of the
        /// virtual machine.</param>
        public AzureIaaSClassicComputeVMProtectableItem(string backupManagementType = default(string), string friendlyName = default(string), string protectionState = default(string), string virtualMachineId = default(string))
            : base(backupManagementType, friendlyName, protectionState, virtualMachineId)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
