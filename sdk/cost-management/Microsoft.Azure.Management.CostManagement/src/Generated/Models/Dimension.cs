// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CostManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    [Rest.Serialization.JsonTransformation]
    public partial class Dimension : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Dimension class.
        /// </summary>
        public Dimension()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Dimension class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="description">Dimension description.</param>
        /// <param name="filterEnabled">Filter enabled.</param>
        /// <param name="groupingEnabled">Grouping enabled.</param>
        /// <param name="total">Total number of data for the dimension.</param>
        /// <param name="category">Dimension category.</param>
        /// <param name="usageStart">Usage start.</param>
        /// <param name="usageEnd">Usage end.</param>
        /// <param name="nextLink">The link (url) to the next page of
        /// results.</param>
        public Dimension(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string description = default(string), bool? filterEnabled = default(bool?), bool? groupingEnabled = default(bool?), IList<string> data = default(IList<string>), int? total = default(int?), string category = default(string), System.DateTime? usageStart = default(System.DateTime?), System.DateTime? usageEnd = default(System.DateTime?), string nextLink = default(string))
            : base(id, name, type, tags)
        {
            Description = description;
            FilterEnabled = filterEnabled;
            GroupingEnabled = groupingEnabled;
            Data = data;
            Total = total;
            Category = category;
            UsageStart = usageStart;
            UsageEnd = usageEnd;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets dimension description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets filter enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.filterEnabled")]
        public bool? FilterEnabled { get; private set; }

        /// <summary>
        /// Gets grouping enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.groupingEnabled")]
        public bool? GroupingEnabled { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.data")]
        public IList<string> Data { get; set; }

        /// <summary>
        /// Gets total number of data for the dimension.
        /// </summary>
        [JsonProperty(PropertyName = "properties.total")]
        public int? Total { get; private set; }

        /// <summary>
        /// Gets dimension category.
        /// </summary>
        [JsonProperty(PropertyName = "properties.category")]
        public string Category { get; private set; }

        /// <summary>
        /// Gets usage start.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usageStart")]
        public System.DateTime? UsageStart { get; private set; }

        /// <summary>
        /// Gets usage end.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usageEnd")]
        public System.DateTime? UsageEnd { get; private set; }

        /// <summary>
        /// Gets the link (url) to the next page of results.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nextLink")]
        public string NextLink { get; private set; }

    }
}
