// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SlotSwapStatus
    {
        internal static SlotSwapStatus DeserializeSlotSwapStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DateTimeOffset> timestampUtc = default;
            Core.Optional<string> sourceSlotName = default;
            Core.Optional<string> destinationSlotName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestampUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestampUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("sourceSlotName"u8))
                {
                    sourceSlotName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationSlotName"u8))
                {
                    destinationSlotName = property.Value.GetString();
                    continue;
                }
            }
            return new SlotSwapStatus(Core.Optional.ToNullable(timestampUtc), sourceSlotName.Value, destinationSlotName.Value);
        }
    }
}
