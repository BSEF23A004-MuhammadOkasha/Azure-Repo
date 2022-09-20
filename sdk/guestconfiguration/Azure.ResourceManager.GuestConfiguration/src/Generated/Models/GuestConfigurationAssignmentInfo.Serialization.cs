// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    public partial class GuestConfigurationAssignmentInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration");
                writer.WriteObjectValue(Configuration);
            }
            writer.WriteEndObject();
        }

        internal static GuestConfigurationAssignmentInfo DeserializeGuestConfigurationAssignmentInfo(JsonElement element)
        {
            Optional<string> name = default;
            Optional<ConfigurationInfo> configuration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configuration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    configuration = ConfigurationInfo.DeserializeConfigurationInfo(property.Value);
                    continue;
                }
            }
            return new GuestConfigurationAssignmentInfo(name.Value, configuration.Value);
        }
    }
}
