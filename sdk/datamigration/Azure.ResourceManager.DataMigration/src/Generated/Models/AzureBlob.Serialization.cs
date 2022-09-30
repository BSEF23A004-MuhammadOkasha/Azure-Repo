// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class AzureBlob : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountResourceId))
            {
                writer.WritePropertyName("storageAccountResourceId");
                writer.WriteStringValue(StorageAccountResourceId);
            }
            if (Optional.IsDefined(AccountKey))
            {
                writer.WritePropertyName("accountKey");
                writer.WriteStringValue(AccountKey);
            }
            if (Optional.IsDefined(BlobContainerName))
            {
                writer.WritePropertyName("blobContainerName");
                writer.WriteStringValue(BlobContainerName);
            }
            writer.WriteEndObject();
        }

        internal static AzureBlob DeserializeAzureBlob(JsonElement element)
        {
            Optional<string> storageAccountResourceId = default;
            Optional<string> accountKey = default;
            Optional<string> blobContainerName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountResourceId"))
                {
                    storageAccountResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountKey"))
                {
                    accountKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blobContainerName"))
                {
                    blobContainerName = property.Value.GetString();
                    continue;
                }
            }
            return new AzureBlob(storageAccountResourceId.Value, accountKey.Value, blobContainerName.Value);
        }
    }
}
