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
    /// The settings of Application Configuration Service.
    /// </summary>
    public partial class ConfigurationServiceSettings
    {
        /// <summary>
        /// Initializes a new instance of the ConfigurationServiceSettings
        /// class.
        /// </summary>
        public ConfigurationServiceSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConfigurationServiceSettings
        /// class.
        /// </summary>
        public ConfigurationServiceSettings(ConfigurationServiceGitProperty gitProperty = default(ConfigurationServiceGitProperty))
        {
            GitProperty = gitProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gitProperty")]
        public ConfigurationServiceGitProperty GitProperty { get; set; }

    }
}
