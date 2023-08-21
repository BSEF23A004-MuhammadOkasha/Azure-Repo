// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    public partial class SkuDetailsForExistingResource
    {
        internal static SkuDetailsForExistingResource DeserializeSkuDetailsForExistingResource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceType = default;
            Optional<CapacitySku> sku = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = CapacitySku.DeserializeCapacitySku(property.Value);
                    continue;
                }
            }
            return new SkuDetailsForExistingResource(resourceType.Value, sku.Value);
        }
    }
}
