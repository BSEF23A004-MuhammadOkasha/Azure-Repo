// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class CaptureDescription : IUtf8JsonSerializable, IJsonModel<CaptureDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CaptureDescription>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CaptureDescription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CaptureDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CaptureDescription)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Enabled.HasValue)
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Encoding.HasValue)
            {
                writer.WritePropertyName("encoding"u8);
                writer.WriteStringValue(Encoding.Value.ToSerialString());
            }
            if (IntervalInSeconds.HasValue)
            {
                writer.WritePropertyName("intervalInSeconds"u8);
                writer.WriteNumberValue(IntervalInSeconds.Value);
            }
            if (SizeLimitInBytes.HasValue)
            {
                writer.WritePropertyName("sizeLimitInBytes"u8);
                writer.WriteNumberValue(SizeLimitInBytes.Value);
            }
            if (Destination != null)
            {
                writer.WritePropertyName("destination"u8);
                writer.WriteObjectValue(Destination);
            }
            if (SkipEmptyArchives.HasValue)
            {
                writer.WritePropertyName("skipEmptyArchives"u8);
                writer.WriteBooleanValue(SkipEmptyArchives.Value);
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

        CaptureDescription IJsonModel<CaptureDescription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CaptureDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CaptureDescription)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCaptureDescription(document.RootElement, options);
        }

        internal static CaptureDescription DeserializeCaptureDescription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<EncodingCaptureDescription> encoding = default;
            Optional<int> intervalInSeconds = default;
            Optional<int> sizeLimitInBytes = default;
            Optional<EventHubDestination> destination = default;
            Optional<bool> skipEmptyArchives = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encoding"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encoding = property.Value.GetString().ToEncodingCaptureDescription();
                    continue;
                }
                if (property.NameEquals("intervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    intervalInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sizeLimitInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sizeLimitInBytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("destination"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destination = EventHubDestination.DeserializeEventHubDestination(property.Value, options);
                    continue;
                }
                if (property.NameEquals("skipEmptyArchives"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipEmptyArchives = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CaptureDescription(Optional.ToNullable(enabled), Optional.ToNullable(encoding), Optional.ToNullable(intervalInSeconds), Optional.ToNullable(sizeLimitInBytes), destination.Value, Optional.ToNullable(skipEmptyArchives), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CaptureDescription>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CaptureDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CaptureDescription)} does not support '{options.Format}' format.");
            }
        }

        CaptureDescription IPersistableModel<CaptureDescription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CaptureDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCaptureDescription(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CaptureDescription)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CaptureDescription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
