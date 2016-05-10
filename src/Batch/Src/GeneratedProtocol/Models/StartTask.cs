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
    /// A task which is run when a compute node joins a pool in the Azure
    /// Batch service, or when the compute node is rebooted or reimaged.
    /// </summary>
    public partial class StartTask
    {
        /// <summary>
        /// Initializes a new instance of the StartTask class.
        /// </summary>
        public StartTask() { }

        /// <summary>
        /// Initializes a new instance of the StartTask class.
        /// </summary>
        public StartTask(string commandLine = default(string), IList<ResourceFile> resourceFiles = default(IList<ResourceFile>), IList<EnvironmentSetting> environmentSettings = default(IList<EnvironmentSetting>), bool? runElevated = default(bool?), int? maxTaskRetryCount = default(int?), bool? waitForSuccess = default(bool?))
        {
            CommandLine = commandLine;
            ResourceFiles = resourceFiles;
            EnvironmentSettings = environmentSettings;
            RunElevated = runElevated;
            MaxTaskRetryCount = maxTaskRetryCount;
            WaitForSuccess = waitForSuccess;
        }

        /// <summary>
        /// The command line of the start task.
        /// </summary>
        [JsonProperty(PropertyName = "commandLine")]
        public string CommandLine { get; set; }

        /// <summary>
        /// A list of files that the Batch service will download to the
        /// compute node before running the command line.
        /// </summary>
        [JsonProperty(PropertyName = "resourceFiles")]
        public IList<ResourceFile> ResourceFiles { get; set; }

        /// <summary>
        /// A list of environment variable settings for the start task.
        /// </summary>
        [JsonProperty(PropertyName = "environmentSettings")]
        public IList<EnvironmentSetting> EnvironmentSettings { get; set; }

        /// <summary>
        /// Whether to run the start task in elevated mode. The default value
        /// is false.
        /// </summary>
        [JsonProperty(PropertyName = "runElevated")]
        public bool? RunElevated { get; set; }

        /// <summary>
        /// The maximum number of times the task may be retried.
        /// </summary>
        [JsonProperty(PropertyName = "maxTaskRetryCount")]
        public int? MaxTaskRetryCount { get; set; }

        /// <summary>
        /// Whether the Batch service should wait for the start task to
        /// complete successfully (that is, to exit with exit code 0) before
        /// scheduling any tasks on the compute node.
        /// </summary>
        [JsonProperty(PropertyName = "waitForSuccess")]
        public bool? WaitForSuccess { get; set; }

    }
}
