// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Base class for file properties. </summary>
    public partial class ProjectFileProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProjectFileProperties"/>. </summary>
        public ProjectFileProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProjectFileProperties"/>. </summary>
        /// <param name="extension"> Optional File extension. If submitted it should not have a leading period and must match the extension from filePath. </param>
        /// <param name="filePath"> Relative path of this file resource. This property can be set when creating or updating the file resource. </param>
        /// <param name="lastModified"> Modification DateTime. </param>
        /// <param name="mediaType"> File content type. This property can be modified to reflect the file content type. </param>
        /// <param name="size"> File size. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProjectFileProperties(string extension, string filePath, DateTimeOffset? lastModified, string mediaType, long? size, Dictionary<string, BinaryData> rawData)
        {
            Extension = extension;
            FilePath = filePath;
            LastModified = lastModified;
            MediaType = mediaType;
            Size = size;
            _rawData = rawData;
        }

        /// <summary> Optional File extension. If submitted it should not have a leading period and must match the extension from filePath. </summary>
        public string Extension { get; set; }
        /// <summary> Relative path of this file resource. This property can be set when creating or updating the file resource. </summary>
        public string FilePath { get; set; }
        /// <summary> Modification DateTime. </summary>
        public DateTimeOffset? LastModified { get; }
        /// <summary> File content type. This property can be modified to reflect the file content type. </summary>
        public string MediaType { get; set; }
        /// <summary> File size. </summary>
        public long? Size { get; }
    }
}
