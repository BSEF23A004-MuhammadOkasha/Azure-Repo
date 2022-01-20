// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Buildpack properties payload
    /// </summary>
    public partial class BuildpackProperties
    {
        /// <summary>
        /// Initializes a new instance of the BuildpackProperties class.
        /// </summary>
        public BuildpackProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuildpackProperties class.
        /// </summary>
        /// <param name="id">Id of the buildpack</param>
        public BuildpackProperties(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the buildpack
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
