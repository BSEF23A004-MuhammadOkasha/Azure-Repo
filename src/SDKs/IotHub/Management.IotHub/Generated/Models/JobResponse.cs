// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Iothub.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties of the Job Response object.
    /// </summary>
    public partial class JobResponse
    {
        /// <summary>
        /// Initializes a new instance of the JobResponse class.
        /// </summary>
        public JobResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobResponse class.
        /// </summary>
        /// <param name="jobId">The job identifier.</param>
        /// <param name="startTimeUtc">The start time of the job.</param>
        /// <param name="endTimeUtc">The time the job stopped
        /// processing.</param>
        /// <param name="type">The type of the job. Possible values include:
        /// 'unknown', 'export', 'import', 'backup', 'readDeviceProperties',
        /// 'writeDeviceProperties', 'updateDeviceConfiguration',
        /// 'rebootDevice', 'factoryResetDevice', 'firmwareUpdate'</param>
        /// <param name="status">The status of the job. Possible values
        /// include: 'unknown', 'enqueued', 'running', 'completed', 'failed',
        /// 'cancelled'</param>
        /// <param name="failureReason">If status == failed, this string
        /// containing the reason for the failure.</param>
        /// <param name="statusMessage">The status message for the job.</param>
        /// <param name="parentJobId">The job identifier of the parent job, if
        /// any.</param>
        public JobResponse(string jobId = default(string), System.DateTime? startTimeUtc = default(System.DateTime?), System.DateTime? endTimeUtc = default(System.DateTime?), string type = default(string), JobStatus? status = default(JobStatus?), string failureReason = default(string), string statusMessage = default(string), string parentJobId = default(string))
        {
            JobId = jobId;
            StartTimeUtc = startTimeUtc;
            EndTimeUtc = endTimeUtc;
            Type = type;
            Status = status;
            FailureReason = failureReason;
            StatusMessage = statusMessage;
            ParentJobId = parentJobId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the job identifier.
        /// </summary>
        [JsonProperty(PropertyName = "jobId")]
        public string JobId { get; private set; }

        /// <summary>
        /// Gets the start time of the job.
        /// </summary>
        [JsonConverter(typeof(DateTimeRfc1123JsonConverter))]
        [JsonProperty(PropertyName = "startTimeUtc")]
        public System.DateTime? StartTimeUtc { get; private set; }

        /// <summary>
        /// Gets the time the job stopped processing.
        /// </summary>
        [JsonConverter(typeof(DateTimeRfc1123JsonConverter))]
        [JsonProperty(PropertyName = "endTimeUtc")]
        public System.DateTime? EndTimeUtc { get; private set; }

        /// <summary>
        /// Gets the type of the job. Possible values include: 'unknown',
        /// 'export', 'import', 'backup', 'readDeviceProperties',
        /// 'writeDeviceProperties', 'updateDeviceConfiguration',
        /// 'rebootDevice', 'factoryResetDevice', 'firmwareUpdate'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the status of the job. Possible values include: 'unknown',
        /// 'enqueued', 'running', 'completed', 'failed', 'cancelled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public JobStatus? Status { get; private set; }

        /// <summary>
        /// Gets if status == failed, this string containing the reason for the
        /// failure.
        /// </summary>
        [JsonProperty(PropertyName = "failureReason")]
        public string FailureReason { get; private set; }

        /// <summary>
        /// Gets the status message for the job.
        /// </summary>
        [JsonProperty(PropertyName = "statusMessage")]
        public string StatusMessage { get; private set; }

        /// <summary>
        /// Gets the job identifier of the parent job, if any.
        /// </summary>
        [JsonProperty(PropertyName = "parentJobId")]
        public string ParentJobId { get; private set; }

    }
}
