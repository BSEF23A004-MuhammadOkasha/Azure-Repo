// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerApps.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The configuration settings of the session cookie's expiration.
    /// </summary>
    public partial class CookieExpiration
    {
        /// <summary>
        /// Initializes a new instance of the CookieExpiration class.
        /// </summary>
        public CookieExpiration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CookieExpiration class.
        /// </summary>
        /// <param name="convention">The convention used when determining the
        /// session cookie's expiration. Possible values include: 'FixedTime',
        /// 'IdentityProviderDerived'</param>
        /// <param name="timeToExpiration">The time after the request is made
        /// when the session cookie should expire.</param>
        public CookieExpiration(CookieExpirationConvention? convention = default(CookieExpirationConvention?), string timeToExpiration = default(string))
        {
            Convention = convention;
            TimeToExpiration = timeToExpiration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the convention used when determining the session
        /// cookie's expiration. Possible values include: 'FixedTime',
        /// 'IdentityProviderDerived'
        /// </summary>
        [JsonProperty(PropertyName = "convention")]
        public CookieExpirationConvention? Convention { get; set; }

        /// <summary>
        /// Gets or sets the time after the request is made when the session
        /// cookie should expire.
        /// </summary>
        [JsonProperty(PropertyName = "timeToExpiration")]
        public string TimeToExpiration { get; set; }

    }
}
