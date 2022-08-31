// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Nginx.Models
{
    internal partial class NginxLogging : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccount))
            {
                writer.WritePropertyName("storageAccount");
                writer.WriteObjectValue(StorageAccount);
            }
            writer.WriteEndObject();
        }

        internal static NginxLogging DeserializeNginxLogging(JsonElement element)
        {
            Optional<NginxStorageAccount> storageAccount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageAccount = NginxStorageAccount.DeserializeNginxStorageAccount(property.Value);
                    continue;
                }
            }
            return new NginxLogging(storageAccount.Value);
        }
    }
}
