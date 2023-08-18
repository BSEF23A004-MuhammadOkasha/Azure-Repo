// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AppServiceEnvironmentData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Core.Optional.IsCollectionDefined(Tags))
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
            if (Core.Optional.IsDefined(VirtualNetwork))
            {
                writer.WritePropertyName("virtualNetwork"u8);
                writer.WriteObjectValue(VirtualNetwork);
            }
            if (Core.Optional.IsDefined(InternalLoadBalancingMode))
            {
                writer.WritePropertyName("internalLoadBalancingMode"u8);
                writer.WriteStringValue(InternalLoadBalancingMode.Value.ToString());
            }
            if (Core.Optional.IsDefined(MultiSize))
            {
                writer.WritePropertyName("multiSize"u8);
                writer.WriteStringValue(MultiSize);
            }
            if (Core.Optional.IsDefined(IPSslAddressCount))
            {
                writer.WritePropertyName("ipsslAddressCount"u8);
                writer.WriteNumberValue(IPSslAddressCount.Value);
            }
            if (Core.Optional.IsDefined(DnsSuffix))
            {
                writer.WritePropertyName("dnsSuffix"u8);
                writer.WriteStringValue(DnsSuffix);
            }
            if (Core.Optional.IsDefined(FrontEndScaleFactor))
            {
                writer.WritePropertyName("frontEndScaleFactor"u8);
                writer.WriteNumberValue(FrontEndScaleFactor.Value);
            }
            if (Core.Optional.IsCollectionDefined(ClusterSettings))
            {
                writer.WritePropertyName("clusterSettings"u8);
                writer.WriteStartArray();
                foreach (var item in ClusterSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(UserWhitelistedIPRanges))
            {
                writer.WritePropertyName("userWhitelistedIpRanges"u8);
                writer.WriteStartArray();
                foreach (var item in UserWhitelistedIPRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(DedicatedHostCount))
            {
                writer.WritePropertyName("dedicatedHostCount"u8);
                writer.WriteNumberValue(DedicatedHostCount.Value);
            }
            if (Core.Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AppServiceEnvironmentData DeserializeAppServiceEnvironmentData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> kind = default;
            Core.Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<ProvisioningState> provisioningState = default;
            Core.Optional<HostingEnvironmentStatus> status = default;
            Core.Optional<AppServiceVirtualNetworkProfile> virtualNetwork = default;
            Core.Optional<LoadBalancingMode> internalLoadBalancingMode = default;
            Core.Optional<string> multiSize = default;
            Core.Optional<int> multiRoleCount = default;
            Core.Optional<int> ipSslAddressCount = default;
            Core.Optional<string> dnsSuffix = default;
            Core.Optional<int> maximumNumberOfMachines = default;
            Core.Optional<int> frontEndScaleFactor = default;
            Core.Optional<bool> suspended = default;
            Core.Optional<IList<AppServiceNameValuePair>> clusterSettings = default;
            Core.Optional<IList<string>> userWhitelistedIPRanges = default;
            Core.Optional<bool> hasLinuxWorkers = default;
            Core.Optional<int> dedicatedHostCount = default;
            Core.Optional<bool> zoneRedundant = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToHostingEnvironmentStatus();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetwork"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetwork = AppServiceVirtualNetworkProfile.DeserializeAppServiceVirtualNetworkProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("internalLoadBalancingMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            internalLoadBalancingMode = new LoadBalancingMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("multiSize"u8))
                        {
                            multiSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("multiRoleCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            multiRoleCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("ipsslAddressCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ipSslAddressCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dnsSuffix"u8))
                        {
                            dnsSuffix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maximumNumberOfMachines"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumNumberOfMachines = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("frontEndScaleFactor"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            frontEndScaleFactor = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("suspended"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            suspended = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("clusterSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AppServiceNameValuePair> array = new List<AppServiceNameValuePair>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AppServiceNameValuePair.DeserializeAppServiceNameValuePair(item));
                            }
                            clusterSettings = array;
                            continue;
                        }
                        if (property0.NameEquals("userWhitelistedIpRanges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            userWhitelistedIPRanges = array;
                            continue;
                        }
                        if (property0.NameEquals("hasLinuxWorkers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hasLinuxWorkers = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("dedicatedHostCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dedicatedHostCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundant"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zoneRedundant = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AppServiceEnvironmentData(id, name, type, systemData.Value, Core.Optional.ToDictionary(tags), location, Core.Optional.ToNullable(provisioningState), Core.Optional.ToNullable(status), virtualNetwork.Value, Core.Optional.ToNullable(internalLoadBalancingMode), multiSize.Value, Core.Optional.ToNullable(multiRoleCount), Core.Optional.ToNullable(ipSslAddressCount), dnsSuffix.Value, Core.Optional.ToNullable(maximumNumberOfMachines), Core.Optional.ToNullable(frontEndScaleFactor), Core.Optional.ToNullable(suspended), Core.Optional.ToList(clusterSettings), Core.Optional.ToList(userWhitelistedIPRanges), Core.Optional.ToNullable(hasLinuxWorkers), Core.Optional.ToNullable(dedicatedHostCount), Core.Optional.ToNullable(zoneRedundant), kind.Value);
        }
    }
}
