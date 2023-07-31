// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    public partial class NetworkCloudClusterData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("aggregatorOrSingleRackDefinition"u8);
            writer.WriteObjectValue(AggregatorOrSingleRackDefinition);
            if (Optional.IsDefined(AnalyticsWorkspaceId))
            {
                writer.WritePropertyName("analyticsWorkspaceId"u8);
                writer.WriteStringValue(AnalyticsWorkspaceId);
            }
            if (Optional.IsDefined(ClusterLocation))
            {
                writer.WritePropertyName("clusterLocation"u8);
                writer.WriteStringValue(ClusterLocation);
            }
            if (Optional.IsDefined(ClusterServicePrincipal))
            {
                writer.WritePropertyName("clusterServicePrincipal"u8);
                writer.WriteObjectValue(ClusterServicePrincipal);
            }
            writer.WritePropertyName("clusterType"u8);
            writer.WriteStringValue(ClusterType.ToString());
            writer.WritePropertyName("clusterVersion"u8);
            writer.WriteStringValue(ClusterVersion);
            if (Optional.IsDefined(ComputeDeploymentThreshold))
            {
                writer.WritePropertyName("computeDeploymentThreshold"u8);
                writer.WriteObjectValue(ComputeDeploymentThreshold);
            }
            if (Optional.IsCollectionDefined(ComputeRackDefinitions))
            {
                writer.WritePropertyName("computeRackDefinitions"u8);
                writer.WriteStartArray();
                foreach (var item in ComputeRackDefinitions)
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
            writer.WritePropertyName("networkFabricId"u8);
            writer.WriteStringValue(NetworkFabricId);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkCloudClusterData DeserializeNetworkCloudClusterData(JsonElement element)
        {
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
            NetworkCloudRackDefinition aggregatorOrSingleRackDefinition = default;
            Optional<ResourceIdentifier> analyticsWorkspaceId = default;
            Optional<IReadOnlyList<ClusterAvailableUpgradeVersion>> availableUpgradeVersions = default;
            Optional<ClusterCapacity> clusterCapacity = default;
            Optional<ClusterConnectionStatus> clusterConnectionStatus = default;
            Optional<ExtendedLocation> clusterExtendedLocation = default;
            Optional<string> clusterLocation = default;
            Optional<ClusterManagerConnectionStatus> clusterManagerConnectionStatus = default;
            Optional<ResourceIdentifier> clusterManagerId = default;
            Optional<ServicePrincipalInformation> clusterServicePrincipal = default;
            ClusterType clusterType = default;
            string clusterVersion = default;
            Optional<ValidationThreshold> computeDeploymentThreshold = default;
            Optional<IList<NetworkCloudRackDefinition>> computeRackDefinitions = default;
            Optional<ClusterDetailedStatus> detailedStatus = default;
            Optional<string> detailedStatusMessage = default;
            Optional<ExtendedLocation> hybridAksExtendedLocation = default;
            Optional<ManagedResourceGroupConfiguration> managedResourceGroupConfiguration = default;
            Optional<long> manualActionCount = default;
            ResourceIdentifier networkFabricId = default;
            Optional<ClusterProvisioningState> provisioningState = default;
            Optional<DateTimeOffset> supportExpiryDate = default;
            Optional<IReadOnlyList<ResourceIdentifier>> workloadResourceIds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    extendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value);
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
                        if (property0.NameEquals("aggregatorOrSingleRackDefinition"u8))
                        {
                            aggregatorOrSingleRackDefinition = NetworkCloudRackDefinition.DeserializeNetworkCloudRackDefinition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("analyticsWorkspaceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            analyticsWorkspaceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("availableUpgradeVersions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClusterAvailableUpgradeVersion> array = new List<ClusterAvailableUpgradeVersion>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterAvailableUpgradeVersion.DeserializeClusterAvailableUpgradeVersion(item));
                            }
                            availableUpgradeVersions = array;
                            continue;
                        }
                        if (property0.NameEquals("clusterCapacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterCapacity = ClusterCapacity.DeserializeClusterCapacity(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clusterConnectionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterConnectionStatus = new ClusterConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusterExtendedLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterExtendedLocation = ExtendedLocation.DeserializeExtendedLocation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clusterLocation"u8))
                        {
                            clusterLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterManagerConnectionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterManagerConnectionStatus = new ClusterManagerConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusterManagerId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterManagerId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusterServicePrincipal"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterServicePrincipal = ServicePrincipalInformation.DeserializeServicePrincipalInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clusterType"u8))
                        {
                            clusterType = new ClusterType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusterVersion"u8))
                        {
                            clusterVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("computeDeploymentThreshold"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            computeDeploymentThreshold = ValidationThreshold.DeserializeValidationThreshold(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("computeRackDefinitions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkCloudRackDefinition> array = new List<NetworkCloudRackDefinition>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkCloudRackDefinition.DeserializeNetworkCloudRackDefinition(item));
                            }
                            computeRackDefinitions = array;
                            continue;
                        }
                        if (property0.NameEquals("detailedStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detailedStatus = new ClusterDetailedStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatusMessage"u8))
                        {
                            detailedStatusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hybridAksExtendedLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hybridAksExtendedLocation = ExtendedLocation.DeserializeExtendedLocation(property0.Value);
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
                        if (property0.NameEquals("manualActionCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            manualActionCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("networkFabricId"u8))
                        {
                            networkFabricId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ClusterProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("supportExpiryDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportExpiryDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("workloadResourceIds"u8))
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
                            workloadResourceIds = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetworkCloudClusterData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, extendedLocation, aggregatorOrSingleRackDefinition, analyticsWorkspaceId.Value, Optional.ToList(availableUpgradeVersions), clusterCapacity.Value, Optional.ToNullable(clusterConnectionStatus), clusterExtendedLocation.Value, clusterLocation.Value, Optional.ToNullable(clusterManagerConnectionStatus), clusterManagerId.Value, clusterServicePrincipal.Value, clusterType, clusterVersion, computeDeploymentThreshold.Value, Optional.ToList(computeRackDefinitions), Optional.ToNullable(detailedStatus), detailedStatusMessage.Value, hybridAksExtendedLocation.Value, managedResourceGroupConfiguration.Value, Optional.ToNullable(manualActionCount), networkFabricId, Optional.ToNullable(provisioningState), Optional.ToNullable(supportExpiryDate), Optional.ToList(workloadResourceIds));
        }
    }
}
