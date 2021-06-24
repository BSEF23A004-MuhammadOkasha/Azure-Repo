// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A private container registry.
    /// </summary>
    public partial class ContainerRegistry
    {
        /// <summary>
        /// Initializes a new instance of the ContainerRegistry class.
        /// </summary>
        public ContainerRegistry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerRegistry class.
        /// </summary>
        /// <param name="registryServer">The registry URL.</param>
        /// <param name="userName">The user name to log into the registry
        /// server.</param>
        /// <param name="password">The password to log into the registry
        /// server.</param>
        /// <param name="identityReference">The reference to the user assigned
        /// identity to use to access an Azure Container Registry instead of
        /// username and password.</param>
        public ContainerRegistry(string registryServer = default(string), string userName = default(string), string password = default(string), ComputeNodeIdentityReference identityReference = default(ComputeNodeIdentityReference))
        {
            RegistryServer = registryServer;
            UserName = userName;
            Password = password;
            IdentityReference = identityReference;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the registry URL.
        /// </summary>
        /// <remarks>
        /// If omitted, the default is "docker.io".
        /// </remarks>
        [JsonProperty(PropertyName = "registryServer")]
        public string RegistryServer { get; set; }

        /// <summary>
        /// Gets or sets the user name to log into the registry server.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password to log into the registry server.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the reference to the user assigned identity to use to
        /// access an Azure Container Registry instead of username and
        /// password.
        /// </summary>
        [JsonProperty(PropertyName = "identityReference")]
        public ComputeNodeIdentityReference IdentityReference { get; set; }

    }
}
