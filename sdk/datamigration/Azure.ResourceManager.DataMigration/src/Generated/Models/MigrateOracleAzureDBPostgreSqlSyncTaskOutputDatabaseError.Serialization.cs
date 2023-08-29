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

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError : IUtf8JsonSerializable, IModelJsonSerializable<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events"u8);
                writer.WriteStartArray();
                foreach (var item in Events)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        internal static MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> errorMessage = default;
            Optional<IReadOnlyList<SyncMigrationDatabaseErrorEvent>> events = default;
            Optional<string> id = default;
            string resultType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SyncMigrationDatabaseErrorEvent> array = new List<SyncMigrationDatabaseErrorEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncMigrationDatabaseErrorEvent.DeserializeSyncMigrationDatabaseErrorEvent(item));
                    }
                    events = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError(id.Value, resultType, errorMessage.Value, Optional.ToList(events), rawData);
        }

        MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError IModelJsonSerializable<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError IModelSerializable<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
