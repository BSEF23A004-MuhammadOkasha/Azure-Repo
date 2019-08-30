// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagedNetwork.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Managed Network Group resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagedNetworkGroup : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ManagedNetworkGroup class.
        /// </summary>
        public ManagedNetworkGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedNetworkGroup class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="provisioningState">Provisioning state of the
        /// ManagedNetwork resource. Possible values are: 'Updating',
        /// 'Deleting', and 'Failed'. Possible values include: 'Updating',
        /// 'Deleting', 'Failed', 'Succeeded'</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="managementGroups">The collection of management groups
        /// covered by the Managed Network</param>
        /// <param name="subscriptions">The collection of subscriptions covered
        /// by the Managed Network</param>
        /// <param name="virtualNetworks">The collection of virtual nets
        /// covered by the Managed Network</param>
        /// <param name="subnets">The collection of  subnets covered by the
        /// Managed Network</param>
        /// <param name="kind">Responsibility role under which this Managed
        /// Network Group will be created. Possible values include:
        /// 'Connectivity'</param>
        public ManagedNetworkGroup(string id = default(string), string name = default(string), string type = default(string), string provisioningState = default(string), string etag = default(string), IList<ResourceId> managementGroups = default(IList<ResourceId>), IList<ResourceId> subscriptions = default(IList<ResourceId>), IList<ResourceId> virtualNetworks = default(IList<ResourceId>), IList<ResourceId> subnets = default(IList<ResourceId>), string kind = default(string))
            : base(id, name, type)
        {
            ProvisioningState = provisioningState;
            Etag = etag;
            ManagementGroups = managementGroups;
            Subscriptions = subscriptions;
            VirtualNetworks = virtualNetworks;
            Subnets = subnets;
            Kind = kind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets provisioning state of the ManagedNetwork resource. Possible
        /// values are: 'Updating', 'Deleting', and 'Failed'. Possible values
        /// include: 'Updating', 'Deleting', 'Failed', 'Succeeded'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets or sets the collection of management groups covered by the
        /// Managed Network
        /// </summary>
        [JsonProperty(PropertyName = "properties.managementGroups")]
        public IList<ResourceId> ManagementGroups { get; set; }

        /// <summary>
        /// Gets or sets the collection of subscriptions covered by the Managed
        /// Network
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptions")]
        public IList<ResourceId> Subscriptions { get; set; }

        /// <summary>
        /// Gets or sets the collection of virtual nets covered by the Managed
        /// Network
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworks")]
        public IList<ResourceId> VirtualNetworks { get; set; }

        /// <summary>
        /// Gets or sets the collection of  subnets covered by the Managed
        /// Network
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnets")]
        public IList<ResourceId> Subnets { get; set; }

        /// <summary>
        /// Gets or sets responsibility role under which this Managed Network
        /// Group will be created. Possible values include: 'Connectivity'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

    }
}
