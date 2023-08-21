// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class RouteCacheCompressionSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(ContentTypesToCompress))
            {
                writer.WritePropertyName("contentTypesToCompress"u8);
                writer.WriteStartArray();
                foreach (var item in ContentTypesToCompress)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(IsCompressionEnabled))
            {
                writer.WritePropertyName("isCompressionEnabled"u8);
                writer.WriteBooleanValue(IsCompressionEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static RouteCacheCompressionSettings DeserializeRouteCacheCompressionSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IList<string>> contentTypesToCompress = default;
            Core.Optional<bool> isCompressionEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contentTypesToCompress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contentTypesToCompress = array;
                    continue;
                }
                if (property.NameEquals("isCompressionEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCompressionEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new RouteCacheCompressionSettings(Core.Optional.ToList(contentTypesToCompress), Core.Optional.ToNullable(isCompressionEnabled));
        }
    }
}
