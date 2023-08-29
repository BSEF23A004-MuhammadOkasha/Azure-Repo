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
    public partial class MigrateSqlServerSqlDBTaskOutputTableLevel : IUtf8JsonSerializable, IModelJsonSerializable<MigrateSqlServerSqlDBTaskOutputTableLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigrateSqlServerSqlDBTaskOutputTableLevel>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigrateSqlServerSqlDBTaskOutputTableLevel>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskOutputTableLevel>(this, options.Format);

            writer.WriteStartObject();
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

        internal static MigrateSqlServerSqlDBTaskOutputTableLevel DeserializeMigrateSqlServerSqlDBTaskOutputTableLevel(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> objectName = default;
            Optional<DateTimeOffset> startedOn = default;
            Optional<DateTimeOffset> endedOn = default;
            Optional<MigrationState> state = default;
            Optional<string> statusMessage = default;
            Optional<long> itemsCount = default;
            Optional<long> itemsCompletedCount = default;
            Optional<string> errorPrefix = default;
            Optional<string> resultPrefix = default;
            Optional<string> id = default;
            string resultType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectName"u8))
                {
                    objectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new MigrationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusMessage"u8))
                {
                    statusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    itemsCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("itemsCompletedCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    itemsCompletedCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("errorPrefix"u8))
                {
                    errorPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultPrefix"u8))
                {
                    resultPrefix = property.Value.GetString();
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
            return new MigrateSqlServerSqlDBTaskOutputTableLevel(id.Value, resultType, objectName.Value, Optional.ToNullable(startedOn), Optional.ToNullable(endedOn), Optional.ToNullable(state), statusMessage.Value, Optional.ToNullable(itemsCount), Optional.ToNullable(itemsCompletedCount), errorPrefix.Value, resultPrefix.Value, rawData);
        }

        MigrateSqlServerSqlDBTaskOutputTableLevel IModelJsonSerializable<MigrateSqlServerSqlDBTaskOutputTableLevel>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskOutputTableLevel>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlDBTaskOutputTableLevel(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigrateSqlServerSqlDBTaskOutputTableLevel>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskOutputTableLevel>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigrateSqlServerSqlDBTaskOutputTableLevel IModelSerializable<MigrateSqlServerSqlDBTaskOutputTableLevel>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigrateSqlServerSqlDBTaskOutputTableLevel>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigrateSqlServerSqlDBTaskOutputTableLevel(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MigrateSqlServerSqlDBTaskOutputTableLevel model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MigrateSqlServerSqlDBTaskOutputTableLevel(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigrateSqlServerSqlDBTaskOutputTableLevel(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
