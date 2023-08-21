// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class TopologySingleResource
    {
        internal static TopologySingleResource DeserializeTopologySingleResource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> resourceId = default;
            Optional<string> severity = default;
            Optional<bool> recommendationsExist = default;
            Optional<string> networkZones = default;
            Optional<int> topologyScore = default;
            Optional<AzureLocation> location = default;
            Optional<IReadOnlyList<TopologySingleResourceParent>> parents = default;
            Optional<IReadOnlyList<TopologySingleResourceChild>> children = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    severity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendationsExist"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recommendationsExist = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("networkZones"u8))
                {
                    networkZones = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topologyScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    topologyScore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TopologySingleResourceParent> array = new List<TopologySingleResourceParent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TopologySingleResourceParent.DeserializeTopologySingleResourceParent(item));
                    }
                    parents = array;
                    continue;
                }
                if (property.NameEquals("children"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TopologySingleResourceChild> array = new List<TopologySingleResourceChild>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TopologySingleResourceChild.DeserializeTopologySingleResourceChild(item));
                    }
                    children = array;
                    continue;
                }
            }
            return new TopologySingleResource(resourceId.Value, severity.Value, Optional.ToNullable(recommendationsExist), networkZones.Value, Optional.ToNullable(topologyScore), Optional.ToNullable(location), Optional.ToList(parents), Optional.ToList(children));
        }
    }
}
