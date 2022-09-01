// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.FrontDoor.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.FrontDoor
{
    public partial class FrontDoorData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName");
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsCollectionDefined(RoutingRules))
            {
                writer.WritePropertyName("routingRules");
                writer.WriteStartArray();
                foreach (var item in RoutingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LoadBalancingSettings))
            {
                writer.WritePropertyName("loadBalancingSettings");
                writer.WriteStartArray();
                foreach (var item in LoadBalancingSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(HealthProbeSettings))
            {
                writer.WritePropertyName("healthProbeSettings");
                writer.WriteStartArray();
                foreach (var item in HealthProbeSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BackendPools))
            {
                writer.WritePropertyName("backendPools");
                writer.WriteStartArray();
                foreach (var item in BackendPools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FrontendEndpoints))
            {
                writer.WritePropertyName("frontendEndpoints");
                writer.WriteStartArray();
                foreach (var item in FrontendEndpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BackendPoolsSettings))
            {
                writer.WritePropertyName("backendPoolsSettings");
                writer.WriteObjectValue(BackendPoolsSettings);
            }
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState");
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FrontDoorData DeserializeFrontDoorData(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            Core.ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> friendlyName = default;
            Optional<IList<RoutingRuleData>> routingRules = default;
            Optional<IList<FrontDoorLoadBalancingSettingsData>> loadBalancingSettings = default;
            Optional<IList<FrontDoorHealthProbeSettingsData>> healthProbeSettings = default;
            Optional<IList<FrontDoorBackendPool>> backendPools = default;
            Optional<IList<FrontendEndpointData>> frontendEndpoints = default;
            Optional<BackendPoolsSettings> backendPoolsSettings = default;
            Optional<FrontDoorEnabledState> enabledState = default;
            Optional<FrontDoorResourceState> resourceState = default;
            Optional<string> provisioningState = default;
            Optional<string> cname = default;
            Optional<string> frontdoorId = default;
            Optional<IReadOnlyList<FrontDoorRulesEngineData>> rulesEngines = default;
            Optional<IReadOnlyDictionary<string, string>> extendedProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new Core.ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("friendlyName"))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routingRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RoutingRuleData> array = new List<RoutingRuleData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RoutingRuleData.DeserializeRoutingRuleData(item));
                            }
                            routingRules = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancingSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<FrontDoorLoadBalancingSettingsData> array = new List<FrontDoorLoadBalancingSettingsData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FrontDoorLoadBalancingSettingsData.DeserializeFrontDoorLoadBalancingSettingsData(item));
                            }
                            loadBalancingSettings = array;
                            continue;
                        }
                        if (property0.NameEquals("healthProbeSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<FrontDoorHealthProbeSettingsData> array = new List<FrontDoorHealthProbeSettingsData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FrontDoorHealthProbeSettingsData.DeserializeFrontDoorHealthProbeSettingsData(item));
                            }
                            healthProbeSettings = array;
                            continue;
                        }
                        if (property0.NameEquals("backendPools"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<FrontDoorBackendPool> array = new List<FrontDoorBackendPool>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FrontDoorBackendPool.DeserializeFrontDoorBackendPool(item));
                            }
                            backendPools = array;
                            continue;
                        }
                        if (property0.NameEquals("frontendEndpoints"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<FrontendEndpointData> array = new List<FrontendEndpointData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FrontendEndpointData.DeserializeFrontendEndpointData(item));
                            }
                            frontendEndpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("backendPoolsSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            backendPoolsSettings = BackendPoolsSettings.DeserializeBackendPoolsSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enabledState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enabledState = new FrontDoorEnabledState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceState = new FrontDoorResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cname"))
                        {
                            cname = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("frontdoorId"))
                        {
                            frontdoorId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("rulesEngines"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<FrontDoorRulesEngineData> array = new List<FrontDoorRulesEngineData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FrontDoorRulesEngineData.DeserializeFrontDoorRulesEngineData(item));
                            }
                            rulesEngines = array;
                            continue;
                        }
                        if (property0.NameEquals("extendedProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            extendedProperties = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FrontDoorData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, friendlyName.Value, Optional.ToList(routingRules), Optional.ToList(loadBalancingSettings), Optional.ToList(healthProbeSettings), Optional.ToList(backendPools), Optional.ToList(frontendEndpoints), backendPoolsSettings.Value, Optional.ToNullable(enabledState), Optional.ToNullable(resourceState), provisioningState.Value, cname.Value, frontdoorId.Value, Optional.ToList(rulesEngines), Optional.ToDictionary(extendedProperties));
        }
    }
}
