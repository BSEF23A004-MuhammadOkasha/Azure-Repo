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

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class FirewallNetworkProfile : IUtf8JsonSerializable, IJsonModel<FirewallNetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallNetworkProfile>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<FirewallNetworkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VnetConfiguration))
            {
                writer.WritePropertyName("vnetConfiguration"u8);
                writer.WriteObjectValue(VnetConfiguration);
            }
            if (Optional.IsDefined(VwanConfiguration))
            {
                writer.WritePropertyName("vwanConfiguration"u8);
                writer.WriteObjectValue(VwanConfiguration);
            }
            writer.WritePropertyName("networkType"u8);
            writer.WriteStringValue(NetworkType.ToString());
            writer.WritePropertyName("publicIps"u8);
            writer.WriteStartArray();
            foreach (var item in PublicIPs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("enableEgressNat"u8);
            writer.WriteStringValue(EnableEgressNat.ToString());
            if (Optional.IsCollectionDefined(EgressNatIP))
            {
                writer.WritePropertyName("egressNatIp"u8);
                writer.WriteStartArray();
                foreach (var item in EgressNatIP)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        FirewallNetworkProfile IJsonModel<FirewallNetworkProfile>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirewallNetworkProfile)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallNetworkProfile(document.RootElement, options);
        }

        internal static FirewallNetworkProfile DeserializeFirewallNetworkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<FirewallVnetConfiguration> vnetConfiguration = default;
            Optional<FirewallVwanConfiguration> vwanConfiguration = default;
            FirewallNetworkType networkType = default;
            IList<IPAddressInfo> publicIPs = default;
            AllowEgressNatType enableEgressNat = default;
            Optional<IList<IPAddressInfo>> egressNatIP = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vnetConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vnetConfiguration = FirewallVnetConfiguration.DeserializeFirewallVnetConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("vwanConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vwanConfiguration = FirewallVwanConfiguration.DeserializeFirewallVwanConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("networkType"u8))
                {
                    networkType = new FirewallNetworkType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicIps"u8))
                {
                    List<IPAddressInfo> array = new List<IPAddressInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPAddressInfo.DeserializeIPAddressInfo(item));
                    }
                    publicIPs = array;
                    continue;
                }
                if (property.NameEquals("enableEgressNat"u8))
                {
                    enableEgressNat = new AllowEgressNatType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("egressNatIp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddressInfo> array = new List<IPAddressInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPAddressInfo.DeserializeIPAddressInfo(item));
                    }
                    egressNatIP = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirewallNetworkProfile(vnetConfiguration.Value, vwanConfiguration.Value, networkType, publicIPs, enableEgressNat, Optional.ToList(egressNatIP), serializedAdditionalRawData);
        }

        BinaryData IModel<FirewallNetworkProfile>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirewallNetworkProfile)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        FirewallNetworkProfile IModel<FirewallNetworkProfile>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirewallNetworkProfile)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFirewallNetworkProfile(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<FirewallNetworkProfile>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
