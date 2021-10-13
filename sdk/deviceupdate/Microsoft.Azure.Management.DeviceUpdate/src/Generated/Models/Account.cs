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
    /// Device Update account details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Account : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Account class.
        /// </summary>
        public Account()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Account class.
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
        /// <param name="hostName">API host name.</param>
        /// <param name="publicNetworkAccess">Whether or not public network
        /// access is allowed for the container registry. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="identity">The type of identity used for the
        /// resource.</param>
        public Account(string location, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), string hostName = default(string), string publicNetworkAccess = default(string), ManagedServiceIdentity identity = default(ManagedServiceIdentity))
            : base(location, id, name, type, systemData, tags)
        {
            ProvisioningState = provisioningState;
            HostName = hostName;
            PublicNetworkAccess = publicNetworkAccess;
            Identity = identity;
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
        /// Gets API host name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; private set; }

        /// <summary>
        /// Gets or sets whether or not public network access is allowed for
        /// the container registry. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets the type of identity used for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ManagedServiceIdentity Identity { get; set; }

    }
}
