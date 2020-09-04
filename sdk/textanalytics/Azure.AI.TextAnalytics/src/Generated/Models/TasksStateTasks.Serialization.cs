// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class TasksStateTasks
    {
        internal static TasksStateTasks DeserializeTasksStateTasks(JsonElement element)
        {
            Optional<IReadOnlyList<TaskState>> details = default;
            int completed = default;
            int failed = default;
            int inProgress = default;
            int total = default;
            Optional<IReadOnlyList<TasksStateTasksEntityRecognitionTasksItem>> entityRecognitionTasks = default;
            Optional<IReadOnlyList<TasksStateTasksEntityRecognitionPiiTasksItem>> entityRecognitionPiiTasks = default;
            Optional<IReadOnlyList<EntityLinkingTasksItem>> entityLinkingTasks = default;
            Optional<IReadOnlyList<TasksStateTasksKeyPhraseExtractionTasksItem>> keyPhraseExtractionTasks = default;
            Optional<IReadOnlyList<TasksStateTasksSentimentAnalysisTasksItem>> sentimentAnalysisTasks = default;
            Optional<IReadOnlyList<CustomClassificationTasksItem>> customClassificationTasks = default;
            Optional<IReadOnlyList<CustomEntityRecognitionTasksItem>> customEntityRecognitionTasks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("details"))
                {
                    List<TaskState> array = new List<TaskState>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TaskState.DeserializeTaskState(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("completed"))
                {
                    completed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failed"))
                {
                    failed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("inProgress"))
                {
                    inProgress = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("total"))
                {
                    total = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("entityRecognitionTasks"))
                {
                    List<TasksStateTasksEntityRecognitionTasksItem> array = new List<TasksStateTasksEntityRecognitionTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TasksStateTasksEntityRecognitionTasksItem.DeserializeTasksStateTasksEntityRecognitionTasksItem(item));
                    }
                    entityRecognitionTasks = array;
                    continue;
                }
                if (property.NameEquals("entityRecognitionPiiTasks"))
                {
                    List<TasksStateTasksEntityRecognitionPiiTasksItem> array = new List<TasksStateTasksEntityRecognitionPiiTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TasksStateTasksEntityRecognitionPiiTasksItem.DeserializeTasksStateTasksEntityRecognitionPiiTasksItem(item));
                    }
                    entityRecognitionPiiTasks = array;
                    continue;
                }
                if (property.NameEquals("entityLinkingTasks"))
                {
                    List<EntityLinkingTasksItem> array = new List<EntityLinkingTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EntityLinkingTasksItem.DeserializeEntityLinkingTasksItem(item));
                    }
                    entityLinkingTasks = array;
                    continue;
                }
                if (property.NameEquals("keyPhraseExtractionTasks"))
                {
                    List<TasksStateTasksKeyPhraseExtractionTasksItem> array = new List<TasksStateTasksKeyPhraseExtractionTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TasksStateTasksKeyPhraseExtractionTasksItem.DeserializeTasksStateTasksKeyPhraseExtractionTasksItem(item));
                    }
                    keyPhraseExtractionTasks = array;
                    continue;
                }
                if (property.NameEquals("sentimentAnalysisTasks"))
                {
                    List<TasksStateTasksSentimentAnalysisTasksItem> array = new List<TasksStateTasksSentimentAnalysisTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TasksStateTasksSentimentAnalysisTasksItem.DeserializeTasksStateTasksSentimentAnalysisTasksItem(item));
                    }
                    sentimentAnalysisTasks = array;
                    continue;
                }
                if (property.NameEquals("customClassificationTasks"))
                {
                    List<CustomClassificationTasksItem> array = new List<CustomClassificationTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomClassificationTasksItem.DeserializeCustomClassificationTasksItem(item));
                    }
                    customClassificationTasks = array;
                    continue;
                }
                if (property.NameEquals("customEntityRecognitionTasks"))
                {
                    List<CustomEntityRecognitionTasksItem> array = new List<CustomEntityRecognitionTasksItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomEntityRecognitionTasksItem.DeserializeCustomEntityRecognitionTasksItem(item));
                    }
                    customEntityRecognitionTasks = array;
                    continue;
                }
            }
            return new TasksStateTasks(Optional.ToList(details), completed, failed, inProgress, total, Optional.ToList(entityRecognitionTasks), Optional.ToList(entityRecognitionPiiTasks), Optional.ToList(entityLinkingTasks), Optional.ToList(keyPhraseExtractionTasks), Optional.ToList(sentimentAnalysisTasks), Optional.ToList(customClassificationTasks), Optional.ToList(customEntityRecognitionTasks));
        }
    }
}
