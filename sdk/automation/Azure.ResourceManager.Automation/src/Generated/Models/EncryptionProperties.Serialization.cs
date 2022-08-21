// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class EncryptionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyVaultProperties");
                writer.WriteObjectValue(KeyVaultProperties);
            }
            if (Optional.IsDefined(KeySource))
            {
                writer.WritePropertyName("keySource");
                writer.WriteStringValue(KeySource.Value.ToSerialString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            writer.WriteEndObject();
        }

        internal static EncryptionProperties DeserializeEncryptionProperties(JsonElement element)
        {
            Optional<KeyVaultProperties> keyVaultProperties = default;
            Optional<EncryptionKeySourceType> keySource = default;
            Optional<EncryptionPropertiesIdentity> identity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    keyVaultProperties = KeyVaultProperties.DeserializeKeyVaultProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("keySource"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    keySource = property.Value.GetString().ToEncryptionKeySourceType();
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = EncryptionPropertiesIdentity.DeserializeEncryptionPropertiesIdentity(property.Value);
                    continue;
                }
            }
            return new EncryptionProperties(keyVaultProperties.Value, Optional.ToNullable(keySource), identity.Value);
        }
    }
}
