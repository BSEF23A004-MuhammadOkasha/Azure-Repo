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
    public partial class ProductDisplayInfo : IUtf8JsonSerializable, IModelJsonSerializable<ProductDisplayInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProductDisplayInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProductDisplayInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProductDisplayInfo>(this, options.Format);

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

        internal static ProductDisplayInfo DeserializeProductDisplayInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> productFamilyDisplayName = default;
            Optional<string> configurationDisplayName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("productFamilyDisplayName"u8))
                {
                    productFamilyDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationDisplayName"u8))
                {
                    configurationDisplayName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ProductDisplayInfo(productFamilyDisplayName.Value, configurationDisplayName.Value, rawData);
        }

        ProductDisplayInfo IModelJsonSerializable<ProductDisplayInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProductDisplayInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProductDisplayInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProductDisplayInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProductDisplayInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProductDisplayInfo IModelSerializable<ProductDisplayInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProductDisplayInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProductDisplayInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ProductDisplayInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ProductDisplayInfo"/> to convert. </param>
        public static implicit operator RequestContent(ProductDisplayInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ProductDisplayInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ProductDisplayInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProductDisplayInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
