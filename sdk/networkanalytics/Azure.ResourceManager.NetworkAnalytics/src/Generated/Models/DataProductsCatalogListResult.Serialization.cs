// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NetworkAnalytics;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    internal partial class DataProductsCatalogListResult
    {
        internal static DataProductsCatalogListResult DeserializeDataProductsCatalogListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DataProductsCatalogData> value = default;
            Optional<Uri> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DataProductsCatalogData> array = new List<DataProductsCatalogData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataProductsCatalogData.DeserializeDataProductsCatalogData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new DataProductsCatalogListResult(value, nextLink.Value);
        }
    }
}
