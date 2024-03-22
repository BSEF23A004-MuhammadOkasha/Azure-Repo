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
    internal partial class UpdateEncryptionConfig : IUtf8JsonSerializable, IJsonModel<UpdateEncryptionConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateEncryptionConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UpdateEncryptionConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateEncryptionConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateEncryptionConfig)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(KeyVaultMetaInfo))
            {
                writer.WritePropertyName("keyVaultMetaInfo"u8);
                writer.WriteObjectValue<UpdateKeyVaultMetaInfo>(KeyVaultMetaInfo, options);
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

        UpdateEncryptionConfig IJsonModel<UpdateEncryptionConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateEncryptionConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateEncryptionConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateEncryptionConfig(document.RootElement, options);
        }

        internal static UpdateEncryptionConfig DeserializeUpdateEncryptionConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UpdateKeyVaultMetaInfo keyVaultMetaInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultMetaInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultMetaInfo = UpdateKeyVaultMetaInfo.DeserializeUpdateKeyVaultMetaInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UpdateEncryptionConfig(keyVaultMetaInfo, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpdateEncryptionConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateEncryptionConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UpdateEncryptionConfig)} does not support writing '{options.Format}' format.");
            }
        }

        UpdateEncryptionConfig IPersistableModel<UpdateEncryptionConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateEncryptionConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUpdateEncryptionConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdateEncryptionConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateEncryptionConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
