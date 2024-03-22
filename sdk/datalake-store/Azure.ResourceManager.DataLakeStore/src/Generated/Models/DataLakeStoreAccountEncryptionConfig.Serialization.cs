// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    public partial class DataLakeStoreAccountEncryptionConfig : IUtf8JsonSerializable, IJsonModel<DataLakeStoreAccountEncryptionConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataLakeStoreAccountEncryptionConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataLakeStoreAccountEncryptionConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountEncryptionConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeStoreAccountEncryptionConfig)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ConfigType.ToSerialString());
            if (Optional.IsDefined(KeyVaultMetaInfo))
            {
                writer.WritePropertyName("keyVaultMetaInfo"u8);
                writer.WriteObjectValue<DataLakeStoreAccountKeyVaultMetaInfo>(KeyVaultMetaInfo, options);
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

        DataLakeStoreAccountEncryptionConfig IJsonModel<DataLakeStoreAccountEncryptionConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountEncryptionConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeStoreAccountEncryptionConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeStoreAccountEncryptionConfig(document.RootElement, options);
        }

        internal static DataLakeStoreAccountEncryptionConfig DeserializeDataLakeStoreAccountEncryptionConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataLakeStoreAccountEncryptionConfigType type = default;
            DataLakeStoreAccountKeyVaultMetaInfo keyVaultMetaInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToDataLakeStoreAccountEncryptionConfigType();
                    continue;
                }
                if (property.NameEquals("keyVaultMetaInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultMetaInfo = DataLakeStoreAccountKeyVaultMetaInfo.DeserializeDataLakeStoreAccountKeyVaultMetaInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataLakeStoreAccountEncryptionConfig(type, keyVaultMetaInfo, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataLakeStoreAccountEncryptionConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountEncryptionConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataLakeStoreAccountEncryptionConfig)} does not support writing '{options.Format}' format.");
            }
        }

        DataLakeStoreAccountEncryptionConfig IPersistableModel<DataLakeStoreAccountEncryptionConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeStoreAccountEncryptionConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataLakeStoreAccountEncryptionConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataLakeStoreAccountEncryptionConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataLakeStoreAccountEncryptionConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
