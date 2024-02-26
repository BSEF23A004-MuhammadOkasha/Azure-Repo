// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBSqlClientEncryptionKeyProperties : IUtf8JsonSerializable, IJsonModel<CosmosDBSqlClientEncryptionKeyProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBSqlClientEncryptionKeyProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosDBSqlClientEncryptionKeyProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlClientEncryptionKeyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBSqlClientEncryptionKeyProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Rid != null)
            {
                writer.WritePropertyName("_rid"u8);
                writer.WriteStringValue(Rid);
            }
            if (options.Format != "W" && Timestamp.HasValue)
            {
                writer.WritePropertyName("_ts"u8);
                writer.WriteNumberValue(Timestamp.Value);
            }
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("_etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (EncryptionAlgorithm != null)
            {
                writer.WritePropertyName("encryptionAlgorithm"u8);
                writer.WriteStringValue(EncryptionAlgorithm);
            }
            if (WrappedDataEncryptionKey != null)
            {
                writer.WritePropertyName("wrappedDataEncryptionKey"u8);
                writer.WriteBase64StringValue(WrappedDataEncryptionKey, "D");
            }
            if (KeyWrapMetadata != null)
            {
                writer.WritePropertyName("keyWrapMetadata"u8);
                writer.WriteObjectValue(KeyWrapMetadata);
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

        CosmosDBSqlClientEncryptionKeyProperties IJsonModel<CosmosDBSqlClientEncryptionKeyProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlClientEncryptionKeyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBSqlClientEncryptionKeyProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBSqlClientEncryptionKeyProperties(document.RootElement, options);
        }

        internal static CosmosDBSqlClientEncryptionKeyProperties DeserializeCosmosDBSqlClientEncryptionKeyProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> rid = default;
            Optional<float> ts = default;
            Optional<ETag> etag = default;
            Optional<string> id = default;
            Optional<string> encryptionAlgorithm = default;
            Optional<byte[]> wrappedDataEncryptionKey = default;
            Optional<CosmosDBKeyWrapMetadata> keyWrapMetadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"u8))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ts = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("_etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionAlgorithm"u8))
                {
                    encryptionAlgorithm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("wrappedDataEncryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wrappedDataEncryptionKey = property.Value.GetBytesFromBase64("D");
                    continue;
                }
                if (property.NameEquals("keyWrapMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyWrapMetadata = CosmosDBKeyWrapMetadata.DeserializeCosmosDBKeyWrapMetadata(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosDBSqlClientEncryptionKeyProperties(id.Value, encryptionAlgorithm.Value, wrappedDataEncryptionKey.Value, keyWrapMetadata.Value, serializedAdditionalRawData, rid.Value, Optional.ToNullable(ts), Optional.ToNullable(etag));
        }

        BinaryData IPersistableModel<CosmosDBSqlClientEncryptionKeyProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlClientEncryptionKeyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBSqlClientEncryptionKeyProperties)} does not support '{options.Format}' format.");
            }
        }

        CosmosDBSqlClientEncryptionKeyProperties IPersistableModel<CosmosDBSqlClientEncryptionKeyProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlClientEncryptionKeyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBSqlClientEncryptionKeyProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBSqlClientEncryptionKeyProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBSqlClientEncryptionKeyProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
