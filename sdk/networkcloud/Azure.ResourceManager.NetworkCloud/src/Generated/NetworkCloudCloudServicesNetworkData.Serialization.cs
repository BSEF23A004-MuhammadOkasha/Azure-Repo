// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    public partial class NetworkCloudCloudServicesNetworkData : IUtf8JsonSerializable, IJsonModel<NetworkCloudCloudServicesNetworkData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkCloudCloudServicesNetworkData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkCloudCloudServicesNetworkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudCloudServicesNetworkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudCloudServicesNetworkData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("extendedLocation"u8);
            writer.WriteObjectValue(ExtendedLocation);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AdditionalEgressEndpoints))
            {
                writer.WritePropertyName("additionalEgressEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalEgressEndpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AssociatedResourceIds))
            {
                writer.WritePropertyName("associatedResourceIds"u8);
                writer.WriteStartArray();
                foreach (var item in AssociatedResourceIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ClusterId))
            {
                writer.WritePropertyName("clusterId"u8);
                writer.WriteStringValue(ClusterId);
            }
            if (options.Format != "W" && Optional.IsDefined(DetailedStatus))
            {
                writer.WritePropertyName("detailedStatus"u8);
                writer.WriteStringValue(DetailedStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DetailedStatusMessage))
            {
                writer.WritePropertyName("detailedStatusMessage"u8);
                writer.WriteStringValue(DetailedStatusMessage);
            }
            if (Optional.IsDefined(EnableDefaultEgressEndpoints))
            {
                writer.WritePropertyName("enableDefaultEgressEndpoints"u8);
                writer.WriteStringValue(EnableDefaultEgressEndpoints.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(EnabledEgressEndpoints))
            {
                writer.WritePropertyName("enabledEgressEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in EnabledEgressEndpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(HybridAksClustersAssociatedIds))
            {
                writer.WritePropertyName("hybridAksClustersAssociatedIds"u8);
                writer.WriteStartArray();
                foreach (var item in HybridAksClustersAssociatedIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(InterfaceName))
            {
                writer.WritePropertyName("interfaceName"u8);
                writer.WriteStringValue(InterfaceName);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(VirtualMachinesAssociatedIds))
            {
                writer.WritePropertyName("virtualMachinesAssociatedIds"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualMachinesAssociatedIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        NetworkCloudCloudServicesNetworkData IJsonModel<NetworkCloudCloudServicesNetworkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudCloudServicesNetworkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudCloudServicesNetworkData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudCloudServicesNetworkData(document.RootElement, options);
        }

        internal static NetworkCloudCloudServicesNetworkData DeserializeNetworkCloudCloudServicesNetworkData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IList<EgressEndpoint>> additionalEgressEndpoints = default;
            Optional<IReadOnlyList<ResourceIdentifier>> associatedResourceIds = default;
            Optional<ResourceIdentifier> clusterId = default;
            Optional<CloudServicesNetworkDetailedStatus> detailedStatus = default;
            Optional<string> detailedStatusMessage = default;
            Optional<CloudServicesNetworkEnableDefaultEgressEndpoint> enableDefaultEgressEndpoints = default;
            Optional<IReadOnlyList<EgressEndpoint>> enabledEgressEndpoints = default;
            Optional<IReadOnlyList<ResourceIdentifier>> hybridAksClustersAssociatedIds = default;
            Optional<string> interfaceName = default;
            Optional<CloudServicesNetworkProvisioningState> provisioningState = default;
            Optional<IReadOnlyList<ResourceIdentifier>> virtualMachinesAssociatedIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    extendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("additionalEgressEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EgressEndpoint> array = new List<EgressEndpoint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EgressEndpoint.DeserializeEgressEndpoint(item, options));
                            }
                            additionalEgressEndpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("associatedResourceIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            associatedResourceIds = array;
                            continue;
                        }
                        if (property0.NameEquals("clusterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detailedStatus = new CloudServicesNetworkDetailedStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatusMessage"u8))
                        {
                            detailedStatusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enableDefaultEgressEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableDefaultEgressEndpoints = new CloudServicesNetworkEnableDefaultEgressEndpoint(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enabledEgressEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EgressEndpoint> array = new List<EgressEndpoint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EgressEndpoint.DeserializeEgressEndpoint(item, options));
                            }
                            enabledEgressEndpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("hybridAksClustersAssociatedIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            hybridAksClustersAssociatedIds = array;
                            continue;
                        }
                        if (property0.NameEquals("interfaceName"u8))
                        {
                            interfaceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new CloudServicesNetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("virtualMachinesAssociatedIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            virtualMachinesAssociatedIds = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkCloudCloudServicesNetworkData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, extendedLocation, Optional.ToList(additionalEgressEndpoints), Optional.ToList(associatedResourceIds), clusterId.Value, Optional.ToNullable(detailedStatus), detailedStatusMessage.Value, Optional.ToNullable(enableDefaultEgressEndpoints), Optional.ToList(enabledEgressEndpoints), Optional.ToList(hybridAksClustersAssociatedIds), interfaceName.Value, Optional.ToNullable(provisioningState), Optional.ToList(virtualMachinesAssociatedIds), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkCloudCloudServicesNetworkData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudCloudServicesNetworkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudCloudServicesNetworkData)} does not support '{options.Format}' format.");
            }
        }

        NetworkCloudCloudServicesNetworkData IPersistableModel<NetworkCloudCloudServicesNetworkData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudCloudServicesNetworkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkCloudCloudServicesNetworkData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudCloudServicesNetworkData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkCloudCloudServicesNetworkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
