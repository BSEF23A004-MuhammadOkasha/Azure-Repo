// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class RoutingRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(FrontendEndpoints))
            {
                writer.WritePropertyName("frontendEndpoints");
                writer.WriteStartArray();
                foreach (var item in FrontendEndpoints)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AcceptedProtocols))
            {
                writer.WritePropertyName("acceptedProtocols");
                writer.WriteStartArray();
                foreach (var item in AcceptedProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PatternsToMatch))
            {
                writer.WritePropertyName("patternsToMatch");
                writer.WriteStartArray();
                foreach (var item in PatternsToMatch)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState");
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            if (Optional.IsDefined(RouteConfiguration))
            {
                writer.WritePropertyName("routeConfiguration");
                writer.WriteObjectValue(RouteConfiguration);
            }
            if (Optional.IsDefined(RulesEngine))
            {
                writer.WritePropertyName("rulesEngine");
                JsonSerializer.Serialize(writer, RulesEngine);
            }
            if (Optional.IsDefined(WebApplicationFirewallPolicyLink))
            {
                writer.WritePropertyName("webApplicationFirewallPolicyLink");
                JsonSerializer.Serialize(writer, WebApplicationFirewallPolicyLink);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RoutingRule DeserializeRoutingRule(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<IList<WritableSubResource>> frontendEndpoints = default;
            Optional<IList<FrontDoorProtocol>> acceptedProtocols = default;
            Optional<IList<string>> patternsToMatch = default;
            Optional<RoutingRuleEnabledState> enabledState = default;
            Optional<RouteConfiguration> routeConfiguration = default;
            Optional<WritableSubResource> rulesEngine = default;
            Optional<WritableSubResource> webApplicationFirewallPolicyLink = default;
            Optional<FrontDoorResourceState> resourceState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
                        if (property0.NameEquals("frontendEndpoints"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.ToString()));
                            }
                            frontendEndpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("acceptedProtocols"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<FrontDoorProtocol> array = new List<FrontDoorProtocol>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new FrontDoorProtocol(item.GetString()));
                            }
                            acceptedProtocols = array;
                            continue;
                        }
                        if (property0.NameEquals("patternsToMatch"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            patternsToMatch = array;
                            continue;
                        }
                        if (property0.NameEquals("enabledState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enabledState = new RoutingRuleEnabledState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("routeConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            routeConfiguration = RouteConfiguration.DeserializeRouteConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("rulesEngine"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            rulesEngine = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("webApplicationFirewallPolicyLink"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            webApplicationFirewallPolicyLink = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
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
                    }
                    continue;
                }
            }
            return new RoutingRule(id.Value, name.Value, type.Value, Optional.ToList(frontendEndpoints), Optional.ToList(acceptedProtocols), Optional.ToList(patternsToMatch), Optional.ToNullable(enabledState), routeConfiguration.Value, rulesEngine, webApplicationFirewallPolicyLink, Optional.ToNullable(resourceState));
        }
    }
}
