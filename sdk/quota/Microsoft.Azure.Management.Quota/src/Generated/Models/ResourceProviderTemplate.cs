// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Quota.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Resource template details for the resource provider.
    /// </summary>
    public partial class ResourceProviderTemplate
    {
        /// <summary>
        /// Initializes a new instance of the ResourceProviderTemplate class.
        /// </summary>
        public ResourceProviderTemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceProviderTemplate class.
        /// </summary>
        /// <param name="resourceType">Resource type.</param>
        /// <param name="resourceQuery">Resource query for dimension
        /// values.</param>
        /// <param name="resourceUsagesQuery">Resource usages query.</param>
        /// <param name="dimensions">Resource provider dimensions.</param>
        public ResourceProviderTemplate(string resourceType = default(string), ResourceQueryDetails resourceQuery = default(ResourceQueryDetails), ResourceQueryDetails resourceUsagesQuery = default(ResourceQueryDetails), IList<ResourceProviderDimension> dimensions = default(IList<ResourceProviderDimension>))
        {
            ResourceType = resourceType;
            ResourceQuery = resourceQuery;
            ResourceUsagesQuery = resourceUsagesQuery;
            Dimensions = dimensions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }

        /// <summary>
        /// Gets or sets resource query for dimension values.
        /// </summary>
        [JsonProperty(PropertyName = "resourceQuery")]
        public ResourceQueryDetails ResourceQuery { get; set; }

        /// <summary>
        /// Gets or sets resource usages query.
        /// </summary>
        [JsonProperty(PropertyName = "resourceUsagesQuery")]
        public ResourceQueryDetails ResourceUsagesQuery { get; set; }

        /// <summary>
        /// Gets or sets resource provider dimensions.
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IList<ResourceProviderDimension> Dimensions { get; set; }

    }
}
