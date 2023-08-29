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
    public partial class MigrateSqlServerSqlDBTaskOutputValidationResult : IUtf8JsonSerializable, IModelJsonSerializable<MigrateSqlServerSqlDBTaskOutputValidationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigrateSqlServerSqlDBTaskOutputValidationResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigrateSqlServerSqlDBTaskOutputValidationResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskOutputValidationResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SummaryResults))
            {
                writer.WritePropertyName("summaryResults"u8);
                writer.WriteStartObject();
                foreach (var item in SummaryResults)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static MigrateSqlServerSqlDBTaskOutputValidationResult DeserializeMigrateSqlServerSqlDBTaskOutputValidationResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> migrationId = default;
            Optional<IReadOnlyDictionary<string, MigrationValidationDatabaseSummaryResult>> summaryResults = default;
            Optional<ValidationStatus> status = default;
            Optional<string> id = default;
            string resultType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("migrationId"u8))
                {
                    migrationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("summaryResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, MigrationValidationDatabaseSummaryResult> dictionary = new Dictionary<string, MigrationValidationDatabaseSummaryResult>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MigrationValidationDatabaseSummaryResult.DeserializeMigrationValidationDatabaseSummaryResult(property0.Value));
                    }
                    summaryResults = dictionary;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ValidationStatus(property.Value.GetString());
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
            return new MigrateSqlServerSqlDBTaskOutputValidationResult(id.Value, resultType, migrationId.Value, Optional.ToDictionary(summaryResults), Optional.ToNullable(status), rawData);
        }

        MigrateSqlServerSqlDBTaskOutputValidationResult IModelJsonSerializable<MigrateSqlServerSqlDBTaskOutputValidationResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskOutputValidationResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlDBTaskOutputValidationResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigrateSqlServerSqlDBTaskOutputValidationResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskOutputValidationResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigrateSqlServerSqlDBTaskOutputValidationResult IModelSerializable<MigrateSqlServerSqlDBTaskOutputValidationResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskOutputValidationResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigrateSqlServerSqlDBTaskOutputValidationResult(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MigrateSqlServerSqlDBTaskOutputValidationResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MigrateSqlServerSqlDBTaskOutputValidationResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigrateSqlServerSqlDBTaskOutputValidationResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
