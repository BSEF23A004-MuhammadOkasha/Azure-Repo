// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkDeviceInterfaceData : IUtf8JsonSerializable, IJsonModel<NetworkDeviceInterfaceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkDeviceInterfaceData>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<NetworkDeviceInterfaceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<NetworkDeviceInterfaceData>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<NetworkDeviceInterfaceData>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(PhysicalIdentifier))
                {
                    writer.WritePropertyName("physicalIdentifier"u8);
                    writer.WriteStringValue(PhysicalIdentifier);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ConnectedTo))
                {
                    writer.WritePropertyName("connectedTo"u8);
                    writer.WriteStringValue(ConnectedTo);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(InterfaceType))
                {
                    writer.WritePropertyName("interfaceType"u8);
                    writer.WriteStringValue(InterfaceType.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IPv4Address))
                {
                    writer.WritePropertyName("ipv4Address"u8);
                    writer.WriteStringValue(IPv4Address.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IPv6Address))
                {
                    writer.WritePropertyName("ipv6Address"u8);
                    writer.WriteStringValue(IPv6Address);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(AdministrativeState))
                {
                    writer.WritePropertyName("administrativeState"u8);
                    writer.WriteStringValue(AdministrativeState.Value.ToString());
                }
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

        NetworkDeviceInterfaceData IJsonModel<NetworkDeviceInterfaceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkDeviceInterfaceData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkDeviceInterfaceData(document.RootElement, options);
        }

        internal static NetworkDeviceInterfaceData DeserializeNetworkDeviceInterfaceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> annotation = default;
            Optional<string> physicalIdentifier = default;
            Optional<string> connectedTo = default;
            Optional<NetworkDeviceInterfaceType> interfaceType = default;
            Optional<IPAddress> ipv4Address = default;
            Optional<string> ipv6Address = default;
            Optional<NetworkFabricProvisioningState> provisioningState = default;
            Optional<NetworkFabricAdministrativeState> administrativeState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("annotation"u8))
                        {
                            annotation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("physicalIdentifier"u8))
                        {
                            physicalIdentifier = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectedTo"u8))
                        {
                            connectedTo = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("interfaceType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            interfaceType = new NetworkDeviceInterfaceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ipv4Address"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipv4Address = IPAddress.Parse(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ipv6Address"u8))
                        {
                            ipv6Address = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkFabricProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("administrativeState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administrativeState = new NetworkFabricAdministrativeState(property0.Value.GetString());
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
            return new NetworkDeviceInterfaceData(id, name, type, systemData.Value, annotation.Value, physicalIdentifier.Value, connectedTo.Value, Optional.ToNullable(interfaceType), ipv4Address.Value, ipv6Address.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(administrativeState), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkDeviceInterfaceData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkDeviceInterfaceData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NetworkDeviceInterfaceData IPersistableModel<NetworkDeviceInterfaceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkDeviceInterfaceData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNetworkDeviceInterfaceData(document.RootElement, options);
        }

        string IPersistableModel<NetworkDeviceInterfaceData>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
