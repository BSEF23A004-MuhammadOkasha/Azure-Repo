// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The workflow type.
    /// </summary>
    [JsonTransformation]
    public partial class Workflow : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Workflow class.
        /// </summary>
        public Workflow() { }

        /// <summary>
        /// Initializes a new instance of the Workflow class.
        /// </summary>
        public Workflow(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), WorkflowProvisioningState? provisioningState = default(WorkflowProvisioningState?), DateTime? createdTime = default(DateTime?), DateTime? changedTime = default(DateTime?), WorkflowState? state = default(WorkflowState?), string version = default(string), string accessEndpoint = default(string), Sku sku = default(Sku), ResourceReference integrationAccount = default(ResourceReference), object definition = default(object), IDictionary<string, WorkflowParameter> parameters = default(IDictionary<string, WorkflowParameter>))
            : base(id, name, type, location, tags)
        {
            ProvisioningState = provisioningState;
            CreatedTime = createdTime;
            ChangedTime = changedTime;
            State = state;
            Version = version;
            AccessEndpoint = accessEndpoint;
            Sku = sku;
            IntegrationAccount = integrationAccount;
            Definition = definition;
            Parameters = parameters;
        }

        /// <summary>
        /// Gets gets the provisioning state. Possible values include:
        /// 'NotSpecified', 'Accepted', 'Running', 'Ready', 'Creating',
        /// 'Created', 'Deleting', 'Deleted', 'Canceled', 'Failed',
        /// 'Succeeded', 'Moving', 'Updating', 'Registering', 'Registered',
        /// 'Unregistering', 'Unregistered', 'Completed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public WorkflowProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets gets the created time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTime")]
        public DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// Gets gets the changed time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.changedTime")]
        public DateTime? ChangedTime { get; private set; }

        /// <summary>
        /// Gets or sets the state. Possible values include: 'NotSpecified',
        /// 'Completed', 'Enabled', 'Disabled', 'Deleted', 'Suspended'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public WorkflowState? State { get; set; }

        /// <summary>
        /// Gets gets the version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets gets the access endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessEndpoint")]
        public string AccessEndpoint { get; private set; }

        /// <summary>
        /// Gets or sets the sku.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the integration account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.integrationAccount")]
        public ResourceReference IntegrationAccount { get; set; }

        /// <summary>
        /// Gets or sets the definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.definition")]
        public object Definition { get; set; }

        /// <summary>
        /// Gets or sets the parameters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IDictionary<string, WorkflowParameter> Parameters { get; set; }

    }
}
