// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ContainerRegistry;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The login password for the container registry.
    /// </summary>
    public partial class RegistryPassword
    {
        /// <summary>
        /// Initializes a new instance of the RegistryPassword class.
        /// </summary>
        public RegistryPassword()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegistryPassword class.
        /// </summary>
        /// <param name="name">The password name. Possible values include:
        /// 'password', 'password2'</param>
        /// <param name="value">The password value.</param>
        public RegistryPassword(PasswordName? name = default(PasswordName?), string value = default(string))
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
        /// Gets or sets the password name. Possible values include:
        /// 'password', 'password2'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public PasswordName? Name { get; set; }

        /// <summary>
        /// Gets or sets the password value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
