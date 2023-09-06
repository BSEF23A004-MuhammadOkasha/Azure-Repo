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

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class KeyValueElement : IUtf8JsonSerializable, IModelJsonSerializable<KeyValueElement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KeyValueElement>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KeyValueElement>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyValueElement>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.Value.ToString());
            }
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            if (Optional.IsCollectionDefined(BoundingBox))
            {
                if (BoundingBox != null)
                {
                    writer.WritePropertyName("boundingBox"u8);
                    writer.WriteStartArray();
                    foreach (var item in BoundingBox)
                    {
                        writer.WriteNumberValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("boundingBox");
                }
            }
            if (Optional.IsCollectionDefined(Elements))
            {
                if (Elements != null)
                {
                    writer.WritePropertyName("elements"u8);
                    writer.WriteStartArray();
                    foreach (var item in Elements)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("elements");
                }
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

        internal static KeyValueElement DeserializeKeyValueElement(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<KeyValueType> type = default;
            string text = default;
            Optional<IReadOnlyList<float>> boundingBox = default;
            Optional<IReadOnlyList<string>> elements = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new KeyValueType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boundingBox"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        boundingBox = null;
                        continue;
                    }
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    boundingBox = array;
                    continue;
                }
                if (property.NameEquals("elements"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        elements = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    elements = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KeyValueElement(Optional.ToNullable(type), text, Optional.ToList(boundingBox), Optional.ToList(elements), rawData);
        }

        KeyValueElement IModelJsonSerializable<KeyValueElement>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyValueElement>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyValueElement(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KeyValueElement>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyValueElement>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KeyValueElement IModelSerializable<KeyValueElement>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyValueElement>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKeyValueElement(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KeyValueElement"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KeyValueElement"/> to convert. </param>
        public static implicit operator RequestContent(KeyValueElement model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KeyValueElement"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KeyValueElement(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKeyValueElement(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
