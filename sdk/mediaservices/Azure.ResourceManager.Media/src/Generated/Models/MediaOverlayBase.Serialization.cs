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
    public partial class MediaOverlayBase : IUtf8JsonSerializable, IModelJsonSerializable<MediaOverlayBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MediaOverlayBase>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MediaOverlayBase>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaOverlayBase>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("inputLabel"u8);
            writer.WriteStringValue(InputLabel);
            if (Optional.IsDefined(Start))
            {
                writer.WritePropertyName("start"u8);
                writer.WriteStringValue(Start.Value, "P");
            }
            if (Optional.IsDefined(End))
            {
                writer.WritePropertyName("end"u8);
                writer.WriteStringValue(End.Value, "P");
            }
            if (Optional.IsDefined(FadeInDuration))
            {
                writer.WritePropertyName("fadeInDuration"u8);
                writer.WriteStringValue(FadeInDuration.Value, "P");
            }
            if (Optional.IsDefined(FadeOutDuration))
            {
                writer.WritePropertyName("fadeOutDuration"u8);
                writer.WriteStringValue(FadeOutDuration.Value, "P");
            }
            if (Optional.IsDefined(AudioGainLevel))
            {
                writer.WritePropertyName("audioGainLevel"u8);
                writer.WriteNumberValue(AudioGainLevel.Value);
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

        internal static MediaOverlayBase DeserializeMediaOverlayBase(JsonElement element, ModelSerializerOptions options = default)
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
                    case "#Microsoft.Media.AudioOverlay": return AudioOverlay.DeserializeAudioOverlay(element);
                    case "#Microsoft.Media.VideoOverlay": return VideoOverlay.DeserializeVideoOverlay(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string odataType = default;
            string inputLabel = default;
            Optional<TimeSpan> start = default;
            Optional<TimeSpan> end = default;
            Optional<TimeSpan> fadeInDuration = default;
            Optional<TimeSpan> fadeOutDuration = default;
            Optional<double> audioGainLevel = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputLabel"u8))
                {
                    inputLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    start = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    end = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("fadeInDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fadeInDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("fadeOutDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fadeOutDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("audioGainLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    audioGainLevel = property.Value.GetDouble();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownOverlay(odataType, inputLabel, Optional.ToNullable(start), Optional.ToNullable(end), Optional.ToNullable(fadeInDuration), Optional.ToNullable(fadeOutDuration), Optional.ToNullable(audioGainLevel), serializedAdditionalRawData);
        }

        MediaOverlayBase IModelJsonSerializable<MediaOverlayBase>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaOverlayBase>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaOverlayBase(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MediaOverlayBase>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaOverlayBase>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MediaOverlayBase IModelSerializable<MediaOverlayBase>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MediaOverlayBase>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMediaOverlayBase(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MediaOverlayBase"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MediaOverlayBase"/> to convert. </param>
        public static implicit operator RequestContent(MediaOverlayBase model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MediaOverlayBase"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MediaOverlayBase(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMediaOverlayBase(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
