// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The properties of a file on a compute node.
    /// </summary>
    public partial class FileProperties
    {
        /// <summary>
        /// Initializes a new instance of the FileProperties class.
        /// </summary>
        public FileProperties() { }

        /// <summary>
        /// Initializes a new instance of the FileProperties class.
        /// </summary>
        public FileProperties(DateTime lastModified, long contentLength, DateTime? creationTime = default(DateTime?), string contentType = default(string), string fileMode = default(string))
        {
            CreationTime = creationTime;
            LastModified = lastModified;
            ContentLength = contentLength;
            ContentType = contentType;
            FileMode = fileMode;
        }

        /// <summary>
        /// The file creation time.
        /// </summary>
        [JsonProperty(PropertyName = "creationTime")]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// The time at which the file was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "lastModified")]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// The length of the file.
        /// </summary>
        [JsonProperty(PropertyName = "contentLength")]
        public long ContentLength { get; set; }

        /// <summary>
        /// The content type of the file.
        /// </summary>
        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// The file mode attribute in octal format. This property will be
        /// returned only from a Linux compute node.
        /// </summary>
        [JsonProperty(PropertyName = "fileMode")]
        public string FileMode { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
