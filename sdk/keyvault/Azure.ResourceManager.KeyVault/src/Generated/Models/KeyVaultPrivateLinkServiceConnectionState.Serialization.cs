// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class KeyVaultPrivateLinkServiceConnectionState : IUtf8JsonSerializable
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
                writer.WriteStringValue(ActionsRequired.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static KeyVaultPrivateLinkServiceConnectionState DeserializeKeyVaultPrivateLinkServiceConnectionState(JsonElement element)
        {
            Optional<KeyVaultPrivateEndpointServiceConnectionStatus> status = default;
            Optional<string> description = default;
            Optional<KeyVaultActionsRequiredMessage> actionsRequired = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new KeyVaultPrivateEndpointServiceConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionsRequired"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    actionsRequired = new KeyVaultActionsRequiredMessage(property.Value.GetString());
                    continue;
                }
            }
            return new KeyVaultPrivateLinkServiceConnectionState(Optional.ToNullable(status), description.Value, Optional.ToNullable(actionsRequired));
        }
    }
}
