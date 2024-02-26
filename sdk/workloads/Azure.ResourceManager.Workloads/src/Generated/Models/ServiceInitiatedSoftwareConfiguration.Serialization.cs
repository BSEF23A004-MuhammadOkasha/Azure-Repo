// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class ServiceInitiatedSoftwareConfiguration : IUtf8JsonSerializable, IJsonModel<ServiceInitiatedSoftwareConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceInitiatedSoftwareConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceInitiatedSoftwareConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceInitiatedSoftwareConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceInitiatedSoftwareConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("bomUrl"u8);
            writer.WriteStringValue(BomUri.AbsoluteUri);
            writer.WritePropertyName("softwareVersion"u8);
            writer.WriteStringValue(SoftwareVersion);
            writer.WritePropertyName("sapBitsStorageAccountId"u8);
            writer.WriteStringValue(SapBitsStorageAccountId);
            writer.WritePropertyName("sapFqdn"u8);
            writer.WriteStringValue(SapFqdn);
            writer.WritePropertyName("sshPrivateKey"u8);
            writer.WriteStringValue(SshPrivateKey);
            if (HighAvailabilitySoftwareConfiguration != null)
            {
                writer.WritePropertyName("highAvailabilitySoftwareConfiguration"u8);
                writer.WriteObjectValue(HighAvailabilitySoftwareConfiguration);
            }
            writer.WritePropertyName("softwareInstallationType"u8);
            writer.WriteStringValue(SoftwareInstallationType.ToString());
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

        ServiceInitiatedSoftwareConfiguration IJsonModel<ServiceInitiatedSoftwareConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceInitiatedSoftwareConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceInitiatedSoftwareConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceInitiatedSoftwareConfiguration(document.RootElement, options);
        }

        internal static ServiceInitiatedSoftwareConfiguration DeserializeServiceInitiatedSoftwareConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri bomUrl = default;
            string softwareVersion = default;
            string sapBitsStorageAccountId = default;
            string sapFqdn = default;
            string sshPrivateKey = default;
            Optional<HighAvailabilitySoftwareConfiguration> highAvailabilitySoftwareConfiguration = default;
            SapSoftwareInstallationType softwareInstallationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bomUrl"u8))
                {
                    bomUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("softwareVersion"u8))
                {
                    softwareVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sapBitsStorageAccountId"u8))
                {
                    sapBitsStorageAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sapFqdn"u8))
                {
                    sapFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sshPrivateKey"u8))
                {
                    sshPrivateKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("highAvailabilitySoftwareConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    highAvailabilitySoftwareConfiguration = HighAvailabilitySoftwareConfiguration.DeserializeHighAvailabilitySoftwareConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("softwareInstallationType"u8))
                {
                    softwareInstallationType = new SapSoftwareInstallationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceInitiatedSoftwareConfiguration(softwareInstallationType, serializedAdditionalRawData, bomUrl, softwareVersion, sapBitsStorageAccountId, sapFqdn, sshPrivateKey, highAvailabilitySoftwareConfiguration.Value);
        }

        BinaryData IPersistableModel<ServiceInitiatedSoftwareConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceInitiatedSoftwareConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceInitiatedSoftwareConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ServiceInitiatedSoftwareConfiguration IPersistableModel<ServiceInitiatedSoftwareConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceInitiatedSoftwareConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceInitiatedSoftwareConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceInitiatedSoftwareConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceInitiatedSoftwareConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
