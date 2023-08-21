// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class StorageCacheUpgradeStatus
    {
        internal static StorageCacheUpgradeStatus DeserializeStorageCacheUpgradeStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> currentFirmwareVersion = default;
            Optional<StorageCacheFirmwareStatusType> firmwareUpdateStatus = default;
            Optional<DateTimeOffset> firmwareUpdateDeadline = default;
            Optional<DateTimeOffset> lastFirmwareUpdate = default;
            Optional<string> pendingFirmwareVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currentFirmwareVersion"u8))
                {
                    currentFirmwareVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firmwareUpdateStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firmwareUpdateStatus = new StorageCacheFirmwareStatusType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("firmwareUpdateDeadline"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firmwareUpdateDeadline = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastFirmwareUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastFirmwareUpdate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("pendingFirmwareVersion"u8))
                {
                    pendingFirmwareVersion = property.Value.GetString();
                    continue;
                }
            }
            return new StorageCacheUpgradeStatus(currentFirmwareVersion.Value, Optional.ToNullable(firmwareUpdateStatus), Optional.ToNullable(firmwareUpdateDeadline), Optional.ToNullable(lastFirmwareUpdate), pendingFirmwareVersion.Value);
        }
    }
}
