// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    internal partial class ManagedIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UserAssignedIdentity))
            {
                writer.WritePropertyName("userAssignedIdentity");
                writer.WriteStringValue(UserAssignedIdentity);
            }
            writer.WriteEndObject();
        }

        internal static ManagedIdentity DeserializeManagedIdentity(JsonElement element)
        {
            Optional<ResourceIdentifier> userAssignedIdentity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userAssignedIdentity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    userAssignedIdentity = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new ManagedIdentity(userAssignedIdentity.Value);
        }
    }
}
