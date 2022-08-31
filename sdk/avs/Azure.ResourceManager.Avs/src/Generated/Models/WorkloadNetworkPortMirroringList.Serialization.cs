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
    internal partial class WorkloadNetworkPortMirroringList
    {
        internal static WorkloadNetworkPortMirroringList DeserializeWorkloadNetworkPortMirroringList(JsonElement element)
        {
            Optional<IReadOnlyList<WorkloadNetworkPortMirroringData>> value = default;
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
                    List<WorkloadNetworkPortMirroringData> array = new List<WorkloadNetworkPortMirroringData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkloadNetworkPortMirroringData.DeserializeWorkloadNetworkPortMirroringData(item));
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
            return new WorkloadNetworkPortMirroringList(Optional.ToList(value), nextLink.Value);
        }
    }
}
