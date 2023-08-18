// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class SlotDifferenceListResult
    {
        internal static SlotDifferenceListResult DeserializeSlotDifferenceListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SlotDifference> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<SlotDifference> array = new List<SlotDifference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SlotDifference.DeserializeSlotDifference(item));
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
            return new SlotDifferenceListResult(value, nextLink.Value);
        }
    }
}
