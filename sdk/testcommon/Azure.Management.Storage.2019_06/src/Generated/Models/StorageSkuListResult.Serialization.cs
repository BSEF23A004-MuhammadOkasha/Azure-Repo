// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class StorageSkuListResult
    {
        internal static StorageSkuListResult DeserializeStorageSkuListResult(JsonElement element)
        {
            Optional<IReadOnlyList<SkuInformation>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SkuInformation> array = new List<SkuInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SkuInformation.DeserializeSkuInformation(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new StorageSkuListResult(Optional.ToList(value));
        }
    }
}
