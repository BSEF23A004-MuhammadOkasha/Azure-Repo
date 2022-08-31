// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    internal partial class DatastoreList
    {
        internal static DatastoreList DeserializeDatastoreList(JsonElement element)
        {
            Optional<IReadOnlyList<DatastoreData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DatastoreData> array = new List<DatastoreData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatastoreData.DeserializeDatastoreData(item));
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
            return new DatastoreList(Optional.ToList(value), nextLink.Value);
        }
    }
}
