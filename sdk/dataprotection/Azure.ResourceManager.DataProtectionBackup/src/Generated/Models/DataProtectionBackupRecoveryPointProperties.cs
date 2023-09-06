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
    /// Azure backup recoveryPoint
    /// Please note <see cref="DataProtectionBackupRecoveryPointProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DataProtectionBackupDiscreteRecoveryPointProperties"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownAzureBackupRecoveryPoint))]
    public abstract partial class DataProtectionBackupRecoveryPointProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataProtectionBackupRecoveryPointProperties"/>. </summary>
        protected DataProtectionBackupRecoveryPointProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataProtectionBackupRecoveryPointProperties"/>. </summary>
        /// <param name="objectType"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataProtectionBackupRecoveryPointProperties(string objectType, Dictionary<string, BinaryData> rawData)
        {
            ObjectType = objectType;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the object type. </summary>
        internal string ObjectType { get; set; }
    }
}
