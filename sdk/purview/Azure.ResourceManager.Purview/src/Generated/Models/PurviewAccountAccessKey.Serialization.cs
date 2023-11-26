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

namespace Azure.ResourceManager.Purview.Models
{
    public partial class PurviewAccountAccessKey : IUtf8JsonSerializable, IJsonModel<PurviewAccountAccessKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PurviewAccountAccessKey>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PurviewAccountAccessKey>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewAccountAccessKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PurviewAccountAccessKey)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AtlasKafkaPrimaryEndpoint))
            {
                writer.WritePropertyName("atlasKafkaPrimaryEndpoint"u8);
                writer.WriteStringValue(AtlasKafkaPrimaryEndpoint);
            }
            if (Optional.IsDefined(AtlasKafkaSecondaryEndpoint))
            {
                writer.WritePropertyName("atlasKafkaSecondaryEndpoint"u8);
                writer.WriteStringValue(AtlasKafkaSecondaryEndpoint);
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

        PurviewAccountAccessKey IJsonModel<PurviewAccountAccessKey>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewAccountAccessKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PurviewAccountAccessKey)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePurviewAccountAccessKey(document.RootElement, options);
        }

        internal static PurviewAccountAccessKey DeserializePurviewAccountAccessKey(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> atlasKafkaPrimaryEndpoint = default;
            Optional<string> atlasKafkaSecondaryEndpoint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("atlasKafkaPrimaryEndpoint"u8))
                {
                    atlasKafkaPrimaryEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("atlasKafkaSecondaryEndpoint"u8))
                {
                    atlasKafkaSecondaryEndpoint = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PurviewAccountAccessKey(atlasKafkaPrimaryEndpoint.Value, atlasKafkaSecondaryEndpoint.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PurviewAccountAccessKey>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewAccountAccessKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PurviewAccountAccessKey)} does not support '{options.Format}' format.");
            }
        }

        PurviewAccountAccessKey IPersistableModel<PurviewAccountAccessKey>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewAccountAccessKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePurviewAccountAccessKey(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PurviewAccountAccessKey)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PurviewAccountAccessKey>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
