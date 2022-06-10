// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class TextClassification : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryMetric))
            {
                writer.WritePropertyName("primaryMetric");
                writer.WriteStringValue(PrimaryMetric.Value.ToString());
            }
            if (Optional.IsDefined(DataSettings))
            {
                if (DataSettings != null)
                {
                    writer.WritePropertyName("dataSettings");
                    writer.WriteObjectValue(DataSettings);
                }
                else
                {
                    writer.WriteNull("dataSettings");
                }
            }
            if (Optional.IsDefined(FeaturizationSettings))
            {
                if (FeaturizationSettings != null)
                {
                    writer.WritePropertyName("featurizationSettings");
                    writer.WriteObjectValue(FeaturizationSettings);
                }
                else
                {
                    writer.WriteNull("featurizationSettings");
                }
            }
            if (Optional.IsDefined(LimitSettings))
            {
                if (LimitSettings != null)
                {
                    writer.WritePropertyName("limitSettings");
                    writer.WriteObjectValue(LimitSettings);
                }
                else
                {
                    writer.WriteNull("limitSettings");
                }
            }
            if (Optional.IsDefined(LogVerbosity))
            {
                writer.WritePropertyName("logVerbosity");
                writer.WriteStringValue(LogVerbosity.Value.ToString());
            }
            writer.WritePropertyName("taskType");
            writer.WriteStringValue(TaskType.ToString());
            writer.WriteEndObject();
        }

        internal static TextClassification DeserializeTextClassification(JsonElement element)
        {
            Optional<ClassificationPrimaryMetrics> primaryMetric = default;
            Optional<NlpVerticalDataSettings> dataSettings = default;
            Optional<NlpVerticalFeaturizationSettings> featurizationSettings = default;
            Optional<NlpVerticalLimitSettings> limitSettings = default;
            Optional<LogVerbosity> logVerbosity = default;
            TaskType taskType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryMetric"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    primaryMetric = new ClassificationPrimaryMetrics(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataSettings = null;
                        continue;
                    }
                    dataSettings = NlpVerticalDataSettings.DeserializeNlpVerticalDataSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("featurizationSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        featurizationSettings = null;
                        continue;
                    }
                    featurizationSettings = NlpVerticalFeaturizationSettings.DeserializeNlpVerticalFeaturizationSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("limitSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        limitSettings = null;
                        continue;
                    }
                    limitSettings = NlpVerticalLimitSettings.DeserializeNlpVerticalLimitSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("logVerbosity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    logVerbosity = new LogVerbosity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskType"))
                {
                    taskType = new TaskType(property.Value.GetString());
                    continue;
                }
            }
            return new TextClassification(Optional.ToNullable(logVerbosity), taskType, Optional.ToNullable(primaryMetric), dataSettings.Value, featurizationSettings.Value, limitSettings.Value);
        }
    }
}
