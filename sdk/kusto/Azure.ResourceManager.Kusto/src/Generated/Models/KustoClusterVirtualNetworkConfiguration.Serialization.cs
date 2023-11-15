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

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoClusterVirtualNetworkConfiguration : IUtf8JsonSerializable, IJsonModel<KustoClusterVirtualNetworkConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KustoClusterVirtualNetworkConfiguration>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<KustoClusterVirtualNetworkConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<KustoClusterVirtualNetworkConfiguration>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<KustoClusterVirtualNetworkConfiguration>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("subnetId"u8);
            writer.WriteStringValue(SubnetId);
            writer.WritePropertyName("enginePublicIpId"u8);
            writer.WriteStringValue(EnginePublicIPId);
            writer.WritePropertyName("dataManagementPublicIpId"u8);
            writer.WriteStringValue(DataManagementPublicIPId);
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
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

        KustoClusterVirtualNetworkConfiguration IJsonModel<KustoClusterVirtualNetworkConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KustoClusterVirtualNetworkConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKustoClusterVirtualNetworkConfiguration(document.RootElement, options);
        }

        internal static KustoClusterVirtualNetworkConfiguration DeserializeKustoClusterVirtualNetworkConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string subnetId = default;
            string enginePublicIPId = default;
            string dataManagementPublicIPId = default;
            Optional<KustoClusterVnetState> state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnetId"u8))
                {
                    subnetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enginePublicIpId"u8))
                {
                    enginePublicIPId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataManagementPublicIpId"u8))
                {
                    dataManagementPublicIPId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new KustoClusterVnetState(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KustoClusterVirtualNetworkConfiguration(subnetId, enginePublicIPId, dataManagementPublicIPId, Optional.ToNullable(state), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KustoClusterVirtualNetworkConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KustoClusterVirtualNetworkConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        KustoClusterVirtualNetworkConfiguration IPersistableModel<KustoClusterVirtualNetworkConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KustoClusterVirtualNetworkConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeKustoClusterVirtualNetworkConfiguration(document.RootElement, options);
        }

        string IPersistableModel<KustoClusterVirtualNetworkConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
