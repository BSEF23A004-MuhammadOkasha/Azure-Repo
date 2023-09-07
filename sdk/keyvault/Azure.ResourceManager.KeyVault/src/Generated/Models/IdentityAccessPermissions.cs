// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> Permissions the identity has for keys, secrets, certificates and storage. </summary>
    public partial class IdentityAccessPermissions
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IdentityAccessPermissions"/>. </summary>
        public IdentityAccessPermissions()
        {
            Keys = new ChangeTrackingList<IdentityAccessKeyPermission>();
            Secrets = new ChangeTrackingList<IdentityAccessSecretPermission>();
            Certificates = new ChangeTrackingList<IdentityAccessCertificatePermission>();
            Storage = new ChangeTrackingList<IdentityAccessStoragePermission>();
        }

        /// <summary> Initializes a new instance of <see cref="IdentityAccessPermissions"/>. </summary>
        /// <param name="keys"> Permissions to keys. </param>
        /// <param name="secrets"> Permissions to secrets. </param>
        /// <param name="certificates"> Permissions to certificates. </param>
        /// <param name="storage"> Permissions to storage accounts. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IdentityAccessPermissions(IList<IdentityAccessKeyPermission> keys, IList<IdentityAccessSecretPermission> secrets, IList<IdentityAccessCertificatePermission> certificates, IList<IdentityAccessStoragePermission> storage, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Keys = keys;
            Secrets = secrets;
            Certificates = certificates;
            Storage = storage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Permissions to keys. </summary>
        public IList<IdentityAccessKeyPermission> Keys { get; }
        /// <summary> Permissions to secrets. </summary>
        public IList<IdentityAccessSecretPermission> Secrets { get; }
        /// <summary> Permissions to certificates. </summary>
        public IList<IdentityAccessCertificatePermission> Certificates { get; }
        /// <summary> Permissions to storage accounts. </summary>
        public IList<IdentityAccessStoragePermission> Storage { get; }
    }
}
