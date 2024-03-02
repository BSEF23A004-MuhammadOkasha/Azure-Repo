// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetUpdateOSProfile : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetUpdateOSProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetUpdateOSProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineScaleSetUpdateOSProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetUpdateOSProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetUpdateOSProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (CustomData != null)
            {
                writer.WritePropertyName("customData"u8);
                writer.WriteStringValue(CustomData);
            }
            if (WindowsConfiguration != null)
            {
                writer.WritePropertyName("windowsConfiguration"u8);
                writer.WriteObjectValue(WindowsConfiguration);
            }
            if (LinuxConfiguration != null)
            {
                writer.WritePropertyName("linuxConfiguration"u8);
                writer.WriteObjectValue(LinuxConfiguration);
            }
            if (!(Secrets is ChangeTrackingList<VaultSecretGroup> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("secrets"u8);
                writer.WriteStartArray();
                foreach (var item in Secrets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        VirtualMachineScaleSetUpdateOSProfile IJsonModel<VirtualMachineScaleSetUpdateOSProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetUpdateOSProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetUpdateOSProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetUpdateOSProfile(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetUpdateOSProfile DeserializeVirtualMachineScaleSetUpdateOSProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string customData = default;
            WindowsConfiguration windowsConfiguration = default;
            LinuxConfiguration linuxConfiguration = default;
            IList<VaultSecretGroup> secrets = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customData"u8))
                {
                    customData = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("windowsConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsConfiguration = WindowsConfiguration.DeserializeWindowsConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("linuxConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linuxConfiguration = LinuxConfiguration.DeserializeLinuxConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("secrets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VaultSecretGroup> array = new List<VaultSecretGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VaultSecretGroup.DeserializeVaultSecretGroup(item, options));
                    }
                    secrets = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineScaleSetUpdateOSProfile(customData, windowsConfiguration, linuxConfiguration, secrets ?? new ChangeTrackingList<VaultSecretGroup>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineScaleSetUpdateOSProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetUpdateOSProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetUpdateOSProfile)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetUpdateOSProfile IPersistableModel<VirtualMachineScaleSetUpdateOSProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetUpdateOSProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetUpdateOSProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetUpdateOSProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetUpdateOSProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
