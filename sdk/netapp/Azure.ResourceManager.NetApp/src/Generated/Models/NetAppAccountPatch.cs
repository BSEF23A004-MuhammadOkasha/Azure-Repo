// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> NetApp account patch resource. </summary>
    public partial class NetAppAccountPatch : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NetAppAccountPatch. </summary>
        /// <param name="location"> The location. </param>
        public NetAppAccountPatch(AzureLocation location) : base(location)
        {
            ActiveDirectories = new ChangeTrackingList<NetAppAccountActiveDirectory>();
        }

        /// <summary> Azure lifecycle management. </summary>
        public string ProvisioningState { get; }
        /// <summary> Active Directories. </summary>
        public IList<NetAppAccountActiveDirectory> ActiveDirectories { get; }
        /// <summary> Encryption settings. </summary>
        internal AccountEncryption Encryption { get; set; }
        /// <summary> Encryption Key Source. Possible values are: &apos;Microsoft.NetApp&apos;. </summary>
        public string EncryptionKeySource
        {
            get => Encryption is null ? default : Encryption.KeySource;
            set
            {
                if (Encryption is null)
                    Encryption = new AccountEncryption();
                Encryption.KeySource = value;
            }
        }
    }
}
