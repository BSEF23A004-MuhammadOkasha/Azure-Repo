// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationSplitProperties
    {
        internal static ReservationSplitProperties DeserializeReservationSplitProperties(JsonElement element)
        {
            Optional<IReadOnlyList<string>> splitDestinations = default;
            Optional<string> splitSource = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("splitDestinations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    splitDestinations = array;
                    continue;
                }
                if (property.NameEquals("splitSource"))
                {
                    splitSource = property.Value.GetString();
                    continue;
                }
            }
            return new ReservationSplitProperties(Optional.ToList(splitDestinations), splitSource.Value);
        }
    }
}
