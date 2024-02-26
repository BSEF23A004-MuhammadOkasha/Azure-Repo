// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    public partial class MetricsBatchResult
    {
        internal static MetricsBatchResult DeserializeMetricsBatchResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<MetricsBatchResultValues> values = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricsBatchResultValues> array = new List<MetricsBatchResultValues>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricsBatchResultValues.DeserializeMetricsBatchResultValues(item));
                    }
                    values = array;
                    continue;
                }
            }
            return new MetricsBatchResult(values ?? new ChangeTrackingList<MetricsBatchResultValues>());
        }
    }
}
