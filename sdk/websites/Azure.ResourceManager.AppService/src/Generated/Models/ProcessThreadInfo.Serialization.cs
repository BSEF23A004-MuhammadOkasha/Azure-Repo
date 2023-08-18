// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ProcessThreadInfo : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Href))
            {
                writer.WritePropertyName("href"u8);
                writer.WriteStringValue(Href);
            }
            if (Core.Optional.IsDefined(Process))
            {
                writer.WritePropertyName("process"u8);
                writer.WriteStringValue(Process);
            }
            if (Core.Optional.IsDefined(StartAddress))
            {
                writer.WritePropertyName("start_address"u8);
                writer.WriteStringValue(StartAddress);
            }
            if (Core.Optional.IsDefined(CurrentPriority))
            {
                writer.WritePropertyName("current_priority"u8);
                writer.WriteNumberValue(CurrentPriority.Value);
            }
            if (Core.Optional.IsDefined(PriorityLevel))
            {
                writer.WritePropertyName("priority_level"u8);
                writer.WriteStringValue(PriorityLevel);
            }
            if (Core.Optional.IsDefined(BasePriority))
            {
                writer.WritePropertyName("base_priority"u8);
                writer.WriteNumberValue(BasePriority.Value);
            }
            if (Core.Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("start_time"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Core.Optional.IsDefined(TotalProcessorTime))
            {
                writer.WritePropertyName("total_processor_time"u8);
                writer.WriteStringValue(TotalProcessorTime);
            }
            if (Core.Optional.IsDefined(UserProcessorTime))
            {
                writer.WritePropertyName("user_processor_time"u8);
                writer.WriteStringValue(UserProcessorTime);
            }
            if (Core.Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (Core.Optional.IsDefined(WaitReason))
            {
                writer.WritePropertyName("wait_reason"u8);
                writer.WriteStringValue(WaitReason);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ProcessThreadInfo DeserializeProcessThreadInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<int> identifier = default;
            Core.Optional<string> href = default;
            Core.Optional<string> process = default;
            Core.Optional<string> startAddress = default;
            Core.Optional<int> currentPriority = default;
            Core.Optional<string> priorityLevel = default;
            Core.Optional<int> basePriority = default;
            Core.Optional<DateTimeOffset> startTime = default;
            Core.Optional<string> totalProcessorTime = default;
            Core.Optional<string> userProcessorTime = default;
            Core.Optional<string> state = default;
            Core.Optional<string> waitReason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("identifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            identifier = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("href"u8))
                        {
                            href = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("process"u8))
                        {
                            process = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("start_address"u8))
                        {
                            startAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("current_priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentPriority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("priority_level"u8))
                        {
                            priorityLevel = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("base_priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            basePriority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("start_time"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("total_processor_time"u8))
                        {
                            totalProcessorTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("user_processor_time"u8))
                        {
                            userProcessorTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("wait_reason"u8))
                        {
                            waitReason = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ProcessThreadInfo(id, name, type, systemData.Value, Core.Optional.ToNullable(identifier), href.Value, process.Value, startAddress.Value, Core.Optional.ToNullable(currentPriority), priorityLevel.Value, Core.Optional.ToNullable(basePriority), Core.Optional.ToNullable(startTime), totalProcessorTime.Value, userProcessorTime.Value, state.Value, waitReason.Value, kind.Value);
        }
    }
}
