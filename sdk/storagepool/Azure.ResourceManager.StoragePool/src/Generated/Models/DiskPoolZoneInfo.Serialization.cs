// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Models
{
    public partial class DiskPoolZoneInfo
    {
        internal static DiskPoolZoneInfo DeserializeDiskPoolZoneInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<string>> availabilityZones = default;
            Core.Optional<IReadOnlyList<string>> additionalCapabilities = default;
            Core.Optional<StoragePoolSku> sku = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("availabilityZones"u8))
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
                    availabilityZones = array;
                    continue;
                }
                if (property.NameEquals("additionalCapabilities"u8))
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
                    additionalCapabilities = array;
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = StoragePoolSku.DeserializeStoragePoolSku(property.Value);
                    continue;
                }
            }
            return new DiskPoolZoneInfo(Core.Optional.ToList(availabilityZones), Core.Optional.ToList(additionalCapabilities), sku.Value);
        }
    }
}
