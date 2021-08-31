// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.ChangeAnalysis.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The resource provider operation details.
    /// </summary>
    public partial class ResourceProviderOperationDisplay
    {
        /// <summary>
        /// Initializes a new instance of the ResourceProviderOperationDisplay
        /// class.
        /// </summary>
        public ResourceProviderOperationDisplay()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceProviderOperationDisplay
        /// class.
        /// </summary>
        /// <param name="provider">Name of the resource provider.</param>
        /// <param name="resource">Name of the resource type.</param>
        /// <param name="operation">Name of the resource provider
        /// operation.</param>
        /// <param name="description">Description of the resource provider
        /// operation.</param>
        public ResourceProviderOperationDisplay(string provider = default(string), string resource = default(string), string operation = default(string), string description = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the resource provider.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets name of the resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets name of the resource provider operation.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets description of the resource provider operation.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
