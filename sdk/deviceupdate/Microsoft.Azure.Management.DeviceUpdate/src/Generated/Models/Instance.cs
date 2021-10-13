// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DeviceUpdate.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Device Update instance details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Instance : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Instance class.
        /// </summary>
        public Instance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Instance class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="provisioningState">Provisioning state. Possible values
        /// include: 'Succeeded', 'Deleted', 'Failed', 'Canceled', 'Accepted',
        /// 'Creating'</param>
        /// <param name="accountName">Parent Device Update Account name which
        /// Instance belongs to.</param>
        /// <param name="iotHubs">List of IoT Hubs associated with the
        /// account.</param>
        /// <param name="enableDiagnostics">Enables or Disables the diagnostic
        /// logs collection</param>
        public Instance(string location, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), string accountName = default(string), IList<IotHubSettings> iotHubs = default(IList<IotHubSettings>), bool? enableDiagnostics = default(bool?), DiagnosticStorageProperties diagnosticStorageProperties = default(DiagnosticStorageProperties))
            : base(location, id, name, type, systemData, tags)
        {
            ProvisioningState = provisioningState;
            AccountName = accountName;
            IotHubs = iotHubs;
            EnableDiagnostics = enableDiagnostics;
            DiagnosticStorageProperties = diagnosticStorageProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets provisioning state. Possible values include: 'Succeeded',
        /// 'Deleted', 'Failed', 'Canceled', 'Accepted', 'Creating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets parent Device Update Account name which Instance belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountName")]
        public string AccountName { get; private set; }

        /// <summary>
        /// Gets or sets list of IoT Hubs associated with the account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.iotHubs")]
        public IList<IotHubSettings> IotHubs { get; set; }

        /// <summary>
        /// Gets or sets enables or Disables the diagnostic logs collection
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableDiagnostics")]
        public bool? EnableDiagnostics { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.diagnosticStorageProperties")]
        public DiagnosticStorageProperties DiagnosticStorageProperties { get; set; }

    }
}
