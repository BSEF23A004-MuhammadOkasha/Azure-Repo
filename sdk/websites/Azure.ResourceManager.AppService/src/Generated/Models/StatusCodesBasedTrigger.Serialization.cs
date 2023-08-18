// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StatusCodesBasedTrigger : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteNumberValue(Status.Value);
            }
            if (Core.Optional.IsDefined(SubStatus))
            {
                writer.WritePropertyName("subStatus"u8);
                writer.WriteNumberValue(SubStatus.Value);
            }
            if (Core.Optional.IsDefined(Win32Status))
            {
                writer.WritePropertyName("win32Status"u8);
                writer.WriteNumberValue(Win32Status.Value);
            }
            if (Core.Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Core.Optional.IsDefined(TimeInterval))
            {
                writer.WritePropertyName("timeInterval"u8);
                writer.WriteStringValue(TimeInterval);
            }
            if (Core.Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            writer.WriteEndObject();
        }

        internal static StatusCodesBasedTrigger DeserializeStatusCodesBasedTrigger(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<int> status = default;
            Core.Optional<int> subStatus = default;
            Core.Optional<int> win32Status = default;
            Core.Optional<int> count = default;
            Core.Optional<string> timeInterval = default;
            Core.Optional<string> path = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("subStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subStatus = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("win32Status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    win32Status = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeInterval"u8))
                {
                    timeInterval = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
            }
            return new StatusCodesBasedTrigger(Core.Optional.ToNullable(status), Core.Optional.ToNullable(subStatus), Core.Optional.ToNullable(win32Status), Core.Optional.ToNullable(count), timeInterval.Value, path.Value);
        }
    }
}
