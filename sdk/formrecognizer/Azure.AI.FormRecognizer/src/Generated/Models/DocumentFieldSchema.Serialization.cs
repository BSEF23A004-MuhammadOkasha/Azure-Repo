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
    public partial class DocumentFieldSchema : IUtf8JsonSerializable, IModelJsonSerializable<DocumentFieldSchema>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DocumentFieldSchema>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DocumentFieldSchema>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentFieldSchema>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToSerialString());
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Example))
            {
                writer.WritePropertyName("example"u8);
                writer.WriteStringValue(Example);
            }
            if (Optional.IsDefined(Items))
            {
                writer.WritePropertyName("items"u8);
                if (Items is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DocumentFieldSchema>)Items).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DocumentFieldSchema>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
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

        internal static DocumentFieldSchema DeserializeDocumentFieldSchema(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DocumentFieldType type = default;
            Optional<string> description = default;
            Optional<string> example = default;
            Optional<DocumentFieldSchema> items = default;
            Optional<IReadOnlyDictionary<string, DocumentFieldSchema>> properties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToDocumentFieldType();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("example"u8))
                {
                    example = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("items"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    items = DeserializeDocumentFieldSchema(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, DocumentFieldSchema> dictionary = new Dictionary<string, DocumentFieldSchema>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DeserializeDocumentFieldSchema(property0.Value));
                    }
                    properties = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DocumentFieldSchema(type, description.Value, example.Value, items.Value, Optional.ToDictionary(properties), rawData);
        }

        DocumentFieldSchema IModelJsonSerializable<DocumentFieldSchema>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentFieldSchema>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentFieldSchema(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DocumentFieldSchema>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentFieldSchema>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DocumentFieldSchema IModelSerializable<DocumentFieldSchema>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentFieldSchema>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDocumentFieldSchema(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DocumentFieldSchema"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DocumentFieldSchema"/> to convert. </param>
        public static implicit operator RequestContent(DocumentFieldSchema model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DocumentFieldSchema"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DocumentFieldSchema(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDocumentFieldSchema(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
