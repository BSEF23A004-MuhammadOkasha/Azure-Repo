// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of the Backend WebProxy Server to use in the Request to
    /// Backend.
    /// <see
    /// href="https://msdn.microsoft.com/en-us/library/system.net.webproxy(v=vs.110).aspx"
    /// />
    /// </summary>
    public partial class BackendProxyContract
    {
        /// <summary>
        /// Initializes a new instance of the BackendProxyContract class.
        /// </summary>
        public BackendProxyContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackendProxyContract class.
        /// </summary>
        /// <param name="url">WebProxy Server AbsoluteUri property which
        /// includes the entire URI stored in the Uri instance, including all
        /// fragments and query strings.</param>
        /// <param name="username">Username to connect to the WebProxy
        /// server</param>
        /// <param name="password">Password to connect to the WebProxy
        /// Server</param>
        public BackendProxyContract(string url, string username = default(string), string password = default(string))
        {
            Url = url;
            Username = username;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets webProxy Server AbsoluteUri property which includes
        /// the entire URI stored in the Uri instance, including all fragments
        /// and query strings.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets username to connect to the WebProxy server
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets password to connect to the WebProxy Server
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
            if (Url != null)
            {
                if (Url.Length > 2000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Url", 2000);
                }
                if (Url.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Url", 1);
                }
            }
        }
    }
}
