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

namespace Azure.ResourceManager.Network
{
    public partial class VirtualNetworkGatewayNatRuleData : IUtf8JsonSerializable, IJsonModel<VirtualNetworkGatewayNatRuleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualNetworkGatewayNatRuleData>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<VirtualNetworkGatewayNatRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<VirtualNetworkGatewayNatRuleData>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<VirtualNetworkGatewayNatRuleData>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
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
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ResourceType))
                {
                    writer.WritePropertyName("type"u8);
                    writer.WriteStringValue(ResourceType.Value);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (Optional.IsDefined(VpnNatRuleType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(VpnNatRuleType.Value.ToString());
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(InternalMappings))
            {
                writer.WritePropertyName("internalMappings"u8);
                writer.WriteStartArray();
                foreach (var item in InternalMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExternalMappings))
            {
                writer.WritePropertyName("externalMappings"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IPConfigurationId))
            {
                writer.WritePropertyName("ipConfigurationId"u8);
                writer.WriteStringValue(IPConfigurationId);
            }
            writer.WriteEndObject();
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

        VirtualNetworkGatewayNatRuleData IJsonModel<VirtualNetworkGatewayNatRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VirtualNetworkGatewayNatRuleData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualNetworkGatewayNatRuleData(document.RootElement, options);
        }

        internal static VirtualNetworkGatewayNatRuleData DeserializeVirtualNetworkGatewayNatRuleData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<VpnNatRuleType> type0 = default;
            Optional<VpnNatRuleMode> mode = default;
            Optional<IList<VpnNatRuleMapping>> internalMappings = default;
            Optional<IList<VpnNatRuleMapping>> externalMappings = default;
            Optional<string> ipConfigurationId = default;
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type0 = new VpnNatRuleType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("mode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mode = new VpnNatRuleMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("internalMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnNatRuleMapping> array = new List<VpnNatRuleMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnNatRuleMapping.DeserializeVpnNatRuleMapping(item));
                            }
                            internalMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("externalMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnNatRuleMapping> array = new List<VpnNatRuleMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnNatRuleMapping.DeserializeVpnNatRuleMapping(item));
                            }
                            externalMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurationId"u8))
                        {
                            ipConfigurationId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualNetworkGatewayNatRuleData(id.Value, name.Value, Optional.ToNullable(type), serializedAdditionalRawData, Optional.ToNullable(etag), Optional.ToNullable(provisioningState), Optional.ToNullable(type0), Optional.ToNullable(mode), Optional.ToList(internalMappings), Optional.ToList(externalMappings), ipConfigurationId.Value);
        }

        BinaryData IPersistableModel<VirtualNetworkGatewayNatRuleData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VirtualNetworkGatewayNatRuleData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        VirtualNetworkGatewayNatRuleData IPersistableModel<VirtualNetworkGatewayNatRuleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VirtualNetworkGatewayNatRuleData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeVirtualNetworkGatewayNatRuleData(document.RootElement, options);
        }

        string IPersistableModel<VirtualNetworkGatewayNatRuleData>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
