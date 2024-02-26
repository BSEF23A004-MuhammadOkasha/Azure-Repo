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
    public partial class SapInstallWithoutOSConfigSoftwareConfiguration : IUtf8JsonSerializable, IJsonModel<SapInstallWithoutOSConfigSoftwareConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapInstallWithoutOSConfigSoftwareConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SapInstallWithoutOSConfigSoftwareConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapInstallWithoutOSConfigSoftwareConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapInstallWithoutOSConfigSoftwareConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("bomUrl"u8);
            writer.WriteStringValue(BomUri.AbsoluteUri);
            writer.WritePropertyName("sapBitsStorageAccountId"u8);
            writer.WriteStringValue(SapBitsStorageAccountId);
            writer.WritePropertyName("softwareVersion"u8);
            writer.WriteStringValue(SoftwareVersion);
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

        SapInstallWithoutOSConfigSoftwareConfiguration IJsonModel<SapInstallWithoutOSConfigSoftwareConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapInstallWithoutOSConfigSoftwareConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapInstallWithoutOSConfigSoftwareConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapInstallWithoutOSConfigSoftwareConfiguration(document.RootElement, options);
        }

        internal static SapInstallWithoutOSConfigSoftwareConfiguration DeserializeSapInstallWithoutOSConfigSoftwareConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri bomUrl = default;
            string sapBitsStorageAccountId = default;
            string softwareVersion = default;
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
                if (property.NameEquals("sapBitsStorageAccountId"u8))
                {
                    sapBitsStorageAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("softwareVersion"u8))
                {
                    softwareVersion = property.Value.GetString();
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
            return new SapInstallWithoutOSConfigSoftwareConfiguration(softwareInstallationType, serializedAdditionalRawData, bomUrl, sapBitsStorageAccountId, softwareVersion, highAvailabilitySoftwareConfiguration.Value);
        }

        BinaryData IPersistableModel<SapInstallWithoutOSConfigSoftwareConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapInstallWithoutOSConfigSoftwareConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SapInstallWithoutOSConfigSoftwareConfiguration)} does not support '{options.Format}' format.");
            }
        }

        SapInstallWithoutOSConfigSoftwareConfiguration IPersistableModel<SapInstallWithoutOSConfigSoftwareConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapInstallWithoutOSConfigSoftwareConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSapInstallWithoutOSConfigSoftwareConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SapInstallWithoutOSConfigSoftwareConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapInstallWithoutOSConfigSoftwareConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
