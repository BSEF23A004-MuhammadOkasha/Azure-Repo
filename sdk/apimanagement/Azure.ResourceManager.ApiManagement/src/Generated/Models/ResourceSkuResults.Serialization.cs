// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class ResourceSkuResults
    {
        internal static ResourceSkuResults DeserializeResourceSkuResults(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AvailableApiManagementServiceSkuResult> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<AvailableApiManagementServiceSkuResult> array = new List<AvailableApiManagementServiceSkuResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableApiManagementServiceSkuResult.DeserializeAvailableApiManagementServiceSkuResult(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceSkuResults(value, nextLink.Value);
        }
    }
}
