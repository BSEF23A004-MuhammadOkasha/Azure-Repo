// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class PeriodicModeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BackupIntervalInMinutes))
            {
                writer.WritePropertyName("backupIntervalInMinutes");
                writer.WriteNumberValue(BackupIntervalInMinutes.Value);
            }
            if (Optional.IsDefined(BackupRetentionIntervalInHours))
            {
                writer.WritePropertyName("backupRetentionIntervalInHours");
                writer.WriteNumberValue(BackupRetentionIntervalInHours.Value);
            }
            writer.WriteEndObject();
        }

        internal static PeriodicModeProperties DeserializePeriodicModeProperties(JsonElement element)
        {
            Optional<int> backupIntervalInMinutes = default;
            Optional<int> backupRetentionIntervalInHours = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupIntervalInMinutes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    backupIntervalInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backupRetentionIntervalInHours"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    backupRetentionIntervalInHours = property.Value.GetInt32();
                    continue;
                }
            }
            return new PeriodicModeProperties(Optional.ToNullable(backupIntervalInMinutes), Optional.ToNullable(backupRetentionIntervalInHours));
        }
    }
}
