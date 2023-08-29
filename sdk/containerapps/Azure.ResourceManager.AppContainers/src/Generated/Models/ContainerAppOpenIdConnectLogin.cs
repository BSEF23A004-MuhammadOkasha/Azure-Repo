// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The configuration settings of the login flow of the custom Open ID Connect provider. </summary>
    public partial class ContainerAppOpenIdConnectLogin
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppOpenIdConnectLogin"/>. </summary>
        public ContainerAppOpenIdConnectLogin()
        {
            Scopes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppOpenIdConnectLogin"/>. </summary>
        /// <param name="nameClaimType"> The name of the claim that contains the users name. </param>
        /// <param name="scopes"> A list of the scopes that should be requested while authenticating. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppOpenIdConnectLogin(string nameClaimType, IList<string> scopes, Dictionary<string, BinaryData> rawData)
        {
            NameClaimType = nameClaimType;
            Scopes = scopes;
            _rawData = rawData;
        }

        /// <summary> The name of the claim that contains the users name. </summary>
        public string NameClaimType { get; set; }
        /// <summary> A list of the scopes that should be requested while authenticating. </summary>
        public IList<string> Scopes { get; }
    }
}
