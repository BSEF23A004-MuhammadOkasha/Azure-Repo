// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using System.Linq;

    /// <summary>
    /// Description of a NotificationHub AdmCredential.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class AdmCredential
    {
        /// <summary>
        /// Initializes a new instance of the AdmCredential class.
        /// </summary>
        public AdmCredential() { }

        /// <summary>
        /// Initializes a new instance of the AdmCredential class.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="clientSecret">The credential secret access
        /// key.</param>
        /// <param name="authTokenUrl">The URL of the authorization
        /// token.</param>
        public AdmCredential(string clientId = default(string), string clientSecret = default(string), string authTokenUrl = default(string))
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            AuthTokenUrl = authTokenUrl;
        }

        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the credential secret access key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the URL of the authorization token.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.authTokenUrl")]
        public string AuthTokenUrl { get; set; }

    }
}
