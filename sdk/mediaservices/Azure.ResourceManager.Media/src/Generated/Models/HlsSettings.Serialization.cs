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
    public partial class HlsSettings : IUtf8JsonSerializable, IJsonModel<HlsSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HlsSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HlsSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HlsSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HlsSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (IsDefault.HasValue)
            {
                writer.WritePropertyName("default"u8);
                writer.WriteBooleanValue(IsDefault.Value);
            }
            if (IsForced.HasValue)
            {
                writer.WritePropertyName("forced"u8);
                writer.WriteBooleanValue(IsForced.Value);
            }
            if (Characteristics != null)
            {
                writer.WritePropertyName("characteristics"u8);
                writer.WriteStringValue(Characteristics);
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

        HlsSettings IJsonModel<HlsSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HlsSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HlsSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHlsSettings(document.RootElement, options);
        }

        internal static HlsSettings DeserializeHlsSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> @default = default;
            Optional<bool> forced = default;
            Optional<string> characteristics = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("default"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @default = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("forced"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forced = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("characteristics"u8))
                {
                    characteristics = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HlsSettings(Optional.ToNullable(@default), Optional.ToNullable(forced), characteristics.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HlsSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HlsSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HlsSettings)} does not support '{options.Format}' format.");
            }
        }

        HlsSettings IPersistableModel<HlsSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HlsSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHlsSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HlsSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HlsSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
