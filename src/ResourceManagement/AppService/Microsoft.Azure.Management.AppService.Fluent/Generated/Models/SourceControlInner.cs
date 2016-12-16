// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// The source control OAuth token.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class SourceControlInner : Microsoft.Azure.Management.Resource.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the SourceControlInner class.
        /// </summary>
        public SourceControlInner() { }

        /// <summary>
        /// Initializes a new instance of the SourceControlInner class.
        /// </summary>
        /// <param name="sourceControlName">Name or source control
        /// type.</param>
        /// <param name="token">OAuth access token.</param>
        /// <param name="tokenSecret">OAuth access token secret.</param>
        /// <param name="refreshToken">OAuth refresh token.</param>
        /// <param name="expirationTime">OAuth token expiration.</param>
        public SourceControlInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string sourceControlName = default(string), string token = default(string), string tokenSecret = default(string), string refreshToken = default(string), System.DateTime? expirationTime = default(System.DateTime?))
            : base(location, id, name, type, tags)
        {
            SourceControlName = sourceControlName;
            Token = token;
            TokenSecret = tokenSecret;
            RefreshToken = refreshToken;
            ExpirationTime = expirationTime;
        }

        /// <summary>
        /// Gets or sets name or source control type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.name")]
        public string SourceControlName { get; set; }

        /// <summary>
        /// Gets or sets oAuth access token.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.token")]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets oAuth access token secret.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.tokenSecret")]
        public string TokenSecret { get; set; }

        /// <summary>
        /// Gets or sets oAuth refresh token.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.refreshToken")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or sets oAuth token expiration.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.expirationTime")]
        public System.DateTime? ExpirationTime { get; set; }

    }
}
