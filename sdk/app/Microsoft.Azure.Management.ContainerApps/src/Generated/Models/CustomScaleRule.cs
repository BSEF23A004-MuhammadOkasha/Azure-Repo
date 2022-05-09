// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerApps.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Container App container Custom scaling rule.
    /// </summary>
    public partial class CustomScaleRule
    {
        /// <summary>
        /// Initializes a new instance of the CustomScaleRule class.
        /// </summary>
        public CustomScaleRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomScaleRule class.
        /// </summary>
        /// <param name="type">Type of the custom scale rule
        /// eg: azure-servicebus, redis etc.</param>
        /// <param name="metadata">Metadata properties to describe custom scale
        /// rule.</param>
        /// <param name="auth">Authentication secrets for the custom scale
        /// rule.</param>
        public CustomScaleRule(string type = default(string), IDictionary<string, string> metadata = default(IDictionary<string, string>), IList<ScaleRuleAuth> auth = default(IList<ScaleRuleAuth>))
        {
            Type = type;
            Metadata = metadata;
            Auth = auth;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of the custom scale rule
        /// eg: azure-servicebus, redis etc.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets metadata properties to describe custom scale rule.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets authentication secrets for the custom scale rule.
        /// </summary>
        [JsonProperty(PropertyName = "auth")]
        public IList<ScaleRuleAuth> Auth { get; set; }

    }
}
