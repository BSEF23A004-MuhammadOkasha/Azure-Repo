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
    /// List of supported capabilities persisted on the disk resource for VM
    /// use.
    /// </summary>
    public partial class SupportedCapabilities
    {
        /// <summary>
        /// Initializes a new instance of the SupportedCapabilities class.
        /// </summary>
        public SupportedCapabilities()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SupportedCapabilities class.
        /// </summary>
        /// <param name="diskControllerTypes">The disk controllers that an OS
        /// disk supports. If set it can be SCSI or SCSI, NVME or NVME,
        /// SCSI.</param>
        /// <param name="acceleratedNetwork">True if the image from which the
        /// OS disk is created supports accelerated networking.</param>
        /// <param name="architecture">CPU architecture supported by an OS
        /// disk. Possible values include: 'x64', 'Arm64'</param>
        public SupportedCapabilities(string diskControllerTypes = default(string), bool? acceleratedNetwork = default(bool?), string architecture = default(string))
        {
            DiskControllerTypes = diskControllerTypes;
            AcceleratedNetwork = acceleratedNetwork;
            Architecture = architecture;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the disk controllers that an OS disk supports. If set
        /// it can be SCSI or SCSI, NVME or NVME, SCSI.
        /// </summary>
        [JsonProperty(PropertyName = "diskControllerTypes")]
        public string DiskControllerTypes { get; set; }

        /// <summary>
        /// Gets or sets true if the image from which the OS disk is created
        /// supports accelerated networking.
        /// </summary>
        [JsonProperty(PropertyName = "acceleratedNetwork")]
        public bool? AcceleratedNetwork { get; set; }

        /// <summary>
        /// Gets or sets CPU architecture supported by an OS disk. Possible
        /// values include: 'x64', 'Arm64'
        /// </summary>
        [JsonProperty(PropertyName = "architecture")]
        public string Architecture { get; set; }

    }
}
