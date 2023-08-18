// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Models
{
    internal partial class DiskPoolZoneListResult
    {
        internal static DiskPoolZoneListResult DeserializeDiskPoolZoneListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<DiskPoolZoneInfo>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiskPoolZoneInfo> array = new List<DiskPoolZoneInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiskPoolZoneInfo.DeserializeDiskPoolZoneInfo(item));
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
            return new DiskPoolZoneListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
