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
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class MediaPrivateEndpointConnectionListResult : IUtf8JsonSerializable, IModelJsonSerializable<MediaPrivateEndpointConnectionListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaPrivateEndpointConnectionListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaPrivateEndpointConnectionListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaPrivateEndpointConnectionListResult>(this, options.Format);

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
                        ((IModelJsonSerializable<MediaServicesPrivateEndpointConnectionData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static MediaPrivateEndpointConnectionListResult DeserializeMediaPrivateEndpointConnectionListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MediaServicesPrivateEndpointConnectionData>> value = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaServicesPrivateEndpointConnectionData> array = new List<MediaServicesPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaServicesPrivateEndpointConnectionData.DeserializeMediaServicesPrivateEndpointConnectionData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaPrivateEndpointConnectionListResult(Optional.ToList(value), serializedAdditionalRawData);
        }

        MediaPrivateEndpointConnectionListResult IModelJsonSerializable<MediaPrivateEndpointConnectionListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaPrivateEndpointConnectionListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaPrivateEndpointConnectionListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaPrivateEndpointConnectionListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaPrivateEndpointConnectionListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaPrivateEndpointConnectionListResult IModelSerializable<MediaPrivateEndpointConnectionListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaPrivateEndpointConnectionListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaPrivateEndpointConnectionListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MediaPrivateEndpointConnectionListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MediaPrivateEndpointConnectionListResult"/> to convert. </param>
        public static implicit operator RequestContent(MediaPrivateEndpointConnectionListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MediaPrivateEndpointConnectionListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MediaPrivateEndpointConnectionListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaPrivateEndpointConnectionListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
