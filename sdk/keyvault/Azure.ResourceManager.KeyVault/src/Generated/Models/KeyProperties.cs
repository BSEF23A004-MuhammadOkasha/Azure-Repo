// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> The properties of the key. </summary>
    public partial class KeyProperties
    {
        /// <summary> Initializes a new instance of KeyProperties. </summary>
        public KeyProperties()
        {
            KeyOps = new ChangeTrackingList<JsonWebKeyOperation>();
        }

        /// <summary> The attributes of the key. </summary>
        public KeyAttributes Attributes { get; set; }
        /// <summary> The type of the key. For valid values, see JsonWebKeyType. </summary>
        public JsonWebKeyType? Kty { get; set; }
        /// <summary> Gets the key ops. </summary>
        public IList<JsonWebKeyOperation> KeyOps { get; }
        /// <summary> The key size in bits. For example: 2048, 3072, or 4096 for RSA. </summary>
        public int? KeySize { get; set; }
        /// <summary> The elliptic curve name. For valid values, see JsonWebKeyCurveName. </summary>
        public JsonWebKeyCurveName? CurveName { get; set; }
        /// <summary> The URI to retrieve the current version of the key. </summary>
        public string KeyUri { get; }
        /// <summary> The URI to retrieve the specific version of the key. </summary>
        public string KeyUriWithVersion { get; }
    }
}
