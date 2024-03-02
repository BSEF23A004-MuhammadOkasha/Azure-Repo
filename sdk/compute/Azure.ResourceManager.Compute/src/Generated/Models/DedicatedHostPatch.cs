// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the dedicated host. Only tags, autoReplaceOnFailure and licenseType may be updated. </summary>
    public partial class DedicatedHostPatch : ComputeResourcePatch
    {
        /// <summary> Initializes a new instance of <see cref="DedicatedHostPatch"/>. </summary>
        public DedicatedHostPatch()
        {
            VirtualMachines = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="DedicatedHostPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="sku"> [List all available dedicated host sizes for resizing] (https://docs.microsoft.com/rest/api/compute/dedicated-hosts/listavailablesizes). Resizing can be only used to scale up DedicatedHost. Only name is required to be set. </param>
        /// <param name="platformFaultDomain"> Fault domain of the dedicated host within a dedicated host group. </param>
        /// <param name="autoReplaceOnFailure"> Specifies whether the dedicated host should be replaced automatically in case of a failure. The value is defaulted to 'true' when not provided. </param>
        /// <param name="hostId"> A unique id generated and assigned to the dedicated host by the platform. Does not change throughout the lifetime of the host. </param>
        /// <param name="virtualMachines"> A list of references to all virtual machines in the Dedicated Host. </param>
        /// <param name="licenseType"> Specifies the software license type that will be applied to the VMs deployed on the dedicated host. Possible values are: **None,** **Windows_Server_Hybrid,** **Windows_Server_Perpetual.** The default value is: **None.**. </param>
        /// <param name="provisioningOn"> The date when the host was first provisioned. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="instanceView"> The dedicated host instance view. </param>
        /// <param name="timeCreated"> Specifies the time at which the Dedicated Host resource was created. Minimum api-version: 2021-11-01. </param>
        internal DedicatedHostPatch(IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ComputeSku sku, int? platformFaultDomain, bool? autoReplaceOnFailure, string hostId, IReadOnlyList<SubResource> virtualMachines, DedicatedHostLicenseType? licenseType, DateTimeOffset? provisioningOn, string provisioningState, DedicatedHostInstanceView instanceView, DateTimeOffset? timeCreated) : base(tags, serializedAdditionalRawData)
        {
            Sku = sku;
            PlatformFaultDomain = platformFaultDomain;
            AutoReplaceOnFailure = autoReplaceOnFailure;
            HostId = hostId;
            VirtualMachines = virtualMachines;
            LicenseType = licenseType;
            ProvisioningOn = provisioningOn;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
            TimeCreated = timeCreated;
        }

        /// <summary> [List all available dedicated host sizes for resizing] (https://docs.microsoft.com/rest/api/compute/dedicated-hosts/listavailablesizes). Resizing can be only used to scale up DedicatedHost. Only name is required to be set. </summary>
        public ComputeSku Sku { get; set; }
        /// <summary> Fault domain of the dedicated host within a dedicated host group. </summary>
        public int? PlatformFaultDomain { get; set; }
        /// <summary> Specifies whether the dedicated host should be replaced automatically in case of a failure. The value is defaulted to 'true' when not provided. </summary>
        public bool? AutoReplaceOnFailure { get; set; }
        /// <summary> A unique id generated and assigned to the dedicated host by the platform. Does not change throughout the lifetime of the host. </summary>
        public string HostId { get; }
        /// <summary> A list of references to all virtual machines in the Dedicated Host. </summary>
        public IReadOnlyList<SubResource> VirtualMachines { get; }
        /// <summary> Specifies the software license type that will be applied to the VMs deployed on the dedicated host. Possible values are: **None,** **Windows_Server_Hybrid,** **Windows_Server_Perpetual.** The default value is: **None.**. </summary>
        public DedicatedHostLicenseType? LicenseType { get; set; }
        /// <summary> The date when the host was first provisioned. </summary>
        public DateTimeOffset? ProvisioningOn { get; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The dedicated host instance view. </summary>
        public DedicatedHostInstanceView InstanceView { get; }
        /// <summary> Specifies the time at which the Dedicated Host resource was created. Minimum api-version: 2021-11-01. </summary>
        public DateTimeOffset? TimeCreated { get; }
    }
}
