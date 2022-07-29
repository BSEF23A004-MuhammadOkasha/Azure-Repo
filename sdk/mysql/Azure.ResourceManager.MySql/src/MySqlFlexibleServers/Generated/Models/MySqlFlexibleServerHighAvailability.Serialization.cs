// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerHighAvailability : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode");
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(StandbyAvailabilityZone))
            {
                writer.WritePropertyName("standbyAvailabilityZone");
                writer.WriteStringValue(StandbyAvailabilityZone);
            }
            writer.WriteEndObject();
        }

        internal static MySqlFlexibleServerHighAvailability DeserializeMySqlFlexibleServerHighAvailability(JsonElement element)
        {
            Optional<MySqlFlexibleServerHighAvailabilityMode> mode = default;
            Optional<MySqlFlexibleServerHighAvailabilityState> state = default;
            Optional<string> standbyAvailabilityZone = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mode = new MySqlFlexibleServerHighAvailabilityMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new MySqlFlexibleServerHighAvailabilityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("standbyAvailabilityZone"))
                {
                    standbyAvailabilityZone = property.Value.GetString();
                    continue;
                }
            }
            return new MySqlFlexibleServerHighAvailability(Optional.ToNullable(mode), Optional.ToNullable(state), standbyAvailabilityZone.Value);
        }
    }
}
