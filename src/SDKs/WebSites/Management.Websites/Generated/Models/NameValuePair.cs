// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Name value pair.
    /// </summary>
    public partial class NameValuePair
    {
        /// <summary>
        /// Initializes a new instance of the NameValuePair class.
        /// </summary>
        public NameValuePair()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NameValuePair class.
        /// </summary>
        /// <param name="name">Pair name.</param>
        /// <param name="value">Pair value.</param>
        public NameValuePair(string name = default(string), string value = default(string))
        {
            Name = name;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets pair name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets pair value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
