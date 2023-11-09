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

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class BareMetalMachineConfiguration : IUtf8JsonSerializable, IJsonModel<BareMetalMachineConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BareMetalMachineConfiguration>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<BareMetalMachineConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(BmcConnectionString))
                {
                    writer.WritePropertyName("bmcConnectionString"u8);
                    writer.WriteStringValue(BmcConnectionString);
                }
            }
            writer.WritePropertyName("bmcCredentials"u8);
            writer.WriteObjectValue(BmcCredentials);
            writer.WritePropertyName("bmcMacAddress"u8);
            writer.WriteStringValue(BmcMacAddress);
            writer.WritePropertyName("bootMacAddress"u8);
            writer.WriteStringValue(BootMacAddress);
            if (Optional.IsDefined(MachineDetails))
            {
                writer.WritePropertyName("machineDetails"u8);
                writer.WriteStringValue(MachineDetails);
            }
            if (Optional.IsDefined(MachineName))
            {
                writer.WritePropertyName("machineName"u8);
                writer.WriteStringValue(MachineName);
            }
            writer.WritePropertyName("rackSlot"u8);
            writer.WriteNumberValue(RackSlot);
            writer.WritePropertyName("serialNumber"u8);
            writer.WriteStringValue(SerialNumber);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        BareMetalMachineConfiguration IJsonModel<BareMetalMachineConfiguration>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BareMetalMachineConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBareMetalMachineConfiguration(document.RootElement, options);
        }

        internal static BareMetalMachineConfiguration DeserializeBareMetalMachineConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> bmcConnectionString = default;
            AdministrativeCredentials bmcCredentials = default;
            string bmcMacAddress = default;
            string bootMacAddress = default;
            Optional<string> machineDetails = default;
            Optional<string> machineName = default;
            long rackSlot = default;
            string serialNumber = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bmcConnectionString"u8))
                {
                    bmcConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bmcCredentials"u8))
                {
                    bmcCredentials = AdministrativeCredentials.DeserializeAdministrativeCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("bmcMacAddress"u8))
                {
                    bmcMacAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bootMacAddress"u8))
                {
                    bootMacAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineDetails"u8))
                {
                    machineDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineName"u8))
                {
                    machineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rackSlot"u8))
                {
                    rackSlot = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BareMetalMachineConfiguration(bmcConnectionString.Value, bmcCredentials, bmcMacAddress, bootMacAddress, machineDetails.Value, machineName.Value, rackSlot, serialNumber, serializedAdditionalRawData);
        }

        BinaryData IModel<BareMetalMachineConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BareMetalMachineConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BareMetalMachineConfiguration IModel<BareMetalMachineConfiguration>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BareMetalMachineConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBareMetalMachineConfiguration(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<BareMetalMachineConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
