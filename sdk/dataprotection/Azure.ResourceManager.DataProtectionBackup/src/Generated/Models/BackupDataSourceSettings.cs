// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary>
    /// Parameters for Backup Datasource
    /// Please note <see cref="BackupDataSourceSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="BlobBackupDataSourceSettings"/> and <see cref="KubernetesClusterBackupDataSourceSettings"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownBackupDatasourceParameters))]
    public abstract partial class BackupDataSourceSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BackupDataSourceSettings"/>. </summary>
        protected BackupDataSourceSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupDataSourceSettings"/>. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupDataSourceSettings(string objectType, Dictionary<string, BinaryData> rawData)
        {
            ObjectType = objectType;
            _rawData = rawData;
        }

        /// <summary> Type of the specific object - used for deserializing. </summary>
        internal string ObjectType { get; set; }
    }
}
