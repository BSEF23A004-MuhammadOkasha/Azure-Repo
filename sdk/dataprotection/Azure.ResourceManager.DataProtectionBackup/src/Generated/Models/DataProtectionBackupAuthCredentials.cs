// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary>
    /// Base class for different types of authentication credentials.
    /// Please note <see cref="DataProtectionBackupAuthCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SecretStoreBasedAuthCredentials"/>.
    /// </summary>
    public abstract partial class DataProtectionBackupAuthCredentials
    {
        /// <summary> Initializes a new instance of <see cref="DataProtectionBackupAuthCredentials"/>. </summary>
        protected DataProtectionBackupAuthCredentials()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataProtectionBackupAuthCredentials"/>. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        internal DataProtectionBackupAuthCredentials(string objectType)
        {
            ObjectType = objectType;
        }

        /// <summary> Type of the specific object - used for deserializing. </summary>
        internal string ObjectType { get; set; }
    }
}
