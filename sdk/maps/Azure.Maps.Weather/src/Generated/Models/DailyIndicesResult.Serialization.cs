// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Weather
{
    public partial class DailyIndicesResult
    {
        internal static DailyIndicesResult DeserializeDailyIndicesResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DailyIndex> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DailyIndex> array = new List<DailyIndex>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DailyIndex.DeserializeDailyIndex(item));
                    }
                    results = array;
                    continue;
                }
            }
            return new DailyIndicesResult(results ?? new ChangeTrackingList<DailyIndex>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DailyIndicesResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDailyIndicesResult(document.RootElement);
        }
    }
}
