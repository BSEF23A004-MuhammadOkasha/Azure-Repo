// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The TasksStateTasksKeyPhraseExtractionTasksItem. </summary>
    internal partial class KeyPhraseExtractionTasksItem : TaskState
    {
        /// <summary> Initializes a new instance of KeyPhraseExtractionTasksItem. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        internal KeyPhraseExtractionTasksItem(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status) : base(lastUpdateDateTime, status)
        {
        }

        /// <summary> Initializes a new instance of KeyPhraseExtractionTasksItem. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="taskName"></param>
        /// <param name="status"></param>
        /// <param name="results"></param>
        internal KeyPhraseExtractionTasksItem(DateTimeOffset lastUpdateDateTime, string taskName, TextAnalyticsOperationStatus status, KeyPhraseResult results) : base(lastUpdateDateTime, taskName, status)
        {
            Results = results;
        }

        public KeyPhraseResult Results { get; }
    }
}
