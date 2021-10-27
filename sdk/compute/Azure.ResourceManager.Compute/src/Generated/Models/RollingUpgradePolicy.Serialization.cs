// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RollingUpgradePolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxBatchInstancePercent))
            {
                writer.WritePropertyName("maxBatchInstancePercent");
                writer.WriteNumberValue(MaxBatchInstancePercent.Value);
            }
            if (Optional.IsDefined(MaxUnhealthyInstancePercent))
            {
                writer.WritePropertyName("maxUnhealthyInstancePercent");
                writer.WriteNumberValue(MaxUnhealthyInstancePercent.Value);
            }
            if (Optional.IsDefined(MaxUnhealthyUpgradedInstancePercent))
            {
                writer.WritePropertyName("maxUnhealthyUpgradedInstancePercent");
                writer.WriteNumberValue(MaxUnhealthyUpgradedInstancePercent.Value);
            }
            if (Optional.IsDefined(PauseTimeBetweenBatches))
            {
                writer.WritePropertyName("pauseTimeBetweenBatches");
                writer.WriteStringValue(PauseTimeBetweenBatches);
            }
            if (Optional.IsDefined(EnableCrossZoneUpgrade))
            {
                writer.WritePropertyName("enableCrossZoneUpgrade");
                writer.WriteBooleanValue(EnableCrossZoneUpgrade.Value);
            }
            if (Optional.IsDefined(PrioritizeUnhealthyInstances))
            {
                writer.WritePropertyName("prioritizeUnhealthyInstances");
                writer.WriteBooleanValue(PrioritizeUnhealthyInstances.Value);
            }
            writer.WriteEndObject();
        }

        internal static RollingUpgradePolicy DeserializeRollingUpgradePolicy(JsonElement element)
        {
            Optional<int> maxBatchInstancePercent = default;
            Optional<int> maxUnhealthyInstancePercent = default;
            Optional<int> maxUnhealthyUpgradedInstancePercent = default;
            Optional<string> pauseTimeBetweenBatches = default;
            Optional<bool> enableCrossZoneUpgrade = default;
            Optional<bool> prioritizeUnhealthyInstances = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxBatchInstancePercent"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxBatchInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxUnhealthyInstancePercent"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxUnhealthyInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxUnhealthyUpgradedInstancePercent"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxUnhealthyUpgradedInstancePercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pauseTimeBetweenBatches"))
                {
                    pauseTimeBetweenBatches = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableCrossZoneUpgrade"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableCrossZoneUpgrade = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("prioritizeUnhealthyInstances"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    prioritizeUnhealthyInstances = property.Value.GetBoolean();
                    continue;
                }
            }
            return new RollingUpgradePolicy(Optional.ToNullable(maxBatchInstancePercent), Optional.ToNullable(maxUnhealthyInstancePercent), Optional.ToNullable(maxUnhealthyUpgradedInstancePercent), pauseTimeBetweenBatches.Value, Optional.ToNullable(enableCrossZoneUpgrade), Optional.ToNullable(prioritizeUnhealthyInstances));
        }
    }
}
