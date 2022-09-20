// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class AlertProcessingRuleMonthlyRecurrence : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("daysOfMonth");
            writer.WriteStartArray();
            foreach (var item in DaysOfMonth)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("recurrenceType");
            writer.WriteStringValue(RecurrenceType.ToString());
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime");
                writer.WriteStringValue(StartOn.Value, "T");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime");
                writer.WriteStringValue(EndOn.Value, "T");
            }
            writer.WriteEndObject();
        }

        internal static AlertProcessingRuleMonthlyRecurrence DeserializeAlertProcessingRuleMonthlyRecurrence(JsonElement element)
        {
            IList<int> daysOfMonth = default;
            RecurrenceType recurrenceType = default;
            Optional<TimeSpan> startTime = default;
            Optional<TimeSpan> endTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("daysOfMonth"))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    daysOfMonth = array;
                    continue;
                }
                if (property.NameEquals("recurrenceType"))
                {
                    recurrenceType = new RecurrenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetTimeSpan("T");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetTimeSpan("T");
                    continue;
                }
            }
            return new AlertProcessingRuleMonthlyRecurrence(recurrenceType, Optional.ToNullable(startTime), Optional.ToNullable(endTime), daysOfMonth);
        }
    }
}
