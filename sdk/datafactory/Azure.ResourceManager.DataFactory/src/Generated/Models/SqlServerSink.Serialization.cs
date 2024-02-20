// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SqlServerSink : IUtf8JsonSerializable, IJsonModel<SqlServerSink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlServerSink>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlServerSink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerSink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerSink)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SqlWriterStoredProcedureName))
            {
                writer.WritePropertyName("sqlWriterStoredProcedureName"u8);
                JsonSerializer.Serialize(writer, SqlWriterStoredProcedureName);
            }
            if (Optional.IsDefined(SqlWriterTableType))
            {
                writer.WritePropertyName("sqlWriterTableType"u8);
                JsonSerializer.Serialize(writer, SqlWriterTableType);
            }
            if (Optional.IsDefined(PreCopyScript))
            {
                writer.WritePropertyName("preCopyScript"u8);
                JsonSerializer.Serialize(writer, PreCopyScript);
            }
            if (Optional.IsDefined(StoredProcedureParameters))
            {
                writer.WritePropertyName("storedProcedureParameters"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(StoredProcedureParameters);
#else
                using (JsonDocument document = JsonDocument.Parse(StoredProcedureParameters))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(StoredProcedureTableTypeParameterName))
            {
                writer.WritePropertyName("storedProcedureTableTypeParameterName"u8);
                JsonSerializer.Serialize(writer, StoredProcedureTableTypeParameterName);
            }
            if (Optional.IsDefined(TableOption))
            {
                writer.WritePropertyName("tableOption"u8);
                JsonSerializer.Serialize(writer, TableOption);
            }
            if (Optional.IsDefined(SqlWriterUseTableLock))
            {
                writer.WritePropertyName("sqlWriterUseTableLock"u8);
                JsonSerializer.Serialize(writer, SqlWriterUseTableLock);
            }
            if (Optional.IsDefined(WriteBehavior))
            {
                writer.WritePropertyName("writeBehavior"u8);
                JsonSerializer.Serialize(writer, WriteBehavior);
            }
            if (Optional.IsDefined(UpsertSettings))
            {
                writer.WritePropertyName("upsertSettings"u8);
                writer.WriteObjectValue(UpsertSettings);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CopySinkType);
            if (Optional.IsDefined(WriteBatchSize))
            {
                writer.WritePropertyName("writeBatchSize"u8);
                JsonSerializer.Serialize(writer, WriteBatchSize);
            }
            if (Optional.IsDefined(WriteBatchTimeout))
            {
                writer.WritePropertyName("writeBatchTimeout"u8);
                JsonSerializer.Serialize(writer, WriteBatchTimeout);
            }
            if (Optional.IsDefined(SinkRetryCount))
            {
                writer.WritePropertyName("sinkRetryCount"u8);
                JsonSerializer.Serialize(writer, SinkRetryCount);
            }
            if (Optional.IsDefined(SinkRetryWait))
            {
                writer.WritePropertyName("sinkRetryWait"u8);
                JsonSerializer.Serialize(writer, SinkRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (Optional.IsDefined(DisableMetricsCollection))
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        SqlServerSink IJsonModel<SqlServerSink>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerSink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerSink)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlServerSink(document.RootElement, options);
        }

        internal static SqlServerSink DeserializeSqlServerSink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<string>> sqlWriterStoredProcedureName = default;
            Optional<DataFactoryElement<string>> sqlWriterTableType = default;
            Optional<DataFactoryElement<string>> preCopyScript = default;
            Optional<BinaryData> storedProcedureParameters = default;
            Optional<DataFactoryElement<string>> storedProcedureTableTypeParameterName = default;
            Optional<DataFactoryElement<string>> tableOption = default;
            Optional<DataFactoryElement<bool>> sqlWriterUseTableLock = default;
            Optional<DataFactoryElement<string>> writeBehavior = default;
            Optional<SqlUpsertSettings> upsertSettings = default;
            string type = default;
            Optional<DataFactoryElement<int>> writeBatchSize = default;
            Optional<DataFactoryElement<string>> writeBatchTimeout = default;
            Optional<DataFactoryElement<int>> sinkRetryCount = default;
            Optional<DataFactoryElement<string>> sinkRetryWait = default;
            Optional<DataFactoryElement<int>> maxConcurrentConnections = default;
            Optional<DataFactoryElement<bool>> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlWriterStoredProcedureName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlWriterStoredProcedureName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sqlWriterTableType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlWriterTableType = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("preCopyScript"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preCopyScript = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("storedProcedureParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storedProcedureParameters = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("storedProcedureTableTypeParameterName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storedProcedureTableTypeParameterName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("tableOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tableOption = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sqlWriterUseTableLock"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlWriterUseTableLock = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("writeBehavior"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBehavior = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("upsertSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upsertSettings = SqlUpsertSettings.DeserializeSqlUpsertSettings(property.Value, options);
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
                    writeBatchSize = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("writeBatchTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBatchTimeout = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sinkRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryCount = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sinkRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryWait = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableMetricsCollection = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SqlServerSink(type, writeBatchSize.Value, writeBatchTimeout.Value, sinkRetryCount.Value, sinkRetryWait.Value, maxConcurrentConnections.Value, disableMetricsCollection.Value, additionalProperties, sqlWriterStoredProcedureName.Value, sqlWriterTableType.Value, preCopyScript.Value, storedProcedureParameters.Value, storedProcedureTableTypeParameterName.Value, tableOption.Value, sqlWriterUseTableLock.Value, writeBehavior.Value, upsertSettings.Value);
        }

        BinaryData IPersistableModel<SqlServerSink>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerSink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlServerSink)} does not support '{options.Format}' format.");
            }
        }

        SqlServerSink IPersistableModel<SqlServerSink>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerSink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlServerSink(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlServerSink)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlServerSink>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
