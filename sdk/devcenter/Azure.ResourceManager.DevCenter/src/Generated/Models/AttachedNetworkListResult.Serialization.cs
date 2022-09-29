// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevCenter;

namespace Azure.ResourceManager.DevCenter.Models
{
    internal partial class AttachedNetworkListResult
    {
        internal static AttachedNetworkListResult DeserializeAttachedNetworkListResult(JsonElement element)
        {
            Optional<IReadOnlyList<AttachedNetworkConnectionData>> value = default;
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
                    List<AttachedNetworkConnectionData> array = new List<AttachedNetworkConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AttachedNetworkConnectionData.DeserializeAttachedNetworkConnectionData(item));
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
            return new AttachedNetworkListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
