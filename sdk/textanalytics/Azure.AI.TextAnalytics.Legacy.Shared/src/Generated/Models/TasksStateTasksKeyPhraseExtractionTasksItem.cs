// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics.Legacy;

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    /// <summary> The TasksStateTasksKeyPhraseExtractionTasksItem. </summary>
    internal partial class TasksStateTasksKeyPhraseExtractionTasksItem : TaskState
    {
        /// <summary> Initializes a new instance of <see cref="TasksStateTasksKeyPhraseExtractionTasksItem"/>. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        internal TasksStateTasksKeyPhraseExtractionTasksItem(DateTimeOffset lastUpdateDateTime, State status) : base(lastUpdateDateTime, status)
        {
        }

        /// <summary> Initializes a new instance of <see cref="TasksStateTasksKeyPhraseExtractionTasksItem"/>. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="taskName"></param>
        /// <param name="status"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="results"></param>
        internal TasksStateTasksKeyPhraseExtractionTasksItem(DateTimeOffset lastUpdateDateTime, string taskName, State status, IDictionary<string, BinaryData> serializedAdditionalRawData, KeyPhraseResult results) : base(lastUpdateDateTime, taskName, status, serializedAdditionalRawData)
        {
            Results = results;
        }

        /// <summary> Initializes a new instance of <see cref="TasksStateTasksKeyPhraseExtractionTasksItem"/> for deserialization. </summary>
        internal TasksStateTasksKeyPhraseExtractionTasksItem()
        {
        }

        /// <summary> Gets the results. </summary>
        public KeyPhraseResult Results { get; }
    }
}
