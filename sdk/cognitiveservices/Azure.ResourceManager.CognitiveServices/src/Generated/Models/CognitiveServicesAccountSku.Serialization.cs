// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CognitiveServicesAccountSku
    {
        internal static CognitiveServicesAccountSku DeserializeCognitiveServicesAccountSku(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ResourceType> resourceType = default;
            Core.Optional<CognitiveServicesSku> sku = default;
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
                    sku = CognitiveServicesSku.DeserializeCognitiveServicesSku(property.Value);
                    continue;
                }
            }
            return new CognitiveServicesAccountSku(Core.Optional.ToNullable(resourceType), sku.Value);
        }
    }
}
