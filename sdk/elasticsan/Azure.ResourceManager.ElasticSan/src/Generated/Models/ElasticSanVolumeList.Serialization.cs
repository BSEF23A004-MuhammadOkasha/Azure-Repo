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
using Azure.ResourceManager.ElasticSan;

namespace Azure.ResourceManager.ElasticSan.Models
{
    internal partial class ElasticSanVolumeList : IUtf8JsonSerializable, IModelJsonSerializable<ElasticSanVolumeList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ElasticSanVolumeList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ElasticSanVolumeList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ElasticSanVolumeList>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ElasticSanVolumeData>)item).Serialize(writer, options);
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

        internal static ElasticSanVolumeList DeserializeElasticSanVolumeList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ElasticSanVolumeData>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ElasticSanVolumeData> array = new List<ElasticSanVolumeData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ElasticSanVolumeData.DeserializeElasticSanVolumeData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ElasticSanVolumeList(Optional.ToList(value), nextLink.Value, rawData);
        }

        ElasticSanVolumeList IModelJsonSerializable<ElasticSanVolumeList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ElasticSanVolumeList>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticSanVolumeList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ElasticSanVolumeList>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ElasticSanVolumeList>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ElasticSanVolumeList IModelSerializable<ElasticSanVolumeList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ElasticSanVolumeList>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeElasticSanVolumeList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ElasticSanVolumeList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ElasticSanVolumeList"/> to convert. </param>
        public static implicit operator RequestContent(ElasticSanVolumeList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ElasticSanVolumeList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ElasticSanVolumeList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeElasticSanVolumeList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
