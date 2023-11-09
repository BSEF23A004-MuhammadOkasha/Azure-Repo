// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VpnSiteLinkConnectionData : IUtf8JsonSerializable, IJsonModel<VpnSiteLinkConnectionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnSiteLinkConnectionData>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<VpnSiteLinkConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ETag))
                {
                    writer.WritePropertyName("etag"u8);
                    writer.WriteStringValue(ETag.Value.ToString());
                }
            }
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
            if (Optional.IsDefined(VpnSiteLink))
            {
                writer.WritePropertyName("vpnSiteLink"u8);
                JsonSerializer.Serialize(writer, VpnSiteLink);
            }
            if (Optional.IsDefined(RoutingWeight))
            {
                writer.WritePropertyName("routingWeight"u8);
                writer.WriteNumberValue(RoutingWeight.Value);
            }
            if (Optional.IsDefined(VpnLinkConnectionMode))
            {
                writer.WritePropertyName("vpnLinkConnectionMode"u8);
                writer.WriteStringValue(VpnLinkConnectionMode.Value.ToString());
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ConnectionStatus))
                {
                    writer.WritePropertyName("connectionStatus"u8);
                    writer.WriteStringValue(ConnectionStatus.Value.ToString());
                }
            }
            if (Optional.IsDefined(VpnConnectionProtocolType))
            {
                writer.WritePropertyName("vpnConnectionProtocolType"u8);
                writer.WriteStringValue(VpnConnectionProtocolType.Value.ToString());
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(IngressBytesTransferred))
                {
                    writer.WritePropertyName("ingressBytesTransferred"u8);
                    writer.WriteNumberValue(IngressBytesTransferred.Value);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(EgressBytesTransferred))
                {
                    writer.WritePropertyName("egressBytesTransferred"u8);
                    writer.WriteNumberValue(EgressBytesTransferred.Value);
                }
            }
            if (Optional.IsDefined(ConnectionBandwidth))
            {
                writer.WritePropertyName("connectionBandwidth"u8);
                writer.WriteNumberValue(ConnectionBandwidth.Value);
            }
            if (Optional.IsDefined(SharedKey))
            {
                writer.WritePropertyName("sharedKey"u8);
                writer.WriteStringValue(SharedKey);
            }
            if (Optional.IsDefined(EnableBgp))
            {
                writer.WritePropertyName("enableBgp"u8);
                writer.WriteBooleanValue(EnableBgp.Value);
            }
            if (Optional.IsCollectionDefined(VpnGatewayCustomBgpAddresses))
            {
                writer.WritePropertyName("vpnGatewayCustomBgpAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in VpnGatewayCustomBgpAddresses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UsePolicyBasedTrafficSelectors))
            {
                writer.WritePropertyName("usePolicyBasedTrafficSelectors"u8);
                writer.WriteBooleanValue(UsePolicyBasedTrafficSelectors.Value);
            }
            if (Optional.IsCollectionDefined(IPsecPolicies))
            {
                writer.WritePropertyName("ipsecPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in IPsecPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableRateLimiting))
            {
                writer.WritePropertyName("enableRateLimiting"u8);
                writer.WriteBooleanValue(EnableRateLimiting.Value);
            }
            if (Optional.IsDefined(UseLocalAzureIPAddress))
            {
                writer.WritePropertyName("useLocalAzureIpAddress"u8);
                writer.WriteBooleanValue(UseLocalAzureIPAddress.Value);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (Optional.IsCollectionDefined(IngressNatRules))
            {
                writer.WritePropertyName("ingressNatRules"u8);
                writer.WriteStartArray();
                foreach (var item in IngressNatRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EgressNatRules))
            {
                writer.WritePropertyName("egressNatRules"u8);
                writer.WriteStartArray();
                foreach (var item in EgressNatRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
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

        VpnSiteLinkConnectionData IJsonModel<VpnSiteLinkConnectionData>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VpnSiteLinkConnectionData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnSiteLinkConnectionData(document.RootElement, options);
        }

        internal static VpnSiteLinkConnectionData DeserializeVpnSiteLinkConnectionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<WritableSubResource> vpnSiteLink = default;
            Optional<int> routingWeight = default;
            Optional<VpnLinkConnectionMode> vpnLinkConnectionMode = default;
            Optional<VpnConnectionStatus> connectionStatus = default;
            Optional<VirtualNetworkGatewayConnectionProtocol> vpnConnectionProtocolType = default;
            Optional<long> ingressBytesTransferred = default;
            Optional<long> egressBytesTransferred = default;
            Optional<int> connectionBandwidth = default;
            Optional<string> sharedKey = default;
            Optional<bool> enableBgp = default;
            Optional<IList<GatewayCustomBgpIPAddressIPConfiguration>> vpnGatewayCustomBgpAddresses = default;
            Optional<bool> usePolicyBasedTrafficSelectors = default;
            Optional<IList<IPsecPolicy>> ipsecPolicies = default;
            Optional<bool> enableRateLimiting = default;
            Optional<bool> useLocalAzureIPAddress = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<IList<WritableSubResource>> ingressNatRules = default;
            Optional<IList<WritableSubResource>> egressNatRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("vpnSiteLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnSiteLink = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("routingWeight"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingWeight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("vpnLinkConnectionMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnLinkConnectionMode = new VpnLinkConnectionMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("connectionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionStatus = new VpnConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnConnectionProtocolType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnConnectionProtocolType = new VirtualNetworkGatewayConnectionProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ingressBytesTransferred"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ingressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("egressBytesTransferred"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            egressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("connectionBandwidth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionBandwidth = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sharedKey"u8))
                        {
                            sharedKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enableBgp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBgp = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("vpnGatewayCustomBgpAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<GatewayCustomBgpIPAddressIPConfiguration> array = new List<GatewayCustomBgpIPAddressIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(GatewayCustomBgpIPAddressIPConfiguration.DeserializeGatewayCustomBgpIPAddressIPConfiguration(item));
                            }
                            vpnGatewayCustomBgpAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("usePolicyBasedTrafficSelectors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usePolicyBasedTrafficSelectors = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ipsecPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPsecPolicy> array = new List<IPsecPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IPsecPolicy.DeserializeIPsecPolicy(item));
                            }
                            ipsecPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("enableRateLimiting"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableRateLimiting = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useLocalAzureIpAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useLocalAzureIPAddress = property0.Value.GetBoolean();
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
                        if (property0.NameEquals("ingressNatRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            ingressNatRules = array;
                            continue;
                        }
                        if (property0.NameEquals("egressNatRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            egressNatRules = array;
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
            return new VpnSiteLinkConnectionData(id.Value, name.Value, Optional.ToNullable(type), serializedAdditionalRawData, Optional.ToNullable(etag), vpnSiteLink, Optional.ToNullable(routingWeight), Optional.ToNullable(vpnLinkConnectionMode), Optional.ToNullable(connectionStatus), Optional.ToNullable(vpnConnectionProtocolType), Optional.ToNullable(ingressBytesTransferred), Optional.ToNullable(egressBytesTransferred), Optional.ToNullable(connectionBandwidth), sharedKey.Value, Optional.ToNullable(enableBgp), Optional.ToList(vpnGatewayCustomBgpAddresses), Optional.ToNullable(usePolicyBasedTrafficSelectors), Optional.ToList(ipsecPolicies), Optional.ToNullable(enableRateLimiting), Optional.ToNullable(useLocalAzureIPAddress), Optional.ToNullable(provisioningState), Optional.ToList(ingressNatRules), Optional.ToList(egressNatRules));
        }

        BinaryData IModel<VpnSiteLinkConnectionData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VpnSiteLinkConnectionData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        VpnSiteLinkConnectionData IModel<VpnSiteLinkConnectionData>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VpnSiteLinkConnectionData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeVpnSiteLinkConnectionData(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<VpnSiteLinkConnectionData>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
