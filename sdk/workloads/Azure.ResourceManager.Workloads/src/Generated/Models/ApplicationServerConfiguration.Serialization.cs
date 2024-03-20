// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Workloads;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class ApplicationServerConfiguration : IUtf8JsonSerializable, IJsonModel<ApplicationServerConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationServerConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationServerConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationServerConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationServerConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("subnetId"u8);
            writer.WriteStringValue(SubnetId);
            writer.WritePropertyName("virtualMachineConfiguration"u8);
            writer.WriteObjectValue(VirtualMachineConfiguration);
            writer.WritePropertyName("instanceCount"u8);
            writer.WriteNumberValue(InstanceCount);
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

        ApplicationServerConfiguration IJsonModel<ApplicationServerConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationServerConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationServerConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationServerConfiguration(document.RootElement, options);
        }

        internal static ApplicationServerConfiguration DeserializeApplicationServerConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier subnetId = default;
            SapVirtualMachineConfiguration virtualMachineConfiguration = default;
            long instanceCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnetId"u8))
                {
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualMachineConfiguration"u8))
                {
                    virtualMachineConfiguration = SapVirtualMachineConfiguration.DeserializeSapVirtualMachineConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("instanceCount"u8))
                {
                    instanceCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationServerConfiguration(subnetId, virtualMachineConfiguration, instanceCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationServerConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationServerConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationServerConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ApplicationServerConfiguration IPersistableModel<ApplicationServerConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationServerConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationServerConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationServerConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationServerConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
