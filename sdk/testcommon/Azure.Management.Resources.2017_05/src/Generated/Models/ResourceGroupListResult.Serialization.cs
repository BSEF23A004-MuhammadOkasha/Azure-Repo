// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resources.Models
{
    public partial class ResourceGroupListResult
    {
        internal static ResourceGroupListResult DeserializeResourceGroupListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ResourceGroup>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResourceGroup> array = new List<ResourceGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceGroup.DeserializeResourceGroup(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceGroupListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
