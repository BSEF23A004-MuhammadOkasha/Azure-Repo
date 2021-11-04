// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class EncryptionProtectorData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ServerKeyName))
            {
                writer.WritePropertyName("serverKeyName");
                writer.WriteStringValue(ServerKeyName);
            }
            if (Optional.IsDefined(ServerKeyType))
            {
                writer.WritePropertyName("serverKeyType");
                writer.WriteStringValue(ServerKeyType.Value.ToString());
            }
            if (Optional.IsDefined(AutoRotationEnabled))
            {
                writer.WritePropertyName("autoRotationEnabled");
                writer.WriteBooleanValue(AutoRotationEnabled.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static EncryptionProtectorData DeserializeEncryptionProtectorData(JsonElement element)
        {
            Optional<string> kind = default;
            Optional<string> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> subregion = default;
            Optional<string> serverKeyName = default;
            Optional<ServerKeyType> serverKeyType = default;
            Optional<string> uri = default;
            Optional<string> thumbprint = default;
            Optional<bool> autoRotationEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("subregion"))
                        {
                            subregion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverKeyName"))
                        {
                            serverKeyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverKeyType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            serverKeyType = new ServerKeyType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("uri"))
                        {
                            uri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("thumbprint"))
                        {
                            thumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoRotationEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            autoRotationEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new EncryptionProtectorData(id, name, type, kind.Value, location.Value, subregion.Value, serverKeyName.Value, Optional.ToNullable(serverKeyType), uri.Value, thumbprint.Value, Optional.ToNullable(autoRotationEnabled));
        }
    }
}
