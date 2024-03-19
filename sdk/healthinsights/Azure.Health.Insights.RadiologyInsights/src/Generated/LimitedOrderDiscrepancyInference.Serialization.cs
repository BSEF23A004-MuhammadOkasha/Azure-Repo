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
    public partial class LimitedOrderDiscrepancyInference : IUtf8JsonSerializable, IJsonModel<LimitedOrderDiscrepancyInference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LimitedOrderDiscrepancyInference>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LimitedOrderDiscrepancyInference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LimitedOrderDiscrepancyInference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LimitedOrderDiscrepancyInference)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("orderType"u8);
            writer.WriteObjectValue(OrderType);
            if (Optional.IsCollectionDefined(PresentBodyParts))
            {
                writer.WritePropertyName("presentBodyParts"u8);
                writer.WriteStartArray();
                foreach (var item in PresentBodyParts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PresentBodyPartMeasurements))
            {
                writer.WritePropertyName("presentBodyPartMeasurements"u8);
                writer.WriteStartArray();
                foreach (var item in PresentBodyPartMeasurements)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        LimitedOrderDiscrepancyInference IJsonModel<LimitedOrderDiscrepancyInference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LimitedOrderDiscrepancyInference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LimitedOrderDiscrepancyInference)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLimitedOrderDiscrepancyInference(document.RootElement, options);
        }

        internal static LimitedOrderDiscrepancyInference DeserializeLimitedOrderDiscrepancyInference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FhirR4CodeableConcept orderType = default;
            IReadOnlyList<FhirR4CodeableConcept> presentBodyParts = default;
            IReadOnlyList<FhirR4CodeableConcept> presentBodyPartMeasurements = default;
            IReadOnlyList<FhirR4Extension> extension = default;
            RadiologyInsightsInferenceType kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("orderType"u8))
                {
                    orderType = FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(property.Value, options);
                    continue;
                }
                if (property.NameEquals("presentBodyParts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4CodeableConcept> array = new List<FhirR4CodeableConcept>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(item, options));
                    }
                    presentBodyParts = array;
                    continue;
                }
                if (property.NameEquals("presentBodyPartMeasurements"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4CodeableConcept> array = new List<FhirR4CodeableConcept>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(item, options));
                    }
                    presentBodyPartMeasurements = array;
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
                if (property.NameEquals("kind"u8))
                {
                    kind = new RadiologyInsightsInferenceType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LimitedOrderDiscrepancyInference(
                extension ?? new ChangeTrackingList<FhirR4Extension>(),
                kind,
                serializedAdditionalRawData,
                orderType,
                presentBodyParts ?? new ChangeTrackingList<FhirR4CodeableConcept>(),
                presentBodyPartMeasurements ?? new ChangeTrackingList<FhirR4CodeableConcept>());
        }

        BinaryData IPersistableModel<LimitedOrderDiscrepancyInference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LimitedOrderDiscrepancyInference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LimitedOrderDiscrepancyInference)} does not support '{options.Format}' format.");
            }
        }

        LimitedOrderDiscrepancyInference IPersistableModel<LimitedOrderDiscrepancyInference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LimitedOrderDiscrepancyInference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLimitedOrderDiscrepancyInference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LimitedOrderDiscrepancyInference)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LimitedOrderDiscrepancyInference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new LimitedOrderDiscrepancyInference FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLimitedOrderDiscrepancyInference(document.RootElement);
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
