// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorTimeWindow : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            writer.WritePropertyName("start"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("end"u8);
            writer.WriteStringValue(EndOn, "O");
            writer.WriteEndObject();
        }

        internal static MonitorTimeWindow DeserializeMonitorTimeWindow(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> timeZone = default;
            DateTimeOffset start = default;
            DateTimeOffset end = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    start = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    end = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new MonitorTimeWindow(timeZone.Value, start, end);
        }
    }
}
