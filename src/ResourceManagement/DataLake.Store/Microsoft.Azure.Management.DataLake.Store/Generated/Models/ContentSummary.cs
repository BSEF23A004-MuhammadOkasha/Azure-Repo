// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Data Lake Store content summary information
    /// </summary>
    public partial class ContentSummary
    {
        /// <summary>
        /// Initializes a new instance of the ContentSummary class.
        /// </summary>
        public ContentSummary() { }

        /// <summary>
        /// Initializes a new instance of the ContentSummary class.
        /// </summary>
        /// <param name="directoryCount">the number of directories.</param>
        /// <param name="fileCount">the number of files.</param>
        /// <param name="length">the number of bytes used by the
        /// content.</param>
        /// <param name="spaceConsumed">the disk space consumed by the
        /// content.</param>
        public ContentSummary(long? directoryCount = default(long?), long? fileCount = default(long?), long? length = default(long?), long? spaceConsumed = default(long?))
        {
            DirectoryCount = directoryCount;
            FileCount = fileCount;
            Length = length;
            SpaceConsumed = spaceConsumed;
        }

        /// <summary>
        /// Gets the number of directories.
        /// </summary>
        [JsonProperty(PropertyName = "directoryCount")]
        public long? DirectoryCount { get; protected set; }

        /// <summary>
        /// Gets the number of files.
        /// </summary>
        [JsonProperty(PropertyName = "fileCount")]
        public long? FileCount { get; protected set; }

        /// <summary>
        /// Gets the number of bytes used by the content.
        /// </summary>
        [JsonProperty(PropertyName = "length")]
        public long? Length { get; protected set; }

        /// <summary>
        /// Gets the disk space consumed by the content.
        /// </summary>
        [JsonProperty(PropertyName = "spaceConsumed")]
        public long? SpaceConsumed { get; protected set; }

    }
}

