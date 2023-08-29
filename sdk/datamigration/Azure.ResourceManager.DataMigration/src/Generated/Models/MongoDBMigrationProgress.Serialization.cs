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
    public partial class MongoDBMigrationProgress : IUtf8JsonSerializable, IModelJsonSerializable<MongoDBMigrationProgress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MongoDBMigrationProgress>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MongoDBMigrationProgress>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MongoDBMigrationProgress>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Databases))
            {
                writer.WritePropertyName("databases"u8);
                writer.WriteStartObject();
                foreach (var item in Databases)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("bytesCopied"u8);
            writer.WriteNumberValue(BytesCopied);
            writer.WritePropertyName("documentsCopied"u8);
            writer.WriteNumberValue(DocumentsCopied);
            writer.WritePropertyName("elapsedTime"u8);
            writer.WriteStringValue(ElapsedTime);
            writer.WritePropertyName("errors"u8);
            writer.WriteStartObject();
            foreach (var item in Errors)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("eventsPending"u8);
            writer.WriteNumberValue(EventsPending);
            writer.WritePropertyName("eventsReplayed"u8);
            writer.WriteNumberValue(EventsReplayed);
            if (Optional.IsDefined(LastEventOn))
            {
                writer.WritePropertyName("lastEventTime"u8);
                writer.WriteStringValue(LastEventOn.Value, "O");
            }
            if (Optional.IsDefined(LastReplayOn))
            {
                writer.WritePropertyName("lastReplayTime"u8);
                writer.WriteStringValue(LastReplayOn.Value, "O");
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(QualifiedName))
            {
                writer.WritePropertyName("qualifiedName"u8);
                writer.WriteStringValue(QualifiedName);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType.ToString());
            writer.WritePropertyName("state"u8);
            writer.WriteStringValue(State.ToString());
            writer.WritePropertyName("totalBytes"u8);
            writer.WriteNumberValue(TotalBytes);
            writer.WritePropertyName("totalDocuments"u8);
            writer.WriteNumberValue(TotalDocuments);
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

        internal static MongoDBMigrationProgress DeserializeMongoDBMigrationProgress(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyDictionary<string, MongoDBDatabaseProgress>> databases = default;
            long bytesCopied = default;
            long documentsCopied = default;
            string elapsedTime = default;
            IReadOnlyDictionary<string, MongoDBError> errors = default;
            long eventsPending = default;
            long eventsReplayed = default;
            Optional<DateTimeOffset> lastEventTime = default;
            Optional<DateTimeOffset> lastReplayTime = default;
            Optional<string> name = default;
            Optional<string> qualifiedName = default;
            MongoDBProgressResultType resultType = default;
            MongoDBMigrationState state = default;
            long totalBytes = default;
            long totalDocuments = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, MongoDBDatabaseProgress> dictionary = new Dictionary<string, MongoDBDatabaseProgress>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MongoDBDatabaseProgress.DeserializeMongoDBDatabaseProgress(property0.Value));
                    }
                    databases = dictionary;
                    continue;
                }
                if (property.NameEquals("bytesCopied"u8))
                {
                    bytesCopied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("documentsCopied"u8))
                {
                    documentsCopied = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("elapsedTime"u8))
                {
                    elapsedTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    Dictionary<string, MongoDBError> dictionary = new Dictionary<string, MongoDBError>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MongoDBError.DeserializeMongoDBError(property0.Value));
                    }
                    errors = dictionary;
                    continue;
                }
                if (property.NameEquals("eventsPending"u8))
                {
                    eventsPending = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("eventsReplayed"u8))
                {
                    eventsReplayed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastEventTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastEventTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastReplayTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastReplayTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qualifiedName"u8))
                {
                    qualifiedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = new MongoDBProgressResultType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = new MongoDBMigrationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("totalBytes"u8))
                {
                    totalBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalDocuments"u8))
                {
                    totalDocuments = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MongoDBMigrationProgress(bytesCopied, documentsCopied, elapsedTime, errors, eventsPending, eventsReplayed, Optional.ToNullable(lastEventTime), Optional.ToNullable(lastReplayTime), name.Value, qualifiedName.Value, resultType, state, totalBytes, totalDocuments, Optional.ToDictionary(databases), rawData);
        }

        MongoDBMigrationProgress IModelJsonSerializable<MongoDBMigrationProgress>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MongoDBMigrationProgress>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoDBMigrationProgress(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MongoDBMigrationProgress>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MongoDBMigrationProgress>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MongoDBMigrationProgress IModelSerializable<MongoDBMigrationProgress>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MongoDBMigrationProgress>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMongoDBMigrationProgress(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MongoDBMigrationProgress model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MongoDBMigrationProgress(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMongoDBMigrationProgress(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
