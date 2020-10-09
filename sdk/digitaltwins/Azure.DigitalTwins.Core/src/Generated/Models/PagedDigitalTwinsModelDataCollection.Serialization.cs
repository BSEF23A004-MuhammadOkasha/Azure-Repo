// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.DigitalTwins.Core
{
    internal partial class PagedDigitalTwinsModelDataCollection
    {
        internal static PagedDigitalTwinsModelDataCollection DeserializePagedDigitalTwinsModelDataCollection(JsonElement element)
        {
            Optional<IReadOnlyList<DigitalTwinsModelData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<DigitalTwinsModelData> array = new List<DigitalTwinsModelData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DigitalTwinsModelData.DeserializeDigitalTwinsModelData(item));
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
            return new PagedDigitalTwinsModelDataCollection(Optional.ToList(value), nextLink.Value);
        }
    }
}
