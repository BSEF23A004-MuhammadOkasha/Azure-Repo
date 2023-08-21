// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    internal partial class SoftwareUpdateConfigurationListResult
    {
        internal static SoftwareUpdateConfigurationListResult DeserializeSoftwareUpdateConfigurationListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<SoftwareUpdateConfigurationCollectionItem>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SoftwareUpdateConfigurationCollectionItem> array = new List<SoftwareUpdateConfigurationCollectionItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SoftwareUpdateConfigurationCollectionItem.DeserializeSoftwareUpdateConfigurationCollectionItem(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SoftwareUpdateConfigurationListResult(Core.Optional.ToList(value));
        }
    }
}
