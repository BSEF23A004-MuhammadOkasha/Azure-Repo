// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class DevicesStatistics
    {
        internal static DevicesStatistics DeserializeDevicesStatistics(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> totalDeviceCount = default;
            Optional<long> enabledDeviceCount = default;
            Optional<long> disabledDeviceCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalDeviceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalDeviceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("enabledDeviceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledDeviceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("disabledDeviceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disabledDeviceCount = property.Value.GetInt64();
                    continue;
                }
            }
            return new DevicesStatistics(Optional.ToNullable(totalDeviceCount), Optional.ToNullable(enabledDeviceCount), Optional.ToNullable(disabledDeviceCount));
        }
    }
}
