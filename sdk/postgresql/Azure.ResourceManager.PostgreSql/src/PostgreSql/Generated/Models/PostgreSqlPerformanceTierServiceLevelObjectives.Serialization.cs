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

namespace Azure.ResourceManager.PostgreSql.Models
{
    public partial class PostgreSqlPerformanceTierServiceLevelObjectives : IUtf8JsonSerializable, IModelJsonSerializable<PostgreSqlPerformanceTierServiceLevelObjectives>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PostgreSqlPerformanceTierServiceLevelObjectives>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PostgreSqlPerformanceTierServiceLevelObjectives>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlPerformanceTierServiceLevelObjectives>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Edition))
            {
                writer.WritePropertyName("edition"u8);
                writer.WriteStringValue(Edition);
            }
            if (Optional.IsDefined(VCores))
            {
                writer.WritePropertyName("vCore"u8);
                writer.WriteNumberValue(VCores.Value);
            }
            if (Optional.IsDefined(HardwareGeneration))
            {
                writer.WritePropertyName("hardwareGeneration"u8);
                writer.WriteStringValue(HardwareGeneration);
            }
            if (Optional.IsDefined(MaxBackupRetentionDays))
            {
                writer.WritePropertyName("maxBackupRetentionDays"u8);
                writer.WriteNumberValue(MaxBackupRetentionDays.Value);
            }
            if (Optional.IsDefined(MinBackupRetentionDays))
            {
                writer.WritePropertyName("minBackupRetentionDays"u8);
                writer.WriteNumberValue(MinBackupRetentionDays.Value);
            }
            if (Optional.IsDefined(MaxStorageInMB))
            {
                writer.WritePropertyName("maxStorageMB"u8);
                writer.WriteNumberValue(MaxStorageInMB.Value);
            }
            if (Optional.IsDefined(MinStorageInMB))
            {
                writer.WritePropertyName("minStorageMB"u8);
                writer.WriteNumberValue(MinStorageInMB.Value);
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

        internal static PostgreSqlPerformanceTierServiceLevelObjectives DeserializePostgreSqlPerformanceTierServiceLevelObjectives(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> edition = default;
            Optional<int> vCore = default;
            Optional<string> hardwareGeneration = default;
            Optional<int> maxBackupRetentionDays = default;
            Optional<int> minBackupRetentionDays = default;
            Optional<int> maxStorageMB = default;
            Optional<int> minStorageMB = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("edition"u8))
                {
                    edition = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vCore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vCore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hardwareGeneration"u8))
                {
                    hardwareGeneration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxBackupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBackupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minBackupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minBackupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PostgreSqlPerformanceTierServiceLevelObjectives(id.Value, edition.Value, Optional.ToNullable(vCore), hardwareGeneration.Value, Optional.ToNullable(maxBackupRetentionDays), Optional.ToNullable(minBackupRetentionDays), Optional.ToNullable(maxStorageMB), Optional.ToNullable(minStorageMB), rawData);
        }

        PostgreSqlPerformanceTierServiceLevelObjectives IModelJsonSerializable<PostgreSqlPerformanceTierServiceLevelObjectives>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlPerformanceTierServiceLevelObjectives>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlPerformanceTierServiceLevelObjectives(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PostgreSqlPerformanceTierServiceLevelObjectives>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlPerformanceTierServiceLevelObjectives>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PostgreSqlPerformanceTierServiceLevelObjectives IModelSerializable<PostgreSqlPerformanceTierServiceLevelObjectives>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PostgreSqlPerformanceTierServiceLevelObjectives>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePostgreSqlPerformanceTierServiceLevelObjectives(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PostgreSqlPerformanceTierServiceLevelObjectives"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PostgreSqlPerformanceTierServiceLevelObjectives"/> to convert. </param>
        public static implicit operator RequestContent(PostgreSqlPerformanceTierServiceLevelObjectives model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PostgreSqlPerformanceTierServiceLevelObjectives"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PostgreSqlPerformanceTierServiceLevelObjectives(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePostgreSqlPerformanceTierServiceLevelObjectives(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
