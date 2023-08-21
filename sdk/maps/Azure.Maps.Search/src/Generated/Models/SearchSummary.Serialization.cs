// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    internal partial class SearchSummary
    {
        internal static SearchSummary DeserializeSearchSummary(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> query = default;
            Optional<MapsQueryType> queryType = default;
            Optional<int> queryTime = default;
            Optional<int> numResults = default;
            Optional<int> limit = default;
            Optional<int> offset = default;
            Optional<int> totalResults = default;
            Optional<int> fuzzyLevel = default;
            Optional<LatLongPairAbbreviated> geoBias = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"u8))
                {
                    query = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryType = new MapsQueryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryTime = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numResults = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("offset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalResults = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fuzzyLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fuzzyLevel = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("geoBias"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoBias = LatLongPairAbbreviated.DeserializeLatLongPairAbbreviated(property.Value);
                    continue;
                }
            }
            return new SearchSummary(query.Value, Optional.ToNullable(queryType), Optional.ToNullable(queryTime), numResults, Optional.ToNullable(limit), Optional.ToNullable(offset), Optional.ToNullable(totalResults), Optional.ToNullable(fuzzyLevel), geoBias.Value);
        }
    }
}
