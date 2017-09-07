// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Relay.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Relay;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Description of a Namespace resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RelayUpdateParameters : ResourceNamespacePatch
    {
        /// <summary>
        /// Initializes a new instance of the RelayUpdateParameters class.
        /// </summary>
        public RelayUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RelayUpdateParameters class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="sku">Sku of the Namespace.</param>
        /// <param name="provisioningState">Possible values include: 'Created',
        /// 'Succeeded', 'Deleted', 'Failed', 'Updating', 'Unknown'</param>
        /// <param name="createdAt">The time the namespace was created.</param>
        /// <param name="updatedAt">The time the namespace was updated.</param>
        /// <param name="serviceBusEndpoint">Endpoint you can use to perform
        /// Service Bus operations.</param>
        /// <param name="metricId">Identifier for Azure Insights
        /// metrics</param>
        public RelayUpdateParameters(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), ProvisioningStateEnum? provisioningState = default(ProvisioningStateEnum?), System.DateTime? createdAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?), string serviceBusEndpoint = default(string), string metricId = default(string))
            : base(id, name, type, tags)
        {
            Sku = sku;
            ProvisioningState = provisioningState;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ServiceBusEndpoint = serviceBusEndpoint;
            MetricId = metricId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets sku of the Namespace.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets possible values include: 'Created', 'Succeeded', 'Deleted',
        /// 'Failed', 'Updating', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningStateEnum? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the time the namespace was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets the time the namespace was updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public System.DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Gets endpoint you can use to perform Service Bus operations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceBusEndpoint")]
        public string ServiceBusEndpoint { get; private set; }

        /// <summary>
        /// Gets identifier for Azure Insights metrics
        /// </summary>
        [JsonProperty(PropertyName = "properties.metricId")]
        public string MetricId { get; private set; }

    }
}
