// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the SqlJob data model. </summary>
    public partial class SqlJobData : ResourceData
    {
        /// <summary> Initializes a new instance of SqlJobData. </summary>
        public SqlJobData()
        {
        }

        /// <summary> Initializes a new instance of SqlJobData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> User-defined description of the job. </param>
        /// <param name="version"> The job version number. </param>
        /// <param name="schedule"> Schedule properties of the job. </param>
        internal SqlJobData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, int? version, JobSchedule schedule) : base(id, name, resourceType, systemData)
        {
            Description = description;
            Version = version;
            Schedule = schedule;
        }

        /// <summary> User-defined description of the job. </summary>
        public string Description { get; set; }
        /// <summary> The job version number. </summary>
        public int? Version { get; }
        /// <summary> Schedule properties of the job. </summary>
        public JobSchedule Schedule { get; set; }
    }
}
