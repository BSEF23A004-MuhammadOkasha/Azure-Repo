// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Weather
{
    public partial class StormSearchResult
    {
        internal static StormSearchResult DeserializeStormSearchResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<StormSearchResultItem> results = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StormSearchResultItem> array = new List<StormSearchResultItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StormSearchResultItem.DeserializeStormSearchResultItem(item));
                    }
                    results = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new StormSearchResult(results ?? new ChangeTrackingList<StormSearchResultItem>(), nextLink);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static StormSearchResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeStormSearchResult(document.RootElement);
        }
    }
}
