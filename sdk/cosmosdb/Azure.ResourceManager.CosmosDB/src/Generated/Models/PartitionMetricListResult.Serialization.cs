// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class PartitionMetricListResult
    {
        internal static PartitionMetricListResult DeserializePartitionMetricListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<PartitionMetric>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PartitionMetric> array = new List<PartitionMetric>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PartitionMetric.DeserializePartitionMetric(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PartitionMetricListResult(Optional.ToList(value));
        }
    }
}
