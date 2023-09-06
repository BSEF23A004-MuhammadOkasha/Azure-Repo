// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Source LifeCycle. </summary>
    public partial class SourceLifeCycle
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SourceLifeCycle"/>. </summary>
        /// <param name="deleteAfter">
        /// Delete Option
        /// Please note <see cref="DataProtectionBackupDeleteSetting"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataProtectionBackupAbsoluteDeleteSetting"/>.
        /// </param>
        /// <param name="sourceDataStore"> DataStoreInfo base. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deleteAfter"/> or <paramref name="sourceDataStore"/> is null. </exception>
        public SourceLifeCycle(DataProtectionBackupDeleteSetting deleteAfter, DataStoreInfoBase sourceDataStore)
        {
            Argument.AssertNotNull(deleteAfter, nameof(deleteAfter));
            Argument.AssertNotNull(sourceDataStore, nameof(sourceDataStore));

            DeleteAfter = deleteAfter;
            SourceDataStore = sourceDataStore;
            TargetDataStoreCopySettings = new ChangeTrackingList<TargetCopySetting>();
        }

        /// <summary> Initializes a new instance of <see cref="SourceLifeCycle"/>. </summary>
        /// <param name="deleteAfter">
        /// Delete Option
        /// Please note <see cref="DataProtectionBackupDeleteSetting"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataProtectionBackupAbsoluteDeleteSetting"/>.
        /// </param>
        /// <param name="sourceDataStore"> DataStoreInfo base. </param>
        /// <param name="targetDataStoreCopySettings"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SourceLifeCycle(DataProtectionBackupDeleteSetting deleteAfter, DataStoreInfoBase sourceDataStore, IList<TargetCopySetting> targetDataStoreCopySettings, Dictionary<string, BinaryData> rawData)
        {
            DeleteAfter = deleteAfter;
            SourceDataStore = sourceDataStore;
            TargetDataStoreCopySettings = targetDataStoreCopySettings;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SourceLifeCycle"/> for deserialization. </summary>
        internal SourceLifeCycle()
        {
        }

        /// <summary>
        /// Delete Option
        /// Please note <see cref="DataProtectionBackupDeleteSetting"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataProtectionBackupAbsoluteDeleteSetting"/>.
        /// </summary>
        public DataProtectionBackupDeleteSetting DeleteAfter { get; set; }
        /// <summary> DataStoreInfo base. </summary>
        public DataStoreInfoBase SourceDataStore { get; set; }
        /// <summary> Gets the target data store copy settings. </summary>
        public IList<TargetCopySetting> TargetDataStoreCopySettings { get; }
    }
}
