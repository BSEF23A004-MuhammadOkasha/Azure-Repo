// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Rooms.Models
{
    internal partial class RoomModel
    {
        internal static RoomModel DeserializeRoomModel(JsonElement element)
        {
            Optional<string> id = default;
            Optional<DateTimeOffset> createdDateTime = default;
            Optional<DateTimeOffset> validFrom = default;
            Optional<DateTimeOffset> validUntil = default;
            Optional<IReadOnlyDictionary<string, object>> participants = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("validFrom"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    validFrom = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("validUntil"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    validUntil = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("participants"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    participants = dictionary;
                    continue;
                }
            }
            return new RoomModel(id.Value, Optional.ToNullable(createdDateTime), Optional.ToNullable(validFrom), Optional.ToNullable(validUntil), Optional.ToDictionary(participants));
        }
    }
}
