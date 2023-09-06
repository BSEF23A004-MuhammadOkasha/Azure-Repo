// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class ExpressRouteCrossConnectionPeeringData : IUtf8JsonSerializable, IModelJsonSerializable<ExpressRouteCrossConnectionPeeringData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExpressRouteCrossConnectionPeeringData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExpressRouteCrossConnectionPeeringData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExpressRouteCrossConnectionPeeringData>(this, options.Format);

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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PeeringType))
            {
                writer.WritePropertyName("peeringType"u8);
                writer.WriteStringValue(PeeringType.Value.ToString());
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(PeerASN))
            {
                writer.WritePropertyName("peerASN"u8);
                writer.WriteNumberValue(PeerASN.Value);
            }
            if (Optional.IsDefined(PrimaryPeerAddressPrefix))
            {
                writer.WritePropertyName("primaryPeerAddressPrefix"u8);
                writer.WriteStringValue(PrimaryPeerAddressPrefix);
            }
            if (Optional.IsDefined(SecondaryPeerAddressPrefix))
            {
                writer.WritePropertyName("secondaryPeerAddressPrefix"u8);
                writer.WriteStringValue(SecondaryPeerAddressPrefix);
            }
            if (Optional.IsDefined(SharedKey))
            {
                writer.WritePropertyName("sharedKey"u8);
                writer.WriteStringValue(SharedKey);
            }
            if (Optional.IsDefined(VlanId))
            {
                writer.WritePropertyName("vlanId"u8);
                writer.WriteNumberValue(VlanId.Value);
            }
            if (Optional.IsDefined(MicrosoftPeeringConfig))
            {
                writer.WritePropertyName("microsoftPeeringConfig"u8);
                if (MicrosoftPeeringConfig is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ExpressRouteCircuitPeeringConfig>)MicrosoftPeeringConfig).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(GatewayManagerETag))
            {
                writer.WritePropertyName("gatewayManagerEtag"u8);
                writer.WriteStringValue(GatewayManagerETag);
            }
            if (Optional.IsDefined(IPv6PeeringConfig))
            {
                writer.WritePropertyName("ipv6PeeringConfig"u8);
                if (IPv6PeeringConfig is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<IPv6ExpressRouteCircuitPeeringConfig>)IPv6PeeringConfig).Serialize(writer, options);
                }
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ExpressRouteCrossConnectionPeeringData DeserializeExpressRouteCrossConnectionPeeringData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<ExpressRoutePeeringType> peeringType = default;
            Optional<ExpressRoutePeeringState> state = default;
            Optional<int> azureASN = default;
            Optional<long> peerASN = default;
            Optional<string> primaryPeerAddressPrefix = default;
            Optional<string> secondaryPeerAddressPrefix = default;
            Optional<string> primaryAzurePort = default;
            Optional<string> secondaryAzurePort = default;
            Optional<string> sharedKey = default;
            Optional<int> vlanId = default;
            Optional<ExpressRouteCircuitPeeringConfig> microsoftPeeringConfig = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<string> gatewayManagerETag = default;
            Optional<string> lastModifiedBy = default;
            Optional<IPv6ExpressRouteCircuitPeeringConfig> ipv6PeeringConfig = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("peeringType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peeringType = new ExpressRoutePeeringType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new ExpressRoutePeeringState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("azureASN"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureASN = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("peerASN"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peerASN = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("primaryPeerAddressPrefix"u8))
                        {
                            primaryPeerAddressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secondaryPeerAddressPrefix"u8))
                        {
                            secondaryPeerAddressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("primaryAzurePort"u8))
                        {
                            primaryAzurePort = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secondaryAzurePort"u8))
                        {
                            secondaryAzurePort = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedKey"u8))
                        {
                            sharedKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vlanId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vlanId = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("microsoftPeeringConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            microsoftPeeringConfig = ExpressRouteCircuitPeeringConfig.DeserializeExpressRouteCircuitPeeringConfig(property0.Value);
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
                        if (property0.NameEquals("gatewayManagerEtag"u8))
                        {
                            gatewayManagerETag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedBy"u8))
                        {
                            lastModifiedBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipv6PeeringConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipv6PeeringConfig = IPv6ExpressRouteCircuitPeeringConfig.DeserializeIPv6ExpressRouteCircuitPeeringConfig(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExpressRouteCrossConnectionPeeringData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(etag), Optional.ToNullable(peeringType), Optional.ToNullable(state), Optional.ToNullable(azureASN), Optional.ToNullable(peerASN), primaryPeerAddressPrefix.Value, secondaryPeerAddressPrefix.Value, primaryAzurePort.Value, secondaryAzurePort.Value, sharedKey.Value, Optional.ToNullable(vlanId), microsoftPeeringConfig.Value, Optional.ToNullable(provisioningState), gatewayManagerETag.Value, lastModifiedBy.Value, ipv6PeeringConfig.Value, rawData);
        }

        ExpressRouteCrossConnectionPeeringData IModelJsonSerializable<ExpressRouteCrossConnectionPeeringData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExpressRouteCrossConnectionPeeringData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteCrossConnectionPeeringData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExpressRouteCrossConnectionPeeringData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExpressRouteCrossConnectionPeeringData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExpressRouteCrossConnectionPeeringData IModelSerializable<ExpressRouteCrossConnectionPeeringData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExpressRouteCrossConnectionPeeringData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExpressRouteCrossConnectionPeeringData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ExpressRouteCrossConnectionPeeringData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ExpressRouteCrossConnectionPeeringData"/> to convert. </param>
        public static implicit operator RequestContent(ExpressRouteCrossConnectionPeeringData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ExpressRouteCrossConnectionPeeringData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ExpressRouteCrossConnectionPeeringData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExpressRouteCrossConnectionPeeringData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
