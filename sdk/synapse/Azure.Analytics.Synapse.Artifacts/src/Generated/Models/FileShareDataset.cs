// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> An on-premises file system dataset. </summary>
    public partial class FileShareDataset : Dataset
    {
        /// <summary> Initializes a new instance of <see cref="FileShareDataset"/>. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public FileShareDataset(LinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));

            Type = "FileShare";
        }

        /// <summary> Initializes a new instance of <see cref="FileShareDataset"/>. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="folderPath"> The path of the on-premises file system. Type: string (or Expression with resultType string). </param>
        /// <param name="fileName"> The name of the on-premises file system. Type: string (or Expression with resultType string). </param>
        /// <param name="modifiedDatetimeStart"> The start of file's modified datetime. Type: string (or Expression with resultType string). </param>
        /// <param name="modifiedDatetimeEnd"> The end of file's modified datetime. Type: string (or Expression with resultType string). </param>
        /// <param name="format">
        /// The format of the files.
        /// Please note <see cref="DatasetStorageFormat"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AvroFormat"/>, <see cref="JsonFormat"/>, <see cref="OrcFormat"/>, <see cref="ParquetFormat"/> and <see cref="TextFormat"/>.
        /// </param>
        /// <param name="fileFilter"> Specify a filter to be used to select a subset of files in the folderPath rather than all files. Type: string (or Expression with resultType string). </param>
        /// <param name="compression"> The data compression method used for the file system. </param>
        internal FileShareDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, object folderPath, object fileName, object modifiedDatetimeStart, object modifiedDatetimeEnd, DatasetStorageFormat format, object fileFilter, DatasetCompression compression) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            FolderPath = folderPath;
            FileName = fileName;
            ModifiedDatetimeStart = modifiedDatetimeStart;
            ModifiedDatetimeEnd = modifiedDatetimeEnd;
            Format = format;
            FileFilter = fileFilter;
            Compression = compression;
            Type = type ?? "FileShare";
        }

        /// <summary> Initializes a new instance of <see cref="FileShareDataset"/> for deserialization. </summary>
        internal FileShareDataset()
        {
        }

        /// <summary> The path of the on-premises file system. Type: string (or Expression with resultType string). </summary>
        public object FolderPath { get; set; }
        /// <summary> The name of the on-premises file system. Type: string (or Expression with resultType string). </summary>
        public object FileName { get; set; }
        /// <summary> The start of file's modified datetime. Type: string (or Expression with resultType string). </summary>
        public object ModifiedDatetimeStart { get; set; }
        /// <summary> The end of file's modified datetime. Type: string (or Expression with resultType string). </summary>
        public object ModifiedDatetimeEnd { get; set; }
        /// <summary>
        /// The format of the files.
        /// Please note <see cref="DatasetStorageFormat"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AvroFormat"/>, <see cref="JsonFormat"/>, <see cref="OrcFormat"/>, <see cref="ParquetFormat"/> and <see cref="TextFormat"/>.
        /// </summary>
        public DatasetStorageFormat Format { get; set; }
        /// <summary> Specify a filter to be used to select a subset of files in the folderPath rather than all files. Type: string (or Expression with resultType string). </summary>
        public object FileFilter { get; set; }
        /// <summary> The data compression method used for the file system. </summary>
        public DatasetCompression Compression { get; set; }
    }
}
