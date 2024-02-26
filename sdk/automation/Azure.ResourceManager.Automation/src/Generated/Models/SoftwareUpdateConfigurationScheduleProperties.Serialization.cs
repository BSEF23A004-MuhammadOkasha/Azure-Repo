// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class SoftwareUpdateConfigurationScheduleProperties : IUtf8JsonSerializable, IJsonModel<SoftwareUpdateConfigurationScheduleProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SoftwareUpdateConfigurationScheduleProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SoftwareUpdateConfigurationScheduleProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationScheduleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationScheduleProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (StartOn.HasValue)
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && StartInMinutes.HasValue)
            {
                writer.WritePropertyName("startTimeOffsetMinutes"u8);
                writer.WriteNumberValue(StartInMinutes.Value);
            }
            if (ExpireOn.HasValue)
            {
                if (ExpireOn != null)
                {
                    writer.WritePropertyName("expiryTime"u8);
                    writer.WriteStringValue(ExpireOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("expiryTime");
                }
            }
            if (ExpireInMinutes.HasValue)
            {
                writer.WritePropertyName("expiryTimeOffsetMinutes"u8);
                writer.WriteNumberValue(ExpireInMinutes.Value);
            }
            if (IsEnabled.HasValue)
            {
                writer.WritePropertyName("isEnabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (NextRunOn.HasValue)
            {
                if (NextRunOn != null)
                {
                    writer.WritePropertyName("nextRun"u8);
                    writer.WriteStringValue(NextRunOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("nextRun");
                }
            }
            if (NextRunInMinutes.HasValue)
            {
                writer.WritePropertyName("nextRunOffsetMinutes"u8);
                writer.WriteNumberValue(NextRunInMinutes.Value);
            }
            if (Interval.HasValue)
            {
                writer.WritePropertyName("interval"u8);
                writer.WriteNumberValue(Interval.Value);
            }
            if (Frequency.HasValue)
            {
                writer.WritePropertyName("frequency"u8);
                writer.WriteStringValue(Frequency.Value.ToString());
            }
            if (TimeZone != null)
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            if (AdvancedSchedule != null)
            {
                writer.WritePropertyName("advancedSchedule"u8);
                writer.WriteObjectValue(AdvancedSchedule);
            }
            if (CreatedOn.HasValue)
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (LastModifiedOn.HasValue)
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SoftwareUpdateConfigurationScheduleProperties IJsonModel<SoftwareUpdateConfigurationScheduleProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationScheduleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationScheduleProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSoftwareUpdateConfigurationScheduleProperties(document.RootElement, options);
        }

        internal static SoftwareUpdateConfigurationScheduleProperties DeserializeSoftwareUpdateConfigurationScheduleProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> startTime = default;
            Optional<double> startTimeOffsetMinutes = default;
            Optional<DateTimeOffset?> expiryTime = default;
            Optional<double> expiryTimeOffsetMinutes = default;
            Optional<bool> isEnabled = default;
            Optional<DateTimeOffset?> nextRun = default;
            Optional<double> nextRunOffsetMinutes = default;
            Optional<long> interval = default;
            Optional<AutomationScheduleFrequency> frequency = default;
            Optional<string> timeZone = default;
            Optional<AutomationAdvancedSchedule> advancedSchedule = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<string> description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startTimeOffsetMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTimeOffsetMinutes = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("expiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        expiryTime = null;
                        continue;
                    }
                    expiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expiryTimeOffsetMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTimeOffsetMinutes = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nextRun"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nextRun = null;
                        continue;
                    }
                    nextRun = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("nextRunOffsetMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextRunOffsetMinutes = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("interval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interval = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("frequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frequency = new AutomationScheduleFrequency(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("advancedSchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    advancedSchedule = AutomationAdvancedSchedule.DeserializeAutomationAdvancedSchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SoftwareUpdateConfigurationScheduleProperties(Optional.ToNullable(startTime), Optional.ToNullable(startTimeOffsetMinutes), Optional.ToNullable(expiryTime), Optional.ToNullable(expiryTimeOffsetMinutes), Optional.ToNullable(isEnabled), Optional.ToNullable(nextRun), Optional.ToNullable(nextRunOffsetMinutes), Optional.ToNullable(interval), Optional.ToNullable(frequency), timeZone.Value, advancedSchedule.Value, Optional.ToNullable(creationTime), Optional.ToNullable(lastModifiedTime), description.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SoftwareUpdateConfigurationScheduleProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationScheduleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationScheduleProperties)} does not support '{options.Format}' format.");
            }
        }

        SoftwareUpdateConfigurationScheduleProperties IPersistableModel<SoftwareUpdateConfigurationScheduleProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SoftwareUpdateConfigurationScheduleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSoftwareUpdateConfigurationScheduleProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SoftwareUpdateConfigurationScheduleProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SoftwareUpdateConfigurationScheduleProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
