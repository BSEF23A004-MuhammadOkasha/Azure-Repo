// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the Azure Active Directory token validation flow. </summary>
    public partial class AppServiceAadValidation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceAadValidation"/>. </summary>
        public AppServiceAadValidation()
        {
            AllowedAudiences = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceAadValidation"/>. </summary>
        /// <param name="jwtClaimChecks"> The configuration settings of the checks that should be made while validating the JWT Claims. </param>
        /// <param name="allowedAudiences"> The list of audiences that can make successful authentication/authorization requests. </param>
        /// <param name="defaultAuthorizationPolicy"> The configuration settings of the default authorization policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceAadValidation(JwtClaimChecks jwtClaimChecks, IList<string> allowedAudiences, DefaultAuthorizationPolicy defaultAuthorizationPolicy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            JwtClaimChecks = jwtClaimChecks;
            AllowedAudiences = allowedAudiences;
            DefaultAuthorizationPolicy = defaultAuthorizationPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The configuration settings of the checks that should be made while validating the JWT Claims. </summary>
        public JwtClaimChecks JwtClaimChecks { get; set; }
        /// <summary> The list of audiences that can make successful authentication/authorization requests. </summary>
        public IList<string> AllowedAudiences { get; }
        /// <summary> The configuration settings of the default authorization policy. </summary>
        public DefaultAuthorizationPolicy DefaultAuthorizationPolicy { get; set; }
    }
}
