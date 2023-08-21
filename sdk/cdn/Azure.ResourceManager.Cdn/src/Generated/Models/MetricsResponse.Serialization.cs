// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class MetricsResponse
    {
        internal static MetricsResponse DeserializeMetricsResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DateTimeOffset> dateTimeBegin = default;
            Core.Optional<DateTimeOffset> dateTimeEnd = default;
            Core.Optional<MetricsResponseGranularity> granularity = default;
            Core.Optional<IReadOnlyList<MetricsResponseSeriesItem>> series = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateTimeBegin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateTimeBegin = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("dateTimeEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateTimeEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("granularity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    granularity = new MetricsResponseGranularity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("series"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricsResponseSeriesItem> array = new List<MetricsResponseSeriesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricsResponseSeriesItem.DeserializeMetricsResponseSeriesItem(item));
                    }
                    series = array;
                    continue;
                }
            }
            return new MetricsResponse(Core.Optional.ToNullable(dateTimeBegin), Core.Optional.ToNullable(dateTimeEnd), Core.Optional.ToNullable(granularity), Core.Optional.ToList(series));
        }
    }
}
