// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class StorageProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("storageType");
            writer.WriteStringValue(StorageType.ToString());
            writer.WriteEndObject();
        }

        internal static StorageProperties DeserializeStorageProperties(JsonElement element)
        {
            if (element.TryGetProperty("storageType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "StorageAccount": return StorageAccount.DeserializeStorageAccount(element);
                }
            }
            StorageType storageType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageType"))
                {
                    storageType = new StorageType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownStorageProperties(storageType);
        }
    }
}
