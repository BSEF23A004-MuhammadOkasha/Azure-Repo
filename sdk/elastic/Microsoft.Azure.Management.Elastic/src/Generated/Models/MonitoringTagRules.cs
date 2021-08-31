// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Elastic.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Capture logs and metrics of Azure resources based on ARM tags.
    /// </summary>
    public partial class MonitoringTagRules : IResource
    {
        /// <summary>
        /// Initializes a new instance of the MonitoringTagRules class.
        /// </summary>
        public MonitoringTagRules()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MonitoringTagRules class.
        /// </summary>
        /// <param name="name">Name of the rule set.</param>
        /// <param name="id">The id of the rule set.</param>
        /// <param name="type">The type of the rule set.</param>
        /// <param name="properties">Properties of the monitoring tag
        /// rules.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource</param>
        public MonitoringTagRules(string name = default(string), string id = default(string), string type = default(string), MonitoringTagRulesProperties properties = default(MonitoringTagRulesProperties), SystemData systemData = default(SystemData))
        {
            Name = name;
            Id = id;
            Type = type;
            Properties = properties;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the rule set.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the id of the rule set.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the type of the rule set.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets properties of the monitoring tag rules.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public MonitoringTagRulesProperties Properties { get; set; }

        /// <summary>
        /// Gets the system metadata relating to this resource
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
