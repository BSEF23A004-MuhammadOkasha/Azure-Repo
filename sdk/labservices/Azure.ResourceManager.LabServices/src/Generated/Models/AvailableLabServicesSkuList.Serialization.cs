// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    internal partial class AvailableLabServicesSkuList
    {
        internal static AvailableLabServicesSkuList DeserializeAvailableLabServicesSkuList(JsonElement element)
        {
            Optional<IReadOnlyList<AvailableLabServicesSku>> value = default;
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
                    List<AvailableLabServicesSku> array = new List<AvailableLabServicesSku>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableLabServicesSku.DeserializeAvailableLabServicesSku(item));
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
            return new AvailableLabServicesSkuList(Optional.ToList(value), nextLink.Value);
        }
    }
}
