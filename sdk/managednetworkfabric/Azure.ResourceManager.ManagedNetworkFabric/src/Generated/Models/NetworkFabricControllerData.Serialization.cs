// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkFabricControllerData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (Optional.IsCollectionDefined(InfrastructureExpressRouteConnections))
            {
                writer.WritePropertyName("infrastructureExpressRouteConnections"u8);
                writer.WriteStartArray();
                foreach (var item in InfrastructureExpressRouteConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WorkloadExpressRouteConnections))
            {
                writer.WritePropertyName("workloadExpressRouteConnections"u8);
                writer.WriteStartArray();
                foreach (var item in WorkloadExpressRouteConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ManagedResourceGroupConfiguration))
            {
                writer.WritePropertyName("managedResourceGroupConfiguration"u8);
                writer.WriteObjectValue(ManagedResourceGroupConfiguration);
            }
            if (Optional.IsDefined(IsWorkloadManagementNetworkEnabled))
            {
                writer.WritePropertyName("isWorkloadManagementNetworkEnabled"u8);
                writer.WriteStringValue(IsWorkloadManagementNetworkEnabled.Value.ToString());
            }
            if (Optional.IsDefined(IPv4AddressSpace))
            {
                writer.WritePropertyName("ipv4AddressSpace"u8);
                writer.WriteStringValue(IPv4AddressSpace);
            }
            if (Optional.IsDefined(IPv6AddressSpace))
            {
                writer.WritePropertyName("ipv6AddressSpace"u8);
                writer.WriteStringValue(IPv6AddressSpace);
            }
            if (Optional.IsDefined(NfcSku))
            {
                writer.WritePropertyName("nfcSku"u8);
                writer.WriteStringValue(NfcSku.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkFabricControllerData DeserializeNetworkFabricControllerData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> annotation = default;
            Optional<IList<ExpressRouteConnectionInformation>> infrastructureExpressRouteConnections = default;
            Optional<IList<ExpressRouteConnectionInformation>> workloadExpressRouteConnections = default;
            Optional<NetworkFabricControllerServices> infrastructureServices = default;
            Optional<NetworkFabricControllerServices> workloadServices = default;
            Optional<ManagedResourceGroupConfiguration> managedResourceGroupConfiguration = default;
            Optional<IReadOnlyList<ResourceIdentifier>> networkFabricIds = default;
            Optional<bool> workloadManagementNetwork = default;
            Optional<IsWorkloadManagementNetworkEnabled> isWorkloadManagementNetworkEnabled = default;
            Optional<IReadOnlyList<ResourceIdentifier>> tenantInternetGatewayIds = default;
            Optional<string> ipv4AddressSpace = default;
            Optional<string> ipv6AddressSpace = default;
            Optional<NetworkFabricControllerSKU> nfcSku = default;
            Optional<NetworkFabricProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("annotation"u8))
                        {
                            annotation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("infrastructureExpressRouteConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ExpressRouteConnectionInformation> array = new List<ExpressRouteConnectionInformation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ExpressRouteConnectionInformation.DeserializeExpressRouteConnectionInformation(item));
                            }
                            infrastructureExpressRouteConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("workloadExpressRouteConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ExpressRouteConnectionInformation> array = new List<ExpressRouteConnectionInformation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ExpressRouteConnectionInformation.DeserializeExpressRouteConnectionInformation(item));
                            }
                            workloadExpressRouteConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("infrastructureServices"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            infrastructureServices = NetworkFabricControllerServices.DeserializeNetworkFabricControllerServices(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("workloadServices"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workloadServices = NetworkFabricControllerServices.DeserializeNetworkFabricControllerServices(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("managedResourceGroupConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedResourceGroupConfiguration = ManagedResourceGroupConfiguration.DeserializeManagedResourceGroupConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkFabricIds"u8))
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
                            networkFabricIds = array;
                            continue;
                        }
                        if (property0.NameEquals("workloadManagementNetwork"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workloadManagementNetwork = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isWorkloadManagementNetworkEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isWorkloadManagementNetworkEnabled = new IsWorkloadManagementNetworkEnabled(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tenantInternetGatewayIds"u8))
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
                            tenantInternetGatewayIds = array;
                            continue;
                        }
                        if (property0.NameEquals("ipv4AddressSpace"u8))
                        {
                            ipv4AddressSpace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipv6AddressSpace"u8))
                        {
                            ipv6AddressSpace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nfcSku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nfcSku = new NetworkFabricControllerSKU(property0.Value.GetString());
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
                    }
                    continue;
                }
            }
            return new NetworkFabricControllerData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, annotation.Value, Optional.ToList(infrastructureExpressRouteConnections), Optional.ToList(workloadExpressRouteConnections), infrastructureServices.Value, workloadServices.Value, managedResourceGroupConfiguration.Value, Optional.ToList(networkFabricIds), Optional.ToNullable(workloadManagementNetwork), Optional.ToNullable(isWorkloadManagementNetworkEnabled), Optional.ToList(tenantInternetGatewayIds), ipv4AddressSpace.Value, ipv6AddressSpace.Value, Optional.ToNullable(nfcSku), Optional.ToNullable(provisioningState));
        }
    }
}
