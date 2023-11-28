// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> The assignment for a worker to a job. </summary>
    public partial class RouterWorkerAssignment
    {
        /// <summary> Initializes a new instance of <see cref="RouterWorkerAssignment"/>. </summary>
        /// <param name="assignmentId"> Id of the assignment. </param>
        /// <param name="jobId"> Id of the job assigned. </param>
        /// <param name="capacityCost"> The amount of capacity this assignment has consumed on the worker. </param>
        /// <param name="assignedAt"> The assignment time of the job in UTC. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentId"/> or <paramref name="jobId"/> is null. </exception>
        internal RouterWorkerAssignment(string assignmentId, string jobId, int capacityCost, DateTimeOffset assignedAt)
        {
            Argument.AssertNotNull(assignmentId, nameof(assignmentId));
            Argument.AssertNotNull(jobId, nameof(jobId));

            AssignmentId = assignmentId;
            JobId = jobId;
            CapacityCost = capacityCost;
            AssignedAt = assignedAt;
        }

        /// <summary> Id of the assignment. </summary>
        public string AssignmentId { get; }
        /// <summary> Id of the job assigned. </summary>
        public string JobId { get; }
        /// <summary> The amount of capacity this assignment has consumed on the worker. </summary>
        public int CapacityCost { get; }
        /// <summary> The assignment time of the job in UTC. </summary>
        public DateTimeOffset AssignedAt { get; }
    }
}
