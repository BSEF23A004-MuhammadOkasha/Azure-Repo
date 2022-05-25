// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class RecoverableDatabaseData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RecoverableDatabaseData DeserializeRecoverableDatabaseData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> edition = default;
            Optional<string> serviceLevelObjective = default;
            Optional<string> elasticPoolName = default;
            Optional<DateTimeOffset> lastAvailableBackupDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("edition"))
                        {
                            edition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceLevelObjective"))
                        {
                            serviceLevelObjective = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("elasticPoolName"))
                        {
                            elasticPoolName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastAvailableBackupDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastAvailableBackupDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RecoverableDatabaseData(id, name, type, systemData, edition.Value, serviceLevelObjective.Value, elasticPoolName.Value, Optional.ToNullable(lastAvailableBackupDate));
        }
    }
}
