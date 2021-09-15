// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ResourcesResponseEndpointsPropertiesItemsItem
    {
        internal static ResourcesResponseEndpointsPropertiesItemsItem DeserializeResourcesResponseEndpointsPropertiesItemsItem(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> endpointId = default;
            Optional<bool> history = default;
            ResourceIdentifier id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointId"))
                {
                    endpointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("history"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    history = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new ResourcesResponseEndpointsPropertiesItemsItem(id, name.Value, endpointId.Value, Optional.ToNullable(history));
        }
    }
}
