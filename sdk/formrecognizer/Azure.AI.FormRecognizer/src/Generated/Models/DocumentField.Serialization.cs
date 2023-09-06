// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class DocumentField : IUtf8JsonSerializable, IModelJsonSerializable<DocumentField>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DocumentField>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DocumentField>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentField>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ExpectedFieldType.ToSerialString());
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
            if (Optional.IsDefined(ValueNumber))
            {
                writer.WritePropertyName("valueNumber"u8);
                writer.WriteNumberValue(ValueNumber.Value);
            }
            if (Optional.IsDefined(ValueInteger))
            {
                writer.WritePropertyName("valueInteger"u8);
                writer.WriteNumberValue(ValueInteger.Value);
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
            if (Optional.IsCollectionDefined(ValueArray))
            {
                writer.WritePropertyName("valueArray"u8);
                writer.WriteStartArray();
                foreach (var item in ValueArray)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DocumentField>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ValueObject))
            {
                writer.WritePropertyName("valueObject"u8);
                writer.WriteStartObject();
                foreach (var item in ValueObject)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DocumentField>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ValueCurrency))
            {
                writer.WritePropertyName("valueCurrency"u8);
                if (ValueCurrency.Value is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CurrencyValue>)ValueCurrency.Value).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ValueAddress))
            {
                writer.WritePropertyName("valueAddress"u8);
                if (ValueAddress is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AddressValue>)ValueAddress).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ValueBoolean))
            {
                writer.WritePropertyName("valueBoolean"u8);
                writer.WriteBooleanValue(ValueBoolean.Value);
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
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<BoundingRegion>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Spans))
            {
                writer.WritePropertyName("spans"u8);
                writer.WriteStartArray();
                foreach (var item in Spans)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DocumentSpan>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Confidence))
            {
                writer.WritePropertyName("confidence"u8);
                writer.WriteNumberValue(Confidence.Value);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static DocumentField DeserializeDocumentField(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DocumentFieldType type = default;
            Optional<string> valueString = default;
            Optional<DateTimeOffset> valueDate = default;
            Optional<TimeSpan> valueTime = default;
            Optional<string> valuePhoneNumber = default;
            Optional<double> valueNumber = default;
            Optional<long> valueInteger = default;
            Optional<V3SelectionMarkState> valueSelectionMark = default;
            Optional<DocumentSignatureType> valueSignature = default;
            Optional<string> valueCountryRegion = default;
            Optional<IReadOnlyList<DocumentField>> valueArray = default;
            Optional<IReadOnlyDictionary<string, DocumentField>> valueObject = default;
            Optional<CurrencyValue> valueCurrency = default;
            Optional<AddressValue> valueAddress = default;
            Optional<bool> valueBoolean = default;
            Optional<string> content = default;
            Optional<IReadOnlyList<BoundingRegion>> boundingRegions = default;
            Optional<IReadOnlyList<DocumentSpan>> spans = default;
            Optional<float> confidence = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToDocumentFieldType();
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
                    valueSelectionMark = new V3SelectionMarkState(property.Value.GetString());
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
                        array.Add(DeserializeDocumentField(item));
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
                        dictionary.Add(property0.Name, DeserializeDocumentField(property0.Value));
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
                    valueCurrency = CurrencyValue.DeserializeCurrencyValue(property.Value);
                    continue;
                }
                if (property.NameEquals("valueAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueAddress = AddressValue.DeserializeAddressValue(property.Value);
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
                        array.Add(BoundingRegion.DeserializeBoundingRegion(item));
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
                        array.Add(DocumentSpan.DeserializeDocumentSpan(item));
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DocumentField(type, valueString.Value, Optional.ToNullable(valueDate), Optional.ToNullable(valueTime), valuePhoneNumber.Value, Optional.ToNullable(valueNumber), Optional.ToNullable(valueInteger), Optional.ToNullable(valueSelectionMark), Optional.ToNullable(valueSignature), valueCountryRegion.Value, Optional.ToList(valueArray), Optional.ToDictionary(valueObject), Optional.ToNullable(valueCurrency), valueAddress.Value, Optional.ToNullable(valueBoolean), content.Value, Optional.ToList(boundingRegions), Optional.ToList(spans), Optional.ToNullable(confidence), rawData);
        }

        DocumentField IModelJsonSerializable<DocumentField>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentField>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentField(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DocumentField>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentField>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DocumentField IModelSerializable<DocumentField>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentField>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDocumentField(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DocumentField"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DocumentField"/> to convert. </param>
        public static implicit operator RequestContent(DocumentField model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DocumentField"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DocumentField(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDocumentField(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
