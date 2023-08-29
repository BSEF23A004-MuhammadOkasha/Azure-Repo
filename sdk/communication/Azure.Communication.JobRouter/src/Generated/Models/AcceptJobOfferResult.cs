// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Response containing Id's for the worker, job, and assignment from an accepted offer. </summary>
    public partial class AcceptJobOfferResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AcceptJobOfferResult"/>. </summary>
        /// <param name="assignmentId"> The assignment Id that assigns a worker that has accepted an offer to a job. </param>
        /// <param name="jobId"> The Id of the job assigned. </param>
        /// <param name="workerId"> The Id of the worker that has been assigned this job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentId"/>, <paramref name="jobId"/> or <paramref name="workerId"/> is null. </exception>
        internal AcceptJobOfferResult(string assignmentId, string jobId, string workerId)
        {
            Argument.AssertNotNull(assignmentId, nameof(assignmentId));
            Argument.AssertNotNull(jobId, nameof(jobId));
            Argument.AssertNotNull(workerId, nameof(workerId));

            AssignmentId = assignmentId;
            JobId = jobId;
            WorkerId = workerId;
        }

        /// <summary> Initializes a new instance of <see cref="AcceptJobOfferResult"/>. </summary>
        /// <param name="assignmentId"> The assignment Id that assigns a worker that has accepted an offer to a job. </param>
        /// <param name="jobId"> The Id of the job assigned. </param>
        /// <param name="workerId"> The Id of the worker that has been assigned this job. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AcceptJobOfferResult(string assignmentId, string jobId, string workerId, Dictionary<string, BinaryData> rawData)
        {
            AssignmentId = assignmentId;
            JobId = jobId;
            WorkerId = workerId;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AcceptJobOfferResult"/> for deserialization. </summary>
        internal AcceptJobOfferResult()
        {
        }

        /// <summary> The assignment Id that assigns a worker that has accepted an offer to a job. </summary>
        public string AssignmentId { get; }
        /// <summary> The Id of the job assigned. </summary>
        public string JobId { get; }
        /// <summary> The Id of the worker that has been assigned this job. </summary>
        public string WorkerId { get; }
    }
}
