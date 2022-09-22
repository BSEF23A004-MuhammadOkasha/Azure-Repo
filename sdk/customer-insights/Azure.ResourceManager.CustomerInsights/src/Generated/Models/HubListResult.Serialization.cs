// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    internal partial class HubListResult
    {
        internal static HubListResult DeserializeHubListResult(JsonElement element)
        {
            Optional<IReadOnlyList<HubData>> value = default;
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
                    List<HubData> array = new List<HubData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HubData.DeserializeHubData(item));
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
            return new HubListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
