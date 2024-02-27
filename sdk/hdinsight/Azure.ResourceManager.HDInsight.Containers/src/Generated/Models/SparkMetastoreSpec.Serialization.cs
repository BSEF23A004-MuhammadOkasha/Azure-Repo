// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class SparkMetastoreSpec : IUtf8JsonSerializable, IJsonModel<SparkMetastoreSpec>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SparkMetastoreSpec>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SparkMetastoreSpec>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkMetastoreSpec>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SparkMetastoreSpec)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("dbServerHost"u8);
            writer.WriteStringValue(DBServerHost);
            writer.WritePropertyName("dbName"u8);
            writer.WriteStringValue(DBName);
            writer.WritePropertyName("dbUserName"u8);
            writer.WriteStringValue(DBUserName);
            writer.WritePropertyName("dbPasswordSecretName"u8);
            writer.WriteStringValue(DBPasswordSecretName);
            writer.WritePropertyName("keyVaultId"u8);
            writer.WriteStringValue(KeyVaultId);
            if (ThriftUriString != null)
            {
                writer.WritePropertyName("thriftUrl"u8);
                writer.WriteStringValue(ThriftUriString);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
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
            }
            writer.WriteEndObject();
        }

        SparkMetastoreSpec IJsonModel<SparkMetastoreSpec>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkMetastoreSpec>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SparkMetastoreSpec)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSparkMetastoreSpec(document.RootElement, options);
        }

        internal static SparkMetastoreSpec DeserializeSparkMetastoreSpec(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dbServerHost = default;
            string dbName = default;
            string dbUserName = default;
            string dbPasswordSecretName = default;
            string keyVaultId = default;
            string thriftUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dbServerHost"u8))
                {
                    dbServerHost = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbName"u8))
                {
                    dbName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbUserName"u8))
                {
                    dbUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbPasswordSecretName"u8))
                {
                    dbPasswordSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultId"u8))
                {
                    keyVaultId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thriftUrl"u8))
                {
                    thriftUrl = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SparkMetastoreSpec(
                dbServerHost,
                dbName,
                dbUserName,
                dbPasswordSecretName,
                keyVaultId,
                thriftUrl,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SparkMetastoreSpec>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkMetastoreSpec>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SparkMetastoreSpec)} does not support '{options.Format}' format.");
            }
        }

        SparkMetastoreSpec IPersistableModel<SparkMetastoreSpec>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkMetastoreSpec>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSparkMetastoreSpec(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SparkMetastoreSpec)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SparkMetastoreSpec>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
