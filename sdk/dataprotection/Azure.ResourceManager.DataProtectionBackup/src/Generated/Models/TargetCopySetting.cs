// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Target copy settings. </summary>
    public partial class TargetCopySetting
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TargetCopySetting"/>. </summary>
        /// <param name="copyAfter">
        /// It can be CustomCopyOption or ImmediateCopyOption.
        /// Please note <see cref="DataProtectionBackupCopySetting"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CopyOnExpirySetting"/>, <see cref="CustomCopySetting"/> and <see cref="ImmediateCopySetting"/>.
        /// </param>
        /// <param name="dataStore"> Info of target datastore. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="copyAfter"/> or <paramref name="dataStore"/> is null. </exception>
        public TargetCopySetting(DataProtectionBackupCopySetting copyAfter, DataStoreInfoBase dataStore)
        {
            Argument.AssertNotNull(copyAfter, nameof(copyAfter));
            Argument.AssertNotNull(dataStore, nameof(dataStore));

            CopyAfter = copyAfter;
            DataStore = dataStore;
        }

        /// <summary> Initializes a new instance of <see cref="TargetCopySetting"/>. </summary>
        /// <param name="copyAfter">
        /// It can be CustomCopyOption or ImmediateCopyOption.
        /// Please note <see cref="DataProtectionBackupCopySetting"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CopyOnExpirySetting"/>, <see cref="CustomCopySetting"/> and <see cref="ImmediateCopySetting"/>.
        /// </param>
        /// <param name="dataStore"> Info of target datastore. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TargetCopySetting(DataProtectionBackupCopySetting copyAfter, DataStoreInfoBase dataStore, Dictionary<string, BinaryData> rawData)
        {
            CopyAfter = copyAfter;
            DataStore = dataStore;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="TargetCopySetting"/> for deserialization. </summary>
        internal TargetCopySetting()
        {
        }

        /// <summary>
        /// It can be CustomCopyOption or ImmediateCopyOption.
        /// Please note <see cref="DataProtectionBackupCopySetting"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CopyOnExpirySetting"/>, <see cref="CustomCopySetting"/> and <see cref="ImmediateCopySetting"/>.
        /// </summary>
        public DataProtectionBackupCopySetting CopyAfter { get; set; }
        /// <summary> Info of target datastore. </summary>
        public DataStoreInfoBase DataStore { get; set; }
    }
}
