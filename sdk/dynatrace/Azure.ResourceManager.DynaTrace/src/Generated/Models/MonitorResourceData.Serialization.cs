// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DynaTrace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DynaTrace
{
    public partial class MonitorResourceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(MonitoringStatus))
            {
                writer.WritePropertyName("monitoringStatus");
                writer.WriteStringValue(MonitoringStatus.Value.ToString());
            }
            if (Optional.IsDefined(MarketplaceSubscriptionStatus))
            {
                writer.WritePropertyName("marketplaceSubscriptionStatus");
                writer.WriteStringValue(MarketplaceSubscriptionStatus.Value.ToString());
            }
            if (Optional.IsDefined(DynatraceEnvironmentProperties))
            {
                writer.WritePropertyName("dynatraceEnvironmentProperties");
                writer.WriteObjectValue(DynatraceEnvironmentProperties);
            }
            if (Optional.IsDefined(UserInfo))
            {
                writer.WritePropertyName("userInfo");
                writer.WriteObjectValue(UserInfo);
            }
            if (Optional.IsDefined(PlanData))
            {
                writer.WritePropertyName("planData");
                writer.WriteObjectValue(PlanData);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MonitorResourceData DeserializeMonitorResourceData(JsonElement element)
        {
            Optional<IdentityProperties> identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<MonitoringStatus> monitoringStatus = default;
            Optional<MarketplaceSubscriptionStatus> marketplaceSubscriptionStatus = default;
            Optional<DynatraceEnvironmentProperties> dynatraceEnvironmentProperties = default;
            Optional<UserInfo> userInfo = default;
            Optional<PlanData> planData = default;
            Optional<LiftrResourceCategories> liftrResourceCategory = default;
            Optional<int> liftrResourcePreference = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = IdentityProperties.DeserializeIdentityProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
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
                        if (property0.NameEquals("monitoringStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            monitoringStatus = new MonitoringStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("marketplaceSubscriptionStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            marketplaceSubscriptionStatus = new MarketplaceSubscriptionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dynatraceEnvironmentProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dynatraceEnvironmentProperties = DynatraceEnvironmentProperties.DeserializeDynatraceEnvironmentProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("userInfo"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            userInfo = UserInfo.DeserializeUserInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("planData"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            planData = PlanData.DeserializePlanData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("liftrResourceCategory"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            liftrResourceCategory = new LiftrResourceCategories(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("liftrResourcePreference"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            liftrResourcePreference = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MonitorResourceData(id, name, type, systemData, tags, location, identity.Value, Optional.ToNullable(monitoringStatus), Optional.ToNullable(marketplaceSubscriptionStatus), dynatraceEnvironmentProperties.Value, userInfo.Value, planData.Value, Optional.ToNullable(liftrResourceCategory), Optional.ToNullable(liftrResourcePreference), Optional.ToNullable(provisioningState));
        }
    }
}
