// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageTableSignedIdentifier : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Core.Optional.IsDefined(AccessPolicy))
            {
                writer.WritePropertyName("accessPolicy"u8);
                writer.WriteObjectValue(AccessPolicy);
            }
            writer.WriteEndObject();
        }

        internal static StorageTableSignedIdentifier DeserializeStorageTableSignedIdentifier(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            Core.Optional<StorageTableAccessPolicy> accessPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accessPolicy = StorageTableAccessPolicy.DeserializeStorageTableAccessPolicy(property.Value);
                    continue;
                }
            }
            return new StorageTableSignedIdentifier(id, accessPolicy.Value);
        }
    }
}
