// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Client secret information for factory's bring your own app repository configuration. </summary>
    public partial class FactoryGitHubClientSecret
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FactoryGitHubClientSecret"/>. </summary>
        public FactoryGitHubClientSecret()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FactoryGitHubClientSecret"/>. </summary>
        /// <param name="byoaSecretAkvUri"> Bring your own app client secret AKV URL. </param>
        /// <param name="byoaSecretName"> Bring your own app client secret name in AKV. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FactoryGitHubClientSecret(Uri byoaSecretAkvUri, string byoaSecretName, Dictionary<string, BinaryData> rawData)
        {
            ByoaSecretAkvUri = byoaSecretAkvUri;
            ByoaSecretName = byoaSecretName;
            _rawData = rawData;
        }

        /// <summary> Bring your own app client secret AKV URL. </summary>
        public Uri ByoaSecretAkvUri { get; set; }
        /// <summary> Bring your own app client secret name in AKV. </summary>
        public string ByoaSecretName { get; set; }
    }
}
