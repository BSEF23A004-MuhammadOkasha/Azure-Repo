// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Blueprint;

namespace Azure.ResourceManager.Blueprint.Models
{
    internal partial class PublishedBlueprintList
    {
        internal static PublishedBlueprintList DeserializePublishedBlueprintList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<PublishedBlueprintData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PublishedBlueprintData> array = new List<PublishedBlueprintData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PublishedBlueprintData.DeserializePublishedBlueprintData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PublishedBlueprintList(Optional.ToList(value), nextLink.Value);
        }
    }
}
