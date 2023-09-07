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

namespace Azure.ResourceManager.IotHub.Models
{
    internal partial class IotHubPropertiesDeviceStreams : IUtf8JsonSerializable, IModelJsonSerializable<IotHubPropertiesDeviceStreams>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IotHubPropertiesDeviceStreams>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IotHubPropertiesDeviceStreams>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubPropertiesDeviceStreams>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(StreamingEndpoints))
            {
                writer.WritePropertyName("streamingEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in StreamingEndpoints)
                {
                    writer.WriteStringValue(item);
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

        internal static IotHubPropertiesDeviceStreams DeserializeIotHubPropertiesDeviceStreams(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> streamingEndpoints = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streamingEndpoints"u8))
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
                    streamingEndpoints = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IotHubPropertiesDeviceStreams(Optional.ToList(streamingEndpoints), serializedAdditionalRawData);
        }

        IotHubPropertiesDeviceStreams IModelJsonSerializable<IotHubPropertiesDeviceStreams>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubPropertiesDeviceStreams>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubPropertiesDeviceStreams(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IotHubPropertiesDeviceStreams>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubPropertiesDeviceStreams>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IotHubPropertiesDeviceStreams IModelSerializable<IotHubPropertiesDeviceStreams>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotHubPropertiesDeviceStreams>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIotHubPropertiesDeviceStreams(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IotHubPropertiesDeviceStreams"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IotHubPropertiesDeviceStreams"/> to convert. </param>
        public static implicit operator RequestContent(IotHubPropertiesDeviceStreams model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IotHubPropertiesDeviceStreams"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IotHubPropertiesDeviceStreams(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIotHubPropertiesDeviceStreams(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
