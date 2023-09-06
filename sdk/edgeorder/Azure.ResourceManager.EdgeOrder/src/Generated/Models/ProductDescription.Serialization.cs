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

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ProductDescription : IUtf8JsonSerializable, IModelJsonSerializable<ProductDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProductDescription>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProductDescription>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProductDescription>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ProductDescription DeserializeProductDescription(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProductDescriptionType> descriptionType = default;
            Optional<string> shortDescription = default;
            Optional<string> longDescription = default;
            Optional<IReadOnlyList<string>> keywords = default;
            Optional<IReadOnlyList<string>> attributes = default;
            Optional<IReadOnlyList<ProductLink>> links = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("descriptionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    descriptionType = new ProductDescriptionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("shortDescription"u8))
                {
                    shortDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("longDescription"u8))
                {
                    longDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keywords"u8))
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
                    keywords = array;
                    continue;
                }
                if (property.NameEquals("attributes"u8))
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
                    attributes = array;
                    continue;
                }
                if (property.NameEquals("links"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProductLink> array = new List<ProductLink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProductLink.DeserializeProductLink(item));
                    }
                    links = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ProductDescription(Optional.ToNullable(descriptionType), shortDescription.Value, longDescription.Value, Optional.ToList(keywords), Optional.ToList(attributes), Optional.ToList(links), rawData);
        }

        ProductDescription IModelJsonSerializable<ProductDescription>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProductDescription>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProductDescription(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProductDescription>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProductDescription>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProductDescription IModelSerializable<ProductDescription>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProductDescription>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProductDescription(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ProductDescription"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ProductDescription"/> to convert. </param>
        public static implicit operator RequestContent(ProductDescription model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ProductDescription"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ProductDescription(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProductDescription(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
