// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class KeyVaultProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(KeyIdentifier))
            {
                writer.WritePropertyName("keyIdentifier"u8);
                writer.WriteStringValue(KeyIdentifier);
            }
            writer.WriteEndObject();
        }

        internal static KeyVaultProperties DeserializeKeyVaultProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> keyIdentifier = default;
            Optional<string> currentKeyIdentifier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyIdentifier"u8))
                {
                    keyIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentKeyIdentifier"u8))
                {
                    currentKeyIdentifier = property.Value.GetString();
                    continue;
                }
            }
            return new KeyVaultProperties(keyIdentifier.Value, currentKeyIdentifier.Value);
        }
    }
}
