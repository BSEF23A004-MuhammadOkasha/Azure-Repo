// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ManagedClusterSubnet : IUtf8JsonSerializable, IJsonModel<ManagedClusterSubnet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterSubnet>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterSubnet>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSubnet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterSubnet)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (IsIPv6Enabled.HasValue)
            {
                writer.WritePropertyName("enableIpv6"u8);
                writer.WriteBooleanValue(IsIPv6Enabled.Value);
            }
            if (PrivateEndpointNetworkPolicies.HasValue)
            {
                writer.WritePropertyName("privateEndpointNetworkPolicies"u8);
                writer.WriteStringValue(PrivateEndpointNetworkPolicies.Value.ToString());
            }
            if (PrivateLinkServiceNetworkPolicies.HasValue)
            {
                writer.WritePropertyName("privateLinkServiceNetworkPolicies"u8);
                writer.WriteStringValue(PrivateLinkServiceNetworkPolicies.Value.ToString());
            }
            if (NetworkSecurityGroupId != null)
            {
                writer.WritePropertyName("networkSecurityGroupId"u8);
                writer.WriteStringValue(NetworkSecurityGroupId);
            }
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

        ManagedClusterSubnet IJsonModel<ManagedClusterSubnet>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSubnet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterSubnet)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterSubnet(document.RootElement, options);
        }

        internal static ManagedClusterSubnet DeserializeManagedClusterSubnet(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<bool> enableIPv6 = default;
            Optional<ManagedClusterSubnetPrivateEndpointNetworkPoliciesState> privateEndpointNetworkPolicies = default;
            Optional<ManagedClusterSubnetPrivateLinkServiceNetworkPoliciesState> privateLinkServiceNetworkPolicies = default;
            Optional<ResourceIdentifier> networkSecurityGroupId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableIpv6"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableIPv6 = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("privateEndpointNetworkPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpointNetworkPolicies = new ManagedClusterSubnetPrivateEndpointNetworkPoliciesState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateLinkServiceNetworkPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateLinkServiceNetworkPolicies = new ManagedClusterSubnetPrivateLinkServiceNetworkPoliciesState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkSecurityGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    networkSecurityGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterSubnet(name, Optional.ToNullable(enableIPv6), Optional.ToNullable(privateEndpointNetworkPolicies), Optional.ToNullable(privateLinkServiceNetworkPolicies), networkSecurityGroupId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterSubnet>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSubnet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterSubnet)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterSubnet IPersistableModel<ManagedClusterSubnet>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSubnet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterSubnet(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterSubnet)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterSubnet>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
