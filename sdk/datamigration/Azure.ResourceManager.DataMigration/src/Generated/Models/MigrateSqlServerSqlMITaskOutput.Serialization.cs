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
    public partial class MigrateSqlServerSqlMITaskOutput : IUtf8JsonSerializable, IModelJsonSerializable<MigrateSqlServerSqlMITaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigrateSqlServerSqlMITaskOutput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigrateSqlServerSqlMITaskOutput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

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

        internal static MigrateSqlServerSqlMITaskOutput DeserializeMigrateSqlServerSqlMITaskOutput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resultType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AgentJobLevelOutput": return MigrateSqlServerSqlMITaskOutputAgentJobLevel.DeserializeMigrateSqlServerSqlMITaskOutputAgentJobLevel(element);
                    case "DatabaseLevelOutput": return MigrateSqlServerSqlMITaskOutputDatabaseLevel.DeserializeMigrateSqlServerSqlMITaskOutputDatabaseLevel(element);
                    case "ErrorOutput": return MigrateSqlServerSqlMITaskOutputError.DeserializeMigrateSqlServerSqlMITaskOutputError(element);
                    case "LoginLevelOutput": return MigrateSqlServerSqlMITaskOutputLoginLevel.DeserializeMigrateSqlServerSqlMITaskOutputLoginLevel(element);
                    case "MigrationLevelOutput": return MigrateSqlServerSqlMITaskOutputMigrationLevel.DeserializeMigrateSqlServerSqlMITaskOutputMigrationLevel(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            Optional<string> id = default;
            string resultType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
            return new UnknownMigrateSqlServerSqlMITaskOutput(id.Value, resultType, rawData);
        }

        MigrateSqlServerSqlMITaskOutput IModelJsonSerializable<MigrateSqlServerSqlMITaskOutput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlMITaskOutput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigrateSqlServerSqlMITaskOutput>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigrateSqlServerSqlMITaskOutput IModelSerializable<MigrateSqlServerSqlMITaskOutput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigrateSqlServerSqlMITaskOutput(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MigrateSqlServerSqlMITaskOutput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MigrateSqlServerSqlMITaskOutput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigrateSqlServerSqlMITaskOutput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
