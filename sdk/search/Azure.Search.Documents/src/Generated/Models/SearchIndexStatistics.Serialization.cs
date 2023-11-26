// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexStatistics : IUtf8JsonSerializable, IJsonModel<SearchIndexStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchIndexStatistics>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SearchIndexStatistics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchIndexStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SearchIndexStatistics)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("documentCount"u8);
                writer.WriteNumberValue(DocumentCount);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("storageSize"u8);
                writer.WriteNumberValue(StorageSize);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("vectorIndexSize"u8);
                writer.WriteNumberValue(VectorIndexSize);
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

        SearchIndexStatistics IJsonModel<SearchIndexStatistics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchIndexStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SearchIndexStatistics)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchIndexStatistics(document.RootElement, options);
        }

        internal static SearchIndexStatistics DeserializeSearchIndexStatistics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long documentCount = default;
            long storageSize = default;
            long vectorIndexSize = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documentCount"u8))
                {
                    documentCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("storageSize"u8))
                {
                    storageSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("vectorIndexSize"u8))
                {
                    vectorIndexSize = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SearchIndexStatistics(documentCount, storageSize, vectorIndexSize, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SearchIndexStatistics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchIndexStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SearchIndexStatistics)} does not support '{options.Format}' format.");
            }
        }

        SearchIndexStatistics IPersistableModel<SearchIndexStatistics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchIndexStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSearchIndexStatistics(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SearchIndexStatistics)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SearchIndexStatistics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
