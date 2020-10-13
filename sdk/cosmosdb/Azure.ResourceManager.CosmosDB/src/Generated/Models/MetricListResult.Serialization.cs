// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class MetricListResult
    {
        internal static MetricListResult DeserializeMetricListResult(JsonElement element)
        {
            Optional<IReadOnlyList<Metric>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Metric> array = new List<Metric>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Metric.DeserializeMetric(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MetricListResult(Optional.ToList(value));
        }
    }
}
