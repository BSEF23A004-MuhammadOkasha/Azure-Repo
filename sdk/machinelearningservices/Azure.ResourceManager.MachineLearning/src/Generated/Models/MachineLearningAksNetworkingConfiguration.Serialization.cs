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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningAksNetworkingConfiguration : IUtf8JsonSerializable, IJsonModel<MachineLearningAksNetworkingConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningAksNetworkingConfiguration>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MachineLearningAksNetworkingConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MachineLearningAksNetworkingConfiguration>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MachineLearningAksNetworkingConfiguration>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(ServiceCidr))
            {
                writer.WritePropertyName("serviceCidr"u8);
                writer.WriteStringValue(ServiceCidr);
            }
            if (Optional.IsDefined(DnsServiceIP))
            {
                writer.WritePropertyName("dnsServiceIP"u8);
                writer.WriteStringValue(DnsServiceIP);
            }
            if (Optional.IsDefined(DockerBridgeCidr))
            {
                writer.WritePropertyName("dockerBridgeCidr"u8);
                writer.WriteStringValue(DockerBridgeCidr);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        MachineLearningAksNetworkingConfiguration IJsonModel<MachineLearningAksNetworkingConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningAksNetworkingConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningAksNetworkingConfiguration(document.RootElement, options);
        }

        internal static MachineLearningAksNetworkingConfiguration DeserializeMachineLearningAksNetworkingConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> subnetId = default;
            Optional<string> serviceCidr = default;
            Optional<string> dnsServiceIP = default;
            Optional<string> dockerBridgeCidr = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceCidr"u8))
                {
                    serviceCidr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnsServiceIP"u8))
                {
                    dnsServiceIP = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dockerBridgeCidr"u8))
                {
                    dockerBridgeCidr = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningAksNetworkingConfiguration(subnetId.Value, serviceCidr.Value, dnsServiceIP.Value, dockerBridgeCidr.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningAksNetworkingConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningAksNetworkingConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MachineLearningAksNetworkingConfiguration IPersistableModel<MachineLearningAksNetworkingConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineLearningAksNetworkingConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMachineLearningAksNetworkingConfiguration(document.RootElement, options);
        }

        string IPersistableModel<MachineLearningAksNetworkingConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
