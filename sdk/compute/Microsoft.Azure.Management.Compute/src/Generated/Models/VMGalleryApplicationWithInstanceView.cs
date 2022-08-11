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

    public partial class VMGalleryApplicationWithInstanceView : VMGalleryApplication
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VMGalleryApplicationWithInstanceView class.
        /// </summary>
        public VMGalleryApplicationWithInstanceView()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VMGalleryApplicationWithInstanceView class.
        /// </summary>
        /// <param name="packageReferenceId">Specifies the
        /// GalleryApplicationVersion resource id on the form of
        /// /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}</param>
        /// <param name="tags">Optional, Specifies a passthrough value for more
        /// generic context.</param>
        /// <param name="order">Optional, Specifies the order in which the
        /// packages have to be installed</param>
        /// <param name="configurationReference">Optional, Specifies the uri to
        /// an azure blob that will replace the default configuration for the
        /// package if provided</param>
        /// <param name="treatFailureAsDeploymentFailure">Optional, If true,
        /// any failure for any operation in the VmApplication will fail the
        /// deployment</param>
        /// <param name="enableAutomaticUpgrade">If set to true, when a new
        /// Gallery Application version is available in PIR/SIG, it will be
        /// automatically updated for the VM/VMSS</param>
        /// <param name="instanceView">Contains instanceView of the
        /// VMApplication if $expand=instanceView is specified</param>
        public VMGalleryApplicationWithInstanceView(string packageReferenceId, string tags = default(string), int? order = default(int?), string configurationReference = default(string), bool? treatFailureAsDeploymentFailure = default(bool?), bool? enableAutomaticUpgrade = default(bool?), VMGalleryApplicationInstanceView instanceView = default(VMGalleryApplicationInstanceView))
            : base(packageReferenceId, tags, order, configurationReference, treatFailureAsDeploymentFailure, enableAutomaticUpgrade)
        {
            InstanceView = instanceView;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets contains instanceView of the VMApplication if
        /// $expand=instanceView is specified
        /// </summary>
        [JsonProperty(PropertyName = "instanceView")]
        public VMGalleryApplicationInstanceView InstanceView { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
