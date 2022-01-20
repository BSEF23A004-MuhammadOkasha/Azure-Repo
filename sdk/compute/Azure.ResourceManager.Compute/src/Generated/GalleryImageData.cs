// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the GalleryImage data model. </summary>
    public partial class GalleryImageData : TrackedResource
    {
        /// <summary> Initializes a new instance of GalleryImageData. </summary>
        /// <param name="location"> The location. </param>
        public GalleryImageData(AzureLocation location) : base(location)
        {
            Features = new ChangeTrackingList<GalleryImageFeature>();
        }

        /// <summary> Initializes a new instance of GalleryImageData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="description"> The description of this gallery image definition resource. This property is updatable. </param>
        /// <param name="eula"> The Eula agreement for the gallery image definition. </param>
        /// <param name="privacyStatementUri"> The privacy statement uri. </param>
        /// <param name="releaseNoteUri"> The release note uri. </param>
        /// <param name="oSType"> This property allows you to specify the type of the OS that is included in the disk when creating a VM from a managed image. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**. </param>
        /// <param name="oSState"> This property allows the user to specify whether the virtual machines created under this image are &apos;Generalized&apos; or &apos;Specialized&apos;. </param>
        /// <param name="hyperVGeneration"> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </param>
        /// <param name="endOfLifeDate"> The end of life date of the gallery image definition. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <param name="identifier"> This is the gallery image definition identifier. </param>
        /// <param name="recommended"> The properties describe the recommended machine configuration for this Image Definition. These properties are updatable. </param>
        /// <param name="disallowed"> Describes the disallowed disk types. </param>
        /// <param name="purchasePlan"> Describes the gallery image definition purchase plan. This is used by marketplace images. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="features"> A list of gallery image features. </param>
        internal GalleryImageData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, string description, string eula, string privacyStatementUri, string releaseNoteUri, OperatingSystemTypes? oSType, OperatingSystemStateTypes? oSState, HyperVGeneration? hyperVGeneration, DateTimeOffset? endOfLifeDate, GalleryImageIdentifier identifier, RecommendedMachineConfiguration recommended, Disallowed disallowed, ImagePurchasePlan purchasePlan, GalleryImagePropertiesProvisioningState? provisioningState, IList<GalleryImageFeature> features) : base(id, name, type, tags, location)
        {
            Description = description;
            Eula = eula;
            PrivacyStatementUri = privacyStatementUri;
            ReleaseNoteUri = releaseNoteUri;
            OSType = oSType;
            OSState = oSState;
            HyperVGeneration = hyperVGeneration;
            EndOfLifeDate = endOfLifeDate;
            Identifier = identifier;
            Recommended = recommended;
            Disallowed = disallowed;
            PurchasePlan = purchasePlan;
            ProvisioningState = provisioningState;
            Features = features;
        }

        /// <summary> The description of this gallery image definition resource. This property is updatable. </summary>
        public string Description { get; set; }
        /// <summary> The Eula agreement for the gallery image definition. </summary>
        public string Eula { get; set; }
        /// <summary> The privacy statement uri. </summary>
        public string PrivacyStatementUri { get; set; }
        /// <summary> The release note uri. </summary>
        public string ReleaseNoteUri { get; set; }
        /// <summary> This property allows you to specify the type of the OS that is included in the disk when creating a VM from a managed image. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**. </summary>
        public OperatingSystemTypes? OSType { get; set; }
        /// <summary> This property allows the user to specify whether the virtual machines created under this image are &apos;Generalized&apos; or &apos;Specialized&apos;. </summary>
        public OperatingSystemStateTypes? OSState { get; set; }
        /// <summary> The hypervisor generation of the Virtual Machine. Applicable to OS disks only. </summary>
        public HyperVGeneration? HyperVGeneration { get; set; }
        /// <summary> The end of life date of the gallery image definition. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? EndOfLifeDate { get; set; }
        /// <summary> This is the gallery image definition identifier. </summary>
        public GalleryImageIdentifier Identifier { get; set; }
        /// <summary> The properties describe the recommended machine configuration for this Image Definition. These properties are updatable. </summary>
        public RecommendedMachineConfiguration Recommended { get; set; }
        /// <summary> Describes the disallowed disk types. </summary>
        public Disallowed Disallowed { get; set; }
        /// <summary> Describes the gallery image definition purchase plan. This is used by marketplace images. </summary>
        public ImagePurchasePlan PurchasePlan { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public GalleryImagePropertiesProvisioningState? ProvisioningState { get; }
        /// <summary> A list of gallery image features. </summary>
        public IList<GalleryImageFeature> Features { get; }
    }
}
