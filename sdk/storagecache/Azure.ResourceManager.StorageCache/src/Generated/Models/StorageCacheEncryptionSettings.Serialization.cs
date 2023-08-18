// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class StorageCacheEncryptionSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(KeyEncryptionKey))
            {
                writer.WritePropertyName("keyEncryptionKey"u8);
                writer.WriteObjectValue(KeyEncryptionKey);
            }
            if (Core.Optional.IsDefined(EnableRotationToLatestKeyVersion))
            {
                writer.WritePropertyName("rotationToLatestKeyVersionEnabled"u8);
                writer.WriteBooleanValue(EnableRotationToLatestKeyVersion.Value);
            }
            writer.WriteEndObject();
        }

        internal static StorageCacheEncryptionSettings DeserializeStorageCacheEncryptionSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<StorageCacheEncryptionKeyVaultKeyReference> keyEncryptionKey = default;
            Core.Optional<bool> rotationToLatestKeyVersionEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyEncryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyEncryptionKey = StorageCacheEncryptionKeyVaultKeyReference.DeserializeStorageCacheEncryptionKeyVaultKeyReference(property.Value);
                    continue;
                }
                if (property.NameEquals("rotationToLatestKeyVersionEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rotationToLatestKeyVersionEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new StorageCacheEncryptionSettings(keyEncryptionKey.Value, Core.Optional.ToNullable(rotationToLatestKeyVersionEnabled));
        }
    }
}
