// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AgFoodPlatform;

namespace Azure.ResourceManager.AgFoodPlatform.Models
{
    internal partial class FarmBeatsListResponse
    {
        internal static FarmBeatsListResponse DeserializeFarmBeatsListResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<FarmBeatData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FarmBeatData> array = new List<FarmBeatData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FarmBeatData.DeserializeFarmBeatData(item));
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
            return new FarmBeatsListResponse(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
