// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistrySecretObject : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(ObjectType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(ObjectType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ContainerRegistrySecretObject DeserializeContainerRegistrySecretObject(JsonElement element)
        {
            Optional<string> value = default;
            Optional<ContainerRegistrySecretObjectType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ContainerRegistrySecretObjectType(property.Value.GetString());
                    continue;
                }
            }
            return new ContainerRegistrySecretObject(value.Value, Optional.ToNullable(type));
        }
    }
}
