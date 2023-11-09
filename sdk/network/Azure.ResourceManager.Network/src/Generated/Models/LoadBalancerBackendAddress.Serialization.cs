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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class LoadBalancerBackendAddress : IUtf8JsonSerializable, IJsonModel<LoadBalancerBackendAddress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LoadBalancerBackendAddress>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<LoadBalancerBackendAddress>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualNetwork))
            {
                writer.WritePropertyName("virtualNetwork"u8);
                JsonSerializer.Serialize(writer, VirtualNetwork);
            }
            if (Optional.IsDefined(Subnet))
            {
                writer.WritePropertyName("subnet"u8);
                JsonSerializer.Serialize(writer, Subnet);
            }
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(NetworkInterfaceIPConfiguration))
                {
                    writer.WritePropertyName("networkInterfaceIPConfiguration"u8);
                    JsonSerializer.Serialize(writer, NetworkInterfaceIPConfiguration);
                }
            }
            if (Optional.IsDefined(LoadBalancerFrontendIPConfiguration))
            {
                writer.WritePropertyName("loadBalancerFrontendIPConfiguration"u8);
                JsonSerializer.Serialize(writer, LoadBalancerFrontendIPConfiguration);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(InboundNatRulesPortMapping))
                {
                    writer.WritePropertyName("inboundNatRulesPortMapping"u8);
                    writer.WriteStartArray();
                    foreach (var item in InboundNatRulesPortMapping)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (Optional.IsDefined(AdminState))
            {
                writer.WritePropertyName("adminState"u8);
                writer.WriteStringValue(AdminState.Value.ToString());
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

        LoadBalancerBackendAddress IJsonModel<LoadBalancerBackendAddress>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LoadBalancerBackendAddress)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadBalancerBackendAddress(document.RootElement, options);
        }

        internal static LoadBalancerBackendAddress DeserializeLoadBalancerBackendAddress(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<WritableSubResource> virtualNetwork = default;
            Optional<WritableSubResource> subnet = default;
            Optional<string> ipAddress = default;
            Optional<WritableSubResource> networkInterfaceIPConfiguration = default;
            Optional<WritableSubResource> loadBalancerFrontendIPConfiguration = default;
            Optional<IReadOnlyList<NatRulePortMapping>> inboundNatRulesPortMapping = default;
            Optional<LoadBalancerBackendAddressAdminState> adminState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                        if (property0.NameEquals("virtualNetwork"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetwork = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("subnet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnet = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("ipAddress"u8))
                        {
                            ipAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkInterfaceIPConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkInterfaceIPConfiguration = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerFrontendIPConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            loadBalancerFrontendIPConfiguration = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("inboundNatRulesPortMapping"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NatRulePortMapping> array = new List<NatRulePortMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NatRulePortMapping.DeserializeNatRulePortMapping(item));
                            }
                            inboundNatRulesPortMapping = array;
                            continue;
                        }
                        if (property0.NameEquals("adminState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            adminState = new LoadBalancerBackendAddressAdminState(property0.Value.GetString());
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
            return new LoadBalancerBackendAddress(name.Value, virtualNetwork, subnet, ipAddress.Value, networkInterfaceIPConfiguration, loadBalancerFrontendIPConfiguration, Optional.ToList(inboundNatRulesPortMapping), Optional.ToNullable(adminState), serializedAdditionalRawData);
        }

        BinaryData IModel<LoadBalancerBackendAddress>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LoadBalancerBackendAddress)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        LoadBalancerBackendAddress IModel<LoadBalancerBackendAddress>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LoadBalancerBackendAddress)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeLoadBalancerBackendAddress(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<LoadBalancerBackendAddress>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
