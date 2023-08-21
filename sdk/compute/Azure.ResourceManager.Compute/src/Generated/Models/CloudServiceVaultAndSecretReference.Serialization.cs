// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class CloudServiceVaultAndSecretReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceVault))
            {
                writer.WritePropertyName("sourceVault"u8);
                JsonSerializer.Serialize(writer, SourceVault);
            }
            if (Optional.IsDefined(SecretUri))
            {
                writer.WritePropertyName("secretUrl"u8);
                writer.WriteStringValue(SecretUri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static CloudServiceVaultAndSecretReference DeserializeCloudServiceVaultAndSecretReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WritableSubResource> sourceVault = default;
            Optional<Uri> secretUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceVault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceVault = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("secretUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secretUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new CloudServiceVaultAndSecretReference(sourceVault, secretUrl.Value);
        }
    }
}
