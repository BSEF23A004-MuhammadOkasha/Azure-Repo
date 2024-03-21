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
    public partial class AgentPoolNetworkPortRange : IUtf8JsonSerializable, IJsonModel<AgentPoolNetworkPortRange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AgentPoolNetworkPortRange>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AgentPoolNetworkPortRange>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolNetworkPortRange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentPoolNetworkPortRange)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PortStart))
            {
                writer.WritePropertyName("portStart"u8);
                writer.WriteNumberValue(PortStart.Value);
            }
            if (Optional.IsDefined(PortEnd))
            {
                writer.WritePropertyName("portEnd"u8);
                writer.WriteNumberValue(PortEnd.Value);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
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

        AgentPoolNetworkPortRange IJsonModel<AgentPoolNetworkPortRange>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolNetworkPortRange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentPoolNetworkPortRange)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAgentPoolNetworkPortRange(document.RootElement, options);
        }

        internal static AgentPoolNetworkPortRange DeserializeAgentPoolNetworkPortRange(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? portStart = default;
            int? portEnd = default;
            AgentPoolNetworkPortProtocol? protocol = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("portStart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portStart = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("portEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portEnd = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocol = new AgentPoolNetworkPortProtocol(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AgentPoolNetworkPortRange(portStart, portEnd, protocol, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AgentPoolNetworkPortRange>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolNetworkPortRange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AgentPoolNetworkPortRange)} does not support writing '{options.Format}' format.");
            }
        }

        AgentPoolNetworkPortRange IPersistableModel<AgentPoolNetworkPortRange>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolNetworkPortRange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAgentPoolNetworkPortRange(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AgentPoolNetworkPortRange)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AgentPoolNetworkPortRange>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
