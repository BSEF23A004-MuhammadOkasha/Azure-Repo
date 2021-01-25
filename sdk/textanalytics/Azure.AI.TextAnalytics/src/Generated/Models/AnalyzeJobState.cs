// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The AnalyzeJobState. </summary>
    internal partial class AnalyzeJobState : AnalyzeJobMetadata
    {
        /// <summary> Initializes a new instance of AnalyzeJobState. </summary>
        /// <param name="createdDateTime"> . </param>
        /// <param name="jobId"> . </param>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="status"> . </param>
        /// <param name="tasks"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="tasks"/> is null. </exception>
        internal AnalyzeJobState(DateTimeOffset createdDateTime, string jobId, DateTimeOffset lastUpdateDateTime, JobStatus status, AnalyzeTasks tasks) : base(createdDateTime, jobId, lastUpdateDateTime, status)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (tasks == null)
            {
                throw new ArgumentNullException(nameof(tasks));
            }

            Errors = new ChangeTrackingList<TextAnalyticsErrorInternal>();
            Tasks = tasks;
        }

        /// <summary> Initializes a new instance of AnalyzeJobState. </summary>
        /// <param name="createdDateTime"> . </param>
        /// <param name="expirationDateTime"> . </param>
        /// <param name="jobId"> . </param>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="status"> . </param>
        /// <param name="displayName"> . </param>
        /// <param name="errors"> . </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the request payload. </param>
        /// <param name="tasks"> . </param>
        /// <param name="nextLink"> . </param>
        internal AnalyzeJobState(DateTimeOffset createdDateTime, DateTimeOffset? expirationDateTime, string jobId, DateTimeOffset lastUpdateDateTime, JobStatus status, string displayName, IReadOnlyList<TextAnalyticsErrorInternal> errors, TextDocumentBatchStatistics statistics, AnalyzeTasks tasks, string nextLink) : base(createdDateTime, expirationDateTime, jobId, lastUpdateDateTime, status, displayName)
        {
            Errors = errors;
            Statistics = statistics;
            Tasks = tasks;
            NextLink = nextLink;
        }

        public IReadOnlyList<TextAnalyticsErrorInternal> Errors { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the request payload. </summary>
        public TextDocumentBatchStatistics Statistics { get; }
        public AnalyzeTasks Tasks { get; }
        public string NextLink { get; }
    }
}
