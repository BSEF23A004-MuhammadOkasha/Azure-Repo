// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchCifsMountConfiguration : IUtf8JsonSerializable, IJsonModel<BatchCifsMountConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchCifsMountConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchCifsMountConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchCifsMountConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchCifsMountConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("userName"u8);
            writer.WriteStringValue(Username);
            writer.WritePropertyName("source"u8);
            writer.WriteStringValue(Source);
            writer.WritePropertyName("relativeMountPath"u8);
            writer.WriteStringValue(RelativeMountPath);
            if (MountOptions != null)
            {
                writer.WritePropertyName("mountOptions"u8);
                writer.WriteStringValue(MountOptions);
            }
            writer.WritePropertyName("password"u8);
            writer.WriteStringValue(Password);
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

        BatchCifsMountConfiguration IJsonModel<BatchCifsMountConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchCifsMountConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchCifsMountConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchCifsMountConfiguration(document.RootElement, options);
        }

        internal static BatchCifsMountConfiguration DeserializeBatchCifsMountConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string userName = default;
            string source = default;
            string relativeMountPath = default;
            Optional<string> mountOptions = default;
            string password = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userName"u8))
                {
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativeMountPath"u8))
                {
                    relativeMountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountOptions"u8))
                {
                    mountOptions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchCifsMountConfiguration(userName, source, relativeMountPath, mountOptions.Value, password, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchCifsMountConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchCifsMountConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchCifsMountConfiguration)} does not support '{options.Format}' format.");
            }
        }

        BatchCifsMountConfiguration IPersistableModel<BatchCifsMountConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchCifsMountConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchCifsMountConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchCifsMountConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchCifsMountConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
