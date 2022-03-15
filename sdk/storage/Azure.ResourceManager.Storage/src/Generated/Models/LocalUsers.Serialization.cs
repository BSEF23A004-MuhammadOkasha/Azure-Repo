// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Storage;

namespace Azure.ResourceManager.Storage.Models
{
    internal partial class LocalUsers
    {
        internal static LocalUsers DeserializeLocalUsers(JsonElement element)
        {
            Optional<IReadOnlyList<LocalUserData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LocalUserData> array = new List<LocalUserData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LocalUserData.DeserializeLocalUserData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new LocalUsers(Optional.ToList(value));
        }
    }
}
