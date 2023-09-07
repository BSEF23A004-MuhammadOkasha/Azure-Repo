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
    public partial class SelectVideoTrackById : IUtf8JsonSerializable, IModelJsonSerializable<SelectVideoTrackById>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SelectVideoTrackById>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SelectVideoTrackById>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SelectVideoTrackById>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("trackId"u8);
            writer.WriteNumberValue(TrackId);
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

        internal static SelectVideoTrackById DeserializeSelectVideoTrackById(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long trackId = default;
            string odataType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trackId"u8))
                {
                    trackId = property.Value.GetInt64();
                    continue;
                }
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
            return new SelectVideoTrackById(odataType, trackId, serializedAdditionalRawData);
        }

        SelectVideoTrackById IModelJsonSerializable<SelectVideoTrackById>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SelectVideoTrackById>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSelectVideoTrackById(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SelectVideoTrackById>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SelectVideoTrackById>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SelectVideoTrackById IModelSerializable<SelectVideoTrackById>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SelectVideoTrackById>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSelectVideoTrackById(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SelectVideoTrackById"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SelectVideoTrackById"/> to convert. </param>
        public static implicit operator RequestContent(SelectVideoTrackById model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SelectVideoTrackById"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SelectVideoTrackById(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSelectVideoTrackById(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
