// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The payload for a Configure HTTP settings request.
    /// </summary>
    public partial class HttpConnectivitySettings
    {
        /// <summary>
        /// Initializes a new instance of the HttpConnectivitySettings class.
        /// </summary>
        public HttpConnectivitySettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HttpConnectivitySettings class.
        /// </summary>
        /// <param name="enabledCredential">Whether or not the HTTP based
        /// authorization is enabled. Possible values include: 'true',
        /// 'false'</param>
        /// <param name="username">The HTTP username.</param>
        /// <param name="password">The HTTP user password.</param>
        public HttpConnectivitySettings(string enabledCredential = default(string), string username = default(string), string password = default(string))
        {
            EnabledCredential = enabledCredential;
            Username = username;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether or not the HTTP based authorization is
        /// enabled. Possible values include: 'true', 'false'
        /// </summary>
        [JsonProperty(PropertyName = "restAuthCredential.isEnabled")]
        public string EnabledCredential { get; set; }

        /// <summary>
        /// Gets or sets the HTTP username.
        /// </summary>
        [JsonProperty(PropertyName = "restAuthCredential.username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the HTTP user password.
        /// </summary>
        [JsonProperty(PropertyName = "restAuthCredential.password")]
        public string Password { get; set; }

    }
}
