// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Datadog;

namespace Azure.ResourceManager.Datadog.Models
{
    internal partial class DatadogMonitorResourceListResponse
    {
        internal static DatadogMonitorResourceListResponse DeserializeDatadogMonitorResourceListResponse(JsonElement element)
        {
            Optional<IReadOnlyList<DatadogMonitorResourceData>> value = default;
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
                    List<DatadogMonitorResourceData> array = new List<DatadogMonitorResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatadogMonitorResourceData.DeserializeDatadogMonitorResourceData(item));
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
            return new DatadogMonitorResourceListResponse(Optional.ToList(value), nextLink.Value);
        }
    }
}
