// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationMergeProperties
    {
        internal static ReservationMergeProperties DeserializeReservationMergeProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> mergeDestination = default;
            Optional<IReadOnlyList<string>> mergeSources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mergeDestination"u8))
                {
                    mergeDestination = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mergeSources"u8))
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
                    mergeSources = array;
                    continue;
                }
            }
            return new ReservationMergeProperties(mergeDestination.Value, Optional.ToList(mergeSources));
        }
    }
}
