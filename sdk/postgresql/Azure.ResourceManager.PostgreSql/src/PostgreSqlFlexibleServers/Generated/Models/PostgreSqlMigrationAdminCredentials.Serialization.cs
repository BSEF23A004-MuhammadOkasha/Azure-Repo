// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlMigrationAdminCredentials : IUtf8JsonSerializable, IModelJsonSerializable<PostgreSqlMigrationAdminCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PostgreSqlMigrationAdminCredentials>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PostgreSqlMigrationAdminCredentials>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlMigrationAdminCredentials>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sourceServerPassword"u8);
            writer.WriteStringValue(SourceServerPassword);
            writer.WritePropertyName("targetServerPassword"u8);
            writer.WriteStringValue(TargetServerPassword);
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static PostgreSqlMigrationAdminCredentials DeserializePostgreSqlMigrationAdminCredentials(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceServerPassword = default;
            string targetServerPassword = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceServerPassword"u8))
                {
                    sourceServerPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerPassword"u8))
                {
                    targetServerPassword = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PostgreSqlMigrationAdminCredentials(sourceServerPassword, targetServerPassword, rawData);
        }

        PostgreSqlMigrationAdminCredentials IModelJsonSerializable<PostgreSqlMigrationAdminCredentials>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlMigrationAdminCredentials>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlMigrationAdminCredentials(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PostgreSqlMigrationAdminCredentials>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlMigrationAdminCredentials>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PostgreSqlMigrationAdminCredentials IModelSerializable<PostgreSqlMigrationAdminCredentials>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlMigrationAdminCredentials>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePostgreSqlMigrationAdminCredentials(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PostgreSqlMigrationAdminCredentials"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PostgreSqlMigrationAdminCredentials"/> to convert. </param>
        public static implicit operator RequestContent(PostgreSqlMigrationAdminCredentials model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PostgreSqlMigrationAdminCredentials"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PostgreSqlMigrationAdminCredentials(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePostgreSqlMigrationAdminCredentials(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
