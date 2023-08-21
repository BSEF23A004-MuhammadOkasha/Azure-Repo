// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class UnknownStorageProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("storageType"u8);
            writer.WriteStringValue(StorageType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownStorageProperties DeserializeUnknownStorageProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StorageType storageType = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageType"u8))
                {
                    storageType = new StorageType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownStorageProperties(storageType);
        }
    }
}
