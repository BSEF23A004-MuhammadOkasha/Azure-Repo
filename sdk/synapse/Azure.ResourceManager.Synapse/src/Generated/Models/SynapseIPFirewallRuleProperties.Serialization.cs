// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseIPFirewallRuleProperties : IUtf8JsonSerializable, IJsonModel<SynapseIPFirewallRuleProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseIPFirewallRuleProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SynapseIPFirewallRuleProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SynapseIPFirewallRuleProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SynapseIPFirewallRuleProperties>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EndIPAddress))
            {
                writer.WritePropertyName("endIpAddress"u8);
                writer.WriteStringValue(EndIPAddress.ToString());
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (Optional.IsDefined(StartIPAddress))
            {
                writer.WritePropertyName("startIpAddress"u8);
                writer.WriteStringValue(StartIPAddress.ToString());
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

        SynapseIPFirewallRuleProperties IJsonModel<SynapseIPFirewallRuleProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseIPFirewallRuleProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIPFirewallRuleProperties(document.RootElement, options);
        }

        internal static SynapseIPFirewallRuleProperties DeserializeSynapseIPFirewallRuleProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IPAddress> endIPAddress = default;
            Optional<SynapseProvisioningState> provisioningState = default;
            Optional<IPAddress> startIPAddress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new SynapseProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseIPFirewallRuleProperties(endIPAddress.Value, Optional.ToNullable(provisioningState), startIPAddress.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseIPFirewallRuleProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseIPFirewallRuleProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SynapseIPFirewallRuleProperties IPersistableModel<SynapseIPFirewallRuleProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SynapseIPFirewallRuleProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSynapseIPFirewallRuleProperties(document.RootElement, options);
        }

        string IPersistableModel<SynapseIPFirewallRuleProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
