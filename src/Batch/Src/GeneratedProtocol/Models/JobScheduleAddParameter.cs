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
    /// A job schedule that allows recurring jobs by specifying when to run
    /// jobs and a specification used to create each job.
    /// </summary>
    public partial class JobScheduleAddParameter
    {
        /// <summary>
        /// Initializes a new instance of the JobScheduleAddParameter class.
        /// </summary>
        public JobScheduleAddParameter() { }

        /// <summary>
        /// Initializes a new instance of the JobScheduleAddParameter class.
        /// </summary>
        public JobScheduleAddParameter(string id, Schedule schedule, JobSpecification jobSpecification, string displayName = default(string), IList<MetadataItem> metadata = default(IList<MetadataItem>))
        {
            Id = id;
            DisplayName = displayName;
            Schedule = schedule;
            JobSpecification = jobSpecification;
            Metadata = metadata;
        }

        /// <summary>
        /// A string that uniquely identifies the schedule within the account.
        /// A GUID is recommended.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The display name for the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The schedule according to which jobs will be created.
        /// </summary>
        [JsonProperty(PropertyName = "schedule")]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// The details of the jobs to be created on this schedule.
        /// </summary>
        [JsonProperty(PropertyName = "jobSpecification")]
        public JobSpecification JobSpecification { get; set; }

        /// <summary>
        /// A list of name-value pairs associated with the schedule as
        /// metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Schedule == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Schedule");
            }
            if (JobSpecification == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "JobSpecification");
            }
            if (this.JobSpecification != null)
            {
                this.JobSpecification.Validate();
            }
        }
    }
}
