// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class NetworkStatusContract : IUtf8JsonSerializable, IJsonModel<NetworkStatusContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkStatusContract>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkStatusContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkStatusContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkStatusContract)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("dnsServers"u8);
            writer.WriteStartArray();
            foreach (var item in DnsServers)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("connectivityStatus"u8);
            writer.WriteStartArray();
            foreach (var item in ConnectivityStatus)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        NetworkStatusContract IJsonModel<NetworkStatusContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkStatusContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkStatusContract)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkStatusContract(document.RootElement, options);
        }

        internal static NetworkStatusContract DeserializeNetworkStatusContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> dnsServers = default;
            IReadOnlyList<ConnectivityStatusContract> connectivityStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dnsServers"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dnsServers = array;
                    continue;
                }
                if (property.NameEquals("connectivityStatus"u8))
                {
                    List<ConnectivityStatusContract> array = new List<ConnectivityStatusContract>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectivityStatusContract.DeserializeConnectivityStatusContract(item, options));
                    }
                    connectivityStatus = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkStatusContract(dnsServers, connectivityStatus, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkStatusContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkStatusContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkStatusContract)} does not support '{options.Format}' format.");
            }
        }

        NetworkStatusContract IPersistableModel<NetworkStatusContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkStatusContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkStatusContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkStatusContract)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkStatusContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
