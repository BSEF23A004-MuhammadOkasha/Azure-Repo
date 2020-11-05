// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.AI.MetricsAdvisor;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class MetricPeriodFeedback : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("value");
            writer.WriteObjectValue(ValueInternal);
            writer.WritePropertyName("feedbackType");
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("metricId");
            writer.WriteStringValue(MetricId);
            writer.WritePropertyName("dimensionFilter");
            writer.WriteObjectValue(DimensionFilter);
            writer.WriteEndObject();
        }

        internal static MetricPeriodFeedback DeserializeMetricPeriodFeedback(JsonElement element)
        {
            PeriodFeedbackValue value = default;
            FeedbackType feedbackType = default;
            Optional<string> feedbackId = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<string> userPrincipal = default;
            string metricId = default;
            FeedbackDimensionFilter dimensionFilter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = PeriodFeedbackValue.DeserializePeriodFeedbackValue(property.Value);
                    continue;
                }
                if (property.NameEquals("feedbackType"))
                {
                    feedbackType = new FeedbackType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("feedbackId"))
                {
                    feedbackId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("userPrincipal"))
                {
                    userPrincipal = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricId"))
                {
                    metricId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensionFilter"))
                {
                    dimensionFilter = FeedbackDimensionFilter.DeserializeFeedbackDimensionFilter(property.Value);
                    continue;
                }
            }
            return new MetricPeriodFeedback(feedbackType, feedbackId.Value, Optional.ToNullable(createdTime), userPrincipal.Value, metricId, dimensionFilter, value);
        }
    }
}
