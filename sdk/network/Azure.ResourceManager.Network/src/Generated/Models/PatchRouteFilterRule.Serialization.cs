// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class PatchRouteFilterRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Access))
            {
                writer.WritePropertyName("access");
                writer.WriteStringValue(Access.Value.ToString());
            }
            if (Optional.IsDefined(RouteFilterRuleType))
            {
                writer.WritePropertyName("routeFilterRuleType");
                writer.WriteStringValue(RouteFilterRuleType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Communities))
            {
                writer.WritePropertyName("communities");
                writer.WriteStartArray();
                foreach (var item in Communities)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PatchRouteFilterRule DeserializePatchRouteFilterRule(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<Access> access = default;
            Optional<RouteFilterRuleType> routeFilterRuleType = default;
            Optional<IList<string>> communities = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
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
                        if (property0.NameEquals("access"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            access = new Access(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("routeFilterRuleType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            routeFilterRuleType = new RouteFilterRuleType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("communities"))
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
                            communities = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PatchRouteFilterRule(id.Value, name.Value, etag.Value, Optional.ToNullable(access), Optional.ToNullable(routeFilterRuleType), Optional.ToList(communities), Optional.ToNullable(provisioningState));
        }
    }
}
