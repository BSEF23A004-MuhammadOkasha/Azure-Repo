// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Deployment dependency information.
    /// </summary>
    public partial class BasicDependency
    {
        /// <summary>
        /// Initializes a new instance of the BasicDependency class.
        /// </summary>
        public BasicDependency() { }

        /// <summary>
        /// Initializes a new instance of the BasicDependency class.
        /// </summary>
        /// <param name="id">Gets or sets the ID of the dependency.</param>
        /// <param name="resourceType">Gets or sets the dependency resource
        /// type.</param>
        /// <param name="resourceName">Gets or sets the dependency resource
        /// name.</param>
        public BasicDependency(string id = default(string), string resourceType = default(string), string resourceName = default(string))
        {
            Id = id;
            ResourceType = resourceType;
            ResourceName = resourceName;
        }

        /// <summary>
        /// Gets or sets the ID of the dependency.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the dependency resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }

        /// <summary>
        /// Gets or sets the dependency resource name.
        /// </summary>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }

    }
}
