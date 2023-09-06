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
    public partial class DocumentPage : IUtf8JsonSerializable, IModelJsonSerializable<DocumentPage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DocumentPage>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DocumentPage>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentPage>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("pageNumber"u8);
            writer.WriteNumberValue(PageNumber);
            if (Optional.IsDefined(Angle))
            {
                writer.WritePropertyName("angle"u8);
                writer.WriteNumberValue(Angle.Value);
            }
            if (Optional.IsDefined(Width))
            {
                writer.WritePropertyName("width"u8);
                writer.WriteNumberValue(Width.Value);
            }
            if (Optional.IsDefined(Height))
            {
                writer.WritePropertyName("height"u8);
                writer.WriteNumberValue(Height.Value);
            }
            if (Optional.IsDefined(UnitPrivate))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(UnitPrivate.Value.ToString());
            }
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
            if (Optional.IsCollectionDefined(Words))
            {
                writer.WritePropertyName("words"u8);
                writer.WriteStartArray();
                foreach (var item in Words)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DocumentWord>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SelectionMarks))
            {
                writer.WritePropertyName("selectionMarks"u8);
                writer.WriteStartArray();
                foreach (var item in SelectionMarks)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DocumentSelectionMark>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Lines))
            {
                writer.WritePropertyName("lines"u8);
                writer.WriteStartArray();
                foreach (var item in Lines)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DocumentLine>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Barcodes))
            {
                writer.WritePropertyName("barcodes"u8);
                writer.WriteStartArray();
                foreach (var item in Barcodes)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DocumentBarcode>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Formulas))
            {
                writer.WritePropertyName("formulas"u8);
                writer.WriteStartArray();
                foreach (var item in Formulas)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DocumentFormula>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static DocumentPage DeserializeDocumentPage(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int pageNumber = default;
            Optional<float> angle = default;
            Optional<float> width = default;
            Optional<float> height = default;
            Optional<V3LengthUnit> unit = default;
            IReadOnlyList<DocumentSpan> spans = default;
            Optional<IReadOnlyList<DocumentWord>> words = default;
            Optional<IReadOnlyList<DocumentSelectionMark>> selectionMarks = default;
            Optional<IReadOnlyList<DocumentLine>> lines = default;
            Optional<IReadOnlyList<DocumentBarcode>> barcodes = default;
            Optional<IReadOnlyList<DocumentFormula>> formulas = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pageNumber"u8))
                {
                    pageNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("angle"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    angle = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("width"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    width = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("height"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    height = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new V3LengthUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("spans"u8))
                {
                    List<DocumentSpan> array = new List<DocumentSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentSpan.DeserializeDocumentSpan(item));
                    }
                    spans = array;
                    continue;
                }
                if (property.NameEquals("words"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentWord> array = new List<DocumentWord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentWord.DeserializeDocumentWord(item));
                    }
                    words = array;
                    continue;
                }
                if (property.NameEquals("selectionMarks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentSelectionMark> array = new List<DocumentSelectionMark>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentSelectionMark.DeserializeDocumentSelectionMark(item));
                    }
                    selectionMarks = array;
                    continue;
                }
                if (property.NameEquals("lines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentLine> array = new List<DocumentLine>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentLine.DeserializeDocumentLine(item));
                    }
                    lines = array;
                    continue;
                }
                if (property.NameEquals("barcodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentBarcode> array = new List<DocumentBarcode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentBarcode.DeserializeDocumentBarcode(item));
                    }
                    barcodes = array;
                    continue;
                }
                if (property.NameEquals("formulas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentFormula> array = new List<DocumentFormula>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentFormula.DeserializeDocumentFormula(item));
                    }
                    formulas = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DocumentPage(pageNumber, Optional.ToNullable(angle), Optional.ToNullable(width), Optional.ToNullable(height), Optional.ToNullable(unit), spans, Optional.ToList(words), Optional.ToList(selectionMarks), Optional.ToList(lines), Optional.ToList(barcodes), Optional.ToList(formulas), rawData);
        }

        DocumentPage IModelJsonSerializable<DocumentPage>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentPage>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentPage(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DocumentPage>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentPage>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DocumentPage IModelSerializable<DocumentPage>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentPage>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDocumentPage(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DocumentPage"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DocumentPage"/> to convert. </param>
        public static implicit operator RequestContent(DocumentPage model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DocumentPage"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DocumentPage(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDocumentPage(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
