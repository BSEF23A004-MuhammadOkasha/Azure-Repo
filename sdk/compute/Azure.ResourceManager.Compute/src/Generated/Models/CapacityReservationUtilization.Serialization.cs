// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class CapacityReservationUtilization
    {
        internal static CapacityReservationUtilization DeserializeCapacityReservationUtilization(JsonElement element)
        {
            Optional<IReadOnlyList<Resources.Models.SubResource>> virtualMachinesAllocated = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualMachinesAllocated"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Resources.Models.SubResource> array = new List<Resources.Models.SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<Resources.Models.SubResource>(item.ToString()));
                    }
                    virtualMachinesAllocated = array;
                    continue;
                }
            }
            return new CapacityReservationUtilization(Optional.ToList(virtualMachinesAllocated));
        }
    }
}
