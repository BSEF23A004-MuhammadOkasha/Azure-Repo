// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> disk encryption set update resource. </summary>
    public partial class DiskEncryptionSetPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DiskEncryptionSetPatch"/>. </summary>
        public DiskEncryptionSetPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DiskEncryptionSetPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="identity"> The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used to encrypt disks. </param>
        /// <param name="encryptionType"> The type of key used to encrypt the data of the disk. </param>
        /// <param name="activeKey"> Key Vault Key Url to be used for server side encryption of Managed Disks and Snapshots. </param>
        /// <param name="rotationToLatestKeyVersionEnabled"> Set this flag to true to enable auto-updating of this disk encryption set to the latest key version. </param>
        /// <param name="federatedClientId"> Multi-tenant application client id to access key vault in a different tenant. Setting the value to 'None' will clear the property. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskEncryptionSetPatch(IDictionary<string, string> tags, ManagedServiceIdentity identity, DiskEncryptionSetType? encryptionType, KeyForDiskEncryptionSet activeKey, bool? rotationToLatestKeyVersionEnabled, string federatedClientId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Identity = identity;
            EncryptionType = encryptionType;
            ActiveKey = activeKey;
            RotationToLatestKeyVersionEnabled = rotationToLatestKeyVersionEnabled;
            FederatedClientId = federatedClientId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used to encrypt disks. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The type of key used to encrypt the data of the disk. </summary>
        public DiskEncryptionSetType? EncryptionType { get; set; }
        /// <summary> Key Vault Key Url to be used for server side encryption of Managed Disks and Snapshots. </summary>
        public KeyForDiskEncryptionSet ActiveKey { get; set; }
        /// <summary> Set this flag to true to enable auto-updating of this disk encryption set to the latest key version. </summary>
        public bool? RotationToLatestKeyVersionEnabled { get; set; }
        /// <summary> Multi-tenant application client id to access key vault in a different tenant. Setting the value to 'None' will clear the property. </summary>
        public string FederatedClientId { get; set; }
    }
}
