// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    public partial class WorkloadClassifierData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(MemberName))
            {
                writer.WritePropertyName("memberName");
                writer.WriteStringValue(MemberName);
            }
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label");
                writer.WriteStringValue(Label);
            }
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context");
                writer.WriteStringValue(Context);
            }
            if (Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime");
                writer.WriteStringValue(StartTime);
            }
            if (Optional.IsDefined(EndTime))
            {
                writer.WritePropertyName("endTime");
                writer.WriteStringValue(EndTime);
            }
            if (Optional.IsDefined(Importance))
            {
                writer.WritePropertyName("importance");
                writer.WriteStringValue(Importance);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WorkloadClassifierData DeserializeWorkloadClassifierData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> memberName = default;
            Optional<string> label = default;
            Optional<string> context = default;
            Optional<string> startTime = default;
            Optional<string> endTime = default;
            Optional<string> importance = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("memberName"))
                        {
                            memberName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("label"))
                        {
                            label = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("context"))
                        {
                            context = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startTime"))
                        {
                            startTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endTime"))
                        {
                            endTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("importance"))
                        {
                            importance = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WorkloadClassifierData(id, name, type, memberName.Value, label.Value, context.Value, startTime.Value, endTime.Value, importance.Value);
        }
    }
}
