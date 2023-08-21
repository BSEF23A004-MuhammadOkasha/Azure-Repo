// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CassandraTableResourceInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(TableName);
            if (Optional.IsDefined(DefaultTtl))
            {
                writer.WritePropertyName("defaultTtl"u8);
                writer.WriteNumberValue(DefaultTtl.Value);
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
                writer.WriteObjectValue(Schema);
            }
            if (Optional.IsDefined(AnalyticalStorageTtl))
            {
                writer.WritePropertyName("analyticalStorageTtl"u8);
                writer.WriteNumberValue(AnalyticalStorageTtl.Value);
            }
            writer.WriteEndObject();
        }

        internal static CassandraTableResourceInfo DeserializeCassandraTableResourceInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            Optional<int> defaultTtl = default;
            Optional<CassandraSchema> schema = default;
            Optional<int> analyticalStorageTtl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultTtl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultTtl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("schema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schema = CassandraSchema.DeserializeCassandraSchema(property.Value);
                    continue;
                }
                if (property.NameEquals("analyticalStorageTtl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analyticalStorageTtl = property.Value.GetInt32();
                    continue;
                }
            }
            return new CassandraTableResourceInfo(id, Optional.ToNullable(defaultTtl), schema.Value, Optional.ToNullable(analyticalStorageTtl));
        }
    }
}
