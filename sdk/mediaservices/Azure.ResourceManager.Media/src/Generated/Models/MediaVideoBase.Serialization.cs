// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaVideoBase : IUtf8JsonSerializable, IJsonModel<MediaVideoBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaVideoBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MediaVideoBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaVideoBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaVideoBase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (KeyFrameInterval.HasValue)
            {
                writer.WritePropertyName("keyFrameInterval"u8);
                writer.WriteStringValue(KeyFrameInterval.Value, "P");
            }
            if (StretchMode.HasValue)
            {
                writer.WritePropertyName("stretchMode"u8);
                writer.WriteStringValue(StretchMode.Value.ToString());
            }
            if (SyncMode.HasValue)
            {
                writer.WritePropertyName("syncMode"u8);
                writer.WriteStringValue(SyncMode.Value.ToString());
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Label != null)
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MediaVideoBase IJsonModel<MediaVideoBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaVideoBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaVideoBase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaVideoBase(document.RootElement, options);
        }

        internal static MediaVideoBase DeserializeMediaVideoBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.H264Video": return H264Video.DeserializeH264Video(element, options);
                    case "#Microsoft.Media.H265Video": return H265Video.DeserializeH265Video(element, options);
                    case "#Microsoft.Media.Image": return MediaImageBase.DeserializeMediaImageBase(element, options);
                    case "#Microsoft.Media.JpgImage": return JpgImage.DeserializeJpgImage(element, options);
                    case "#Microsoft.Media.PngImage": return PngImage.DeserializePngImage(element, options);
                }
            }
            TimeSpan? keyFrameInterval = default;
            InputVideoStretchMode? stretchMode = default;
            VideoSyncMode? syncMode = default;
            string odataType = "#Microsoft.Media.Video";
            string label = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyFrameInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyFrameInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("stretchMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stretchMode = new InputVideoStretchMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("syncMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    syncMode = new VideoSyncMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MediaVideoBase(
                odataType,
                label,
                serializedAdditionalRawData,
                keyFrameInterval,
                stretchMode,
                syncMode);
        }

        BinaryData IPersistableModel<MediaVideoBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaVideoBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaVideoBase)} does not support '{options.Format}' format.");
            }
        }

        MediaVideoBase IPersistableModel<MediaVideoBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaVideoBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaVideoBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaVideoBase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaVideoBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
