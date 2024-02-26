// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformSkuCapacity : IUtf8JsonSerializable, IJsonModel<AppPlatformSkuCapacity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformSkuCapacity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformSkuCapacity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformSkuCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformSkuCapacity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("minimum"u8);
            writer.WriteNumberValue(Minimum);
            if (Maximum.HasValue)
            {
                writer.WritePropertyName("maximum"u8);
                writer.WriteNumberValue(Maximum.Value);
            }
            if (Default.HasValue)
            {
                writer.WritePropertyName("default"u8);
                writer.WriteNumberValue(Default.Value);
            }
            if (ScaleType.HasValue)
            {
                writer.WritePropertyName("scaleType"u8);
                writer.WriteStringValue(ScaleType.Value.ToString());
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

        AppPlatformSkuCapacity IJsonModel<AppPlatformSkuCapacity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformSkuCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformSkuCapacity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformSkuCapacity(document.RootElement, options);
        }

        internal static AppPlatformSkuCapacity DeserializeAppPlatformSkuCapacity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int minimum = default;
            Optional<int> maximum = default;
            Optional<int> @default = default;
            Optional<AppPlatformSkuScaleType> scaleType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minimum"u8))
                {
                    minimum = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximum = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("default"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @default = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scaleType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleType = new AppPlatformSkuScaleType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformSkuCapacity(minimum, Optional.ToNullable(maximum), Optional.ToNullable(@default), Optional.ToNullable(scaleType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformSkuCapacity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformSkuCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformSkuCapacity)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformSkuCapacity IPersistableModel<AppPlatformSkuCapacity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformSkuCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformSkuCapacity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformSkuCapacity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformSkuCapacity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
