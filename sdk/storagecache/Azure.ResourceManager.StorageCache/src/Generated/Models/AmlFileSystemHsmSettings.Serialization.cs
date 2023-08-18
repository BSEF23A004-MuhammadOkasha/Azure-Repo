// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class AmlFileSystemHsmSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("container"u8);
            writer.WriteStringValue(Container);
            writer.WritePropertyName("loggingContainer"u8);
            writer.WriteStringValue(LoggingContainer);
            if (Core.Optional.IsDefined(ImportPrefix))
            {
                writer.WritePropertyName("importPrefix"u8);
                writer.WriteStringValue(ImportPrefix);
            }
            writer.WriteEndObject();
        }

        internal static AmlFileSystemHsmSettings DeserializeAmlFileSystemHsmSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string container = default;
            string loggingContainer = default;
            Core.Optional<string> importPrefix = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("container"u8))
                {
                    container = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loggingContainer"u8))
                {
                    loggingContainer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("importPrefix"u8))
                {
                    importPrefix = property.Value.GetString();
                    continue;
                }
            }
            return new AmlFileSystemHsmSettings(container, loggingContainer, importPrefix.Value);
        }
    }
}
