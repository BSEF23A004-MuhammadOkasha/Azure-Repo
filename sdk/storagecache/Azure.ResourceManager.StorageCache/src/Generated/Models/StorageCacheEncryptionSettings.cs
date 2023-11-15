// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Cache encryption settings. </summary>
    public partial class StorageCacheEncryptionSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageCacheEncryptionSettings"/>. </summary>
        public StorageCacheEncryptionSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageCacheEncryptionSettings"/>. </summary>
        /// <param name="keyEncryptionKey"> Specifies the location of the key encryption key in key vault. </param>
        /// <param name="enableRotationToLatestKeyVersion"> Specifies whether the service will automatically rotate to the newest version of the key in the key vault. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageCacheEncryptionSettings(StorageCacheEncryptionKeyVaultKeyReference keyEncryptionKey, bool? enableRotationToLatestKeyVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyEncryptionKey = keyEncryptionKey;
            EnableRotationToLatestKeyVersion = enableRotationToLatestKeyVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the location of the key encryption key in key vault. </summary>
        public StorageCacheEncryptionKeyVaultKeyReference KeyEncryptionKey { get; set; }
        /// <summary> Specifies whether the service will automatically rotate to the newest version of the key in the key vault. </summary>
        public bool? EnableRotationToLatestKeyVersion { get; set; }
    }
}
