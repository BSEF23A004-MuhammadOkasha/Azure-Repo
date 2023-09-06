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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class LoadBalancingRuleData : IUtf8JsonSerializable, IModelJsonSerializable<LoadBalancingRuleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LoadBalancingRuleData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LoadBalancingRuleData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadBalancingRuleData>(this, options.Format);

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
            if (Optional.IsDefined(FrontendIPConfiguration))
            {
                writer.WritePropertyName("frontendIPConfiguration"u8);
                JsonSerializer.Serialize(writer, FrontendIPConfiguration);
            }
            if (Optional.IsDefined(BackendAddressPool))
            {
                writer.WritePropertyName("backendAddressPool"u8);
                JsonSerializer.Serialize(writer, BackendAddressPool);
            }
            if (Optional.IsCollectionDefined(BackendAddressPools))
            {
                writer.WritePropertyName("backendAddressPools"u8);
                writer.WriteStartArray();
                foreach (var item in BackendAddressPools)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Probe))
            {
                writer.WritePropertyName("probe"u8);
                JsonSerializer.Serialize(writer, Probe);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(LoadDistribution))
            {
                writer.WritePropertyName("loadDistribution"u8);
                writer.WriteStringValue(LoadDistribution.Value.ToString());
            }
            if (Optional.IsDefined(FrontendPort))
            {
                writer.WritePropertyName("frontendPort"u8);
                writer.WriteNumberValue(FrontendPort.Value);
            }
            if (Optional.IsDefined(BackendPort))
            {
                writer.WritePropertyName("backendPort"u8);
                writer.WriteNumberValue(BackendPort.Value);
            }
            if (Optional.IsDefined(IdleTimeoutInMinutes))
            {
                writer.WritePropertyName("idleTimeoutInMinutes"u8);
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
            }
            if (Optional.IsDefined(EnableFloatingIP))
            {
                writer.WritePropertyName("enableFloatingIP"u8);
                writer.WriteBooleanValue(EnableFloatingIP.Value);
            }
            if (Optional.IsDefined(EnableTcpReset))
            {
                writer.WritePropertyName("enableTcpReset"u8);
                writer.WriteBooleanValue(EnableTcpReset.Value);
            }
            if (Optional.IsDefined(DisableOutboundSnat))
            {
                writer.WritePropertyName("disableOutboundSnat"u8);
                writer.WriteBooleanValue(DisableOutboundSnat.Value);
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

        internal static LoadBalancingRuleData DeserializeLoadBalancingRuleData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<WritableSubResource> frontendIPConfiguration = default;
            Optional<WritableSubResource> backendAddressPool = default;
            Optional<IList<WritableSubResource>> backendAddressPools = default;
            Optional<WritableSubResource> probe = default;
            Optional<LoadBalancingTransportProtocol> protocol = default;
            Optional<LoadDistribution> loadDistribution = default;
            Optional<int> frontendPort = default;
            Optional<int> backendPort = default;
            Optional<int> idleTimeoutInMinutes = default;
            Optional<bool> enableFloatingIP = default;
            Optional<bool> enableTcpReset = default;
            Optional<bool> disableOutboundSnat = default;
            Optional<NetworkProvisioningState> provisioningState = default;
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
                        if (property0.NameEquals("frontendIPConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            frontendIPConfiguration = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("backendAddressPool"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backendAddressPool = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("backendAddressPools"u8))
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
                            backendAddressPools = array;
                            continue;
                        }
                        if (property0.NameEquals("probe"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            probe = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("protocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protocol = new LoadBalancingTransportProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("loadDistribution"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            loadDistribution = new LoadDistribution(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("frontendPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            frontendPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("backendPort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backendPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("idleTimeoutInMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            idleTimeoutInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enableFloatingIP"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableFloatingIP = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableTcpReset"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableTcpReset = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("disableOutboundSnat"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableOutboundSnat = property0.Value.GetBoolean();
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
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LoadBalancingRuleData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(etag), frontendIPConfiguration, backendAddressPool, Optional.ToList(backendAddressPools), probe, Optional.ToNullable(protocol), Optional.ToNullable(loadDistribution), Optional.ToNullable(frontendPort), Optional.ToNullable(backendPort), Optional.ToNullable(idleTimeoutInMinutes), Optional.ToNullable(enableFloatingIP), Optional.ToNullable(enableTcpReset), Optional.ToNullable(disableOutboundSnat), Optional.ToNullable(provisioningState), rawData);
        }

        LoadBalancingRuleData IModelJsonSerializable<LoadBalancingRuleData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadBalancingRuleData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadBalancingRuleData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LoadBalancingRuleData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadBalancingRuleData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LoadBalancingRuleData IModelSerializable<LoadBalancingRuleData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadBalancingRuleData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLoadBalancingRuleData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LoadBalancingRuleData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LoadBalancingRuleData"/> to convert. </param>
        public static implicit operator RequestContent(LoadBalancingRuleData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LoadBalancingRuleData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LoadBalancingRuleData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLoadBalancingRuleData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
