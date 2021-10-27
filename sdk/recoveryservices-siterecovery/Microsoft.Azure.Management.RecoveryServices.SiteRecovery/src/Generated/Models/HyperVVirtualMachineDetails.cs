// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Single Host fabric provider specific VM settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HyperVVirtualMachine")]
    public partial class HyperVVirtualMachineDetails : ConfigurationSettings
    {
        /// <summary>
        /// Initializes a new instance of the HyperVVirtualMachineDetails
        /// class.
        /// </summary>
        public HyperVVirtualMachineDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HyperVVirtualMachineDetails
        /// class.
        /// </summary>
        /// <param name="sourceItemId">The source id of the object.</param>
        /// <param name="generation">The id of the object in fabric.</param>
        /// <param name="osDetails">The Last replication time.</param>
        /// <param name="diskDetails">The Last successful failover
        /// time.</param>
        /// <param name="hasPhysicalDisk">A value indicating whether the VM has
        /// a physical disk attached. String value of
        /// SrsDataContract.PresenceStatus enum. Possible values include:
        /// 'Unknown', 'Present', 'NotPresent'</param>
        /// <param name="hasFibreChannelAdapter">A value indicating whether the
        /// VM has a fibre channel adapter attached. String value of
        /// SrsDataContract.PresenceStatus enum. Possible values include:
        /// 'Unknown', 'Present', 'NotPresent'</param>
        /// <param name="hasSharedVhd">A value indicating whether the VM has a
        /// shared VHD attached. String value of SrsDataContract.PresenceStatus
        /// enum. Possible values include: 'Unknown', 'Present',
        /// 'NotPresent'</param>
        /// <param name="hyperVHostId">The Id of the hyper-v host in
        /// fabric.</param>
        public HyperVVirtualMachineDetails(string sourceItemId = default(string), string generation = default(string), OSDetails osDetails = default(OSDetails), IList<DiskDetails> diskDetails = default(IList<DiskDetails>), string hasPhysicalDisk = default(string), string hasFibreChannelAdapter = default(string), string hasSharedVhd = default(string), string hyperVHostId = default(string))
        {
            SourceItemId = sourceItemId;
            Generation = generation;
            OsDetails = osDetails;
            DiskDetails = diskDetails;
            HasPhysicalDisk = hasPhysicalDisk;
            HasFibreChannelAdapter = hasFibreChannelAdapter;
            HasSharedVhd = hasSharedVhd;
            HyperVHostId = hyperVHostId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the source id of the object.
        /// </summary>
        [JsonProperty(PropertyName = "sourceItemId")]
        public string SourceItemId { get; set; }

        /// <summary>
        /// Gets or sets the id of the object in fabric.
        /// </summary>
        [JsonProperty(PropertyName = "generation")]
        public string Generation { get; set; }

        /// <summary>
        /// Gets or sets the Last replication time.
        /// </summary>
        [JsonProperty(PropertyName = "osDetails")]
        public OSDetails OsDetails { get; set; }

        /// <summary>
        /// Gets or sets the Last successful failover time.
        /// </summary>
        [JsonProperty(PropertyName = "diskDetails")]
        public IList<DiskDetails> DiskDetails { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the VM has a physical disk
        /// attached. String value of SrsDataContract.PresenceStatus enum.
        /// Possible values include: 'Unknown', 'Present', 'NotPresent'
        /// </summary>
        [JsonProperty(PropertyName = "hasPhysicalDisk")]
        public string HasPhysicalDisk { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the VM has a fibre channel
        /// adapter attached. String value of SrsDataContract.PresenceStatus
        /// enum. Possible values include: 'Unknown', 'Present', 'NotPresent'
        /// </summary>
        [JsonProperty(PropertyName = "hasFibreChannelAdapter")]
        public string HasFibreChannelAdapter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the VM has a shared VHD
        /// attached. String value of SrsDataContract.PresenceStatus enum.
        /// Possible values include: 'Unknown', 'Present', 'NotPresent'
        /// </summary>
        [JsonProperty(PropertyName = "hasSharedVhd")]
        public string HasSharedVhd { get; set; }

        /// <summary>
        /// Gets or sets the Id of the hyper-v host in fabric.
        /// </summary>
        [JsonProperty(PropertyName = "hyperVHostId")]
        public string HyperVHostId { get; set; }

    }
}
