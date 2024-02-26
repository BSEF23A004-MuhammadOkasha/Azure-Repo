// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterSecurityProfileDefender : IUtf8JsonSerializable, IJsonModel<ManagedClusterSecurityProfileDefender>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterSecurityProfileDefender>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterSecurityProfileDefender>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfileDefender>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterSecurityProfileDefender)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (LogAnalyticsWorkspaceResourceId != null)
            {
                writer.WritePropertyName("logAnalyticsWorkspaceResourceId"u8);
                writer.WriteStringValue(LogAnalyticsWorkspaceResourceId);
            }
            if (SecurityMonitoring != null)
            {
                writer.WritePropertyName("securityMonitoring"u8);
                writer.WriteObjectValue(SecurityMonitoring);
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

        ManagedClusterSecurityProfileDefender IJsonModel<ManagedClusterSecurityProfileDefender>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfileDefender>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterSecurityProfileDefender)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterSecurityProfileDefender(document.RootElement, options);
        }

        internal static ManagedClusterSecurityProfileDefender DeserializeManagedClusterSecurityProfileDefender(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> logAnalyticsWorkspaceResourceId = default;
            Optional<ManagedClusterSecurityProfileDefenderSecurityMonitoring> securityMonitoring = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logAnalyticsWorkspaceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logAnalyticsWorkspaceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("securityMonitoring"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityMonitoring = ManagedClusterSecurityProfileDefenderSecurityMonitoring.DeserializeManagedClusterSecurityProfileDefenderSecurityMonitoring(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterSecurityProfileDefender(logAnalyticsWorkspaceResourceId.Value, securityMonitoring.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterSecurityProfileDefender>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfileDefender>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterSecurityProfileDefender)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterSecurityProfileDefender IPersistableModel<ManagedClusterSecurityProfileDefender>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfileDefender>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterSecurityProfileDefender(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterSecurityProfileDefender)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterSecurityProfileDefender>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
