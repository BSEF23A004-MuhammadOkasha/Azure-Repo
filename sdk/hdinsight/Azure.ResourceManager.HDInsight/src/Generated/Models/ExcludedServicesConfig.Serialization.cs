// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class ExcludedServicesConfig : IUtf8JsonSerializable, IJsonModel<ExcludedServicesConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExcludedServicesConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExcludedServicesConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExcludedServicesConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExcludedServicesConfig)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ExcludedServicesConfigId != null)
            {
                writer.WritePropertyName("excludedServicesConfigId"u8);
                writer.WriteStringValue(ExcludedServicesConfigId);
            }
            if (ExcludedServicesList != null)
            {
                writer.WritePropertyName("excludedServicesList"u8);
                writer.WriteStringValue(ExcludedServicesList);
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

        ExcludedServicesConfig IJsonModel<ExcludedServicesConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExcludedServicesConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExcludedServicesConfig)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExcludedServicesConfig(document.RootElement, options);
        }

        internal static ExcludedServicesConfig DeserializeExcludedServicesConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> excludedServicesConfigId = default;
            Optional<string> excludedServicesList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("excludedServicesConfigId"u8))
                {
                    excludedServicesConfigId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludedServicesList"u8))
                {
                    excludedServicesList = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExcludedServicesConfig(excludedServicesConfigId.Value, excludedServicesList.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExcludedServicesConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExcludedServicesConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExcludedServicesConfig)} does not support '{options.Format}' format.");
            }
        }

        ExcludedServicesConfig IPersistableModel<ExcludedServicesConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExcludedServicesConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExcludedServicesConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExcludedServicesConfig)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExcludedServicesConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
