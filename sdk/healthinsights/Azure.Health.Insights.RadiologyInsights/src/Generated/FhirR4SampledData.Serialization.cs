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
    public partial class FhirR4SampledData : IUtf8JsonSerializable, IJsonModel<FhirR4SampledData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FhirR4SampledData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FhirR4SampledData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4SampledData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirR4SampledData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("origin"u8);
            writer.WriteObjectValue(Origin);
            writer.WritePropertyName("period"u8);
            writer.WriteNumberValue(Period);
            if (Optional.IsDefined(Factor))
            {
                writer.WritePropertyName("factor"u8);
                writer.WriteNumberValue(Factor.Value);
            }
            if (Optional.IsDefined(LowerLimit))
            {
                writer.WritePropertyName("lowerLimit"u8);
                writer.WriteNumberValue(LowerLimit.Value);
            }
            if (Optional.IsDefined(UpperLimit))
            {
                writer.WritePropertyName("upperLimit"u8);
                writer.WriteNumberValue(UpperLimit.Value);
            }
            writer.WritePropertyName("dimensions"u8);
            writer.WriteNumberValue(Dimensions);
            if (Optional.IsDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStringValue(Data);
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

        FhirR4SampledData IJsonModel<FhirR4SampledData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4SampledData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirR4SampledData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFhirR4SampledData(document.RootElement, options);
        }

        internal static FhirR4SampledData DeserializeFhirR4SampledData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FhirR4Quantity origin = default;
            double period = default;
            double? factor = default;
            double? lowerLimit = default;
            double? upperLimit = default;
            int dimensions = default;
            string data = default;
            string id = default;
            IList<FhirR4Extension> extension = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("origin"u8))
                {
                    origin = FhirR4Quantity.DeserializeFhirR4Quantity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("period"u8))
                {
                    period = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("factor"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    factor = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("lowerLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lowerLimit = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("upperLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upperLimit = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("dimensions"u8))
                {
                    dimensions = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    data = property.Value.GetString();
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
            return new FhirR4SampledData(
                id,
                extension ?? new ChangeTrackingList<FhirR4Extension>(),
                serializedAdditionalRawData,
                origin,
                period,
                factor,
                lowerLimit,
                upperLimit,
                dimensions,
                data);
        }

        BinaryData IPersistableModel<FhirR4SampledData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4SampledData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FhirR4SampledData)} does not support '{options.Format}' format.");
            }
        }

        FhirR4SampledData IPersistableModel<FhirR4SampledData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4SampledData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFhirR4SampledData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FhirR4SampledData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FhirR4SampledData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new FhirR4SampledData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFhirR4SampledData(document.RootElement);
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
