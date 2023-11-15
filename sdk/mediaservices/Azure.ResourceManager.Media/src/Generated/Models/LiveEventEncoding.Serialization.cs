// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class LiveEventEncoding : IUtf8JsonSerializable, IJsonModel<LiveEventEncoding>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LiveEventEncoding>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<LiveEventEncoding>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<LiveEventEncoding>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<LiveEventEncoding>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EncodingType))
            {
                writer.WritePropertyName("encodingType"u8);
                writer.WriteStringValue(EncodingType.Value.ToString());
            }
            if (Optional.IsDefined(PresetName))
            {
                writer.WritePropertyName("presetName"u8);
                writer.WriteStringValue(PresetName);
            }
            if (Optional.IsDefined(StretchMode))
            {
                if (StretchMode != null)
                {
                    writer.WritePropertyName("stretchMode"u8);
                    writer.WriteStringValue(StretchMode.Value.ToString());
                }
                else
                {
                    writer.WriteNull("stretchMode");
                }
            }
            if (Optional.IsDefined(KeyFrameInterval))
            {
                if (KeyFrameInterval != null)
                {
                    writer.WritePropertyName("keyFrameInterval"u8);
                    writer.WriteStringValue(KeyFrameInterval.Value, "P");
                }
                else
                {
                    writer.WriteNull("keyFrameInterval");
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        LiveEventEncoding IJsonModel<LiveEventEncoding>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LiveEventEncoding)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLiveEventEncoding(document.RootElement, options);
        }

        internal static LiveEventEncoding DeserializeLiveEventEncoding(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LiveEventEncodingType> encodingType = default;
            Optional<string> presetName = default;
            Optional<InputVideoStretchMode?> stretchMode = default;
            Optional<TimeSpan?> keyFrameInterval = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encodingType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encodingType = new LiveEventEncodingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("presetName"u8))
                {
                    presetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stretchMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stretchMode = null;
                        continue;
                    }
                    stretchMode = new InputVideoStretchMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyFrameInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyFrameInterval = null;
                        continue;
                    }
                    keyFrameInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LiveEventEncoding(Optional.ToNullable(encodingType), presetName.Value, Optional.ToNullable(stretchMode), Optional.ToNullable(keyFrameInterval), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LiveEventEncoding>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LiveEventEncoding)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        LiveEventEncoding IPersistableModel<LiveEventEncoding>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LiveEventEncoding)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeLiveEventEncoding(document.RootElement, options);
        }

        string IPersistableModel<LiveEventEncoding>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
