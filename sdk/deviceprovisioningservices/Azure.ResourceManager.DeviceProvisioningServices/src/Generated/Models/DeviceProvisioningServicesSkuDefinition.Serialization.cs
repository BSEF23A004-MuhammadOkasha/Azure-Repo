// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    public partial class DeviceProvisioningServicesSkuDefinition : IUtf8JsonSerializable, IJsonModel<DeviceProvisioningServicesSkuDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeviceProvisioningServicesSkuDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeviceProvisioningServicesSkuDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceProvisioningServicesSkuDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DeviceProvisioningServicesSkuDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name.Value.ToString());
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

        DeviceProvisioningServicesSkuDefinition IJsonModel<DeviceProvisioningServicesSkuDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceProvisioningServicesSkuDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DeviceProvisioningServicesSkuDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceProvisioningServicesSkuDefinition(document.RootElement, options);
        }

        internal static DeviceProvisioningServicesSkuDefinition DeserializeDeviceProvisioningServicesSkuDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DeviceProvisioningServicesSku> name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = new DeviceProvisioningServicesSku(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DeviceProvisioningServicesSkuDefinition(Optional.ToNullable(name), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeviceProvisioningServicesSkuDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceProvisioningServicesSkuDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DeviceProvisioningServicesSkuDefinition)} does not support '{options.Format}' format.");
            }
        }

        DeviceProvisioningServicesSkuDefinition IPersistableModel<DeviceProvisioningServicesSkuDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceProvisioningServicesSkuDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeviceProvisioningServicesSkuDefinition(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DeviceProvisioningServicesSkuDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeviceProvisioningServicesSkuDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
