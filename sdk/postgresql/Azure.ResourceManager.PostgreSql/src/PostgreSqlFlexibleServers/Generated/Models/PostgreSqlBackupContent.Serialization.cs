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
    public partial class PostgreSqlBackupContent : IUtf8JsonSerializable, IModelJsonSerializable<PostgreSqlBackupContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PostgreSqlBackupContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PostgreSqlBackupContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlBackupContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("backupSettings"u8);
            if (BackupSettings is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<PostgreSqlFlexibleServerBackupSettings>)BackupSettings).Serialize(writer, options);
            }
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

        internal static PostgreSqlBackupContent DeserializePostgreSqlBackupContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PostgreSqlFlexibleServerBackupSettings backupSettings = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupSettings"u8))
                {
                    backupSettings = PostgreSqlFlexibleServerBackupSettings.DeserializePostgreSqlFlexibleServerBackupSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PostgreSqlBackupContent(backupSettings, rawData);
        }

        PostgreSqlBackupContent IModelJsonSerializable<PostgreSqlBackupContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlBackupContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlBackupContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PostgreSqlBackupContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlBackupContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PostgreSqlBackupContent IModelSerializable<PostgreSqlBackupContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlBackupContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePostgreSqlBackupContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PostgreSqlBackupContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PostgreSqlBackupContent"/> to convert. </param>
        public static implicit operator RequestContent(PostgreSqlBackupContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PostgreSqlBackupContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PostgreSqlBackupContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePostgreSqlBackupContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
