// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Contains lab configuration and default settings. This variant is used for PATCH. </summary>
    public partial class LabPlanPatch : TrackedResourceUpdate
    {
        /// <summary> Initializes a new instance of LabPlanPatch. </summary>
        public LabPlanPatch()
        {
            AllowedRegions = new ChangeTrackingList<string>();
        }

        /// <summary> Managed Identity Information. Current supported identity types: SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The default lab connection profile. This can be changed on a lab resource and only provides a default profile. </summary>
        public ConnectionProfile DefaultConnectionProfile { get; set; }
        /// <summary> The default lab shutdown profile. This can be changed on a lab resource and only provides a default profile. </summary>
        public AutoShutdownProfile DefaultAutoShutdownProfile { get; set; }
        /// <summary> The lab plan network profile. To enforce lab network policies they must be defined here and cannot be changed when there are existing labs associated with this lab plan. </summary>
        internal LabPlanNetworkProfile DefaultNetworkProfile { get; set; }
        /// <summary> The external subnet resource id. </summary>
        public string DefaultNetworkSubnetId
        {
            get => DefaultNetworkProfile is null ? default : DefaultNetworkProfile.SubnetId;
            set
            {
                if (DefaultNetworkProfile is null)
                    DefaultNetworkProfile = new LabPlanNetworkProfile();
                DefaultNetworkProfile.SubnetId = value;
            }
        }

        /// <summary> The allowed regions for the lab creator to use when creating labs using this lab plan. </summary>
        public IList<string> AllowedRegions { get; }
        /// <summary> Resource ID of the Shared Image Gallery attached to this lab plan. When saving a lab template virtual machine image it will be persisted in this gallery. Shared images from the gallery can be made available to use when creating new labs. </summary>
        public string SharedGalleryId { get; set; }
        /// <summary> Support contact information and instructions for users of the lab plan. This information is displayed to lab owners and virtual machine users for all labs in the lab plan. </summary>
        public SupportInfo SupportInfo { get; set; }
        /// <summary> Base Url of the lms instance this lab plan can link lab rosters against. </summary>
        public string LinkedLmsInstance { get; set; }
    }
}
