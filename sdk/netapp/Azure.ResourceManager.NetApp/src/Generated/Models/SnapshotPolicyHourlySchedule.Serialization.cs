// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class SnapshotPolicyHourlySchedule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SnapshotsToKeep))
            {
                writer.WritePropertyName("snapshotsToKeep"u8);
                writer.WriteNumberValue(SnapshotsToKeep.Value);
            }
            if (Optional.IsDefined(Minute))
            {
                writer.WritePropertyName("minute"u8);
                writer.WriteNumberValue(Minute.Value);
            }
            if (Optional.IsDefined(UsedBytes))
            {
                writer.WritePropertyName("usedBytes"u8);
                writer.WriteNumberValue(UsedBytes.Value);
            }
            writer.WriteEndObject();
        }

        internal static SnapshotPolicyHourlySchedule DeserializeSnapshotPolicyHourlySchedule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> snapshotsToKeep = default;
            Optional<int> minute = default;
            Optional<long> usedBytes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("snapshotsToKeep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    snapshotsToKeep = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minute = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("usedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usedBytes = property.Value.GetInt64();
                    continue;
                }
            }
            return new SnapshotPolicyHourlySchedule(Optional.ToNullable(snapshotsToKeep), Optional.ToNullable(minute), Optional.ToNullable(usedBytes));
        }
    }
}
