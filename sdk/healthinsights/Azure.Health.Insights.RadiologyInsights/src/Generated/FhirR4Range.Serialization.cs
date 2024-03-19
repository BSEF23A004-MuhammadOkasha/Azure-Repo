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

namespace Azure.Health.Insights.RadiologyInsights
{
    public partial class FhirR4Range : IUtf8JsonSerializable, IJsonModel<FhirR4Range>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FhirR4Range>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FhirR4Range>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Range>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirR4Range)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Low))
            {
                writer.WritePropertyName("low"u8);
                writer.WriteObjectValue(Low);
            }
            if (Optional.IsDefined(High))
            {
                writer.WritePropertyName("high"u8);
                writer.WriteObjectValue(High);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsCollectionDefined(Extension))
            {
                writer.WritePropertyName("extension"u8);
                writer.WriteStartArray();
                foreach (var item in Extension)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        FhirR4Range IJsonModel<FhirR4Range>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Range>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirR4Range)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFhirR4Range(document.RootElement, options);
        }

        internal static FhirR4Range DeserializeFhirR4Range(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FhirR4Quantity low = default;
            FhirR4Quantity high = default;
            string id = default;
            IList<FhirR4Extension> extension = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("low"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    low = FhirR4Quantity.DeserializeFhirR4Quantity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("high"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    high = FhirR4Quantity.DeserializeFhirR4Quantity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extension"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4Extension> array = new List<FhirR4Extension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4Extension.DeserializeFhirR4Extension(item, options));
                    }
                    extension = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FhirR4Range(id, extension ?? new ChangeTrackingList<FhirR4Extension>(), serializedAdditionalRawData, low, high);
        }

        BinaryData IPersistableModel<FhirR4Range>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Range>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FhirR4Range)} does not support '{options.Format}' format.");
            }
        }

        FhirR4Range IPersistableModel<FhirR4Range>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Range>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFhirR4Range(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FhirR4Range)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FhirR4Range>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new FhirR4Range FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFhirR4Range(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
