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
    public partial class ContainerAppScaleRule : IUtf8JsonSerializable, IJsonModel<ContainerAppScaleRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppScaleRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppScaleRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScaleRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppScaleRule)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AzureQueue))
            {
                writer.WritePropertyName("azureQueue"u8);
                writer.WriteObjectValue(AzureQueue);
            }
            if (Optional.IsDefined(Custom))
            {
                writer.WritePropertyName("custom"u8);
                writer.WriteObjectValue(Custom);
            }
            if (Optional.IsDefined(Http))
            {
                writer.WritePropertyName("http"u8);
                writer.WriteObjectValue(Http);
            }
            if (Optional.IsDefined(Tcp))
            {
                writer.WritePropertyName("tcp"u8);
                writer.WriteObjectValue(Tcp);
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

        ContainerAppScaleRule IJsonModel<ContainerAppScaleRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScaleRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppScaleRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppScaleRule(document.RootElement, options);
        }

        internal static ContainerAppScaleRule DeserializeContainerAppScaleRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            ContainerAppQueueScaleRule azureQueue = default;
            ContainerAppCustomScaleRule custom = default;
            ContainerAppHttpScaleRule http = default;
            ContainerAppTcpScaleRule tcp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureQueue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureQueue = ContainerAppQueueScaleRule.DeserializeContainerAppQueueScaleRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("custom"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    custom = ContainerAppCustomScaleRule.DeserializeContainerAppCustomScaleRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("http"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    http = ContainerAppHttpScaleRule.DeserializeContainerAppHttpScaleRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tcp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tcp = ContainerAppTcpScaleRule.DeserializeContainerAppTcpScaleRule(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppScaleRule(
                name,
                azureQueue,
                custom,
                http,
                tcp,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppScaleRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScaleRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppScaleRule)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppScaleRule IPersistableModel<ContainerAppScaleRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppScaleRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppScaleRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppScaleRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppScaleRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
