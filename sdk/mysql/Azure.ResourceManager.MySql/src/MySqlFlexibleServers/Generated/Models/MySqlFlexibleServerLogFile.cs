// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Represents a logFile. </summary>
    public partial class MySqlFlexibleServerLogFile : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerLogFile"/>. </summary>
        public MySqlFlexibleServerLogFile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerLogFile"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sizeInKB"> The size in kb of the logFile. </param>
        /// <param name="createdOn"> Creation timestamp of the log file. </param>
        /// <param name="typePropertiesType"> Type of the log file. </param>
        /// <param name="lastModifiedOn"> Last modified timestamp of the log file. </param>
        /// <param name="uri"> The url to download the log file from. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlFlexibleServerLogFile(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, long? sizeInKB, DateTimeOffset? createdOn, string typePropertiesType, DateTimeOffset? lastModifiedOn, Uri uri, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            SizeInKB = sizeInKB;
            CreatedOn = createdOn;
            TypePropertiesType = typePropertiesType;
            LastModifiedOn = lastModifiedOn;
            Uri = uri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The size in kb of the logFile. </summary>
        public long? SizeInKB { get; set; }
        /// <summary> Creation timestamp of the log file. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> Type of the log file. </summary>
        public string TypePropertiesType { get; set; }
        /// <summary> Last modified timestamp of the log file. </summary>
        public DateTimeOffset? LastModifiedOn { get; set; }
        /// <summary> The url to download the log file from. </summary>
        public Uri Uri { get; set; }
    }
}
