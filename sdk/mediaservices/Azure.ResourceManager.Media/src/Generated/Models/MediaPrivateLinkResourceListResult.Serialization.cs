// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class MediaPrivateLinkResourceListResult
    {
        internal static MediaPrivateLinkResourceListResult DeserializeMediaPrivateLinkResourceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<MediaPrivateLinkResourceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MediaPrivateLinkResourceData> array = new List<MediaPrivateLinkResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaPrivateLinkResourceData.DeserializeMediaPrivateLinkResourceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MediaPrivateLinkResourceListResult(Optional.ToList(value));
        }
    }
}
