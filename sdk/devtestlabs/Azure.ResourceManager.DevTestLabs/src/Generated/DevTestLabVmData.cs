// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing the DevTestLabVm data model.
    /// A virtual machine.
    /// </summary>
    public partial class DevTestLabVmData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DevTestLabVmData"/>. </summary>
        /// <param name="location"> The location. </param>
        public DevTestLabVmData(AzureLocation location) : base(location)
        {
            Artifacts = new ChangeTrackingList<DevTestLabArtifactInstallInfo>();
            DataDiskParameters = new ChangeTrackingList<DevTestLabDataDiskProperties>();
            ScheduleParameters = new ChangeTrackingList<DevTestLabScheduleCreationParameter>();
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabVmData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="notes"> The notes of the virtual machine. </param>
        /// <param name="ownerObjectId"> The object identifier of the owner of the virtual machine. </param>
        /// <param name="ownerUserPrincipalName"> The user principal name of the virtual machine owner. </param>
        /// <param name="createdByUserId"> The object identifier of the creator of the virtual machine. </param>
        /// <param name="createdByUser"> The email address of creator of the virtual machine. </param>
        /// <param name="createdOn"> The creation date of the virtual machine. </param>
        /// <param name="computeId"> The resource identifier (Microsoft.Compute) of the virtual machine. </param>
        /// <param name="customImageId"> The custom image identifier of the virtual machine. </param>
        /// <param name="osType"> The OS type of the virtual machine. </param>
        /// <param name="size"> The size of the virtual machine. </param>
        /// <param name="userName"> The user name of the virtual machine. </param>
        /// <param name="password"> The password of the virtual machine administrator. </param>
        /// <param name="sshKey"> The SSH key of the virtual machine administrator. </param>
        /// <param name="isAuthenticationWithSshKey"> Indicates whether this virtual machine uses an SSH key for authentication. </param>
        /// <param name="fqdn"> The fully-qualified domain name of the virtual machine. </param>
        /// <param name="labSubnetName"> The lab subnet name of the virtual machine. </param>
        /// <param name="labVirtualNetworkId"> The lab virtual network identifier of the virtual machine. </param>
        /// <param name="disallowPublicIPAddress"> Indicates whether the virtual machine is to be created without a public IP address. </param>
        /// <param name="artifacts"> The artifacts to be installed on the virtual machine. </param>
        /// <param name="artifactDeploymentStatus"> The artifact deployment status for the virtual machine. </param>
        /// <param name="galleryImageReference"> The Microsoft Azure Marketplace image reference of the virtual machine. </param>
        /// <param name="planId"> The id of the plan associated with the virtual machine image. </param>
        /// <param name="computeVm"> The compute virtual machine properties. </param>
        /// <param name="networkInterface"> The network interface properties. </param>
        /// <param name="applicableSchedule"> The applicable schedule for the virtual machine. </param>
        /// <param name="expireOn"> The expiration date for VM. </param>
        /// <param name="allowClaim"> Indicates whether another user can take ownership of the virtual machine. </param>
        /// <param name="storageType"> Storage type to use for virtual machine (i.e. Standard, Premium). </param>
        /// <param name="vmCreationSource"> Tells source of creation of lab virtual machine. Output property only. </param>
        /// <param name="environmentId"> The resource ID of the environment that contains this virtual machine, if any. </param>
        /// <param name="dataDiskParameters"> New or existing data disks to attach to the virtual machine after creation. </param>
        /// <param name="scheduleParameters"> Virtual Machine schedules to be created. </param>
        /// <param name="lastKnownPowerState"> Last known compute power state captured in DTL. </param>
        /// <param name="provisioningState"> The provisioning status of the resource. </param>
        /// <param name="uniqueIdentifier"> The unique immutable identifier of a resource (Guid). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabVmData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string notes, string ownerObjectId, string ownerUserPrincipalName, string createdByUserId, string createdByUser, DateTimeOffset? createdOn, ResourceIdentifier computeId, string customImageId, string osType, string size, string userName, string password, string sshKey, bool? isAuthenticationWithSshKey, string fqdn, string labSubnetName, ResourceIdentifier labVirtualNetworkId, bool? disallowPublicIPAddress, IList<DevTestLabArtifactInstallInfo> artifacts, DevTestLabArtifactDeploymentStatus artifactDeploymentStatus, DevTestLabGalleryImageReference galleryImageReference, string planId, ComputeVmProperties computeVm, DevTestLabNetworkInterface networkInterface, DevTestLabApplicableSchedule applicableSchedule, DateTimeOffset? expireOn, bool? allowClaim, string storageType, DevTestLabVmCreationSource? vmCreationSource, ResourceIdentifier environmentId, IList<DevTestLabDataDiskProperties> dataDiskParameters, IList<DevTestLabScheduleCreationParameter> scheduleParameters, string lastKnownPowerState, string provisioningState, Guid? uniqueIdentifier, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Notes = notes;
            OwnerObjectId = ownerObjectId;
            OwnerUserPrincipalName = ownerUserPrincipalName;
            CreatedByUserId = createdByUserId;
            CreatedByUser = createdByUser;
            CreatedOn = createdOn;
            ComputeId = computeId;
            CustomImageId = customImageId;
            OSType = osType;
            Size = size;
            UserName = userName;
            Password = password;
            SshKey = sshKey;
            IsAuthenticationWithSshKey = isAuthenticationWithSshKey;
            Fqdn = fqdn;
            LabSubnetName = labSubnetName;
            LabVirtualNetworkId = labVirtualNetworkId;
            DisallowPublicIPAddress = disallowPublicIPAddress;
            Artifacts = artifacts;
            ArtifactDeploymentStatus = artifactDeploymentStatus;
            GalleryImageReference = galleryImageReference;
            PlanId = planId;
            ComputeVm = computeVm;
            NetworkInterface = networkInterface;
            ApplicableSchedule = applicableSchedule;
            ExpireOn = expireOn;
            AllowClaim = allowClaim;
            StorageType = storageType;
            VmCreationSource = vmCreationSource;
            EnvironmentId = environmentId;
            DataDiskParameters = dataDiskParameters;
            ScheduleParameters = scheduleParameters;
            LastKnownPowerState = lastKnownPowerState;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabVmData"/> for deserialization. </summary>
        internal DevTestLabVmData()
        {
        }

        /// <summary> The notes of the virtual machine. </summary>
        public string Notes { get; set; }
        /// <summary> The object identifier of the owner of the virtual machine. </summary>
        public string OwnerObjectId { get; set; }
        /// <summary> The user principal name of the virtual machine owner. </summary>
        public string OwnerUserPrincipalName { get; set; }
        /// <summary> The object identifier of the creator of the virtual machine. </summary>
        public string CreatedByUserId { get; }
        /// <summary> The email address of creator of the virtual machine. </summary>
        public string CreatedByUser { get; }
        /// <summary> The creation date of the virtual machine. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> The resource identifier (Microsoft.Compute) of the virtual machine. </summary>
        public ResourceIdentifier ComputeId { get; }
        /// <summary> The custom image identifier of the virtual machine. </summary>
        public string CustomImageId { get; set; }
        /// <summary> The OS type of the virtual machine. </summary>
        public string OSType { get; }
        /// <summary> The size of the virtual machine. </summary>
        public string Size { get; set; }
        /// <summary> The user name of the virtual machine. </summary>
        public string UserName { get; set; }
        /// <summary> The password of the virtual machine administrator. </summary>
        public string Password { get; set; }
        /// <summary> The SSH key of the virtual machine administrator. </summary>
        public string SshKey { get; set; }
        /// <summary> Indicates whether this virtual machine uses an SSH key for authentication. </summary>
        public bool? IsAuthenticationWithSshKey { get; set; }
        /// <summary> The fully-qualified domain name of the virtual machine. </summary>
        public string Fqdn { get; }
        /// <summary> The lab subnet name of the virtual machine. </summary>
        public string LabSubnetName { get; set; }
        /// <summary> The lab virtual network identifier of the virtual machine. </summary>
        public ResourceIdentifier LabVirtualNetworkId { get; set; }
        /// <summary> Indicates whether the virtual machine is to be created without a public IP address. </summary>
        public bool? DisallowPublicIPAddress { get; set; }
        /// <summary> The artifacts to be installed on the virtual machine. </summary>
        public IList<DevTestLabArtifactInstallInfo> Artifacts { get; }
        /// <summary> The artifact deployment status for the virtual machine. </summary>
        public DevTestLabArtifactDeploymentStatus ArtifactDeploymentStatus { get; }
        /// <summary> The Microsoft Azure Marketplace image reference of the virtual machine. </summary>
        public DevTestLabGalleryImageReference GalleryImageReference { get; set; }
        /// <summary> The id of the plan associated with the virtual machine image. </summary>
        public string PlanId { get; set; }
        /// <summary> The compute virtual machine properties. </summary>
        public ComputeVmProperties ComputeVm { get; }
        /// <summary> The network interface properties. </summary>
        public DevTestLabNetworkInterface NetworkInterface { get; set; }
        /// <summary> The applicable schedule for the virtual machine. </summary>
        public DevTestLabApplicableSchedule ApplicableSchedule { get; }
        /// <summary> The expiration date for VM. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> Indicates whether another user can take ownership of the virtual machine. </summary>
        public bool? AllowClaim { get; set; }
        /// <summary> Storage type to use for virtual machine (i.e. Standard, Premium). </summary>
        public string StorageType { get; set; }
        /// <summary> Tells source of creation of lab virtual machine. Output property only. </summary>
        public DevTestLabVmCreationSource? VmCreationSource { get; }
        /// <summary> The resource ID of the environment that contains this virtual machine, if any. </summary>
        public ResourceIdentifier EnvironmentId { get; set; }
        /// <summary> New or existing data disks to attach to the virtual machine after creation. </summary>
        public IList<DevTestLabDataDiskProperties> DataDiskParameters { get; }
        /// <summary> Virtual Machine schedules to be created. </summary>
        public IList<DevTestLabScheduleCreationParameter> ScheduleParameters { get; }
        /// <summary> Last known compute power state captured in DTL. </summary>
        public string LastKnownPowerState { get; }
        /// <summary> The provisioning status of the resource. </summary>
        public string ProvisioningState { get; }
        /// <summary> The unique immutable identifier of a resource (Guid). </summary>
        public Guid? UniqueIdentifier { get; }
    }
}
