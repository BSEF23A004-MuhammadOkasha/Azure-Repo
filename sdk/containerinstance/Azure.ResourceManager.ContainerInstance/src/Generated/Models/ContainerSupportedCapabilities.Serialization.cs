// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerSupportedCapabilities : IUtf8JsonSerializable, IJsonModel<ContainerSupportedCapabilities>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerSupportedCapabilities>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerSupportedCapabilities>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerSupportedCapabilities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerSupportedCapabilities)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && MaxMemoryInGB.HasValue)
            {
                writer.WritePropertyName("maxMemoryInGB"u8);
                writer.WriteNumberValue(MaxMemoryInGB.Value);
            }
            if (options.Format != "W" && MaxCpu.HasValue)
            {
                writer.WritePropertyName("maxCpu"u8);
                writer.WriteNumberValue(MaxCpu.Value);
            }
            if (options.Format != "W" && MaxGpuCount.HasValue)
            {
                writer.WritePropertyName("maxGpuCount"u8);
                writer.WriteNumberValue(MaxGpuCount.Value);
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

        ContainerSupportedCapabilities IJsonModel<ContainerSupportedCapabilities>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerSupportedCapabilities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerSupportedCapabilities)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerSupportedCapabilities(document.RootElement, options);
        }

        internal static ContainerSupportedCapabilities DeserializeContainerSupportedCapabilities(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<float> maxMemoryInGB = default;
            Optional<float> maxCpu = default;
            Optional<float> maxGpuCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxMemoryInGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxMemoryInGB = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("maxCpu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxCpu = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("maxGpuCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxGpuCount = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerSupportedCapabilities(Optional.ToNullable(maxMemoryInGB), Optional.ToNullable(maxCpu), Optional.ToNullable(maxGpuCount), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerSupportedCapabilities>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerSupportedCapabilities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerSupportedCapabilities)} does not support '{options.Format}' format.");
            }
        }

        ContainerSupportedCapabilities IPersistableModel<ContainerSupportedCapabilities>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerSupportedCapabilities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerSupportedCapabilities(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerSupportedCapabilities)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerSupportedCapabilities>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
