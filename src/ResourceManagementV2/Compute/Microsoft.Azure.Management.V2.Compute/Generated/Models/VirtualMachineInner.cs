// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// Describes a Virtual Machine.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineInner : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineInner class.
        /// </summary>
        public VirtualMachineInner() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineInner class.
        /// </summary>
        /// <param name="plan">the purchase plan when deploying virtual
        /// machine from VM Marketplace images.</param>
        /// <param name="hardwareProfile">the hardware profile.</param>
        /// <param name="storageProfile">the storage profile.</param>
        /// <param name="osProfile">the OS profile.</param>
        /// <param name="networkProfile">the network profile.</param>
        /// <param name="diagnosticsProfile">the diagnostics profile.</param>
        /// <param name="availabilitySet">the reference Id of the availability
        /// set to which this virtual machine belongs.</param>
        /// <param name="provisioningState">the provisioning state, which only
        /// appears in the response.</param>
        /// <param name="instanceView">the virtual machine instance
        /// view.</param>
        /// <param name="licenseType">the license type, which is for bring
        /// your own license scenario.</param>
        /// <param name="vmId">the virtual machine unique id.</param>
        /// <param name="resources">the virtual machine child extension
        /// resources.</param>
        public VirtualMachineInner(String location = default(String), String id = default(String), String name = default(String), String type = default(String), IDictionary<string, String> tags = default(IDictionary<string, String>), Plan plan = default(Plan), HardwareProfile hardwareProfile = default(HardwareProfile), StorageProfile storageProfile = default(StorageProfile), OSProfile osProfile = default(OSProfile), NetworkProfile networkProfile = default(NetworkProfile), DiagnosticsProfile diagnosticsProfile = default(DiagnosticsProfile), SubResource availabilitySet = default(SubResource), string provisioningState = default(string), VirtualMachineInstanceView instanceView = default(VirtualMachineInstanceView), string licenseType = default(string), string vmId = default(string), System.Collections.Generic.IList<VirtualMachineExtensionInner> resources = default(System.Collections.Generic.IList<VirtualMachineExtensionInner>))
            : base(location, id, name, type, tags)
        {
            Plan = plan;
            HardwareProfile = hardwareProfile;
            StorageProfile = storageProfile;
            OsProfile = osProfile;
            NetworkProfile = networkProfile;
            DiagnosticsProfile = diagnosticsProfile;
            AvailabilitySet = availabilitySet;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
            LicenseType = licenseType;
            VmId = vmId;
            Resources = resources;
        }

        /// <summary>
        /// Gets or sets the purchase plan when deploying virtual machine from
        /// VM Marketplace images.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "plan")]
        public Plan Plan { get; set; }

        /// <summary>
        /// Gets or sets the hardware profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.hardwareProfile")]
        public HardwareProfile HardwareProfile { get; set; }

        /// <summary>
        /// Gets or sets the storage profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storageProfile")]
        public StorageProfile StorageProfile { get; set; }

        /// <summary>
        /// Gets or sets the OS profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.osProfile")]
        public OSProfile OsProfile { get; set; }

        /// <summary>
        /// Gets or sets the network profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.networkProfile")]
        public NetworkProfile NetworkProfile { get; set; }

        /// <summary>
        /// Gets or sets the diagnostics profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.diagnosticsProfile")]
        public DiagnosticsProfile DiagnosticsProfile { get; set; }

        /// <summary>
        /// Gets or sets the reference Id of the availability set to which
        /// this virtual machine belongs.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.availabilitySet")]
        public SubResource AvailabilitySet { get; set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the virtual machine instance view.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.instanceView")]
        public VirtualMachineInstanceView InstanceView { get; private set; }

        /// <summary>
        /// Gets or sets the license type, which is for bring your own license
        /// scenario.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets the virtual machine unique id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.vmId")]
        public string VmId { get; private set; }

        /// <summary>
        /// Gets the virtual machine child extension resources.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resources")]
        public System.Collections.Generic.IList<VirtualMachineExtensionInner> Resources { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.StorageProfile != null)
            {
                this.StorageProfile.Validate();
            }
        }
    }
}
