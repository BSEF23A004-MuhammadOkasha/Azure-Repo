// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> List of unencrypted credentials for accessing device. </summary>
    internal partial class UnencryptedCredentialsList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UnencryptedCredentialsList"/>. </summary>
        internal UnencryptedCredentialsList()
        {
            Value = new ChangeTrackingList<UnencryptedCredentials>();
        }

        /// <summary> Initializes a new instance of <see cref="UnencryptedCredentialsList"/>. </summary>
        /// <param name="value"> List of unencrypted credentials. </param>
        /// <param name="nextLink"> Link for the next set of unencrypted credentials. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnencryptedCredentialsList(IReadOnlyList<UnencryptedCredentials> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of unencrypted credentials. </summary>
        public IReadOnlyList<UnencryptedCredentials> Value { get; }
        /// <summary> Link for the next set of unencrypted credentials. </summary>
        public string NextLink { get; }
    }
}
