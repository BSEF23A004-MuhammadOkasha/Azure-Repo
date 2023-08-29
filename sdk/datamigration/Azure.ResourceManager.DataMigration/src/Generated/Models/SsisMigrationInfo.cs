// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> SSIS migration info with SSIS store type, overwrite policy. </summary>
    public partial class SsisMigrationInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SsisMigrationInfo"/>. </summary>
        public SsisMigrationInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SsisMigrationInfo"/>. </summary>
        /// <param name="ssisStoreType"> The SSIS store type of source, only SSIS catalog is supported now in DMS. </param>
        /// <param name="projectOverwriteOption"> The overwrite option for the SSIS project migration. </param>
        /// <param name="environmentOverwriteOption"> The overwrite option for the SSIS environment migration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SsisMigrationInfo(SsisStoreType? ssisStoreType, SsisMigrationOverwriteOption? projectOverwriteOption, SsisMigrationOverwriteOption? environmentOverwriteOption, Dictionary<string, BinaryData> rawData)
        {
            SsisStoreType = ssisStoreType;
            ProjectOverwriteOption = projectOverwriteOption;
            EnvironmentOverwriteOption = environmentOverwriteOption;
            _rawData = rawData;
        }

        /// <summary> The SSIS store type of source, only SSIS catalog is supported now in DMS. </summary>
        public SsisStoreType? SsisStoreType { get; set; }
        /// <summary> The overwrite option for the SSIS project migration. </summary>
        public SsisMigrationOverwriteOption? ProjectOverwriteOption { get; set; }
        /// <summary> The overwrite option for the SSIS environment migration. </summary>
        public SsisMigrationOverwriteOption? EnvironmentOverwriteOption { get; set; }
    }
}
