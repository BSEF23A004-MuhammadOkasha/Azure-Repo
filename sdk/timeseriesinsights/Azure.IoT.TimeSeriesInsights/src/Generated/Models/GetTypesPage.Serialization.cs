// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class GetTypesPage
    {
        internal static GetTypesPage DeserializeGetTypesPage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<TimeSeriesType>> types = default;
            Core.Optional<string> continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("types"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TimeSeriesType> array = new List<TimeSeriesType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeSeriesType.DeserializeTimeSeriesType(item));
                    }
                    types = array;
                    continue;
                }
                if (property.NameEquals("continuationToken"u8))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
            }
            return new GetTypesPage(continuationToken.Value, Core.Optional.ToList(types));
        }
    }
}
