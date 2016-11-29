// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// SSO URI required to login to third party web portal.
    /// </summary>
    public partial class SsoUriInner
    {
        /// <summary>
        /// Initializes a new instance of the SsoUriInner class.
        /// </summary>
        public SsoUriInner() { }

        /// <summary>
        /// Initializes a new instance of the SsoUriInner class.
        /// </summary>
        /// <param name="ssoUriValue">The URI used to login to third party web
        /// portal.</param>
        public SsoUriInner(string ssoUriValue = default(string))
        {
            SsoUriValue = ssoUriValue;
        }

        /// <summary>
        /// Gets or sets the URI used to login to third party web portal.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ssoUriValue")]
        public string SsoUriValue { get; set; }

    }
}
