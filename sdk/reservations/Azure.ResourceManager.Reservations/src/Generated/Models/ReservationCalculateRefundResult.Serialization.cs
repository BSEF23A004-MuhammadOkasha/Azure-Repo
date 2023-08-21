// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationCalculateRefundResult
    {
        internal static ReservationCalculateRefundResult DeserializeReservationCalculateRefundResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<ReservationRefundResponseProperties> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = ReservationRefundResponseProperties.DeserializeReservationRefundResponseProperties(property.Value);
                    continue;
                }
            }
            return new ReservationCalculateRefundResult(id.Value, properties.Value);
        }
    }
}
