// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    public partial class HybridRunbookWorkerGroupData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(GroupType))
            {
                writer.WritePropertyName("groupType"u8);
                writer.WriteStringValue(GroupType.Value.ToString());
            }
            if (Core.Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential"u8);
                writer.WriteObjectValue(Credential);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static HybridRunbookWorkerGroupData DeserializeHybridRunbookWorkerGroupData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<HybridWorkerGroup> groupType = default;
            Core.Optional<RunAsCredentialAssociationProperty> credential = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("groupType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            groupType = new HybridWorkerGroup(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("credential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            credential = RunAsCredentialAssociationProperty.DeserializeRunAsCredentialAssociationProperty(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HybridRunbookWorkerGroupData(id, name, type, systemData.Value, Core.Optional.ToNullable(groupType), credential.Value);
        }
    }
}
