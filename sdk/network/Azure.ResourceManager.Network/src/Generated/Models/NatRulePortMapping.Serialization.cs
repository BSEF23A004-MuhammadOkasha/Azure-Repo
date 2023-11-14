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

namespace Azure.ResourceManager.Network.Models
{
    public partial class NatRulePortMapping : IUtf8JsonSerializable, IJsonModel<NatRulePortMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NatRulePortMapping>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<NatRulePortMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<NatRulePortMapping>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<NatRulePortMapping>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InboundNatRuleName))
            {
                writer.WritePropertyName("inboundNatRuleName"u8);
                writer.WriteStringValue(InboundNatRuleName);
            }
            if (Optional.IsDefined(FrontendPort))
            {
                writer.WritePropertyName("frontendPort"u8);
                writer.WriteNumberValue(FrontendPort.Value);
            }
            if (Optional.IsDefined(BackendPort))
            {
                writer.WritePropertyName("backendPort"u8);
                writer.WriteNumberValue(BackendPort.Value);
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

        NatRulePortMapping IJsonModel<NatRulePortMapping>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NatRulePortMapping)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNatRulePortMapping(document.RootElement, options);
        }

        internal static NatRulePortMapping DeserializeNatRulePortMapping(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> inboundNatRuleName = default;
            Optional<int> frontendPort = default;
            Optional<int> backendPort = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inboundNatRuleName"u8))
                {
                    inboundNatRuleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("frontendPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frontendPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backendPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendPort = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NatRulePortMapping(inboundNatRuleName.Value, Optional.ToNullable(frontendPort), Optional.ToNullable(backendPort), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NatRulePortMapping>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NatRulePortMapping)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NatRulePortMapping IPersistableModel<NatRulePortMapping>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NatRulePortMapping)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNatRulePortMapping(document.RootElement, options);
        }

        string IPersistableModel<NatRulePortMapping>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
