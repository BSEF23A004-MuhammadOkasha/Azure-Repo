// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SqlServerSinkConverter))]
    public partial class SqlServerSink : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(SqlWriterStoredProcedureName))
            {
                writer.WritePropertyName("sqlWriterStoredProcedureName"u8);
                writer.WriteObjectValue(SqlWriterStoredProcedureName);
            }
            if (Core.Optional.IsDefined(SqlWriterTableType))
            {
                writer.WritePropertyName("sqlWriterTableType"u8);
                writer.WriteObjectValue(SqlWriterTableType);
            }
            if (Core.Optional.IsDefined(PreCopyScript))
            {
                writer.WritePropertyName("preCopyScript"u8);
                writer.WriteObjectValue(PreCopyScript);
            }
            if (Core.Optional.IsCollectionDefined(StoredProcedureParameters))
            {
                writer.WritePropertyName("storedProcedureParameters"u8);
                writer.WriteStartObject();
                foreach (var item in StoredProcedureParameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsDefined(StoredProcedureTableTypeParameterName))
            {
                writer.WritePropertyName("storedProcedureTableTypeParameterName"u8);
                writer.WriteObjectValue(StoredProcedureTableTypeParameterName);
            }
            if (Core.Optional.IsDefined(TableOption))
            {
                writer.WritePropertyName("tableOption"u8);
                writer.WriteObjectValue(TableOption);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Core.Optional.IsDefined(WriteBatchSize))
            {
                writer.WritePropertyName("writeBatchSize"u8);
                writer.WriteObjectValue(WriteBatchSize);
            }
            if (Core.Optional.IsDefined(WriteBatchTimeout))
            {
                writer.WritePropertyName("writeBatchTimeout"u8);
                writer.WriteObjectValue(WriteBatchTimeout);
            }
            if (Core.Optional.IsDefined(SinkRetryCount))
            {
                writer.WritePropertyName("sinkRetryCount"u8);
                writer.WriteObjectValue(SinkRetryCount);
            }
            if (Core.Optional.IsDefined(SinkRetryWait))
            {
                writer.WritePropertyName("sinkRetryWait"u8);
                writer.WriteObjectValue(SinkRetryWait);
            }
            if (Core.Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static SqlServerSink DeserializeSqlServerSink(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<object> sqlWriterStoredProcedureName = default;
            Core.Optional<object> sqlWriterTableType = default;
            Core.Optional<object> preCopyScript = default;
            Core.Optional<IDictionary<string, StoredProcedureParameter>> storedProcedureParameters = default;
            Core.Optional<object> storedProcedureTableTypeParameterName = default;
            Core.Optional<object> tableOption = default;
            string type = default;
            Core.Optional<object> writeBatchSize = default;
            Core.Optional<object> writeBatchTimeout = default;
            Core.Optional<object> sinkRetryCount = default;
            Core.Optional<object> sinkRetryWait = default;
            Core.Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlWriterStoredProcedureName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlWriterStoredProcedureName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sqlWriterTableType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlWriterTableType = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("preCopyScript"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preCopyScript = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("storedProcedureParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, StoredProcedureParameter> dictionary = new Dictionary<string, StoredProcedureParameter>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, StoredProcedureParameter.DeserializeStoredProcedureParameter(property0.Value));
                    }
                    storedProcedureParameters = dictionary;
                    continue;
                }
                if (property.NameEquals("storedProcedureTableTypeParameterName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storedProcedureTableTypeParameterName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("tableOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tableOption = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("writeBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBatchSize = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("writeBatchTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBatchTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sinkRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sinkRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryWait = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SqlServerSink(type, writeBatchSize.Value, writeBatchTimeout.Value, sinkRetryCount.Value, sinkRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, sqlWriterStoredProcedureName.Value, sqlWriterTableType.Value, preCopyScript.Value, Core.Optional.ToDictionary(storedProcedureParameters), storedProcedureTableTypeParameterName.Value, tableOption.Value);
        }

        internal partial class SqlServerSinkConverter : JsonConverter<SqlServerSink>
        {
            public override void Write(Utf8JsonWriter writer, SqlServerSink model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SqlServerSink Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSqlServerSink(document.RootElement);
            }
        }
    }
}
