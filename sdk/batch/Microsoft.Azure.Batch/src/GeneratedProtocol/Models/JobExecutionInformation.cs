// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains information about the execution of a Job in the Azure Batch
    /// service.
    /// </summary>
    public partial class JobExecutionInformation
    {
        /// <summary>
        /// Initializes a new instance of the JobExecutionInformation class.
        /// </summary>
        public JobExecutionInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobExecutionInformation class.
        /// </summary>
        /// <param name="startTime">The start time of the Job.</param>
        /// <param name="endTime">The completion time of the Job.</param>
        /// <param name="poolId">The ID of the Pool to which this Job is
        /// assigned.</param>
        /// <param name="schedulingError">Details of any error encountered by
        /// the service in starting the Job.</param>
        /// <param name="terminateReason">A string describing the reason the
        /// Job ended.</param>
        public JobExecutionInformation(System.DateTime startTime, System.DateTime? endTime = default(System.DateTime?), string poolId = default(string), JobSchedulingError schedulingError = default(JobSchedulingError), string terminateReason = default(string))
        {
            StartTime = startTime;
            EndTime = endTime;
            PoolId = poolId;
            SchedulingError = schedulingError;
            TerminateReason = terminateReason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the start time of the Job.
        /// </summary>
        /// <remarks>
        /// This is the time at which the Job was created.
        /// </remarks>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the completion time of the Job.
        /// </summary>
        /// <remarks>
        /// This property is set only if the Job is in the completed state.
        /// </remarks>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the ID of the Pool to which this Job is assigned.
        /// </summary>
        /// <remarks>
        /// This element contains the actual Pool where the Job is assigned.
        /// When you get Job details from the service, they also contain a
        /// poolInfo element, which contains the Pool configuration data from
        /// when the Job was added or updated. That poolInfo element may also
        /// contain a poolId element. If it does, the two IDs are the same. If
        /// it does not, it means the Job ran on an auto Pool, and this
        /// property contains the ID of that auto Pool.
        /// </remarks>
        [JsonProperty(PropertyName = "poolId")]
        public string PoolId { get; set; }

        /// <summary>
        /// Gets or sets details of any error encountered by the service in
        /// starting the Job.
        /// </summary>
        /// <remarks>
        /// This property is not set if there was no error starting the Job.
        /// </remarks>
        [JsonProperty(PropertyName = "schedulingError")]
        public JobSchedulingError SchedulingError { get; set; }

        /// <summary>
        /// Gets or sets a string describing the reason the Job ended.
        /// </summary>
        /// <remarks>
        /// This property is set only if the Job is in the completed state. If
        /// the Batch service terminates the Job, it sets the reason as
        /// follows: JMComplete - the Job Manager Task completed, and
        /// killJobOnCompletion was set to true. MaxWallClockTimeExpiry - the
        /// Job reached its maxWallClockTime constraint. TerminateJobSchedule -
        /// the Job ran as part of a schedule, and the schedule terminated.
        /// AllTasksComplete - the Job's onAllTasksComplete attribute is set to
        /// terminatejob, and all Tasks in the Job are complete. TaskFailed -
        /// the Job's onTaskFailure attribute is set to
        /// performExitOptionsJobAction, and a Task in the Job failed with an
        /// exit condition that specified a jobAction of terminatejob. Any
        /// other string is a user-defined reason specified in a call to the
        /// 'Terminate a Job' operation.
        /// </remarks>
        [JsonProperty(PropertyName = "terminateReason")]
        public string TerminateReason { get; set; }

    }
}
