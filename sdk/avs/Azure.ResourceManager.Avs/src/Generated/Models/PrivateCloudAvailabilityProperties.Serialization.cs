// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class PrivateCloudAvailabilityProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Strategy))
            {
                writer.WritePropertyName("strategy"u8);
                writer.WriteStringValue(Strategy.Value.ToString());
            }
            if (Optional.IsDefined(Zone))
            {
                writer.WritePropertyName("zone"u8);
                writer.WriteNumberValue(Zone.Value);
            }
            if (Optional.IsDefined(SecondaryZone))
            {
                writer.WritePropertyName("secondaryZone"u8);
                writer.WriteNumberValue(SecondaryZone.Value);
            }
            writer.WriteEndObject();
        }

        internal static PrivateCloudAvailabilityProperties DeserializePrivateCloudAvailabilityProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AvailabilityStrategy> strategy = default;
            Optional<int> zone = default;
            Optional<int> secondaryZone = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("strategy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    strategy = new AvailabilityStrategy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("zone"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zone = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("secondaryZone"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondaryZone = property.Value.GetInt32();
                    continue;
                }
            }
            return new PrivateCloudAvailabilityProperties(Optional.ToNullable(strategy), Optional.ToNullable(zone), Optional.ToNullable(secondaryZone));
        }
    }
}
