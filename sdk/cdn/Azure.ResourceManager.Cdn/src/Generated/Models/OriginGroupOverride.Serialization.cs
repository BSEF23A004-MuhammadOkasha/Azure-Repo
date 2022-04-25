// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class OriginGroupOverride : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OriginGroup))
            {
                writer.WritePropertyName("originGroup");
                JsonSerializer.Serialize(writer, OriginGroup);
            }
            if (Optional.IsDefined(ForwardingProtocol))
            {
                writer.WritePropertyName("forwardingProtocol");
                writer.WriteStringValue(ForwardingProtocol.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static OriginGroupOverride DeserializeOriginGroupOverride(JsonElement element)
        {
            Optional<WritableSubResource> originGroup = default;
            Optional<ForwardingProtocol> forwardingProtocol = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("originGroup"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    originGroup = JsonSerializer.Deserialize<WritableSubResource>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("forwardingProtocol"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    forwardingProtocol = new ForwardingProtocol(property.Value.GetString());
                    continue;
                }
            }
            return new OriginGroupOverride(originGroup, Optional.ToNullable(forwardingProtocol));
        }
    }
}
