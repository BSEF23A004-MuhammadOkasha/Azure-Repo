// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevCenter.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing the DevCenterProjectEnvironment data model.
    /// Represents an environment type.
    /// </summary>
    public partial class DevCenterProjectEnvironmentData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DevCenterProjectEnvironmentData"/>. </summary>
        /// <param name="location"> The location. </param>
        public DevCenterProjectEnvironmentData(AzureLocation location) : base(location)
        {
            UserRoleAssignments = new ChangeTrackingDictionary<string, DevCenterUserRoleAssignments>();
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterProjectEnvironmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Managed identity properties. </param>
        /// <param name="deploymentTargetId"> Id of a subscription that the environment type will be mapped to. The environment's resources will be deployed into this subscription. </param>
        /// <param name="status"> Defines whether this Environment Type can be used in this Project. </param>
        /// <param name="creatorRoleAssignment"> The role definition assigned to the environment creator on backing resources. </param>
        /// <param name="userRoleAssignments"> Role Assignments created on environment backing resources. This is a mapping from a user object ID to an object of role definition IDs. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DevCenterProjectEnvironmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, ResourceIdentifier deploymentTargetId, EnvironmentTypeEnableStatus? status, ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment creatorRoleAssignment, IDictionary<string, DevCenterUserRoleAssignments> userRoleAssignments, DevCenterProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            DeploymentTargetId = deploymentTargetId;
            Status = status;
            CreatorRoleAssignment = creatorRoleAssignment;
            UserRoleAssignments = userRoleAssignments;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterProjectEnvironmentData"/> for deserialization. </summary>
        internal DevCenterProjectEnvironmentData()
        {
        }

        /// <summary> Managed identity properties. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Id of a subscription that the environment type will be mapped to. The environment's resources will be deployed into this subscription. </summary>
        public ResourceIdentifier DeploymentTargetId { get; set; }
        /// <summary> Defines whether this Environment Type can be used in this Project. </summary>
        public EnvironmentTypeEnableStatus? Status { get; set; }
        /// <summary> The role definition assigned to the environment creator on backing resources. </summary>
        internal ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment CreatorRoleAssignment { get; set; }
        /// <summary> A map of roles to assign to the environment creator. </summary>
        public IDictionary<string, DevCenterEnvironmentRole> Roles
        {
            get
            {
                if (CreatorRoleAssignment is null)
                    CreatorRoleAssignment = new ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment();
                return CreatorRoleAssignment.Roles;
            }
        }

        /// <summary> Role Assignments created on environment backing resources. This is a mapping from a user object ID to an object of role definition IDs. </summary>
        public IDictionary<string, DevCenterUserRoleAssignments> UserRoleAssignments { get; }
        /// <summary> The provisioning state of the resource. </summary>
        public DevCenterProvisioningState? ProvisioningState { get; }
    }
}
