// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MediaLiveEventConnectionRejectedEventDataConverter))]
    public partial class MediaLiveEventConnectionRejectedEventData : IUtf8JsonSerializable, IModelJsonSerializable<MediaLiveEventConnectionRejectedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaLiveEventConnectionRejectedEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaLiveEventConnectionRejectedEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaLiveEventConnectionRejectedEventData>(this, options.Format);

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

        internal static MediaLiveEventConnectionRejectedEventData DeserializeMediaLiveEventConnectionRejectedEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ingestUrl = default;
            Optional<string> streamId = default;
            Optional<string> encoderIp = default;
            Optional<string> encoderPort = default;
            Optional<string> resultCode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ingestUrl"u8))
                {
                    ingestUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streamId"u8))
                {
                    streamId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encoderIp"u8))
                {
                    encoderIp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encoderPort"u8))
                {
                    encoderPort = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultCode"u8))
                {
                    resultCode = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MediaLiveEventConnectionRejectedEventData(ingestUrl.Value, streamId.Value, encoderIp.Value, encoderPort.Value, resultCode.Value, rawData);
        }

        MediaLiveEventConnectionRejectedEventData IModelJsonSerializable<MediaLiveEventConnectionRejectedEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaLiveEventConnectionRejectedEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaLiveEventConnectionRejectedEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaLiveEventConnectionRejectedEventData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaLiveEventConnectionRejectedEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaLiveEventConnectionRejectedEventData IModelSerializable<MediaLiveEventConnectionRejectedEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaLiveEventConnectionRejectedEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaLiveEventConnectionRejectedEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MediaLiveEventConnectionRejectedEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MediaLiveEventConnectionRejectedEventData"/> to convert. </param>
        public static implicit operator RequestContent(MediaLiveEventConnectionRejectedEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MediaLiveEventConnectionRejectedEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MediaLiveEventConnectionRejectedEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaLiveEventConnectionRejectedEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class MediaLiveEventConnectionRejectedEventDataConverter : JsonConverter<MediaLiveEventConnectionRejectedEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaLiveEventConnectionRejectedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MediaLiveEventConnectionRejectedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaLiveEventConnectionRejectedEventData(document.RootElement);
            }
        }
    }
}
