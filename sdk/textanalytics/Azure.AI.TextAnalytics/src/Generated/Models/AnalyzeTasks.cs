// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.AI.TextAnalytics.Internal;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The TasksStateTasks. </summary>
    internal partial class AnalyzeTasks
    {
        /// <summary> Initializes a new instance of AnalyzeTasks. </summary>
        /// <param name="completed"></param>
        /// <param name="failed"></param>
        /// <param name="inProgress"></param>
        /// <param name="total"></param>
        internal AnalyzeTasks(int completed, int failed, int inProgress, int total)
        {
            Completed = completed;
            Failed = failed;
            InProgress = inProgress;
            Total = total;
            EntityRecognitionTasks = new ChangeTrackingList<EntityRecognitionTasksItem>();
            EntityRecognitionPiiTasks = new ChangeTrackingList<EntityRecognitionPiiTasksItem>();
            KeyPhraseExtractionTasks = new ChangeTrackingList<KeyPhraseExtractionTasksItem>();
            EntityLinkingTasks = new ChangeTrackingList<EntityLinkingTasksItem>();
            SentimentAnalysisTasks = new ChangeTrackingList<SentimentAnalysisTasksItem>();
            ExtractiveSummarizationTasks = new ChangeTrackingList<ExtractiveSummarizationTasksItem>();
            CustomEntityRecognitionTasks = new ChangeTrackingList<CustomEntityRecognitionTasksItem>();
            CustomSingleClassificationTasks = new ChangeTrackingList<CustomSingleClassificationTasksItem>();
            CustomMultiClassificationTasks = new ChangeTrackingList<CustomMultiClassificationTasksItem>();
        }

        /// <summary> Initializes a new instance of AnalyzeTasks. </summary>
        /// <param name="completed"></param>
        /// <param name="failed"></param>
        /// <param name="inProgress"></param>
        /// <param name="total"></param>
        /// <param name="entityRecognitionTasks"></param>
        /// <param name="entityRecognitionPiiTasks"></param>
        /// <param name="keyPhraseExtractionTasks"></param>
        /// <param name="entityLinkingTasks"></param>
        /// <param name="sentimentAnalysisTasks"></param>
        /// <param name="extractiveSummarizationTasks"></param>
        /// <param name="customEntityRecognitionTasks"></param>
        /// <param name="customSingleClassificationTasks"></param>
        /// <param name="customMultiClassificationTasks"></param>
        internal AnalyzeTasks(int completed, int failed, int inProgress, int total, IReadOnlyList<EntityRecognitionTasksItem> entityRecognitionTasks, IReadOnlyList<EntityRecognitionPiiTasksItem> entityRecognitionPiiTasks, IReadOnlyList<KeyPhraseExtractionTasksItem> keyPhraseExtractionTasks, IReadOnlyList<EntityLinkingTasksItem> entityLinkingTasks, IReadOnlyList<SentimentAnalysisTasksItem> sentimentAnalysisTasks, IReadOnlyList<ExtractiveSummarizationTasksItem> extractiveSummarizationTasks, IReadOnlyList<CustomEntityRecognitionTasksItem> customEntityRecognitionTasks, IReadOnlyList<CustomSingleClassificationTasksItem> customSingleClassificationTasks, IReadOnlyList<CustomMultiClassificationTasksItem> customMultiClassificationTasks)
        {
            Completed = completed;
            Failed = failed;
            InProgress = inProgress;
            Total = total;
            EntityRecognitionTasks = entityRecognitionTasks;
            EntityRecognitionPiiTasks = entityRecognitionPiiTasks;
            KeyPhraseExtractionTasks = keyPhraseExtractionTasks;
            EntityLinkingTasks = entityLinkingTasks;
            SentimentAnalysisTasks = sentimentAnalysisTasks;
            ExtractiveSummarizationTasks = extractiveSummarizationTasks;
            CustomEntityRecognitionTasks = customEntityRecognitionTasks;
            CustomSingleClassificationTasks = customSingleClassificationTasks;
            CustomMultiClassificationTasks = customMultiClassificationTasks;
        }

        public int Completed { get; }
        public int Failed { get; }
        public int InProgress { get; }
        public int Total { get; }
        public IReadOnlyList<EntityRecognitionTasksItem> EntityRecognitionTasks { get; }
        public IReadOnlyList<EntityRecognitionPiiTasksItem> EntityRecognitionPiiTasks { get; }
        public IReadOnlyList<KeyPhraseExtractionTasksItem> KeyPhraseExtractionTasks { get; }
        public IReadOnlyList<EntityLinkingTasksItem> EntityLinkingTasks { get; }
        public IReadOnlyList<SentimentAnalysisTasksItem> SentimentAnalysisTasks { get; }
        public IReadOnlyList<ExtractiveSummarizationTasksItem> ExtractiveSummarizationTasks { get; }
        public IReadOnlyList<CustomEntityRecognitionTasksItem> CustomEntityRecognitionTasks { get; }
        public IReadOnlyList<CustomSingleClassificationTasksItem> CustomSingleClassificationTasks { get; }
        public IReadOnlyList<CustomMultiClassificationTasksItem> CustomMultiClassificationTasks { get; }
    }
}
