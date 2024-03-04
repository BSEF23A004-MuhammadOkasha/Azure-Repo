// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint : IUtf8JsonSerializable, IJsonModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Category != null)
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (!(Endpoints is ChangeTrackingList<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteStartArray();
                foreach (var item in Endpoints)
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

        SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint IJsonModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint(document.RootElement, options);
        }

        internal static SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint DeserializeSynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string category = default;
            IReadOnlyList<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint> endpoints = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint> array = new List<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint.DeserializeSynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint(item, options));
                    }
                    endpoints = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint(category, endpoints ?? new ChangeTrackingList<SynapseIntegrationRuntimeOutboundNetworkDependenciesEndpoint>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint)} does not support '{options.Format}' format.");
            }
        }

        SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
