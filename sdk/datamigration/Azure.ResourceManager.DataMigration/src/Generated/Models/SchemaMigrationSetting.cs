// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Settings for migrating schema from source to target. </summary>
    public partial class SchemaMigrationSetting
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SchemaMigrationSetting"/>. </summary>
        public SchemaMigrationSetting()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SchemaMigrationSetting"/>. </summary>
        /// <param name="schemaOption"> Option on how to migrate the schema. </param>
        /// <param name="fileId"> Resource Identifier of a file resource containing the uploaded schema file. </param>
        /// <param name="fileName"> Name of the file resource containing the uploaded schema file. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SchemaMigrationSetting(SchemaMigrationOption? schemaOption, string fileId, string fileName, Dictionary<string, BinaryData> rawData)
        {
            SchemaOption = schemaOption;
            FileId = fileId;
            FileName = fileName;
            _rawData = rawData;
        }

        /// <summary> Option on how to migrate the schema. </summary>
        public SchemaMigrationOption? SchemaOption { get; set; }
        /// <summary> Resource Identifier of a file resource containing the uploaded schema file. </summary>
        public string FileId { get; set; }
        /// <summary> Name of the file resource containing the uploaded schema file. </summary>
        public string FileName { get; set; }
    }
}
