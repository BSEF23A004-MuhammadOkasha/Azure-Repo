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

namespace Azure.ResourceManager.Media.Models
{
    public partial class VideoTrackDescriptor : IUtf8JsonSerializable, IModelJsonSerializable<VideoTrackDescriptor>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VideoTrackDescriptor>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VideoTrackDescriptor>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VideoTrackDescriptor>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        internal static VideoTrackDescriptor DeserializeVideoTrackDescriptor(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.SelectVideoTrackByAttribute": return SelectVideoTrackByAttribute.DeserializeSelectVideoTrackByAttribute(element);
                    case "#Microsoft.Media.SelectVideoTrackById": return SelectVideoTrackById.DeserializeSelectVideoTrackById(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string odataType = "#Microsoft.Media.VideoTrackDescriptor";
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VideoTrackDescriptor(odataType, serializedAdditionalRawData);
        }

        VideoTrackDescriptor IModelJsonSerializable<VideoTrackDescriptor>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VideoTrackDescriptor>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVideoTrackDescriptor(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VideoTrackDescriptor>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VideoTrackDescriptor>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VideoTrackDescriptor IModelSerializable<VideoTrackDescriptor>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VideoTrackDescriptor>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVideoTrackDescriptor(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VideoTrackDescriptor"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VideoTrackDescriptor"/> to convert. </param>
        public static implicit operator RequestContent(VideoTrackDescriptor model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VideoTrackDescriptor"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VideoTrackDescriptor(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVideoTrackDescriptor(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
