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
    public partial class WafRankingsResponse
    {
        internal static WafRankingsResponse DeserializeWafRankingsResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DateTimeOffset> dateTimeBegin = default;
            Core.Optional<DateTimeOffset> dateTimeEnd = default;
            Core.Optional<IReadOnlyList<string>> groups = default;
            Core.Optional<IReadOnlyList<WafRankingsResponseDataItem>> data = default;
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
                if (property.NameEquals("groups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    groups = array;
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WafRankingsResponseDataItem> array = new List<WafRankingsResponseDataItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WafRankingsResponseDataItem.DeserializeWafRankingsResponseDataItem(item));
                    }
                    data = array;
                    continue;
                }
            }
            return new WafRankingsResponse(Core.Optional.ToNullable(dateTimeBegin), Core.Optional.ToNullable(dateTimeEnd), Core.Optional.ToList(groups), Core.Optional.ToList(data));
        }
    }
}
