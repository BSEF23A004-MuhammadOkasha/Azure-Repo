// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for an Microsoft.Storage.StorageTaskCompleted event. </summary>
    public partial class StorageTaskCompletedEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageTaskCompletedEventData"/>. </summary>
        internal StorageTaskCompletedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageTaskCompletedEventData"/>. </summary>
        /// <param name="status"> The status for a storage task. </param>
        /// <param name="completedDateTime"> The time at which a storage task was completed. </param>
        /// <param name="taskExecutionId"> The execution id for a storage task. </param>
        /// <param name="taskName"> The task name for a storage task. </param>
        /// <param name="summaryReportBlobUri"> The summary report blob url for a storage task. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageTaskCompletedEventData(StorageTaskCompletedStatus? status, DateTimeOffset? completedDateTime, string taskExecutionId, string taskName, Uri summaryReportBlobUri, Dictionary<string, BinaryData> rawData)
        {
            Status = status;
            CompletedDateTime = completedDateTime;
            TaskExecutionId = taskExecutionId;
            TaskName = taskName;
            SummaryReportBlobUri = summaryReportBlobUri;
            _rawData = rawData;
        }

        /// <summary> The status for a storage task. </summary>
        public StorageTaskCompletedStatus? Status { get; }
        /// <summary> The time at which a storage task was completed. </summary>
        public DateTimeOffset? CompletedDateTime { get; }
        /// <summary> The execution id for a storage task. </summary>
        public string TaskExecutionId { get; }
        /// <summary> The task name for a storage task. </summary>
        public string TaskName { get; }
        /// <summary> The summary report blob url for a storage task. </summary>
        public Uri SummaryReportBlobUri { get; }
    }
}
