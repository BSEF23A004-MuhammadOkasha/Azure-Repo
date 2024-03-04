// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApplicationInsights;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class Annotation : IUtf8JsonSerializable, IJsonModel<Annotation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Annotation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Annotation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Annotation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Annotation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AnnotationName))
            {
                writer.WritePropertyName("AnnotationName"u8);
                writer.WriteStringValue(AnnotationName);
            }
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("Category"u8);
                writer.WriteStringValue(Category);
            }
            if (Optional.IsDefined(EventOn))
            {
                writer.WritePropertyName("EventTime"u8);
                writer.WriteStringValue(EventOn.Value, "O");
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("Id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("Properties"u8);
                writer.WriteStringValue(Properties);
            }
            if (Optional.IsDefined(RelatedAnnotation))
            {
                writer.WritePropertyName("RelatedAnnotation"u8);
                writer.WriteStringValue(RelatedAnnotation);
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

        Annotation IJsonModel<Annotation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Annotation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Annotation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnnotation(document.RootElement, options);
        }

        internal static Annotation DeserializeAnnotation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string annotationName = default;
            string category = default;
            DateTimeOffset? eventTime = default;
            string id = default;
            string properties = default;
            string relatedAnnotation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("AnnotationName"u8))
                {
                    annotationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("EventTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("Id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Properties"u8))
                {
                    properties = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("RelatedAnnotation"u8))
                {
                    relatedAnnotation = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Annotation(
                annotationName,
                category,
                eventTime,
                id,
                properties,
                relatedAnnotation,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Annotation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Annotation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Annotation)} does not support '{options.Format}' format.");
            }
        }

        Annotation IPersistableModel<Annotation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Annotation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAnnotation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Annotation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<Annotation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
