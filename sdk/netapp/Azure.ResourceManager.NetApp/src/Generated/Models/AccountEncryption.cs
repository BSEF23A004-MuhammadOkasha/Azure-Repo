// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Encryption settings. </summary>
    internal partial class AccountEncryption
    {
        /// <summary> Initializes a new instance of AccountEncryption. </summary>
        public AccountEncryption()
        {
        }

        /// <summary> Initializes a new instance of AccountEncryption. </summary>
        /// <param name="keySource"> Encryption Key Source. Possible values are: &apos;Microsoft.NetApp&apos;. </param>
        internal AccountEncryption(string keySource)
        {
            KeySource = keySource;
        }

        /// <summary> Encryption Key Source. Possible values are: &apos;Microsoft.NetApp&apos;. </summary>
        public string KeySource { get; set; }
    }
}
