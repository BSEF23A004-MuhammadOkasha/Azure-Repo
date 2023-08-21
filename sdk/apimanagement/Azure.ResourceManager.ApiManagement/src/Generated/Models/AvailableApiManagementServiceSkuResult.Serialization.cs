// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class AvailableApiManagementServiceSkuResult
    {
        internal static AvailableApiManagementServiceSkuResult DeserializeAvailableApiManagementServiceSkuResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ResourceType> resourceType = default;
            Core.Optional<ResourceSku> sku = default;
            Core.Optional<ApiManagementResourceSkuCapacity> capacity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ResourceSku.DeserializeResourceSku(property.Value);
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = ApiManagementResourceSkuCapacity.DeserializeApiManagementResourceSkuCapacity(property.Value);
                    continue;
                }
            }
            return new AvailableApiManagementServiceSkuResult(Core.Optional.ToNullable(resourceType), sku.Value, capacity.Value);
        }
    }
}
