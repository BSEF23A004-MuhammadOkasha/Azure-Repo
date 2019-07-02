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
    /// Parameters for Reimaging Virtual Machine. NOTE: Virtual Machine OS disk
    /// will always be reimaged
    /// </summary>
    public partial class VirtualMachineReimageParameters
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineReimageParameters
        /// class.
        /// </summary>
        public VirtualMachineReimageParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineReimageParameters
        /// class.
        /// </summary>
        /// <param name="tempDisk">Specifies whether to reimage temp disk.
        /// Default value: false. Note: This temp disk reimage parameter is
        /// only supported for VM/VMSS with Ephemeral OS disk.</param>
        public VirtualMachineReimageParameters(bool? tempDisk = default(bool?))
        {
            TempDisk = tempDisk;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies whether to reimage temp disk. Default value:
        /// false. Note: This temp disk reimage parameter is only supported for
        /// VM/VMSS with Ephemeral OS disk.
        /// </summary>
        [JsonProperty(PropertyName = "tempDisk")]
        public bool? TempDisk { get; set; }

    }
}
