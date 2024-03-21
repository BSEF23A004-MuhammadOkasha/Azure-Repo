// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class AppContainerResources : IUtf8JsonSerializable, IJsonModel<AppContainerResources>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppContainerResources>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppContainerResources>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppContainerResources>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppContainerResources)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Cpu))
            {
                writer.WritePropertyName("cpu"u8);
                writer.WriteNumberValue(Cpu.Value);
            }
            if (Optional.IsDefined(Memory))
            {
                writer.WritePropertyName("memory"u8);
                writer.WriteStringValue(Memory);
            }
            if (options.Format != "W" && Optional.IsDefined(EphemeralStorage))
            {
                writer.WritePropertyName("ephemeralStorage"u8);
                writer.WriteStringValue(EphemeralStorage);
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

        AppContainerResources IJsonModel<AppContainerResources>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppContainerResources>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppContainerResources)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppContainerResources(document.RootElement, options);
        }

        internal static AppContainerResources DeserializeAppContainerResources(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double? cpu = default;
            string memory = default;
            string ephemeralStorage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpu = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("memory"u8))
                {
                    memory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ephemeralStorage"u8))
                {
                    ephemeralStorage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppContainerResources(cpu, memory, ephemeralStorage, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppContainerResources>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppContainerResources>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppContainerResources)} does not support writing '{options.Format}' format.");
            }
        }

        AppContainerResources IPersistableModel<AppContainerResources>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppContainerResources>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppContainerResources(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppContainerResources)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppContainerResources>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
