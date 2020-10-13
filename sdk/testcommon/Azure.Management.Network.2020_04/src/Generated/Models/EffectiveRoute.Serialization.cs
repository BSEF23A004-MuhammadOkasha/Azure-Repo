// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class EffectiveRoute
    {
        internal static EffectiveRoute DeserializeEffectiveRoute(JsonElement element)
        {
            Optional<string> name = default;
            Optional<bool> disableBgpRoutePropagation = default;
            Optional<EffectiveRouteSource> source = default;
            Optional<EffectiveRouteState> state = default;
            Optional<IReadOnlyList<string>> addressPrefix = default;
            Optional<IReadOnlyList<string>> nextHopIpAddress = default;
            Optional<RouteNextHopType> nextHopType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disableBgpRoutePropagation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disableBgpRoutePropagation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    source = new EffectiveRouteSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new EffectiveRouteState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("addressPrefix"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    addressPrefix = array;
                    continue;
                }
                if (property.NameEquals("nextHopIpAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    nextHopIpAddress = array;
                    continue;
                }
                if (property.NameEquals("nextHopType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nextHopType = new RouteNextHopType(property.Value.GetString());
                    continue;
                }
            }
            return new EffectiveRoute(name.Value, Optional.ToNullable(disableBgpRoutePropagation), Optional.ToNullable(source), Optional.ToNullable(state), Optional.ToList(addressPrefix), Optional.ToList(nextHopIpAddress), Optional.ToNullable(nextHopType));
        }
    }
}
