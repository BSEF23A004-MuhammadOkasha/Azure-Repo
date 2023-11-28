// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing the ContainerAppJobExecution data model.
    /// Container Apps Job execution.
    /// </summary>
    public partial class ContainerAppJobExecutionData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ContainerAppJobExecutionData"/>. </summary>
        internal ContainerAppJobExecutionData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppJobExecutionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status"> Current running State of the job. </param>
        /// <param name="startOn"> Job execution start time. </param>
        /// <param name="endOn"> Job execution end time. </param>
        /// <param name="template"> Job's execution container. </param>
        internal ContainerAppJobExecutionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, JobExecutionRunningState? status, DateTimeOffset? startOn, DateTimeOffset? endOn, ContainerAppJobExecutionTemplate template) : base(id, name, resourceType, systemData)
        {
            Status = status;
            StartOn = startOn;
            EndOn = endOn;
            Template = template;
        }

        /// <summary> Current running State of the job. </summary>
        public JobExecutionRunningState? Status { get; }
        /// <summary> Job execution start time. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Job execution end time. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Job's execution container. </summary>
        public ContainerAppJobExecutionTemplate Template { get; }
    }
}
