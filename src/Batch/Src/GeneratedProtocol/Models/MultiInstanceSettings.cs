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
    /// Settings which specify how to run a multi-instance task.
    /// Multi-instance tasks are commonly used to support MPI tasks.
    /// </summary>
    public partial class MultiInstanceSettings
    {
        /// <summary>
        /// Initializes a new instance of the MultiInstanceSettings class.
        /// </summary>
        public MultiInstanceSettings() { }

        /// <summary>
        /// Initializes a new instance of the MultiInstanceSettings class.
        /// </summary>
        public MultiInstanceSettings(int numberOfInstances, string coordinationCommandLine = default(string), IList<ResourceFile> commonResourceFiles = default(IList<ResourceFile>))
        {
            NumberOfInstances = numberOfInstances;
            CoordinationCommandLine = coordinationCommandLine;
            CommonResourceFiles = commonResourceFiles;
        }

        /// <summary>
        /// The number of compute nodes required by the multi-instance task.
        /// </summary>
        [JsonProperty(PropertyName = "numberOfInstances")]
        public int NumberOfInstances { get; set; }

        /// <summary>
        /// The command to run on the compute node instances for coordinating
        /// among the subtasks.
        /// </summary>
        [JsonProperty(PropertyName = "coordinationCommandLine")]
        public string CoordinationCommandLine { get; set; }

        /// <summary>
        /// A list of files that the Batch service will download before
        /// running the coordination command line. The difference between
        /// common resource files and task resource files is that common
        /// resource files are downloaded for all subtasks including the
        /// primary, whereas task resource files are downloaded only for the
        /// primary.
        /// </summary>
        [JsonProperty(PropertyName = "commonResourceFiles")]
        public IList<ResourceFile> CommonResourceFiles { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
        }
    }
}
