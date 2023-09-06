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

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ResourceTypeSkuCapacity : IUtf8JsonSerializable, IModelJsonSerializable<ResourceTypeSkuCapacity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResourceTypeSkuCapacity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResourceTypeSkuCapacity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceTypeSkuCapacity>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("minimum"u8);
            writer.WriteNumberValue(Minimum);
            if (Optional.IsDefined(Maximum))
            {
                writer.WritePropertyName("maximum"u8);
                writer.WriteNumberValue(Maximum.Value);
            }
            if (Optional.IsDefined(Default))
            {
                writer.WritePropertyName("default"u8);
                writer.WriteNumberValue(Default.Value);
            }
            if (Optional.IsDefined(ScaleType))
            {
                writer.WritePropertyName("scaleType"u8);
                writer.WriteStringValue(ScaleType.Value.ToString());
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

        internal static ResourceTypeSkuCapacity DeserializeResourceTypeSkuCapacity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int minimum = default;
            Optional<int> maximum = default;
            Optional<int> @default = default;
            Optional<ResourceTypeSkuScaleType> scaleType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minimum"u8))
                {
                    minimum = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximum = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("default"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @default = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scaleType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleType = new ResourceTypeSkuScaleType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResourceTypeSkuCapacity(minimum, Optional.ToNullable(maximum), Optional.ToNullable(@default), Optional.ToNullable(scaleType), rawData);
        }

        ResourceTypeSkuCapacity IModelJsonSerializable<ResourceTypeSkuCapacity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceTypeSkuCapacity>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceTypeSkuCapacity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResourceTypeSkuCapacity>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceTypeSkuCapacity>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResourceTypeSkuCapacity IModelSerializable<ResourceTypeSkuCapacity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceTypeSkuCapacity>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceTypeSkuCapacity(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ResourceTypeSkuCapacity"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ResourceTypeSkuCapacity"/> to convert. </param>
        public static implicit operator RequestContent(ResourceTypeSkuCapacity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ResourceTypeSkuCapacity"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ResourceTypeSkuCapacity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResourceTypeSkuCapacity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
