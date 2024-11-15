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
    public partial class DocumentField : IUtf8JsonSerializable, IJsonModel<DocumentField>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DocumentField>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DocumentField>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentField>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentField)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            if (Optional.IsDefined(ValueString))
            {
                writer.WritePropertyName("valueString"u8);
                writer.WriteStringValue(ValueString);
            }
            if (Optional.IsDefined(ValueDate))
            {
                writer.WritePropertyName("valueDate"u8);
                writer.WriteStringValue(ValueDate.Value, "D");
            }
            if (Optional.IsDefined(ValueTime))
            {
                writer.WritePropertyName("valueTime"u8);
                writer.WriteStringValue(ValueTime.Value, "T");
            }
            if (Optional.IsDefined(ValuePhoneNumber))
            {
                writer.WritePropertyName("valuePhoneNumber"u8);
                writer.WriteStringValue(ValuePhoneNumber);
            }
            if (Optional.IsDefined(ValueDouble))
            {
                writer.WritePropertyName("valueNumber"u8);
                writer.WriteNumberValue(ValueDouble.Value);
            }
            if (Optional.IsDefined(ValueLong))
            {
                writer.WritePropertyName("valueInteger"u8);
                writer.WriteNumberValue(ValueLong.Value);
            }
            if (Optional.IsDefined(ValueSelectionMark))
            {
                writer.WritePropertyName("valueSelectionMark"u8);
                writer.WriteStringValue(ValueSelectionMark.Value.ToString());
            }
            if (Optional.IsDefined(ValueSignature))
            {
                writer.WritePropertyName("valueSignature"u8);
                writer.WriteStringValue(ValueSignature.Value.ToString());
            }
            if (Optional.IsDefined(ValueCountryRegion))
            {
                writer.WritePropertyName("valueCountryRegion"u8);
                writer.WriteStringValue(ValueCountryRegion);
            }
            if (Optional.IsCollectionDefined(ValueList))
            {
                writer.WritePropertyName("valueArray"u8);
                writer.WriteStartArray();
                foreach (var item in ValueList)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ValueDictionary))
            {
                writer.WritePropertyName("valueObject"u8);
                writer.WriteStartObject();
                foreach (var item in ValueDictionary)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ValueCurrency))
            {
                writer.WritePropertyName("valueCurrency"u8);
                writer.WriteObjectValue(ValueCurrency, options);
            }
            if (Optional.IsDefined(ValueAddress))
            {
                writer.WritePropertyName("valueAddress"u8);
                writer.WriteObjectValue(ValueAddress, options);
            }
            if (Optional.IsDefined(ValueBoolean))
            {
                writer.WritePropertyName("valueBoolean"u8);
                writer.WriteBooleanValue(ValueBoolean.Value);
            }
            if (Optional.IsCollectionDefined(ValueSelectionGroup))
            {
                writer.WritePropertyName("valueSelectionGroup"u8);
                writer.WriteStartArray();
                foreach (var item in ValueSelectionGroup)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content"u8);
                writer.WriteStringValue(Content);
            }
            if (Optional.IsCollectionDefined(BoundingRegions))
            {
                writer.WritePropertyName("boundingRegions"u8);
                writer.WriteStartArray();
                foreach (var item in BoundingRegions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Spans))
            {
                writer.WritePropertyName("spans"u8);
                writer.WriteStartArray();
                foreach (var item in Spans)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Confidence))
            {
                writer.WritePropertyName("confidence"u8);
                writer.WriteNumberValue(Confidence.Value);
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
        }

        DocumentField IJsonModel<DocumentField>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentField>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentField)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentField(document.RootElement, options);
        }

        internal static DocumentField DeserializeDocumentField(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DocumentFieldType type = default;
            string valueString = default;
            DateTimeOffset? valueDate = default;
            TimeSpan? valueTime = default;
            string valuePhoneNumber = default;
            double? valueNumber = default;
            long? valueInteger = default;
            DocumentSelectionMarkState? valueSelectionMark = default;
            DocumentSignatureType? valueSignature = default;
            string valueCountryRegion = default;
            IReadOnlyList<DocumentField> valueArray = default;
            IReadOnlyDictionary<string, DocumentField> valueObject = default;
            CurrencyValue valueCurrency = default;
            AddressValue valueAddress = default;
            bool? valueBoolean = default;
            IReadOnlyList<string> valueSelectionGroup = default;
            string content = default;
            IReadOnlyList<BoundingRegion> boundingRegions = default;
            IReadOnlyList<DocumentSpan> spans = default;
            float? confidence = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new DocumentFieldType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("valueString"u8))
                {
                    valueString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("valueTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueTime = property.Value.GetTimeSpan("T");
                    continue;
                }
                if (property.NameEquals("valuePhoneNumber"u8))
                {
                    valuePhoneNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueNumber = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("valueInteger"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueInteger = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("valueSelectionMark"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueSelectionMark = new DocumentSelectionMarkState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("valueSignature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueSignature = new DocumentSignatureType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("valueCountryRegion"u8))
                {
                    valueCountryRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueArray"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentField> array = new List<DocumentField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeDocumentField(item, options));
                    }
                    valueArray = array;
                    continue;
                }
                if (property.NameEquals("valueObject"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, DocumentField> dictionary = new Dictionary<string, DocumentField>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DeserializeDocumentField(property0.Value, options));
                    }
                    valueObject = dictionary;
                    continue;
                }
                if (property.NameEquals("valueCurrency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueCurrency = CurrencyValue.DeserializeCurrencyValue(property.Value, options);
                    continue;
                }
                if (property.NameEquals("valueAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueAddress = AddressValue.DeserializeAddressValue(property.Value, options);
                    continue;
                }
                if (property.NameEquals("valueBoolean"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueBoolean = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("valueSelectionGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    valueSelectionGroup = array;
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boundingRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BoundingRegion> array = new List<BoundingRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BoundingRegion.DeserializeBoundingRegion(item, options));
                    }
                    boundingRegions = array;
                    continue;
                }
                if (property.NameEquals("spans"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentSpan> array = new List<DocumentSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentSpan.DeserializeDocumentSpan(item, options));
                    }
                    spans = array;
                    continue;
                }
                if (property.NameEquals("confidence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    confidence = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DocumentField(
                type,
                valueString,
                valueDate,
                valueTime,
                valuePhoneNumber,
                valueNumber,
                valueInteger,
                valueSelectionMark,
                valueSignature,
                valueCountryRegion,
                valueArray ?? new ChangeTrackingList<DocumentField>(),
                valueObject ?? new ChangeTrackingDictionary<string, DocumentField>(),
                valueCurrency,
                valueAddress,
                valueBoolean,
                valueSelectionGroup ?? new ChangeTrackingList<string>(),
                content,
                boundingRegions ?? new ChangeTrackingList<BoundingRegion>(),
                spans ?? new ChangeTrackingList<DocumentSpan>(),
                confidence,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DocumentField>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentField>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DocumentField)} does not support writing '{options.Format}' format.");
            }
        }

        DocumentField IPersistableModel<DocumentField>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentField>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDocumentField(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DocumentField)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DocumentField>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DocumentField FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDocumentField(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
