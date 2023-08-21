// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class PaginatedComputeResourcesList
    {
        internal static PaginatedComputeResourcesList DeserializePaginatedComputeResourcesList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MachineLearningComputeData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MachineLearningComputeData> array = new List<MachineLearningComputeData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningComputeData.DeserializeMachineLearningComputeData(item));
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
            return new PaginatedComputeResourcesList(Optional.ToList(value), nextLink.Value);
        }
    }
}
