// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.LabServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LabServices
{
    /// <summary> A class representing the LabVirtualMachine data model. </summary>
    public partial class LabVirtualMachineData : ResourceData
    {
        /// <summary> Initializes a new instance of LabVirtualMachineData. </summary>
        public LabVirtualMachineData()
        {
        }

        /// <summary> Initializes a new instance of LabVirtualMachineData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Current provisioning state of the virtual machine. </param>
        /// <param name="state"> The current state of the virtual machine. </param>
        /// <param name="connectionProfile"> Profile for information about connecting to the virtual machine. </param>
        /// <param name="claimedByUserId"> The lab user ID (not the PUID!) of who claimed the virtual machine. </param>
        /// <param name="vmType"> The type of this VM resource. </param>
        internal LabVirtualMachineData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, LabServicesProvisioningState? provisioningState, LabVirtualMachineState? state, LabVirtualMachineConnectionProfile connectionProfile, string claimedByUserId, LabVirtualMachineType? vmType) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            State = state;
            ConnectionProfile = connectionProfile;
            ClaimedByUserId = claimedByUserId;
            VmType = vmType;
        }

        /// <summary> Current provisioning state of the virtual machine. </summary>
        public LabServicesProvisioningState? ProvisioningState { get; }
        /// <summary> The current state of the virtual machine. </summary>
        public LabVirtualMachineState? State { get; }
        /// <summary> Profile for information about connecting to the virtual machine. </summary>
        public LabVirtualMachineConnectionProfile ConnectionProfile { get; }
        /// <summary> The lab user ID (not the PUID!) of who claimed the virtual machine. </summary>
        public string ClaimedByUserId { get; }
        /// <summary> The type of this VM resource. </summary>
        public LabVirtualMachineType? VmType { get; }
    }
}
