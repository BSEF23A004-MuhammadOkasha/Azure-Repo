// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Models
{
    public partial class StoragePoolSkuRestrictions
    {
        internal static StoragePoolSkuRestrictions DeserializeStoragePoolSkuRestrictions(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StoragePoolSkuRestrictionsType> type = default;
            Optional<IReadOnlyList<string>> values = default;
            Optional<StoragePoolSkuRestrictionInfo> restrictionInfo = default;
            Optional<StoragePoolSkuRestrictionsReasonCode> reasonCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToStoragePoolSkuRestrictionsType();
                    continue;
                }
                if (property.NameEquals("values"u8))
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
                    values = array;
                    continue;
                }
                if (property.NameEquals("restrictionInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restrictionInfo = StoragePoolSkuRestrictionInfo.DeserializeStoragePoolSkuRestrictionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("reasonCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reasonCode = property.Value.GetString().ToStoragePoolSkuRestrictionsReasonCode();
                    continue;
                }
            }
            return new StoragePoolSkuRestrictions(Optional.ToNullable(type), Optional.ToList(values), restrictionInfo.Value, Optional.ToNullable(reasonCode));
        }
    }
}
