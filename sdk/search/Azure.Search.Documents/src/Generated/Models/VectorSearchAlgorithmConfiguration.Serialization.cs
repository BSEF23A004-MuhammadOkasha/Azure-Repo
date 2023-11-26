// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents.Indexes.Models
{
    [PersistableModelProxy(typeof(UnknownVectorSearchAlgorithmConfiguration))]
    public partial class VectorSearchAlgorithmConfiguration : IUtf8JsonSerializable, IJsonModel<VectorSearchAlgorithmConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VectorSearchAlgorithmConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VectorSearchAlgorithmConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorSearchAlgorithmConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VectorSearchAlgorithmConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        VectorSearchAlgorithmConfiguration IJsonModel<VectorSearchAlgorithmConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorSearchAlgorithmConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VectorSearchAlgorithmConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVectorSearchAlgorithmConfiguration(document.RootElement, options);
        }

        internal static VectorSearchAlgorithmConfiguration DeserializeVectorSearchAlgorithmConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "exhaustiveKnn": return ExhaustiveKnnAlgorithmConfiguration.DeserializeExhaustiveKnnAlgorithmConfiguration(element);
                    case "hnsw": return HnswAlgorithmConfiguration.DeserializeHnswAlgorithmConfiguration(element);
                }
            }
            return UnknownVectorSearchAlgorithmConfiguration.DeserializeUnknownVectorSearchAlgorithmConfiguration(element);
        }

        BinaryData IPersistableModel<VectorSearchAlgorithmConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorSearchAlgorithmConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(VectorSearchAlgorithmConfiguration)} does not support '{options.Format}' format.");
            }
        }

        VectorSearchAlgorithmConfiguration IPersistableModel<VectorSearchAlgorithmConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorSearchAlgorithmConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVectorSearchAlgorithmConfiguration(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(VectorSearchAlgorithmConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VectorSearchAlgorithmConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
