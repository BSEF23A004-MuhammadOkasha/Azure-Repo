// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServicePoolSkuInfo
    {
        internal static AppServicePoolSkuInfo DeserializeAppServicePoolSkuInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceType> resourceType = default;
            Optional<AppServiceSkuDescription> sku = default;
            Optional<AppServiceSkuCapacity> capacity = default;
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
                    sku = AppServiceSkuDescription.DeserializeAppServiceSkuDescription(property.Value);
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = AppServiceSkuCapacity.DeserializeAppServiceSkuCapacity(property.Value);
                    continue;
                }
            }
            return new AppServicePoolSkuInfo(Optional.ToNullable(resourceType), sku.Value, capacity.Value);
        }
    }
}
