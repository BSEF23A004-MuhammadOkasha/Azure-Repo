// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    public partial class DocumentLine : IUtf8JsonSerializable, IJsonModel<DocumentLine>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DocumentLine>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DocumentLine>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentLine>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentLine)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("content"u8);
            writer.WriteStringValue(Content);
            if (Optional.IsCollectionDefined(Polygon))
            {
                writer.WritePropertyName("polygon"u8);
                writer.WriteStartArray();
                foreach (var item in Polygon)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("spans"u8);
            writer.WriteStartArray();
            foreach (var item in Spans)
            {
                writer.WriteObjectValue<DocumentSpan>(item, options);
            }
            writer.WriteEndArray();
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

        DocumentLine IJsonModel<DocumentLine>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentLine>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentLine)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentLine(document.RootElement, options);
        }

        internal static DocumentLine DeserializeDocumentLine(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string content = default;
            IReadOnlyList<float> polygon = default;
            IReadOnlyList<DocumentSpan> spans = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"u8))
                {
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("polygon"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    polygon = array;
                    continue;
                }
                if (property.NameEquals("spans"u8))
                {
                    List<DocumentSpan> array = new List<DocumentSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentSpan.DeserializeDocumentSpan(item, options));
                    }
                    spans = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DocumentLine(content, polygon ?? new ChangeTrackingList<float>(), spans, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DocumentLine>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentLine>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DocumentLine)} does not support writing '{options.Format}' format.");
            }
        }

        DocumentLine IPersistableModel<DocumentLine>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentLine>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDocumentLine(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DocumentLine)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DocumentLine>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DocumentLine FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDocumentLine(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<DocumentLine>(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
