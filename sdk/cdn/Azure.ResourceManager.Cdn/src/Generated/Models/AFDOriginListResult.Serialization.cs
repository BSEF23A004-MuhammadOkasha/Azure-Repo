// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    internal partial class AFDOriginListResult
    {
        internal static AFDOriginListResult DeserializeAFDOriginListResult(JsonElement element)
        {
            Optional<IReadOnlyList<AFDOriginData>> value = default;
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
                    List<AFDOriginData> array = new List<AFDOriginData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AFDOriginData.DeserializeAFDOriginData(item));
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
            return new AFDOriginListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
