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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class NetworkVirtualApplianceConnectionData : IUtf8JsonSerializable, IJsonModel<NetworkVirtualApplianceConnectionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkVirtualApplianceConnectionData>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<NetworkVirtualApplianceConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ResourceType))
                {
                    writer.WritePropertyName("type"u8);
                    writer.WriteStringValue(ResourceType.Value);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(NamePropertiesName))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(NamePropertiesName);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (Optional.IsDefined(Asn))
            {
                writer.WritePropertyName("asn"u8);
                writer.WriteNumberValue(Asn.Value);
            }
            if (Optional.IsDefined(TunnelIdentifier))
            {
                writer.WritePropertyName("tunnelIdentifier"u8);
                writer.WriteNumberValue(TunnelIdentifier.Value);
            }
            if (Optional.IsCollectionDefined(BgpPeerAddress))
            {
                writer.WritePropertyName("bgpPeerAddress"u8);
                writer.WriteStartArray();
                foreach (var item in BgpPeerAddress)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableInternetSecurity))
            {
                writer.WritePropertyName("enableInternetSecurity"u8);
                writer.WriteBooleanValue(EnableInternetSecurity.Value);
            }
            if (Optional.IsDefined(RoutingConfiguration))
            {
                writer.WritePropertyName("routingConfiguration"u8);
                writer.WriteObjectValue(RoutingConfiguration);
            }
            writer.WriteEndObject();
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

        NetworkVirtualApplianceConnectionData IJsonModel<NetworkVirtualApplianceConnectionData>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkVirtualApplianceConnectionData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkVirtualApplianceConnectionData(document.RootElement, options);
        }

        internal static NetworkVirtualApplianceConnectionData DeserializeNetworkVirtualApplianceConnectionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<string> name0 = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<long> asn = default;
            Optional<long> tunnelIdentifier = default;
            Optional<IList<string>> bgpPeerAddress = default;
            Optional<bool> enableInternetSecurity = default;
            Optional<RoutingConfigurationNfv> routingConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("name"u8))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("asn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            asn = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("tunnelIdentifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tunnelIdentifier = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bgpPeerAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            bgpPeerAddress = array;
                            continue;
                        }
                        if (property0.NameEquals("enableInternetSecurity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableInternetSecurity = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("routingConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingConfiguration = RoutingConfigurationNfv.DeserializeRoutingConfigurationNfv(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkVirtualApplianceConnectionData(id.Value, name.Value, Optional.ToNullable(type), serializedAdditionalRawData, name0.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(asn), Optional.ToNullable(tunnelIdentifier), Optional.ToList(bgpPeerAddress), Optional.ToNullable(enableInternetSecurity), routingConfiguration.Value);
        }

        BinaryData IModel<NetworkVirtualApplianceConnectionData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkVirtualApplianceConnectionData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NetworkVirtualApplianceConnectionData IModel<NetworkVirtualApplianceConnectionData>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkVirtualApplianceConnectionData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNetworkVirtualApplianceConnectionData(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<NetworkVirtualApplianceConnectionData>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
