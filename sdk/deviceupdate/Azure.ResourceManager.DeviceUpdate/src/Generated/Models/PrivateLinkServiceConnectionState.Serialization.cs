// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class PrivateLinkServiceConnectionState : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ActionsRequired))
            {
                writer.WritePropertyName("actionsRequired");
                writer.WriteStringValue(ActionsRequired);
            }
            writer.WriteEndObject();
        }

        internal static PrivateLinkServiceConnectionState DeserializePrivateLinkServiceConnectionState(JsonElement element)
        {
            Optional<PrivateEndpointServiceConnectionStatus> status = default;
            Optional<string> description = default;
            Optional<string> actionsRequired = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new PrivateEndpointServiceConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionsRequired"))
                {
                    actionsRequired = property.Value.GetString();
                    continue;
                }
            }
            return new PrivateLinkServiceConnectionState(Optional.ToNullable(status), description.Value, actionsRequired.Value);
        }
    }
}
