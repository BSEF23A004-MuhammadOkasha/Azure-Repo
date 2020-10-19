// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Administration.Models
{
    public partial class UpdatePhoneNumberCapabilitiesResponse
    {
        internal static UpdatePhoneNumberCapabilitiesResponse DeserializeUpdatePhoneNumberCapabilitiesResponse(JsonElement element)
        {
            Optional<string> capabilitiesUpdateId = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<CapabilitiesUpdateStatus> capabilitiesUpdateStatus = default;
            Optional<IReadOnlyDictionary<string, NumberUpdateCapabilities>> phoneNumberCapabilitiesUpdates = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("capabilitiesUpdateId"))
                {
                    capabilitiesUpdateId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("capabilitiesUpdateStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    capabilitiesUpdateStatus = new CapabilitiesUpdateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("phoneNumberCapabilitiesUpdates"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, NumberUpdateCapabilities> dictionary = new Dictionary<string, NumberUpdateCapabilities>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, NumberUpdateCapabilities.DeserializeNumberUpdateCapabilities(property0.Value));
                    }
                    phoneNumberCapabilitiesUpdates = dictionary;
                    continue;
                }
            }
            return new UpdatePhoneNumberCapabilitiesResponse(capabilitiesUpdateId.Value, Optional.ToNullable(createdAt), Optional.ToNullable(capabilitiesUpdateStatus), Optional.ToDictionary(phoneNumberCapabilitiesUpdates));
        }
    }
}
