// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBKeyWrapMetadata : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(CosmosDBKeyWrapMetadataType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(CosmosDBKeyWrapMetadataType);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(Algorithm))
            {
                writer.WritePropertyName("algorithm"u8);
                writer.WriteStringValue(Algorithm);
            }
            writer.WriteEndObject();
        }

        internal static CosmosDBKeyWrapMetadata DeserializeCosmosDBKeyWrapMetadata(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> value = default;
            Optional<string> algorithm = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("algorithm"u8))
                {
                    algorithm = property.Value.GetString();
                    continue;
                }
            }
            return new CosmosDBKeyWrapMetadata(name.Value, type.Value, value.Value, algorithm.Value);
        }
    }
}
