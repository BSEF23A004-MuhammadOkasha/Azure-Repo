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
    public partial class NetworkIPConfigurationBgpPeeringAddress : IUtf8JsonSerializable, IJsonModel<NetworkIPConfigurationBgpPeeringAddress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkIPConfigurationBgpPeeringAddress>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<NetworkIPConfigurationBgpPeeringAddress>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IPConfigurationId))
            {
                writer.WritePropertyName("ipconfigurationId"u8);
                writer.WriteStringValue(IPConfigurationId);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(DefaultBgpIPAddresses))
                {
                    writer.WritePropertyName("defaultBgpIpAddresses"u8);
                    writer.WriteStartArray();
                    foreach (var item in DefaultBgpIPAddresses)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (Optional.IsCollectionDefined(CustomBgpIPAddresses))
            {
                writer.WritePropertyName("customBgpIpAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in CustomBgpIPAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(TunnelIPAddresses))
                {
                    writer.WritePropertyName("tunnelIpAddresses"u8);
                    writer.WriteStartArray();
                    foreach (var item in TunnelIPAddresses)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        NetworkIPConfigurationBgpPeeringAddress IJsonModel<NetworkIPConfigurationBgpPeeringAddress>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkIPConfigurationBgpPeeringAddress)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkIPConfigurationBgpPeeringAddress(document.RootElement, options);
        }

        internal static NetworkIPConfigurationBgpPeeringAddress DeserializeNetworkIPConfigurationBgpPeeringAddress(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ipconfigurationId = default;
            Optional<IReadOnlyList<string>> defaultBgpIPAddresses = default;
            Optional<IList<string>> customBgpIPAddresses = default;
            Optional<IReadOnlyList<string>> tunnelIPAddresses = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipconfigurationId"u8))
                {
                    ipconfigurationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultBgpIpAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    defaultBgpIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("customBgpIpAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    customBgpIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("tunnelIpAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tunnelIPAddresses = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkIPConfigurationBgpPeeringAddress(ipconfigurationId.Value, Optional.ToList(defaultBgpIPAddresses), Optional.ToList(customBgpIPAddresses), Optional.ToList(tunnelIPAddresses), serializedAdditionalRawData);
        }

        BinaryData IModel<NetworkIPConfigurationBgpPeeringAddress>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkIPConfigurationBgpPeeringAddress)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NetworkIPConfigurationBgpPeeringAddress IModel<NetworkIPConfigurationBgpPeeringAddress>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkIPConfigurationBgpPeeringAddress)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNetworkIPConfigurationBgpPeeringAddress(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<NetworkIPConfigurationBgpPeeringAddress>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
