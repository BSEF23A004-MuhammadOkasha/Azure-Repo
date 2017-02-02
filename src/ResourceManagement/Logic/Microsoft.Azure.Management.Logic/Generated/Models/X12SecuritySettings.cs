// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The X12 agreement security settings.
    /// </summary>
    public partial class X12SecuritySettings
    {
        /// <summary>
        /// Initializes a new instance of the X12SecuritySettings class.
        /// </summary>
        public X12SecuritySettings() { }

        /// <summary>
        /// Initializes a new instance of the X12SecuritySettings class.
        /// </summary>
        public X12SecuritySettings(string authorizationQualifier = default(string), string authorizationValue = default(string), string securityQualifier = default(string), string passwordValue = default(string))
        {
            AuthorizationQualifier = authorizationQualifier;
            AuthorizationValue = authorizationValue;
            SecurityQualifier = securityQualifier;
            PasswordValue = passwordValue;
        }

        /// <summary>
        /// Gets or sets the authorization qualifier.
        /// </summary>
        [JsonProperty(PropertyName = "authorizationQualifier")]
        public string AuthorizationQualifier { get; set; }

        /// <summary>
        /// Gets or sets the authorization value.
        /// </summary>
        [JsonProperty(PropertyName = "authorizationValue")]
        public string AuthorizationValue { get; set; }

        /// <summary>
        /// Gets or sets the security qualifier.
        /// </summary>
        [JsonProperty(PropertyName = "securityQualifier")]
        public string SecurityQualifier { get; set; }

        /// <summary>
        /// Gets or sets the password value.
        /// </summary>
        [JsonProperty(PropertyName = "passwordValue")]
        public string PasswordValue { get; set; }

    }
}
