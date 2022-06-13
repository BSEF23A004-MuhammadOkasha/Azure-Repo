// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the gallery image definition that you want to update. </summary>
    public partial class GalleryImagePatch : GalleryUpdateResourceData
    {
        /// <summary> Initializes a new instance of GalleryImagePatch. </summary>
        public GalleryImagePatch()
        {
            Features = new ChangeTrackingList<GalleryImageFeature>();
        }

        /// <summary> The description of this gallery image definition resource. This property is updatable. </summary>
        public string Description { get; set; }
        /// <summary> The Eula agreement for the gallery image definition. </summary>
        public string Eula { get; set; }
        /// <summary> The privacy statement uri. </summary>
        public Uri PrivacyStatementUri { get; set; }
        /// <summary> The release note uri. </summary>
        public Uri ReleaseNoteUri { get; set; }
        /// <summary> This property allows you to specify the type of the OS that is included in the disk when creating a VM from a managed image. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**. </summary>
        public OperatingSystemTypes? OSType { get; set; }
        /// <summary> This property allows the user to specify whether the virtual machines created under this image are &apos;Generalized&apos; or &apos;Specialized&apos;. </summary>
        public OperatingSystemStateTypes? OSState { get; set; }
        /// <summary> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </summary>
        public HyperVGeneration? HyperVGeneration { get; set; }
        /// <summary> The end of life date of the gallery image definition. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? EndOfLifeOn { get; set; }
        /// <summary> This is the gallery image definition identifier. </summary>
        public GalleryImageIdentifier Identifier { get; set; }
        /// <summary> The properties describe the recommended machine configuration for this Image Definition. These properties are updatable. </summary>
        public RecommendedMachineConfiguration Recommended { get; set; }
        /// <summary> Describes the disallowed disk types. </summary>
        internal Disallowed Disallowed { get; set; }
        /// <summary> A list of disk types. </summary>
        public IList<string> DisallowedDiskTypes
        {
            get
            {
                if (Disallowed is null)
                    Disallowed = new Disallowed();
                return Disallowed.DiskTypes;
            }
        }

        /// <summary> Describes the gallery image definition purchase plan. This is used by marketplace images. </summary>
        public ImagePurchasePlan PurchasePlan { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public GalleryProvisioningState? ProvisioningState { get; }
        /// <summary> A list of gallery image features. </summary>
        public IList<GalleryImageFeature> Features { get; }
        /// <summary> The architecture of the image. Applicable to OS disks only. </summary>
        public ArchitectureTypes? Architecture { get; set; }
    }
}
